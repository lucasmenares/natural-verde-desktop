namespace APP_NATURAL_VERDE
{
    partial class GestionHorario
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHora = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarGH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoHorario = new System.Windows.Forms.NumericUpDown();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.dgHorario = new MetroFramework.Controls.MetroGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDia = new MetroFramework.Controls.MetroComboBox();
            this.cbxEquipo = new MetroFramework.Controls.MetroComboBox();
            this.btnReiniciarFiltros = new MetroFramework.Controls.MetroButton();
            this.txtFiltroHora = new MetroFramework.Controls.MetroTextBox();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.cbDisponible = new MetroFramework.Controls.MetroComboBox();
            this.dateTimeFiltro = new MetroFramework.Controls.MetroDateTime();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora";
            // 
            // txtHora
            // 
            // 
            // 
            // 
            this.txtHora.CustomButton.Image = null;
            this.txtHora.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtHora.CustomButton.Name = "";
            this.txtHora.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHora.CustomButton.TabIndex = 1;
            this.txtHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHora.CustomButton.UseSelectable = true;
            this.txtHora.CustomButton.Visible = false;
            this.txtHora.Lines = new string[0];
            this.txtHora.Location = new System.Drawing.Point(23, 34);
            this.txtHora.MaxLength = 32767;
            this.txtHora.Name = "txtHora";
            this.txtHora.PasswordChar = '\0';
            this.txtHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHora.SelectedText = "";
            this.txtHora.SelectionLength = 0;
            this.txtHora.SelectionStart = 0;
            this.txtHora.ShortcutsEnabled = true;
            this.txtHora.Size = new System.Drawing.Size(123, 23);
            this.txtHora.TabIndex = 11;
            this.txtHora.UseSelectable = true;
            this.txtHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHora.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Equipo";
            // 
            // btnGuardarGH
            // 
            this.btnGuardarGH.Location = new System.Drawing.Point(406, 34);
            this.btnGuardarGH.Name = "btnGuardarGH";
            this.btnGuardarGH.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarGH.TabIndex = 21;
            this.btnGuardarGH.Text = "Guardar";
            this.btnGuardarGH.UseVisualStyleBackColor = true;
            this.btnGuardarGH.Click += new System.EventHandler(this.btnGuardarGH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Codigo Horario";
            // 
            // txtCodigoHorario
            // 
            this.txtCodigoHorario.Location = new System.Drawing.Point(23, 143);
            this.txtCodigoHorario.Name = "txtCodigoHorario";
            this.txtCodigoHorario.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoHorario.TabIndex = 25;
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(149, 140);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarHorario.TabIndex = 26;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // dgHorario
            // 
            this.dgHorario.AllowUserToResizeRows = false;
            this.dgHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgHorario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgHorario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHorario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgHorario.EnableHeadersVisualStyles = false;
            this.dgHorario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgHorario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgHorario.Location = new System.Drawing.Point(23, 193);
            this.dgHorario.Name = "dgHorario";
            this.dgHorario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgHorario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHorario.Size = new System.Drawing.Size(562, 219);
            this.dgHorario.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Filtrar";
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.ItemHeight = 23;
            this.cbxDia.Location = new System.Drawing.Point(152, 34);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(121, 29);
            this.cbxDia.TabIndex = 30;
            this.cbxDia.UseSelectable = true;
            // 
            // cbxEquipo
            // 
            this.cbxEquipo.FormattingEnabled = true;
            this.cbxEquipo.ItemHeight = 23;
            this.cbxEquipo.Location = new System.Drawing.Point(279, 34);
            this.cbxEquipo.Name = "cbxEquipo";
            this.cbxEquipo.Size = new System.Drawing.Size(121, 29);
            this.cbxEquipo.TabIndex = 31;
            this.cbxEquipo.UseSelectable = true;
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.Location = new System.Drawing.Point(455, 117);
            this.btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            this.btnReiniciarFiltros.Size = new System.Drawing.Size(101, 23);
            this.btnReiniciarFiltros.TabIndex = 34;
            this.btnReiniciarFiltros.Text = "Reiniciar Filtos";
            this.btnReiniciarFiltros.UseSelectable = true;
            this.btnReiniciarFiltros.Click += new System.EventHandler(this.btnReiniciarFiltros_Click);
            // 
            // txtFiltroHora
            // 
            // 
            // 
            // 
            this.txtFiltroHora.CustomButton.Image = null;
            this.txtFiltroHora.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtFiltroHora.CustomButton.Name = "";
            this.txtFiltroHora.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltroHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltroHora.CustomButton.TabIndex = 1;
            this.txtFiltroHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltroHora.CustomButton.UseSelectable = true;
            this.txtFiltroHora.CustomButton.Visible = false;
            this.txtFiltroHora.Lines = new string[0];
            this.txtFiltroHora.Location = new System.Drawing.Point(229, 88);
            this.txtFiltroHora.MaxLength = 32767;
            this.txtFiltroHora.Name = "txtFiltroHora";
            this.txtFiltroHora.PasswordChar = '\0';
            this.txtFiltroHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltroHora.SelectedText = "";
            this.txtFiltroHora.SelectionLength = 0;
            this.txtFiltroHora.SelectionStart = 0;
            this.txtFiltroHora.ShortcutsEnabled = true;
            this.txtFiltroHora.Size = new System.Drawing.Size(93, 23);
            this.txtFiltroHora.TabIndex = 35;
            this.txtFiltroHora.UseSelectable = true;
            this.txtFiltroHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltroHora.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(455, 88);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 36;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseSelectable = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbDisponible
            // 
            this.cbDisponible.FormattingEnabled = true;
            this.cbDisponible.ItemHeight = 23;
            this.cbDisponible.Location = new System.Drawing.Point(328, 88);
            this.cbDisponible.Name = "cbDisponible";
            this.cbDisponible.Size = new System.Drawing.Size(121, 29);
            this.cbDisponible.TabIndex = 37;
            this.cbDisponible.UseSelectable = true;
            // 
            // dateTimeFiltro
            // 
            this.dateTimeFiltro.Location = new System.Drawing.Point(23, 88);
            this.dateTimeFiltro.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeFiltro.Name = "dateTimeFiltro";
            this.dateTimeFiltro.Size = new System.Drawing.Size(200, 29);
            this.dateTimeFiltro.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Hora";
            // 
            // GestionHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 480);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeFiltro);
            this.Controls.Add(this.cbDisponible);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltroHora);
            this.Controls.Add(this.btnReiniciarFiltros);
            this.Controls.Add(this.cbxEquipo);
            this.Controls.Add(this.cbxDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgHorario);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.txtCodigoHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardarGH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label2);
            this.Name = "GestionHorario";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.GestionHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarGH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtCodigoHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private MetroFramework.Controls.MetroGrid dgHorario;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cbxDia;
        private MetroFramework.Controls.MetroComboBox cbxEquipo;
        private MetroFramework.Controls.MetroButton btnReiniciarFiltros;
        private MetroFramework.Controls.MetroTextBox txtFiltroHora;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroComboBox cbDisponible;
        private MetroFramework.Controls.MetroDateTime dateTimeFiltro;
        private System.Windows.Forms.Label label6;
    }
}