namespace Escuela
{
    partial class frmAgregarPersona
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTItuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.rbtProfesor = new System.Windows.Forms.RadioButton();
            this.rbtAlumno = new System.Windows.Forms.RadioButton();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpProfesor = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.bntVolver = new System.Windows.Forms.Button();
            this.grpAlumno = new System.Windows.Forms.GroupBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.btnAgregarPesona = new System.Windows.Forms.Button();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.grpProfesor.SuspendLayout();
            this.grpAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(55, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingrese los datos de la persona";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTItuloToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // lblTItuloToolStripMenuItem
            // 
            this.lblTItuloToolStripMenuItem.Name = "lblTItuloToolStripMenuItem";
            this.lblTItuloToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.lblTItuloToolStripMenuItem.Text = "lblTItulo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.rbtProfesor);
            this.grbTipo.Controls.Add(this.rbtAlumno);
            this.grbTipo.Location = new System.Drawing.Point(72, 267);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(200, 83);
            this.grbTipo.TabIndex = 4;
            this.grbTipo.TabStop = false;
            this.grbTipo.Enter += new System.EventHandler(this.rbtAlumno_CheckedChanged);
            // 
            // rbtProfesor
            // 
            this.rbtProfesor.AutoSize = true;
            this.rbtProfesor.Location = new System.Drawing.Point(30, 55);
            this.rbtProfesor.Name = "rbtProfesor";
            this.rbtProfesor.Size = new System.Drawing.Size(64, 17);
            this.rbtProfesor.TabIndex = 6;
            this.rbtProfesor.Text = "Profesor";
            this.rbtProfesor.UseVisualStyleBackColor = true;
            this.rbtProfesor.CheckedChanged += new System.EventHandler(this.rbtProfesor_CheckedChanged);
            // 
            // rbtAlumno
            // 
            this.rbtAlumno.AutoSize = true;
            this.rbtAlumno.Checked = true;
            this.rbtAlumno.Location = new System.Drawing.Point(30, 19);
            this.rbtAlumno.Name = "rbtAlumno";
            this.rbtAlumno.Size = new System.Drawing.Size(60, 17);
            this.rbtAlumno.TabIndex = 5;
            this.rbtAlumno.TabStop = true;
            this.rbtAlumno.Text = "Alumno";
            this.rbtAlumno.UseVisualStyleBackColor = true;
            this.rbtAlumno.CheckedChanged += new System.EventHandler(this.rbtAlumno_CheckedChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(55, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(172, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(55, 127);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(172, 127);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 163);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // grpProfesor
            // 
            this.grpProfesor.Controls.Add(this.cmbCategoria);
            this.grpProfesor.Controls.Add(this.lblTitulo2);
            this.grpProfesor.Controls.Add(this.lblCategoria);
            this.grpProfesor.Controls.Add(this.txtTitulo);
            this.grpProfesor.Controls.Add(this.lblMateria);
            this.grpProfesor.Controls.Add(this.txtMateria);
            this.grpProfesor.Location = new System.Drawing.Point(387, 227);
            this.grpProfesor.Name = "grpProfesor";
            this.grpProfesor.Size = new System.Drawing.Size(274, 190);
            this.grpProfesor.TabIndex = 11;
            this.grpProfesor.TabStop = false;
            this.grpProfesor.Text = "Datos profesor";
            this.grpProfesor.Visible = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Titular",
            "Suplente",
            "Provisional"});
            this.cmbCategoria.Location = new System.Drawing.Point(141, 115);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(100, 21);
            this.cmbCategoria.TabIndex = 19;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Location = new System.Drawing.Point(24, 83);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo2.TabIndex = 24;
            this.lblTitulo2.Text = "Titulo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(24, 115);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(141, 80);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 16;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(24, 45);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 15;
            this.lblMateria.Text = "Materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(141, 45);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 14;
            this.txtMateria.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(55, 201);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 13;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(172, 201);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 12;
            // 
            // bntVolver
            // 
            this.bntVolver.Location = new System.Drawing.Point(475, 423);
            this.bntVolver.Name = "bntVolver";
            this.bntVolver.Size = new System.Drawing.Size(75, 23);
            this.bntVolver.TabIndex = 14;
            this.bntVolver.Text = "Volver";
            this.bntVolver.UseVisualStyleBackColor = true;
            this.bntVolver.Click += new System.EventHandler(this.bntVolver_Click);
            // 
            // grpAlumno
            // 
            this.grpAlumno.Controls.Add(this.lblCurso);
            this.grpAlumno.Controls.Add(this.lblDivision);
            this.grpAlumno.Controls.Add(this.txtDivision);
            this.grpAlumno.Controls.Add(this.txtCurso);
            this.grpAlumno.Controls.Add(this.lblGrupo);
            this.grpAlumno.Controls.Add(this.txtGrupo);
            this.grpAlumno.Location = new System.Drawing.Point(387, 24);
            this.grpAlumno.Name = "grpAlumno";
            this.grpAlumno.Size = new System.Drawing.Size(274, 190);
            this.grpAlumno.TabIndex = 17;
            this.grpAlumno.TabStop = false;
            this.grpAlumno.Text = "Datos alumno";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(24, 83);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 24;
            this.lblCurso.Text = "Curso";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(24, 115);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 19;
            this.lblDivision.Text = "Division";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(141, 115);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(100, 20);
            this.txtDivision.TabIndex = 18;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(141, 80);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 16;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(24, 45);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 15;
            this.lblGrupo.Text = "Grupo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(141, 45);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtGrupo.TabIndex = 14;
            // 
            // btnAgregarPesona
            // 
            this.btnAgregarPesona.Location = new System.Drawing.Point(691, 214);
            this.btnAgregarPesona.Name = "btnAgregarPesona";
            this.btnAgregarPesona.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarPesona.TabIndex = 18;
            this.btnAgregarPesona.Text = "Agregar persona";
            this.btnAgregarPesona.UseVisualStyleBackColor = true;
            this.btnAgregarPesona.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(172, 235);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // frmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnAgregarPesona);
            this.Controls.Add(this.grpAlumno);
            this.Controls.Add(this.bntVolver);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.grpProfesor);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAgregarPersona";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarPersona_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grpProfesor.ResumeLayout(false);
            this.grpProfesor.PerformLayout();
            this.grpAlumno.ResumeLayout(false);
            this.grpAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.RadioButton rbtProfesor;
        private System.Windows.Forms.RadioButton rbtAlumno;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox grpProfesor;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button bntVolver;
        private System.Windows.Forms.ToolStripMenuItem lblTItuloToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.GroupBox grpAlumno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Button btnAgregarPesona;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label1;
    }
}