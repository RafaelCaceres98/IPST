using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        private string ruta = "Liquidacion.txt";
        public IList<Liquidacion> listaLiquidaciones;

        public LiquidacionCuotaModeradoraRepository()
        {
            listaLiquidaciones = new List<Liquidacion>();
        }

        public void Guardar(Liquidacion liquidacion)
        {        
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);    
                escritor.WriteLine($"{liquidacion.Nombre};{liquidacion.Identificacion};{liquidacion.Salario};{liquidacion.TipoAfiliacion};{liquidacion.ValorServicio};{liquidacion.NumeroLiquidacion}" +
                    $";{liquidacion.CuotaModeradora};{liquidacion.Tarifa};{liquidacion.Tope};{liquidacion.FechaSolicitudLiquidacion}");
            escritor.Close();
            file.Close();
        }

        public IList<Liquidacion> Consultar()
        {
            listaLiquidaciones = new List<Liquidacion>();
            string Line = string.Empty;
            FileStream sourceStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(sourceStream);
            while ((Line = reader.ReadLine()) != null)
            {

                Liquidacion liquidacion;
                char separador = ';';
                string[] Contenedor = Line.Split(separador);
                if(Contenedor[3].Equals("CONTRIBUTIVO"))
                     liquidacion = new LiquidacionContributiva(0);
                else
                     liquidacion = new LiquidacionSubsidada(0);
                liquidacion.Nombre = Contenedor[0];
                liquidacion.Identificacion = Contenedor[1];
                liquidacion.Salario = Convert.ToDouble(Contenedor[2]);
                liquidacion.TipoAfiliacion = Contenedor[3];
                liquidacion.ValorServicio = Convert.ToDouble(Contenedor[4]);
                liquidacion.NumeroLiquidacion = Convert.ToInt32(Contenedor[5]);
                liquidacion.CuotaModeradora = Convert.ToDouble(Contenedor[6]);
                liquidacion.Tarifa = Convert.ToDouble(Contenedor[7]);
                liquidacion.Tope = Convert.ToDouble(Contenedor[8]);
                liquidacion.FechaSolicitudLiquidacion = Convert.ToDateTime(Contenedor[9]);
                listaLiquidaciones.Add(liquidacion);
            }
            reader.Close();
            sourceStream.Close();
            return listaLiquidaciones;
        }

        public Liquidacion Buscar(string identificacion)
        {
            listaLiquidaciones = Consultar();
            foreach (var item in listaLiquidaciones)
            {
                if (item.Identificacion.Equals(identificacion))
                {                
                    return item;
                }
            }
            return null;
        }

        public void Modificar(Liquidacion liquidacion)
        {
            listaLiquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in listaLiquidaciones)
            {
                if (item.Identificacion == liquidacion.Identificacion)
                {
                    Guardar(liquidacion);
                }
                else
                {
                    Guardar(item);
                }    
            }
        }

        public void Eliminar(Liquidacion liquidacion)
        {
            listaLiquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in listaLiquidaciones)
            {
                if (item.Identificacion != liquidacion.Identificacion)
                {
                    Guardar(item);
                }   
            }
        }

        public IList<Liquidacion> MostrarLiquidacionPorTipo(String tipoLiquidacion)
        {
            listaLiquidaciones = Consultar();
            return listaLiquidaciones.Where(l => l.TipoAfiliacion.Equals(tipoLiquidacion)).ToList();
        }

        public int MostrarTotalLiquidacionesPorTipo(string tipoLiquidacion)
        {
            listaLiquidaciones = Consultar();
            return listaLiquidaciones.Where(l => l.TipoAfiliacion.Equals(tipoLiquidacion)).Count();
        }

        public IList<Liquidacion> ConsultarFecha(int Mes, int Anio)
        {
            listaLiquidaciones = Consultar();
            return listaLiquidaciones.Where(l => ((l.FechaSolicitudLiquidacion.Year) == Anio && (l.FechaSolicitudLiquidacion.Month == Mes))).ToList();
        }

        public double TotalLiquidadoPorTipo(string tipoLiquidacion)
        {
            listaLiquidaciones = Consultar();
            return listaLiquidaciones.Where(l => l.TipoAfiliacion.Equals(tipoLiquidacion)).Sum(l=>l.CuotaModeradora);
        }

        public double TotalLiquidacionesTodos()
        {
            listaLiquidaciones = Consultar();
            return listaLiquidaciones.Sum(l => l.CuotaModeradora);
        }

        public IList<Liquidacion> TextoConsultar(string buscar)
        {
            listaLiquidaciones = Consultar();
            return listaLiquidaciones.Where(l => l.Nombre.Contains(buscar)).ToList();
        }

        public IList<Liquidacion> ConsultarLiquidaciones(string Identificacion)
        {
            listaLiquidaciones = Consultar();
            return listaLiquidaciones.Where(l => l.Identificacion.Equals(Identificacion)).ToList();
        }


    }
}
