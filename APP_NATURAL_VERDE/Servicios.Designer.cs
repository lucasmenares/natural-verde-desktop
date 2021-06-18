namespace APP_NATURAL_VERDE
{
    partial class Servicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombreServicio = new MetroFramework.Controls.MetroTextBox();
            this.dgServicios = new MetroFramework.Controls.MetroGrid();
            this.NombreGE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrarServicio = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigoServicio = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarGE = new System.Windows.Forms.Button();
            this.btnEliminarGE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreServicio
            // 
            // 
            // 
            // 
            this.txtNombreServicio.CustomButton.Image = null;
            this.txtNombreServicio.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtNombreServicio.CustomButton.Name = "";
            this.txtNombreServicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreServicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreServicio.CustomButton.TabIndex = 1;
            this.txtNombreServicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreServicio.CustomButton.UseSelectable = true;
            this.txtNombreServicio.CustomButton.Visible = false;
            this.txtNombreServicio.Lines = new string[0];
            this.txtNombreServicio.Location = new System.Drawing.Point(35, 82);
            this.txtNombreServicio.MaxLength = 32767;
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.PasswordChar = '\0';
            this.txtNombreServicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreServicio.SelectedText = "";
            this.txtNombreServicio.SelectionLength = 0;
            this.txtNombreServicio.SelectionStart = 0;
            this.txtNombreServicio.ShortcutsEnabled = true;
            this.txtNombreServicio.Size = new System.Drawing.Size(135, 23);
            this.txtNombreServicio.TabIndex = 5;
            this.txtNombreServicio.UseSelectable = true;
            this.txtNombreServicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreServicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgServicios
            // 
            this.dgServicios.AllowUserToResizeRows = false;
            this.dgServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgServicios.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgServicios.EnableHeadersVisualStyles = false;
            this.dgServicios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgServicios.Location = new System.Drawing.Point(35, 181);
            this.dgServicios.Name = "dgServicios";
            this.dgServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgServicios.Size = new System.Drawing.Size(507, 276);
            this.dgServicios.Style = MetroFramework.MetroColorStyle.Green;
            this.dgServicios.TabIndex = 6;
            // 
            // NombreGE
            // 
            this.NombreGE.AutoSize = true;
            this.NombreGE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreGE.Location = new System.Drawing.Point(32, 50);
            this.NombreGE.Name = "NombreGE";
            this.NombreGE.Size = new System.Drawing.Size(114, 16);
            this.NombreGE.TabIndex = 12;
            this.NombreGE.Text = "Nombre Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filtrar Servicio";
            // 
            // txtFiltrarServicio
            // 
            // 
            // 
            // 
            this.txtFiltrarServicio.CustomButton.Image = null;
            this.txtFiltrarServicio.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtFiltrarServicio.CustomButton.Name = "";
            this.txtFiltrarServicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltrarServicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrarServicio.CustomButton.TabIndex = 1;
            this.txtFiltrarServicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrarServicio.CustomButton.UseSelectable = true;
            this.txtFiltrarServicio.CustomButton.Visible = false;
            this.txtFiltrarServicio.Lines = new string[0];
            this.txtFiltrarServicio.Location = new System.Drawing.Point(35, 138);
            this.txtFiltrarServicio.MaxLength = 32767;
            this.txtFiltrarServicio.Name = "txtFiltrarServicio";
            this.txtFiltrarServicio.PasswordChar = '\0';
            this.txtFiltrarServicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrarServicio.SelectedText = "";
            this.txtFiltrarServicio.SelectionLength = 0;
            this.txtFiltrarServicio.SelectionStart = 0;
            this.txtFiltrarServicio.ShortcutsEnabled = true;
            this.txtFiltrarServicio.Size = new System.Drawing.Size(135, 23);
            this.txtFiltrarServicio.TabIndex = 15;
            this.txtFiltrarServicio.UseSelectable = true;
            this.txtFiltrarServicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarServicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltrarServicio.Click += new System.EventHandler(this.txtFiltrarServicio_Click);
            this.txtFiltrarServicio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrarServicio_KeyUp);
            // 
            // txtCodigoServicio
            // 
            this.txtCodigoServicio.Location = new System.Drawing.Point(293, 85);
            this.txtCodigoServicio.Name = "txtCodigoServicio";
            this.txtCodigoServicio.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoServicio.TabIndex = 19;
            // 
            // btnGuardarGE
            // 
            this.btnGuardarGE.Location = new System.Drawing.Point(176, 82);
            this.btnGuardarGE.Name = "btnGuardarGE";
            this.btnGuardarGE.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarGE.TabIndex = 20;
            this.btnGuardarGE.Text = "Guardar";
            this.btnGuardarGE.UseVisualStyleBackColor = true;
            this.btnGuardarGE.Click += new System.EventHandler(this.btnGuardarGE_Click);
            // 
            // btnEliminarGE
            // 
            this.btnEliminarGE.Location = new System.Drawing.Point(419, 82);
            this.btnEliminarGE.Name = "btnEliminarGE";
            this.btnEliminarGE.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarGE.TabIndex = 21;
            this.btnEliminarGE.Text = "Eliminar";
            this.btnEliminarGE.UseVisualStyleBackColor = true;
            this.btnEliminarGE.Click += new System.EventHandler(this.btnEliminarGE_Click);
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnEliminarGE);
            this.Controls.Add(this.btnGuardarGE);
            this.Controls.Add(this.txtCodigoServicio);
            this.Controls.Add(this.txtFiltrarServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreGE);
            this.Controls.Add(this.dgServicios);
            this.Controls.Add(this.txtNombreServicio);
            this.Name = "Servicios";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtNombreServicio;
        private MetroFramework.Controls.MetroGrid dgServicios;
        private System.Windows.Forms.Label NombreGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtFiltrarServicio;
        private System.Windows.Forms.NumericUpDown txtCodigoServicio;
        private System.Windows.Forms.Button btnGuardarGE;
        private System.Windows.Forms.Button btnEliminarGE;
    }
}