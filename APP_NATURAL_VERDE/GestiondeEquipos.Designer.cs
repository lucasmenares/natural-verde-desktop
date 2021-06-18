namespace APP_NATURAL_VERDE
{
    partial class GestiondeEquipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NombreGE = new System.Windows.Forms.Label();
            this.txtNombreGE = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardarGE = new System.Windows.Forms.Button();
            this.btnEliminarGE = new System.Windows.Forms.Button();
            this.CodigoGE = new System.Windows.Forms.Label();
            this.txtCodigoEquipo = new System.Windows.Forms.NumericUpDown();
            this.dgGestionEquipo = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrarNombre = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreGE
            // 
            this.NombreGE.AutoSize = true;
            this.NombreGE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreGE.Location = new System.Drawing.Point(23, 38);
            this.NombreGE.Name = "NombreGE";
            this.NombreGE.Size = new System.Drawing.Size(106, 16);
            this.NombreGE.TabIndex = 11;
            this.NombreGE.Text = "Nombre Equipo";
            // 
            // txtNombreGE
            // 
            // 
            // 
            // 
            this.txtNombreGE.CustomButton.Image = null;
            this.txtNombreGE.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txtNombreGE.CustomButton.Name = "";
            this.txtNombreGE.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreGE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreGE.CustomButton.TabIndex = 1;
            this.txtNombreGE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreGE.CustomButton.UseSelectable = true;
            this.txtNombreGE.CustomButton.Visible = false;
            this.txtNombreGE.Lines = new string[0];
            this.txtNombreGE.Location = new System.Drawing.Point(23, 63);
            this.txtNombreGE.MaxLength = 32767;
            this.txtNombreGE.Name = "txtNombreGE";
            this.txtNombreGE.PasswordChar = '\0';
            this.txtNombreGE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreGE.SelectedText = "";
            this.txtNombreGE.SelectionLength = 0;
            this.txtNombreGE.SelectionStart = 0;
            this.txtNombreGE.ShortcutsEnabled = true;
            this.txtNombreGE.Size = new System.Drawing.Size(130, 23);
            this.txtNombreGE.TabIndex = 12;
            this.txtNombreGE.UseSelectable = true;
            this.txtNombreGE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreGE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreGE.Click += new System.EventHandler(this.txtNombreGE_Click);
            // 
            // btnGuardarGE
            // 
            this.btnGuardarGE.Location = new System.Drawing.Point(159, 63);
            this.btnGuardarGE.Name = "btnGuardarGE";
            this.btnGuardarGE.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarGE.TabIndex = 13;
            this.btnGuardarGE.Text = "Guardar";
            this.btnGuardarGE.UseVisualStyleBackColor = true;
            this.btnGuardarGE.Click += new System.EventHandler(this.btnGuardarGE_Click);
            // 
            // btnEliminarGE
            // 
            this.btnEliminarGE.Location = new System.Drawing.Point(382, 63);
            this.btnEliminarGE.Name = "btnEliminarGE";
            this.btnEliminarGE.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarGE.TabIndex = 15;
            this.btnEliminarGE.Text = "Eliminar";
            this.btnEliminarGE.UseVisualStyleBackColor = true;
            this.btnEliminarGE.Click += new System.EventHandler(this.btnEliminarGE_Click);
            // 
            // CodigoGE
            // 
            this.CodigoGE.AutoSize = true;
            this.CodigoGE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoGE.Location = new System.Drawing.Point(251, 38);
            this.CodigoGE.Name = "CodigoGE";
            this.CodigoGE.Size = new System.Drawing.Size(101, 16);
            this.CodigoGE.TabIndex = 17;
            this.CodigoGE.Text = "Codigo Equipo";
            // 
            // txtCodigoEquipo
            // 
            this.txtCodigoEquipo.Location = new System.Drawing.Point(254, 66);
            this.txtCodigoEquipo.Name = "txtCodigoEquipo";
            this.txtCodigoEquipo.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoEquipo.TabIndex = 18;
            // 
            // dgGestionEquipo
            // 
            this.dgGestionEquipo.AllowUserToResizeRows = false;
            this.dgGestionEquipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgGestionEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgGestionEquipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgGestionEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGestionEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGestionEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGestionEquipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgGestionEquipo.EnableHeadersVisualStyles = false;
            this.dgGestionEquipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgGestionEquipo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgGestionEquipo.Location = new System.Drawing.Point(26, 179);
            this.dgGestionEquipo.Margin = new System.Windows.Forms.Padding(10);
            this.dgGestionEquipo.Name = "dgGestionEquipo";
            this.dgGestionEquipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGestionEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgGestionEquipo.RowHeadersWidth = 100;
            this.dgGestionEquipo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgGestionEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGestionEquipo.Size = new System.Drawing.Size(461, 178);
            this.dgGestionEquipo.Style = MetroFramework.MetroColorStyle.Green;
            this.dgGestionEquipo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filtrar Nombre";
            // 
            // txtFiltrarNombre
            // 
            // 
            // 
            // 
            this.txtFiltrarNombre.CustomButton.Image = null;
            this.txtFiltrarNombre.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txtFiltrarNombre.CustomButton.Name = "";
            this.txtFiltrarNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltrarNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrarNombre.CustomButton.TabIndex = 1;
            this.txtFiltrarNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrarNombre.CustomButton.UseSelectable = true;
            this.txtFiltrarNombre.CustomButton.Visible = false;
            this.txtFiltrarNombre.Lines = new string[0];
            this.txtFiltrarNombre.Location = new System.Drawing.Point(26, 119);
            this.txtFiltrarNombre.MaxLength = 32767;
            this.txtFiltrarNombre.Name = "txtFiltrarNombre";
            this.txtFiltrarNombre.PasswordChar = '\0';
            this.txtFiltrarNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrarNombre.SelectedText = "";
            this.txtFiltrarNombre.SelectionLength = 0;
            this.txtFiltrarNombre.SelectionStart = 0;
            this.txtFiltrarNombre.ShortcutsEnabled = true;
            this.txtFiltrarNombre.Size = new System.Drawing.Size(130, 23);
            this.txtFiltrarNombre.TabIndex = 22;
            this.txtFiltrarNombre.UseSelectable = true;
            this.txtFiltrarNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltrarNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrarNombre_KeyUp);
            // 
            // GestiondeEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 387);
            this.Controls.Add(this.txtFiltrarNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgGestionEquipo);
            this.Controls.Add(this.txtCodigoEquipo);
            this.Controls.Add(this.CodigoGE);
            this.Controls.Add(this.btnEliminarGE);
            this.Controls.Add(this.btnGuardarGE);
            this.Controls.Add(this.txtNombreGE);
            this.Controls.Add(this.NombreGE);
            this.Name = "GestiondeEquipos";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NombreGE;
        private MetroFramework.Controls.MetroTextBox txtNombreGE;
        private System.Windows.Forms.Button btnGuardarGE;
        private System.Windows.Forms.Button btnEliminarGE;
        private System.Windows.Forms.Label CodigoGE;
        private System.Windows.Forms.NumericUpDown txtCodigoEquipo;
        private MetroFramework.Controls.MetroGrid dgGestionEquipo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtFiltrarNombre;
    }
}