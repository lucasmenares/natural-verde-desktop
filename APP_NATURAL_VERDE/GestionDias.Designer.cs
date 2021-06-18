namespace APP_NATURAL_VERDE
{
    partial class GestionDias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDia = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregarDias = new MetroFramework.Controls.MetroButton();
            this.btnEliminarDias = new MetroFramework.Controls.MetroButton();
            this.dgDiasDisponibles = new MetroFramework.Controls.MetroGrid();
            this.txtCodigoDia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltrarDia = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiasDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestionar Dias de Agendamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // txtDia
            // 
            // 
            // 
            // 
            this.txtDia.CustomButton.Image = null;
            this.txtDia.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtDia.CustomButton.Name = "";
            this.txtDia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDia.CustomButton.TabIndex = 1;
            this.txtDia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDia.CustomButton.UseSelectable = true;
            this.txtDia.CustomButton.Visible = false;
            this.txtDia.Lines = new string[0];
            this.txtDia.Location = new System.Drawing.Point(49, 110);
            this.txtDia.MaxLength = 32767;
            this.txtDia.Name = "txtDia";
            this.txtDia.PasswordChar = '\0';
            this.txtDia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDia.SelectedText = "";
            this.txtDia.SelectionLength = 0;
            this.txtDia.SelectionStart = 0;
            this.txtDia.ShortcutsEnabled = true;
            this.txtDia.Size = new System.Drawing.Size(135, 23);
            this.txtDia.TabIndex = 9;
            this.txtDia.UseSelectable = true;
            this.txtDia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDia.Click += new System.EventHandler(this.txtDia_Click);
            // 
            // btnAgregarDias
            // 
            this.btnAgregarDias.Location = new System.Drawing.Point(209, 110);
            this.btnAgregarDias.Name = "btnAgregarDias";
            this.btnAgregarDias.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDias.TabIndex = 14;
            this.btnAgregarDias.Text = "Agregar";
            this.btnAgregarDias.UseSelectable = true;
            this.btnAgregarDias.Click += new System.EventHandler(this.btnAgregarDias_Click);
            // 
            // btnEliminarDias
            // 
            this.btnEliminarDias.Location = new System.Drawing.Point(506, 107);
            this.btnEliminarDias.Name = "btnEliminarDias";
            this.btnEliminarDias.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDias.TabIndex = 15;
            this.btnEliminarDias.Text = "Eliminar";
            this.btnEliminarDias.UseSelectable = true;
            this.btnEliminarDias.Click += new System.EventHandler(this.btnEliminarDias_Click);
            // 
            // dgDiasDisponibles
            // 
            this.dgDiasDisponibles.AllowUserToResizeRows = false;
            this.dgDiasDisponibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgDiasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDiasDisponibles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDiasDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDiasDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDiasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDiasDisponibles.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDiasDisponibles.EnableHeadersVisualStyles = false;
            this.dgDiasDisponibles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgDiasDisponibles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgDiasDisponibles.Location = new System.Drawing.Point(49, 241);
            this.dgDiasDisponibles.Name = "dgDiasDisponibles";
            this.dgDiasDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDiasDisponibles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDiasDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDiasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDiasDisponibles.Size = new System.Drawing.Size(729, 217);
            this.dgDiasDisponibles.Style = MetroFramework.MetroColorStyle.Green;
            this.dgDiasDisponibles.TabIndex = 16;
            // 
            // txtCodigoDia
            // 
            this.txtCodigoDia.Location = new System.Drawing.Point(370, 110);
            this.txtCodigoDia.Name = "txtCodigoDia";
            this.txtCodigoDia.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoDia.TabIndex = 19;
            this.txtCodigoDia.ValueChanged += new System.EventHandler(this.txtCodigoDia_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Filtrar Dia";
            // 
            // txtFiltrarDia
            // 
            // 
            // 
            // 
            this.txtFiltrarDia.CustomButton.Image = null;
            this.txtFiltrarDia.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtFiltrarDia.CustomButton.Name = "";
            this.txtFiltrarDia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltrarDia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrarDia.CustomButton.TabIndex = 1;
            this.txtFiltrarDia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrarDia.CustomButton.UseSelectable = true;
            this.txtFiltrarDia.CustomButton.Visible = false;
            this.txtFiltrarDia.Lines = new string[0];
            this.txtFiltrarDia.Location = new System.Drawing.Point(49, 173);
            this.txtFiltrarDia.MaxLength = 32767;
            this.txtFiltrarDia.Name = "txtFiltrarDia";
            this.txtFiltrarDia.PasswordChar = '\0';
            this.txtFiltrarDia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrarDia.SelectedText = "";
            this.txtFiltrarDia.SelectionLength = 0;
            this.txtFiltrarDia.SelectionStart = 0;
            this.txtFiltrarDia.ShortcutsEnabled = true;
            this.txtFiltrarDia.Size = new System.Drawing.Size(135, 23);
            this.txtFiltrarDia.TabIndex = 25;
            this.txtFiltrarDia.UseSelectable = true;
            this.txtFiltrarDia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrarDia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltrarDia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrarDia_KeyUp);
            // 
            // GestionDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 577);
            this.Controls.Add(this.txtFiltrarDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoDia);
            this.Controls.Add(this.dgDiasDisponibles);
            this.Controls.Add(this.btnEliminarDias);
            this.Controls.Add(this.btnAgregarDias);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionDias";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgDiasDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtDia;
        private MetroFramework.Controls.MetroButton btnAgregarDias;
        private MetroFramework.Controls.MetroButton btnEliminarDias;
        private MetroFramework.Controls.MetroGrid dgDiasDisponibles;
        private System.Windows.Forms.NumericUpDown txtCodigoDia;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtFiltrarDia;
    }
}