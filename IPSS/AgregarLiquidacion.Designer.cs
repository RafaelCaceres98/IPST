namespace IPSS
{
    partial class AgregarLiquidacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.Tipolbl = new System.Windows.Forms.Label();
            this.tipoBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SalarioTxt = new System.Windows.Forms.TextBox();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.LiquidacionFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(134, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(217, 126);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(121, 20);
            this.IdentificacionTxt.TabIndex = 1;
            // 
            // Tipolbl
            // 
            this.Tipolbl.AutoSize = true;
            this.Tipolbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipolbl.Location = new System.Drawing.Point(368, 173);
            this.Tipolbl.Name = "Tipolbl";
            this.Tipolbl.Size = new System.Drawing.Size(76, 13);
            this.Tipolbl.TabIndex = 2;
            this.Tipolbl.Text = "Tipo Afiliación:";
            // 
            // tipoBox
            // 
            this.tipoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoBox.FormattingEnabled = true;
            this.tipoBox.Items.AddRange(new object[] {
            "SUBSIDIADO",
            "CONTRIBUTIVO"});
            this.tipoBox.Location = new System.Drawing.Point(472, 170);
            this.tipoBox.Name = "tipoBox";
            this.tipoBox.Size = new System.Drawing.Size(119, 21);
            this.tipoBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(157, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(223, 170);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(117, 20);
            this.NombreTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(162, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario:";
            // 
            // SalarioTxt
            // 
            this.SalarioTxt.Location = new System.Drawing.Point(223, 224);
            this.SalarioTxt.Name = "SalarioTxt";
            this.SalarioTxt.Size = new System.Drawing.Size(115, 20);
            this.SalarioTxt.TabIndex = 7;
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(472, 220);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(115, 20);
            this.ValorServicioTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(368, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Servicio:";
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AgregarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarBtn.Location = new System.Drawing.Point(292, 290);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(152, 42);
            this.AgregarBtn.TabIndex = 10;
            this.AgregarBtn.Text = "Agregar Paciente";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // LiquidacionFecha
            // 
            this.LiquidacionFecha.Location = new System.Drawing.Point(408, 123);
            this.LiquidacionFecha.Name = "LiquidacionFecha";
            this.LiquidacionFecha.Size = new System.Drawing.Size(183, 20);
            this.LiquidacionFecha.TabIndex = 11;
            this.LiquidacionFecha.ValueChanged += new System.EventHandler(this.LiquidacionFecha_ValueChanged);
            // 
            // AgregarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(756, 499);
            this.Controls.Add(this.LiquidacionFecha);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalarioTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoBox);
            this.Controls.Add(this.Tipolbl);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarLiquidacion";
            this.Text = "AgregarLiquidacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.Label Tipolbl;
        private System.Windows.Forms.ComboBox tipoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalarioTxt;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DateTimePicker LiquidacionFecha;
    }
}