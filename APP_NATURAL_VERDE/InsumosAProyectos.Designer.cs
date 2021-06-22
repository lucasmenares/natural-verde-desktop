
namespace APP_NATURAL_VERDE
{
    partial class InsumosAProyectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxInsumos = new MetroFramework.Controls.MetroComboBox();
            this.labelInsumo = new MetroFramework.Controls.MetroLabel();
            this.numericCodigoProyecto = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.numericCantidadInsumo = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarInsumo = new MetroFramework.Controls.MetroButton();
            this.dgInsumosAProyectos = new MetroFramework.Controls.MetroGrid();
            this.numericCodigoProyectoFiltrar = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.btnReiniciarFiltro = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericCodigoProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsumosAProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCodigoProyectoFiltrar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxInsumos
            // 
            this.cbxInsumos.FormattingEnabled = true;
            this.cbxInsumos.ItemHeight = 23;
            this.cbxInsumos.Location = new System.Drawing.Point(149, 99);
            this.cbxInsumos.Name = "cbxInsumos";
            this.cbxInsumos.Size = new System.Drawing.Size(121, 29);
            this.cbxInsumos.TabIndex = 0;
            this.cbxInsumos.UseSelectable = true;
            // 
            // labelInsumo
            // 
            this.labelInsumo.AutoSize = true;
            this.labelInsumo.Location = new System.Drawing.Point(149, 77);
            this.labelInsumo.Name = "labelInsumo";
            this.labelInsumo.Size = new System.Drawing.Size(51, 19);
            this.labelInsumo.TabIndex = 1;
            this.labelInsumo.Text = "Insumo";
            // 
            // numericCodigoProyecto
            // 
            this.numericCodigoProyecto.Location = new System.Drawing.Point(23, 99);
            this.numericCodigoProyecto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericCodigoProyecto.Name = "numericCodigoProyecto";
            this.numericCodigoProyecto.Size = new System.Drawing.Size(120, 20);
            this.numericCodigoProyecto.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Codigo proyecto";
            // 
            // numericCantidadInsumo
            // 
            this.numericCantidadInsumo.Location = new System.Drawing.Point(276, 99);
            this.numericCantidadInsumo.Name = "numericCantidadInsumo";
            this.numericCantidadInsumo.Size = new System.Drawing.Size(120, 20);
            this.numericCantidadInsumo.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(276, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Cantidad insumo";
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.Location = new System.Drawing.Point(402, 99);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarInsumo.TabIndex = 6;
            this.btnAgregarInsumo.Text = "Agregar Insumo";
            this.btnAgregarInsumo.UseSelectable = true;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // dgInsumosAProyectos
            // 
            this.dgInsumosAProyectos.AllowUserToResizeRows = false;
            this.dgInsumosAProyectos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgInsumosAProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInsumosAProyectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgInsumosAProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInsumosAProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgInsumosAProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInsumosAProyectos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgInsumosAProyectos.EnableHeadersVisualStyles = false;
            this.dgInsumosAProyectos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgInsumosAProyectos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgInsumosAProyectos.Location = new System.Drawing.Point(21, 210);
            this.dgInsumosAProyectos.Name = "dgInsumosAProyectos";
            this.dgInsumosAProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInsumosAProyectos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgInsumosAProyectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInsumosAProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInsumosAProyectos.Size = new System.Drawing.Size(756, 226);
            this.dgInsumosAProyectos.TabIndex = 7;
            // 
            // numericCodigoProyectoFiltrar
            // 
            this.numericCodigoProyectoFiltrar.Location = new System.Drawing.Point(23, 164);
            this.numericCodigoProyectoFiltrar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCodigoProyectoFiltrar.Name = "numericCodigoProyectoFiltrar";
            this.numericCodigoProyectoFiltrar.Size = new System.Drawing.Size(120, 20);
            this.numericCodigoProyectoFiltrar.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Codigo proyecto";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(149, 164);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseSelectable = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnReiniciarFiltro
            // 
            this.btnReiniciarFiltro.Location = new System.Drawing.Point(230, 164);
            this.btnReiniciarFiltro.Name = "btnReiniciarFiltro";
            this.btnReiniciarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciarFiltro.TabIndex = 11;
            this.btnReiniciarFiltro.Text = "Reiniciar Filtro";
            this.btnReiniciarFiltro.UseSelectable = true;
            this.btnReiniciarFiltro.Click += new System.EventHandler(this.btnReiniciarFiltro_Click);
            // 
            // InsumosAProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReiniciarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.numericCodigoProyectoFiltrar);
            this.Controls.Add(this.dgInsumosAProyectos);
            this.Controls.Add(this.btnAgregarInsumo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.numericCantidadInsumo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.numericCodigoProyecto);
            this.Controls.Add(this.labelInsumo);
            this.Controls.Add(this.cbxInsumos);
            this.Name = "InsumosAProyectos";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "InsumosAProyectos";
            this.Load += new System.EventHandler(this.InsumosAProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCodigoProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsumosAProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCodigoProyectoFiltrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxInsumos;
        private MetroFramework.Controls.MetroLabel labelInsumo;
        private System.Windows.Forms.NumericUpDown numericCodigoProyecto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown numericCantidadInsumo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAgregarInsumo;
        private MetroFramework.Controls.MetroGrid dgInsumosAProyectos;
        private System.Windows.Forms.NumericUpDown numericCodigoProyectoFiltrar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroButton btnReiniciarFiltro;
    }
}