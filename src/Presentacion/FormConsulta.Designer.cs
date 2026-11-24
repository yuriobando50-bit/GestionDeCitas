namespace GestionDeCitas
{
    partial class FormConsulta
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
            label1 = new Label();
            label2 = new Label();
            txtBuscarPaciente = new TextBox();
            btnBuscarPaciente = new Button();
            dgvPacientes = new DataGridView();
            label3 = new Label();
            txtBuscarCita = new TextBox();
            btnBuscarCita = new Button();
            dgvCitas = new DataGridView();
            btnMostrarPacientes = new Button();
            btnMostrarCitas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 33);
            label1.Name = "label1";
            label1.Size = new Size(326, 30);
            label1.TabIndex = 0;
            label1.Text = "CONSUTA DE PACIENTES Y CITAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 78);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "CONSULTA PACIENTES";
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new Point(50, 96);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(100, 23);
            txtBuscarPaciente.TabIndex = 2;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Location = new Point(60, 148);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(75, 23);
            btnBuscarPaciente.TabIndex = 3;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(3, 177);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(215, 87);
            dgvPacientes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 276);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "CONSULTAR CITAS";
            // 
            // txtBuscarCita
            // 
            txtBuscarCita.Location = new Point(50, 294);
            txtBuscarCita.Name = "txtBuscarCita";
            txtBuscarCita.Size = new Size(100, 23);
            txtBuscarCita.TabIndex = 6;
            // 
            // btnBuscarCita
            // 
            btnBuscarCita.Location = new Point(326, 138);
            btnBuscarCita.Name = "btnBuscarCita";
            btnBuscarCita.Size = new Size(75, 23);
            btnBuscarCita.TabIndex = 7;
            btnBuscarCita.Text = "Buscar";
            btnBuscarCita.UseVisualStyleBackColor = true;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(293, 177);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(229, 129);
            dgvCitas.TabIndex = 8;
            // 
            // btnMostrarPacientes
            // 
            btnMostrarPacientes.Location = new Point(326, 326);
            btnMostrarPacientes.Name = "btnMostrarPacientes";
            btnMostrarPacientes.Size = new Size(75, 23);
            btnMostrarPacientes.TabIndex = 9;
            btnMostrarPacientes.Text = "Mostrar todos";
            btnMostrarPacientes.UseVisualStyleBackColor = true;
            // 
            // btnMostrarCitas
            // 
            btnMostrarCitas.Location = new Point(326, 355);
            btnMostrarCitas.Name = "btnMostrarCitas";
            btnMostrarCitas.Size = new Size(75, 23);
            btnMostrarCitas.TabIndex = 10;
            btnMostrarCitas.Text = "Mostrar todas";
            btnMostrarCitas.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(btnMostrarCitas);
            Controls.Add(btnMostrarPacientes);
            Controls.Add(dgvCitas);
            Controls.Add(btnBuscarCita);
            Controls.Add(txtBuscarCita);
            Controls.Add(label3);
            Controls.Add(dgvPacientes);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConsulta";
            Text = "Consulta de pacientes y citas";
            Load += FormConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBuscarPaciente;
        private Button btnBuscarPaciente;
        private DataGridView dgvPacientes;
        private Label label3;
        private TextBox txtBuscarCita;
        private Button btnBuscarCita;
        private DataGridView dgvCitas;
        private Button btnMostrarPacientes;
        private Button btnMostrarCitas;
    }
}