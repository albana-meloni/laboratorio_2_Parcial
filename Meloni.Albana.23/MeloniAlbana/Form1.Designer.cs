namespace MeloniAlbana
{
    partial class FormAtencion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtender = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(569, 33);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(142, 63);
            btnAtender.TabIndex = 4;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 9);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(99, 15);
            lblMedicos.TabIndex = 0;
            lblMedicos.Text = "Personal Médico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(291, 9);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(62, 15);
            lblPacientes.TabIndex = 2;
            lblPacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 33);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(259, 169);
            lstMedicos.TabIndex = 1;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(291, 33);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(259, 169);
            lstPacientes.TabIndex = 3;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 220);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(538, 218);
            rtbInfoMedico.TabIndex = 5;
            rtbInfoMedico.Text = "";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(569, 375);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 63);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(btnSalir);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btnAtender);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atención de pacientes";
            FormClosing += FormAtencion_FormClosing;
            Load += FormAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Label lblMedicos;
        private Label lblPacientes;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private Button btnSalir;
    }
}
