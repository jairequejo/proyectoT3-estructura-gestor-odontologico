namespace GUI
{
    partial class GestorPacientesUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizarListaPacientes = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.clDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarDNI = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.dtpFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDNIRegistroCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudCostoTratamiento = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarTratamiento = new System.Windows.Forms.Button();
            this.dtpFechaTratamiento = new System.Windows.Forms.DateTimePicker();
            this.tbDescripcionTratamiento = new System.Windows.Forms.TextBox();
            this.tbTipoTratamiento = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbDNIPacienteTratamiento = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreDNISeleccionado = new System.Windows.Forms.Label();
            this.btnActualizarHistorial = new System.Windows.Forms.Button();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.clTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoTratamiento)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.btnActualizarListaPacientes);
            this.groupBox2.Controls.Add(this.dgvPacientes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbBuscarDNI);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(207, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 590);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacientes Registardos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(604, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizarListaPacientes
            // 
            this.btnActualizarListaPacientes.Location = new System.Drawing.Point(567, 561);
            this.btnActualizarListaPacientes.Name = "btnActualizarListaPacientes";
            this.btnActualizarListaPacientes.Size = new System.Drawing.Size(112, 23);
            this.btnActualizarListaPacientes.TabIndex = 3;
            this.btnActualizarListaPacientes.Text = "Actualizar Lista";
            this.btnActualizarListaPacientes.UseVisualStyleBackColor = true;
            this.btnActualizarListaPacientes.Click += new System.EventHandler(this.btnActualizarListaPacientes_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDNI,
            this.clApellido,
            this.clNombre,
            this.clEdad,
            this.clTelefono});
            this.dgvPacientes.Location = new System.Drawing.Point(6, 51);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(673, 504);
            this.dgvPacientes.TabIndex = 2;
            // 
            // clDNI
            // 
            this.clDNI.Frozen = true;
            this.clDNI.HeaderText = "DNI";
            this.clDNI.Name = "clDNI";
            this.clDNI.ReadOnly = true;
            // 
            // clApellido
            // 
            this.clApellido.Frozen = true;
            this.clApellido.HeaderText = "Apellido";
            this.clApellido.Name = "clApellido";
            this.clApellido.ReadOnly = true;
            // 
            // clNombre
            // 
            this.clNombre.Frozen = true;
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.Name = "clNombre";
            this.clNombre.ReadOnly = true;
            // 
            // clEdad
            // 
            this.clEdad.Frozen = true;
            this.clEdad.HeaderText = "Edad";
            this.clEdad.Name = "clEdad";
            this.clEdad.ReadOnly = true;
            // 
            // clTelefono
            // 
            this.clTelefono.Frozen = true;
            this.clTelefono.HeaderText = "Teléfono";
            this.clTelefono.Name = "clTelefono";
            this.clTelefono.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar paciente (DNI):";
            // 
            // tbBuscarDNI
            // 
            this.tbBuscarDNI.Location = new System.Drawing.Point(153, 19);
            this.tbBuscarDNI.Name = "tbBuscarDNI";
            this.tbBuscarDNI.Size = new System.Drawing.Size(122, 22);
            this.tbBuscarDNI.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRegistrarPaciente);
            this.groupBox3.Controls.Add(this.dtpFNacimiento);
            this.groupBox3.Controls.Add(this.tbTelefono);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbNombre);
            this.groupBox3.Controls.Add(this.tbApellido);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbDNIRegistroCliente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 305);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar Paciente";
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(9, 268);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(163, 25);
            this.btnRegistrarPaciente.TabIndex = 4;
            this.btnRegistrarPaciente.Text = "Registrar Paciente";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = false;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // dtpFNacimiento
            // 
            this.dtpFNacimiento.Location = new System.Drawing.Point(9, 186);
            this.dtpFNacimiento.Name = "dtpFNacimiento";
            this.dtpFNacimiento.Size = new System.Drawing.Size(159, 22);
            this.dtpFNacimiento.TabIndex = 8;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(10, 230);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(159, 22);
            this.tbTelefono.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(9, 142);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(159, 22);
            this.tbNombre.TabIndex = 5;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(9, 98);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(159, 22);
            this.tbApellido.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // tbDNIRegistroCliente
            // 
            this.tbDNIRegistroCliente.Location = new System.Drawing.Point(9, 54);
            this.tbDNIRegistroCliente.Name = "tbDNIRegistroCliente";
            this.tbDNIRegistroCliente.Size = new System.Drawing.Size(159, 22);
            this.tbDNIRegistroCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudCostoTratamiento);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnRegistrarTratamiento);
            this.groupBox5.Controls.Add(this.dtpFechaTratamiento);
            this.groupBox5.Controls.Add(this.tbDescripcionTratamiento);
            this.groupBox5.Controls.Add(this.tbTipoTratamiento);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.tbDNIPacienteTratamiento);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(7, 324);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 325);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registrar Tratamiento (Manual)";
            // 
            // nudCostoTratamiento
            // 
            this.nudCostoTratamiento.Location = new System.Drawing.Point(16, 254);
            this.nudCostoTratamiento.Name = "nudCostoTratamiento";
            this.nudCostoTratamiento.Size = new System.Drawing.Size(159, 22);
            this.nudCostoTratamiento.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Costo:";
            // 
            // btnRegistrarTratamiento
            // 
            this.btnRegistrarTratamiento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTratamiento.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarTratamiento.Location = new System.Drawing.Point(17, 291);
            this.btnRegistrarTratamiento.Name = "btnRegistrarTratamiento";
            this.btnRegistrarTratamiento.Size = new System.Drawing.Size(159, 25);
            this.btnRegistrarTratamiento.TabIndex = 9;
            this.btnRegistrarTratamiento.Text = "Registrar Tratamiento";
            this.btnRegistrarTratamiento.UseVisualStyleBackColor = false;
            this.btnRegistrarTratamiento.Click += new System.EventHandler(this.btnRegistrarTratamiento_Click);
            // 
            // dtpFechaTratamiento
            // 
            this.dtpFechaTratamiento.Location = new System.Drawing.Point(16, 201);
            this.dtpFechaTratamiento.Name = "dtpFechaTratamiento";
            this.dtpFechaTratamiento.Size = new System.Drawing.Size(159, 22);
            this.dtpFechaTratamiento.TabIndex = 8;
            // 
            // tbDescripcionTratamiento
            // 
            this.tbDescripcionTratamiento.Location = new System.Drawing.Point(16, 157);
            this.tbDescripcionTratamiento.Name = "tbDescripcionTratamiento";
            this.tbDescripcionTratamiento.Size = new System.Drawing.Size(159, 22);
            this.tbDescripcionTratamiento.TabIndex = 5;
            // 
            // tbTipoTratamiento
            // 
            this.tbTipoTratamiento.Location = new System.Drawing.Point(16, 113);
            this.tbTipoTratamiento.Name = "tbTipoTratamiento";
            this.tbTipoTratamiento.Size = new System.Drawing.Size(159, 22);
            this.tbTipoTratamiento.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Fecha:";
            // 
            // tbDNIPacienteTratamiento
            // 
            this.tbDNIPacienteTratamiento.Location = new System.Drawing.Point(16, 69);
            this.tbDNIPacienteTratamiento.Name = "tbDNIPacienteTratamiento";
            this.tbDNIPacienteTratamiento.Size = new System.Drawing.Size(159, 22);
            this.tbDNIPacienteTratamiento.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Descripcion:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "Tipo:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "DNI:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "GESTOR DE PACIENTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreDNISeleccionado);
            this.groupBox1.Controls.Add(this.btnActualizarHistorial);
            this.groupBox1.Controls.Add(this.dgvHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(898, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 588);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de tratamientos del paciente";
            // 
            // lblNombreDNISeleccionado
            // 
            this.lblNombreDNISeleccionado.AutoSize = true;
            this.lblNombreDNISeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDNISeleccionado.Location = new System.Drawing.Point(6, 18);
            this.lblNombreDNISeleccionado.Name = "lblNombreDNISeleccionado";
            this.lblNombreDNISeleccionado.Size = new System.Drawing.Size(35, 18);
            this.lblNombreDNISeleccionado.TabIndex = 21;
            this.lblNombreDNISeleccionado.Text = "___";
            // 
            // btnActualizarHistorial
            // 
            this.btnActualizarHistorial.Location = new System.Drawing.Point(279, 561);
            this.btnActualizarHistorial.Name = "btnActualizarHistorial";
            this.btnActualizarHistorial.Size = new System.Drawing.Size(146, 23);
            this.btnActualizarHistorial.TabIndex = 4;
            this.btnActualizarHistorial.Text = "Actualizar Historial";
            this.btnActualizarHistorial.UseVisualStyleBackColor = true;
            this.btnActualizarHistorial.Click += new System.EventHandler(this.btnActualizarHistorial_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTipo,
            this.clDescripcion,
            this.clCosto,
            this.clFecha});
            this.dgvHistorial.Location = new System.Drawing.Point(6, 49);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(419, 506);
            this.dgvHistorial.TabIndex = 0;
            // 
            // clTipo
            // 
            this.clTipo.Frozen = true;
            this.clTipo.HeaderText = "Tipo";
            this.clTipo.Name = "clTipo";
            this.clTipo.ReadOnly = true;
            // 
            // clDescripcion
            // 
            this.clDescripcion.Frozen = true;
            this.clDescripcion.HeaderText = "Descripción";
            this.clDescripcion.Name = "clDescripcion";
            this.clDescripcion.ReadOnly = true;
            // 
            // clCosto
            // 
            this.clCosto.Frozen = true;
            this.clCosto.HeaderText = "Costo";
            this.clCosto.Name = "clCosto";
            this.clCosto.ReadOnly = true;
            // 
            // clFecha
            // 
            this.clFecha.Frozen = true;
            this.clFecha.HeaderText = "Fecha";
            this.clFecha.Name = "clFecha";
            this.clFecha.ReadOnly = true;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlContenedor.Controls.Add(this.groupBox1);
            this.pnlContenedor.Controls.Add(this.label7);
            this.pnlContenedor.Controls.Add(this.groupBox5);
            this.pnlContenedor.Controls.Add(this.groupBox3);
            this.pnlContenedor.Controls.Add(this.groupBox2);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1369, 652);
            this.pnlContenedor.TabIndex = 14;
            // 
            // GestorPacientesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContenedor);
            this.Name = "GestorPacientesUserControl";
            this.Size = new System.Drawing.Size(1369, 657);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoTratamiento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizarListaPacientes;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscarDNI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.DateTimePicker dtpFNacimiento;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDNIRegistroCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRegistrarTratamiento;
        private System.Windows.Forms.DateTimePicker dtpFechaTratamiento;
        private System.Windows.Forms.TextBox tbDescripcionTratamiento;
        private System.Windows.Forms.TextBox tbTipoTratamiento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbDNIPacienteTratamiento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombreDNISeleccionado;
        private System.Windows.Forms.Button btnActualizarHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFecha;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nudCostoTratamiento;
        private System.Windows.Forms.Label label8;
    }
}
