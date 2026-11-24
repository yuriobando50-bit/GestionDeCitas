namespace GestionDeCitas
{
    partial class FormGestionCitas
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
            lblTitulo = new Label();
            lblPaciente = new Label();
            txtPaciente = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblHora = new Label();
            dtpHora = new DateTimePicker();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnRegistrarCita = new Button();
            dgvCitas = new DataGridView();
            colPaciente = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colHora = new DataGridViewTextBoxColumn();
            colMotivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(27, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE CITAS ";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(27, 70);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(55, 15);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "Paciente:";
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(88, 70);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(100, 23);
            txtPaciente.TabIndex = 2;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(27, 116);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(88, 113);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 4;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(27, 157);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(108, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo electronico:";
            lblCorreo.Click += label1_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(141, 154);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(167, 23);
            txtCorreo.TabIndex = 6;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(27, 204);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(91, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha de la cita:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(124, 204);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(27, 259);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(86, 15);
            lblHora.TabIndex = 9;
            lblHora.Text = "Hora de la cita:";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(124, 258);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(200, 23);
            dtpHora.TabIndex = 10;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(27, 305);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(98, 15);
            lblMotivo.TabIndex = 11;
            lblMotivo.Text = "Motivo de la cita:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(129, 308);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(127, 23);
            txtMotivo.TabIndex = 12;
            // 
            // btnRegistrarCita
            // 
            btnRegistrarCita.Location = new Point(113, 355);
            btnRegistrarCita.Name = "btnRegistrarCita";
            btnRegistrarCita.Size = new Size(116, 23);
            btnRegistrarCita.TabIndex = 13;
            btnRegistrarCita.Text = "Registrar la cita";
            btnRegistrarCita.UseVisualStyleBackColor = true;
            btnRegistrarCita.Click += btnRegistrarCita_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Columns.AddRange(new DataGridViewColumn[] { colPaciente, colTelefono, colCorreo, colFecha, colHora, colMotivo });
            dgvCitas.Location = new Point(12, 403);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.Size = new Size(605, 204);
            dgvCitas.TabIndex = 14;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // colPaciente
            // 
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "colPaciente";
            colPaciente.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telefono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo electronico";
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // colMotivo
            // 
            colMotivo.HeaderText = "Motivo";
            colMotivo.Name = "colMotivo";
            colMotivo.ReadOnly = true;
            // 
            // FormGestionCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(dgvCitas);
            Controls.Add(btnRegistrarCita);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(dtpHora);
            Controls.Add(lblHora);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtPaciente);
            Controls.Add(lblPaciente);
            Controls.Add(lblTitulo);
            Name = "FormGestionCitas";
            Text = "FormGestionCitas";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPaciente;
        private TextBox txtPaciente;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblHora;
        private DateTimePicker dtpHora;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Button btnRegistrarCita;
        private DataGridView dgvCitas;
        private DataGridViewTextBoxColumn colPaciente;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colMotivo;
    }
}