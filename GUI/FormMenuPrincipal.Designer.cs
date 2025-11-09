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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAgendaClientes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(898, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 588);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de tratamientos del paciente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "___";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(279, 561);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Actualizar Historial";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTipo,
            this.clDescripcion,
            this.clCosto,
            this.clFecha});
            this.dataGridView2.Location = new System.Drawing.Point(6, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(419, 506);
            this.dataGridView2.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(207, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 590);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacientes Registardos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actualizar Lista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDNI,
            this.clApellido,
            this.clNombre,
            this.clEdad,
            this.clTelefono});
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(673, 504);
            this.dataGridView1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(422, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar paciente (DNI):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 305);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar Paciente";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Registrar Paciente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 230);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(159, 22);
            this.textBox6.TabIndex = 7;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fechas Nacimiento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 3;
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
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.dateTimePicker4);
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(7, 375);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 267);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registrar Tratamiento (Manual)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 25);
            this.button5.TabIndex = 9;
            this.button5.Text = "Registrar Tratamiento";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(16, 201);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker4.TabIndex = 8;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(16, 157);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(159, 22);
            this.textBox15.TabIndex = 5;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(16, 113);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(159, 22);
            this.textBox16.TabIndex = 4;
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
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(16, 69);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(159, 22);
            this.textBox17.TabIndex = 3;
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
            // btnAgendaClientes
            // 
            this.btnAgendaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendaClientes.Location = new System.Drawing.Point(1125, 11);
            this.btnAgendaClientes.Name = "btnAgendaClientes";
            this.btnAgendaClientes.Size = new System.Drawing.Size(204, 34);
            this.btnAgendaClientes.TabIndex = 11;
            this.btnAgendaClientes.Text = "Agenda Clientes";
            this.btnAgendaClientes.UseVisualStyleBackColor = true;
            this.btnAgendaClientes.Click += new System.EventHandler(this.btnAgendaClientes_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "> GESTOR DE PACIENTES <";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlContenedor.Controls.Add(this.groupBox1);
            this.pnlContenedor.Controls.Add(this.label7);
            this.pnlContenedor.Controls.Add(this.btnAgendaClientes);
            this.pnlContenedor.Controls.Add(this.groupBox5);
            this.pnlContenedor.Controls.Add(this.groupBox3);
            this.pnlContenedor.Controls.Add(this.groupBox2);
            this.pnlContenedor.Location = new System.Drawing.Point(5, 31);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1341, 653);
            this.pnlContenedor.TabIndex = 13;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1352, 686);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FormMenuPrincipal";
            this.Text = "FormMenuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFecha;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEdad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTelefono;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAgendaClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label label10;
    }
}