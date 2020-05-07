using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public  class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository liquidacionCuotaModeradoraRepository;
        Liquidacion liquidacion;
        List<Liquidacion> listaLiquidaciones;
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
            Leer();
        }
        

        public Liquidacion Buscar(string identificacion)
        {
            liquidacion = liquidacionCuotaModeradoraRepository.Buscar(identificacion);
            return liquidacion;
        }

        public IList<Liquidacion> Leer()
        {
            listaLiquidaciones = liquidacionCuotaModeradoraRepository.Consultar().ToList();
            return listaLiquidaciones;
        }

        public String AgregarPaciente(Liquidacion liquidacion)
        {  
            liquidacionCuotaModeradoraRepository.Guardar(liquidacion);
            return "Persona agregada Exitosamente";
        }

        public string Modificar( Liquidacion liquidacionNueva)
        {
            liquidacionCuotaModeradoraRepository.Modificar( liquidacionNueva);
            return "Persona Modificada Exitosamente";
        }

        public string Eliminar(Liquidacion liquidacion)
        {
            liquidacionCuotaModeradoraRepository.Eliminar(liquidacion);
            return "Eliminada Exitosamente";
        }

        public IList<Liquidacion> MostrarLiquidacionPorTipo(string tipoLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.MostrarLiquidacionPorTipo(tipoLiquidacion);
        }

        public int MostrarTotalLiquidacionesPorTipo(string tipoLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.MostrarTotalLiquidacionesPorTipo(tipoLiquidacion);
        }

        public double TotalLiquidadoPorTipo(string tipoLiquidacion)
        {
            return liquidacionCuotaModeradoraRepository.TotalLiquidadoPorTipo(tipoLiquidacion);
        }

        public double TotalLiquidadoTodos()
        {
            return liquidacionCuotaModeradoraRepository.TotalLiquidacionesTodos();
        }

        public IList<Liquidacion> ConsultarFecha(int Mes, int Anio)
        {
            return liquidacionCuotaModeradoraRepository.ConsultarFecha(Mes, Anio);
        }

        public IList<Liquidacion> TextoConsultar(string buscar)
        {
            return liquidacionCuotaModeradoraRepository.TextoConsultar(buscar);
        }

        public IList<Liquidacion> ConsultarLiquidaciones(string Identificacion)
        {
            return liquidacionCuotaModeradoraRepository.ConsultarLiquidaciones(Identificacion);
        }
    }
}
