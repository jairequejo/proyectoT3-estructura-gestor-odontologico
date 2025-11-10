namespace GUI
{
    partial class FormMenuPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.linkGestorPaciente = new System.Windows.Forms.LinkLabel();
            this.linkCitas = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(7, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestor Clínica Licurgo";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlContenedor.Location = new System.Drawing.Point(5, 31);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1341, 653);
            this.pnlContenedor.TabIndex = 13;
            // 
            // linkGestorPaciente
            // 
            this.linkGestorPaciente.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkGestorPaciente.AutoSize = true;
            this.linkGestorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGestorPaciente.LinkColor = System.Drawing.Color.White;
            this.linkGestorPaciente.Location = new System.Drawing.Point(1229, 7);
            this.linkGestorPaciente.Name = "linkGestorPaciente";
            this.linkGestorPaciente.Size = new System.Drawing.Size(91, 18);
            this.linkGestorPaciente.TabIndex = 14;
            this.linkGestorPaciente.TabStop = true;
            this.linkGestorPaciente.Text = "PACIENTES";
            this.linkGestorPaciente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkCitas
            // 
            this.linkCitas.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkCitas.AutoSize = true;
            this.linkCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCitas.LinkColor = System.Drawing.Color.White;
            this.linkCitas.Location = new System.Drawing.Point(1161, 7);
            this.linkCitas.Name = "linkCitas";
            this.linkCitas.Size = new System.Drawing.Size(50, 18);
            this.linkCitas.TabIndex = 15;
            this.linkCitas.TabStop = true;
            this.linkCitas.Text = "CITAS";
            this.linkCitas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCitas_LinkClicked);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1352, 692);
            this.Controls.Add(this.linkCitas);
            this.Controls.Add(this.linkGestorPaciente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FormMenuPrincipal";
            this.Text = "FormMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.LinkLabel linkGestorPaciente;
        private System.Windows.Forms.LinkLabel linkCitas;
    }
}