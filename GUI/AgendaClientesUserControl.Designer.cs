namespace GUI
{
    partial class AgendaClientesUserControl
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chbPreferencial = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.tbMotivoCita = new System.Windows.Forms.TextBox();
            this.tbNombreTemporal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbDNICita = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarCola = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.dtpFiltrarPorFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnFiltrarHoy = new System.Windows.Forms.Button();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.clFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPreferencial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarHistorial = new System.Windows.Forms.Button();
            this.lblUsuarioAtendido = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPacienteEnAtencion = new System.Windows.Forms.Label();
            this.btnCompletarAtencion = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.rtbDescripcionTratamiento = new System.Windows.Forms.RichTextBox();
            this.dtpFechaTratamiento = new System.Windows.Forms.DateTimePicker();
            this.tbTipoTratamiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarTratamiento = new System.Windows.Forms.Button();
            this.lblSiguienteUsuarioCola = new System.Windows.Forms.Label();
            this.btnAtenderCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "AGENDA DE CITAS";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chbPreferencial);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnAgendarCita);
            this.groupBox5.Controls.Add(this.dtpFechaCita);
            this.groupBox5.Controls.Add(this.tbMotivoCita);
            this.groupBox5.Controls.Add(this.tbNombreTemporal);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.tbDNICita);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 298);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agendar Cita";
            // 
            // chbPreferencial
            // 
            this.chbPreferencial.AutoSize = true;
            this.chbPreferencial.Location = new System.Drawing.Point(102, 238);
            this.chbPreferencial.Name = "chbPreferencial";
            this.chbPreferencial.Size = new System.Drawing.Size(15, 14);
            this.chbPreferencial.TabIndex = 17;
            this.chbPreferencial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Preferencial:";
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(16, 258);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(159, 25);
            this.btnAgendarCita.TabIndex = 9;
            this.btnAgendarCita.Text = "Agendar cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(16, 201);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(159, 22);
            this.dtpFechaCita.TabIndex = 8;
            // 
            // tbMotivoCita
            // 
            this.tbMotivoCita.Location = new System.Drawing.Point(16, 157);
            this.tbMotivoCita.Name = "tbMotivoCita";
            this.tbMotivoCita.Size = new System.Drawing.Size(159, 22);
            this.tbMotivoCita.TabIndex = 5;
            // 
            // tbNombreTemporal
            // 
            this.tbNombreTemporal.Location = new System.Drawing.Point(16, 113);
            this.tbNombreTemporal.Name = "tbNombreTemporal";
            this.tbNombreTemporal.Size = new System.Drawing.Size(159, 22);
            this.tbNombreTemporal.TabIndex = 4;
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
            // tbDNICita
            // 
            this.tbDNICita.Location = new System.Drawing.Point(16, 69);
            this.tbDNICita.Name = "tbDNICita";
            this.tbDNICita.Size = new System.Drawing.Size(159, 22);
            this.tbDNICita.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Motivo:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "Nombre:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizarCola);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvCola);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(194, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 565);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cola de citas";
            // 
            // btnActualizarCola
            // 
            this.btnActualizarCola.Location = new System.Drawing.Point(360, 530);
            this.btnActualizarCola.Name = "btnActualizarCola";
            this.btnActualizarCola.Size = new System.Drawing.Size(146, 23);
            this.btnActualizarCola.TabIndex = 23;
            this.btnActualizarCola.Text = "Actualizar Cola";
            this.btnActualizarCola.UseVisualStyleBackColor = true;
            this.btnActualizarCola.Click += new System.EventHandler(this.btnActualizarCola_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltrarPorFecha);
            this.groupBox2.Controls.Add(this.dtpFiltrarPorFecha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnMostrarTodo);
            this.groupBox2.Controls.Add(this.btnFiltrarHoy);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 46);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtos:";
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(439, 18);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(55, 22);
            this.btnFiltrarPorFecha.TabIndex = 23;
            this.btnFiltrarPorFecha.Text = "Filtrar";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarPorFecha.Click += new System.EventHandler(this.btnFiltrarPorFecha_Click);
            // 
            // dtpFiltrarPorFecha
            // 
            this.dtpFiltrarPorFecha.Location = new System.Drawing.Point(207, 18);
            this.dtpFiltrarPorFecha.Name = "dtpFiltrarPorFecha";
            this.dtpFiltrarPorFecha.Size = new System.Drawing.Size(226, 22);
            this.dtpFiltrarPorFecha.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Por Fecha:";
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(57, 16);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(50, 24);
            this.btnMostrarTodo.TabIndex = 21;
            this.btnMostrarTodo.Text = "Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnFiltrarHoy
            // 
            this.btnFiltrarHoy.Location = new System.Drawing.Point(6, 16);
            this.btnFiltrarHoy.Name = "btnFiltrarHoy";
            this.btnFiltrarHoy.Size = new System.Drawing.Size(45, 24);
            this.btnFiltrarHoy.TabIndex = 20;
            this.btnFiltrarHoy.Text = "Hoy";
            this.btnFiltrarHoy.UseVisualStyleBackColor = true;
            this.btnFiltrarHoy.Click += new System.EventHandler(this.btnFiltrarHoy_Click);
            // 
            // dgvCola
            // 
            this.dgvCola.AllowUserToAddRows = false;
            this.dgvCola.AllowUserToDeleteRows = false;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFecha,
            this.clDNI,
            this.clNombre,
            this.clMotivo,
            this.clPreferencial});
            this.dgvCola.Location = new System.Drawing.Point(6, 69);
            this.dgvCola.MultiSelect = false;
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.ReadOnly = true;
            this.dgvCola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCola.Size = new System.Drawing.Size(524, 460);
            this.dgvCola.TabIndex = 0;
            // 
            // clFecha
            // 
            this.clFecha.HeaderText = "Fecha";
            this.clFecha.Name = "clFecha";
            this.clFecha.ReadOnly = true;
            this.clFecha.Width = 80;
            // 
            // clDNI
            // 
            this.clDNI.HeaderText = "DNI";
            this.clDNI.Name = "clDNI";
            this.clDNI.ReadOnly = true;
            this.clDNI.Width = 80;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.Name = "clNombre";
            this.clNombre.ReadOnly = true;
            this.clNombre.Width = 120;
            // 
            // clMotivo
            // 
            this.clMotivo.HeaderText = "Motivo";
            this.clMotivo.Name = "clMotivo";
            this.clMotivo.ReadOnly = true;
            this.clMotivo.Width = 120;
            // 
            // clPreferencial
            // 
            this.clPreferencial.HeaderText = "Preferencial";
            this.clPreferencial.Name = "clPreferencial";
            this.clPreferencial.ReadOnly = true;
            this.clPreferencial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clPreferencial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clPreferencial.Width = 80;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvHistorial);
            this.groupBox6.Controls.Add(this.btnActualizarHistorial);
            this.groupBox6.Controls.Add(this.lblUsuarioAtendido);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(286, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(304, 537);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Historial de tratamientos";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clTipo,
            this.clDescripcion,
            this.clCosto});
            this.dgvHistorial.Location = new System.Drawing.Point(10, 44);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(288, 464);
            this.dgvHistorial.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // clTipo
            // 
            this.clTipo.HeaderText = "Tipo";
            this.clTipo.Name = "clTipo";
            this.clTipo.ReadOnly = true;
            this.clTipo.Width = 80;
            // 
            // clDescripcion
            // 
            this.clDescripcion.HeaderText = "Descripción";
            this.clDescripcion.Name = "clDescripcion";
            this.clDescripcion.ReadOnly = true;
            // 
            // clCosto
            // 
            this.clCosto.HeaderText = "Costo";
            this.clCosto.Name = "clCosto";
            this.clCosto.ReadOnly = true;
            this.clCosto.Width = 60;
            // 
            // btnActualizarHistorial
            // 
            this.btnActualizarHistorial.Location = new System.Drawing.Point(152, 509);
            this.btnActualizarHistorial.Name = "btnActualizarHistorial";
            this.btnActualizarHistorial.Size = new System.Drawing.Size(146, 23);
            this.btnActualizarHistorial.TabIndex = 4;
            this.btnActualizarHistorial.Text = "Actualizar Historial";
            this.btnActualizarHistorial.UseVisualStyleBackColor = true;
            this.btnActualizarHistorial.Click += new System.EventHandler(this.btnActualizarHistorial_Click);
            // 
            // lblUsuarioAtendido
            // 
            this.lblUsuarioAtendido.AutoSize = true;
            this.lblUsuarioAtendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAtendido.Location = new System.Drawing.Point(7, 20);
            this.lblUsuarioAtendido.Name = "lblUsuarioAtendido";
            this.lblUsuarioAtendido.Size = new System.Drawing.Size(31, 15);
            this.lblUsuarioAtendido.TabIndex = 22;
            this.lblUsuarioAtendido.Text = "___";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPacienteEnAtencion);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btnCompletarAtencion);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lblSiguienteUsuarioCola);
            this.groupBox3.Controls.Add(this.btnAtenderCliente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(730, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 565);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Atencion:";
            // 
            // lblPacienteEnAtencion
            // 
            this.lblPacienteEnAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteEnAtencion.ForeColor = System.Drawing.Color.Blue;
            this.lblPacienteEnAtencion.Location = new System.Drawing.Point(9, 105);
            this.lblPacienteEnAtencion.Name = "lblPacienteEnAtencion";
            this.lblPacienteEnAtencion.Size = new System.Drawing.Size(271, 20);
            this.lblPacienteEnAtencion.TabIndex = 24;
            this.lblPacienteEnAtencion.Text = "---";
            this.lblPacienteEnAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompletarAtencion
            // 
            this.btnCompletarAtencion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompletarAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletarAtencion.ForeColor = System.Drawing.Color.Transparent;
            this.btnCompletarAtencion.Location = new System.Drawing.Point(12, 521);
            this.btnCompletarAtencion.Name = "btnCompletarAtencion";
            this.btnCompletarAtencion.Size = new System.Drawing.Size(268, 32);
            this.btnCompletarAtencion.TabIndex = 23;
            this.btnCompletarAtencion.Text = "COMPLETAR ATENCIÓN";
            this.btnCompletarAtencion.UseVisualStyleBackColor = false;
            this.btnCompletarAtencion.Click += new System.EventHandler(this.btnCompletarAtencion_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudCosto);
            this.groupBox4.Controls.Add(this.rtbDescripcionTratamiento);
            this.groupBox4.Controls.Add(this.dtpFechaTratamiento);
            this.groupBox4.Controls.Add(this.tbTipoTratamiento);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnRegistrarTratamiento);
            this.groupBox4.Location = new System.Drawing.Point(9, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 377);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tartamientos";
            // 
            // nudCosto
            // 
            this.nudCosto.DecimalPlaces = 2;
            this.nudCosto.Location = new System.Drawing.Point(13, 305);
            this.nudCosto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(252, 22);
            this.nudCosto.TabIndex = 29;
            // 
            // rtbDescripcionTratamiento
            // 
            this.rtbDescripcionTratamiento.Location = new System.Drawing.Point(13, 94);
            this.rtbDescripcionTratamiento.Name = "rtbDescripcionTratamiento";
            this.rtbDescripcionTratamiento.Size = new System.Drawing.Size(252, 149);
            this.rtbDescripcionTratamiento.TabIndex = 28;
            this.rtbDescripcionTratamiento.Text = "";
            // 
            // dtpFechaTratamiento
            // 
            this.dtpFechaTratamiento.Location = new System.Drawing.Point(13, 266);
            this.dtpFechaTratamiento.Name = "dtpFechaTratamiento";
            this.dtpFechaTratamiento.Size = new System.Drawing.Size(252, 22);
            this.dtpFechaTratamiento.TabIndex = 27;
            // 
            // tbTipoTratamiento
            // 
            this.tbTipoTratamiento.Location = new System.Drawing.Point(13, 49);
            this.tbTipoTratamiento.Name = "tbTipoTratamiento";
            this.tbTipoTratamiento.Size = new System.Drawing.Size(252, 22);
            this.tbTipoTratamiento.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo:";
            // 
            // btnRegistrarTratamiento
            // 
            this.btnRegistrarTratamiento.Location = new System.Drawing.Point(13, 333);
            this.btnRegistrarTratamiento.Name = "btnRegistrarTratamiento";
            this.btnRegistrarTratamiento.Size = new System.Drawing.Size(252, 33);
            this.btnRegistrarTratamiento.TabIndex = 10;
            this.btnRegistrarTratamiento.Text = "Registrar Tratamiento";
            this.btnRegistrarTratamiento.UseVisualStyleBackColor = true;
            this.btnRegistrarTratamiento.Click += new System.EventHandler(this.btnRegistrarTratamiento_Click);
            // 
            // lblSiguienteUsuarioCola
            // 
            this.lblSiguienteUsuarioCola.Location = new System.Drawing.Point(6, 40);
            this.lblSiguienteUsuarioCola.Name = "lblSiguienteUsuarioCola";
            this.lblSiguienteUsuarioCola.Size = new System.Drawing.Size(274, 20);
            this.lblSiguienteUsuarioCola.TabIndex = 21;
            this.lblSiguienteUsuarioCola.Text = "___";
            this.lblSiguienteUsuarioCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtenderCliente
            // 
            this.btnAtenderCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtenderCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtenderCliente.ForeColor = System.Drawing.Color.White;
            this.btnAtenderCliente.Location = new System.Drawing.Point(9, 63);
            this.btnAtenderCliente.Name = "btnAtenderCliente";
            this.btnAtenderCliente.Size = new System.Drawing.Size(271, 39);
            this.btnAtenderCliente.TabIndex = 10;
            this.btnAtenderCliente.Text = "Atender Cliente";
            this.btnAtenderCliente.UseVisualStyleBackColor = false;
            this.btnAtenderCliente.Click += new System.EventHandler(this.btnAtenderCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(82, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Siguiente en la cola:";
            // 
            // AgendaClientesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label7);
            this.Name = "AgendaClientesUserControl";
            this.Size = new System.Drawing.Size(1340, 638);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion // 👈 Falta este

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TextBox tbMotivoCita;
        private System.Windows.Forms.TextBox tbNombreTemporal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbDNICita;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
        private System.Windows.Forms.DateTimePicker dtpFiltrarPorFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnFiltrarHoy;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAtenderCliente;
        private System.Windows.Forms.CheckBox chbPreferencial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSiguienteUsuarioCola;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizarCola;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosto;
        private System.Windows.Forms.Button btnActualizarHistorial;
        private System.Windows.Forms.Label lblUsuarioAtendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMotivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clPreferencial;
        private System.Windows.Forms.Button btnCompletarAtencion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.RichTextBox rtbDescripcionTratamiento;
        private System.Windows.Forms.DateTimePicker dtpFechaTratamiento;
        private System.Windows.Forms.TextBox tbTipoTratamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarTratamiento;
        private System.Windows.Forms.Label lblPacienteEnAtencion;
    }
}