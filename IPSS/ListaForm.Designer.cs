namespace IPSS
{
    partial class ListaForm
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
            this.TablaLiquidaciones = new System.Windows.Forms.DataGridView();
            this.TipoBox = new System.Windows.Forms.ComboBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalLiquidadoTxt = new System.Windows.Forms.TextBox();
            this.BuscarTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaFiltro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaLiquidaciones
            // 
            this.TablaLiquidaciones.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.TablaLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaLiquidaciones.Location = new System.Drawing.Point(227, 45);
            this.TablaLiquidaciones.Name = "TablaLiquidaciones";
            this.TablaLiquidaciones.Size = new System.Drawing.Size(490, 336);
            this.TablaLiquidaciones.TabIndex = 0;
            this.TablaLiquidaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaLiquidaciones_CellContentClick);
            // 
            // TipoBox
            // 
            this.TipoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoBox.FormattingEnabled = true;
            this.TipoBox.Items.AddRange(new object[] {
            "TODOS",
            "SUBSIDIADO",
            "CONTRIBUTIVO"});
            this.TipoBox.Location = new System.Drawing.Point(21, 128);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(145, 21);
            this.TipoBox.TabIndex = 1;
            this.TipoBox.SelectedIndexChanged += new System.EventHandler(this.TipoBox_SelectedIndexChanged);
            // 
            // TotalBox
            // 
            this.TotalBox.Enabled = false;
            this.TotalBox.Location = new System.Drawing.Point(275, 419);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(144, 20);
            this.TotalBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(233, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(459, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Liquidado:";
            // 
            // TotalLiquidadoTxt
            // 
            this.TotalLiquidadoTxt.Enabled = false;
            this.TotalLiquidadoTxt.Location = new System.Drawing.Point(548, 419);
            this.TotalLiquidadoTxt.Name = "TotalLiquidadoTxt";
            this.TotalLiquidadoTxt.Size = new System.Drawing.Size(144, 20);
            this.TotalLiquidadoTxt.TabIndex = 5;
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(20, 208);
            this.BuscarTxt.Name = "BuscarTxt";
            this.BuscarTxt.Size = new System.Drawing.Size(149, 20);
            this.BuscarTxt.TabIndex = 6;
            this.BuscarTxt.TextChanged += new System.EventHandler(this.BuscarTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo liquidación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Búsqueda por Escrito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(44, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Por Fecha:";
            // 
            // FechaFiltro
            // 
            this.FechaFiltro.Location = new System.Drawing.Point(33, 285);
            this.FechaFiltro.Name = "FechaFiltro";
            this.FechaFiltro.Size = new System.Drawing.Size(141, 20);
            this.FechaFiltro.TabIndex = 10;
            this.FechaFiltro.ValueChanged += new System.EventHandler(this.FechaFiltro_ValueChanged);
            // 
            // ListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(756, 499);
            this.Controls.Add(this.FechaFiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarTxt);
            this.Controls.Add(this.TotalLiquidadoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.TablaLiquidaciones);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaForm";
            this.Text = "ListaForm";
            this.Load += new System.EventHandler(this.ListaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaLiquidaciones;
        private System.Windows.Forms.ComboBox TipoBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalLiquidadoTxt;
        private System.Windows.Forms.TextBox BuscarTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaFiltro;
    }
}