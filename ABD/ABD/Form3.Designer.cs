namespace ABD
{
    partial class Form3
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("bd1");
            this.dirUso = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bdusetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOpTablas = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelCrearTablas = new System.Windows.Forms.Panel();
            this.ScrollCrearTabla = new System.Windows.Forms.VScrollBar();
            this.labelTamaño = new System.Windows.Forms.Label();
            this.labelTipoDato = new System.Windows.Forms.Label();
            this.labelCampo = new System.Windows.Forms.Label();
            this.panelConsultas = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.queryCondicion = new System.Windows.Forms.TextBox();
            this.queryTexto = new System.Windows.Forms.TextBox();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.queryResultados = new System.Windows.Forms.DataGridView();
            this.txtNumCampos = new System.Windows.Forms.TextBox();
            this.labelNumCampos = new System.Windows.Forms.Label();
            this.labelTabla = new System.Windows.Forms.Label();
            this.txtNomTabla = new System.Windows.Forms.TextBox();
            this.panelNomTab = new System.Windows.Forms.Panel();
            this.tablaAtributos = new System.Windows.Forms.DataGridView();
            this.nombresCampos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoCampos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensajes = new System.Windows.Forms.ToolTip(this.components);
            this.btnEjecutarQuery = new System.Windows.Forms.PictureBox();
            this.btnNombreTabla = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnAgregarCampos = new System.Windows.Forms.PictureBox();
            this.pictureBD = new System.Windows.Forms.PictureBox();
            this.pictureBorrar = new System.Windows.Forms.PictureBox();
            this.pictureAñadir = new System.Windows.Forms.PictureBox();
            this.btnUsarTabla = new System.Windows.Forms.Button();
            this.btnEliminarTabla = new System.Windows.Forms.Button();
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarTabla = new System.Windows.Forms.Button();
            this.btnCancelarCreacionTabla = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelOpTablas.SuspendLayout();
            this.PanelCrearTablas.SuspendLayout();
            this.panelConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultados)).BeginInit();
            this.panelNomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNombreTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dirUso
            // 
            this.dirUso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirUso.Location = new System.Drawing.Point(1, 22);
            this.dirUso.Name = "dirUso";
            treeNode1.Name = "Node0";
            treeNode1.Text = "bd1";
            this.dirUso.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.dirUso.Size = new System.Drawing.Size(123, 266);
            this.dirUso.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 23);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Base de Datos en Uso";
            // 
            // bdusetxt
            // 
            this.bdusetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdusetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bdusetxt.Location = new System.Drawing.Point(328, 77);
            this.bdusetxt.Name = "bdusetxt";
            this.bdusetxt.ReadOnly = true;
            this.bdusetxt.Size = new System.Drawing.Size(200, 22);
            this.bdusetxt.TabIndex = 12;
            this.bdusetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Crear nueva tabla";
            // 
            // panelOpTablas
            // 
            this.panelOpTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.panelOpTablas.Controls.Add(this.pictureBorrar);
            this.panelOpTablas.Controls.Add(this.pictureAñadir);
            this.panelOpTablas.Controls.Add(this.label4);
            this.panelOpTablas.Controls.Add(this.btnUsarTabla);
            this.panelOpTablas.Controls.Add(this.label3);
            this.panelOpTablas.Controls.Add(this.btnEliminarTabla);
            this.panelOpTablas.Controls.Add(this.btnCrearTabla);
            this.panelOpTablas.Controls.Add(this.label2);
            this.panelOpTablas.Location = new System.Drawing.Point(124, 126);
            this.panelOpTablas.Name = "panelOpTablas";
            this.panelOpTablas.Size = new System.Drawing.Size(608, 115);
            this.panelOpTablas.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(359, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Usar Tabla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(211, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Eliminar Tabla";
            // 
            // PanelCrearTablas
            // 
            this.PanelCrearTablas.BackColor = System.Drawing.Color.PowderBlue;
            this.PanelCrearTablas.Controls.Add(this.btnCancelarCreacionTabla);
            this.PanelCrearTablas.Controls.Add(this.ScrollCrearTabla);
            this.PanelCrearTablas.Controls.Add(this.labelTamaño);
            this.PanelCrearTablas.Controls.Add(this.labelTipoDato);
            this.PanelCrearTablas.Controls.Add(this.btnGuardarTabla);
            this.PanelCrearTablas.Controls.Add(this.labelCampo);
            this.PanelCrearTablas.Location = new System.Drawing.Point(124, 290);
            this.PanelCrearTablas.Name = "PanelCrearTablas";
            this.PanelCrearTablas.Size = new System.Drawing.Size(605, 219);
            this.PanelCrearTablas.TabIndex = 18;
            this.PanelCrearTablas.Visible = false;
            // 
            // ScrollCrearTabla
            // 
            this.ScrollCrearTabla.Location = new System.Drawing.Point(585, 0);
            this.ScrollCrearTabla.Name = "ScrollCrearTabla";
            this.ScrollCrearTabla.Size = new System.Drawing.Size(23, 219);
            this.ScrollCrearTabla.TabIndex = 28;
            // 
            // labelTamaño
            // 
            this.labelTamaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamaño.Location = new System.Drawing.Point(245, 25);
            this.labelTamaño.Name = "labelTamaño";
            this.labelTamaño.Size = new System.Drawing.Size(64, 20);
            this.labelTamaño.TabIndex = 26;
            this.labelTamaño.Text = "Tamaño";
            // 
            // labelTipoDato
            // 
            this.labelTipoDato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTipoDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDato.Location = new System.Drawing.Point(140, 25);
            this.labelTipoDato.Name = "labelTipoDato";
            this.labelTipoDato.Size = new System.Drawing.Size(88, 20);
            this.labelTipoDato.TabIndex = 24;
            this.labelTipoDato.Text = "Tipo de Dato";
            // 
            // labelCampo
            // 
            this.labelCampo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampo.Location = new System.Drawing.Point(25, 25);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(100, 20);
            this.labelCampo.TabIndex = 1;
            this.labelCampo.Text = "campo";
            // 
            // panelConsultas
            // 
            this.panelConsultas.BackColor = System.Drawing.Color.PowderBlue;
            this.panelConsultas.Controls.Add(this.label8);
            this.panelConsultas.Controls.Add(this.label7);
            this.panelConsultas.Controls.Add(this.label6);
            this.panelConsultas.Controls.Add(this.queryCondicion);
            this.panelConsultas.Controls.Add(this.queryTexto);
            this.panelConsultas.Controls.Add(this.cmbOperacion);
            this.panelConsultas.Controls.Add(this.queryResultados);
            this.panelConsultas.Location = new System.Drawing.Point(124, 290);
            this.panelConsultas.Name = "panelConsultas";
            this.panelConsultas.Size = new System.Drawing.Size(608, 219);
            this.panelConsultas.TabIndex = 31;
            this.panelConsultas.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Condicion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Query:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo query:";
            // 
            // queryCondicion
            // 
            this.queryCondicion.Location = new System.Drawing.Point(399, 35);
            this.queryCondicion.Name = "queryCondicion";
            this.queryCondicion.Size = new System.Drawing.Size(183, 20);
            this.queryCondicion.TabIndex = 5;
            // 
            // queryTexto
            // 
            this.queryTexto.Location = new System.Drawing.Point(131, 35);
            this.queryTexto.Name = "queryTexto";
            this.queryTexto.Size = new System.Drawing.Size(245, 20);
            this.queryTexto.TabIndex = 4;
            this.queryTexto.Text = "*";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "Insertar",
            "Actualizar",
            "Buscar",
            "Eliminar"});
            this.cmbOperacion.Location = new System.Drawing.Point(13, 34);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(101, 21);
            this.cmbOperacion.TabIndex = 3;
            // 
            // queryResultados
            // 
            this.queryResultados.AllowUserToAddRows = false;
            this.queryResultados.AllowUserToDeleteRows = false;
            this.queryResultados.BackgroundColor = System.Drawing.Color.White;
            this.queryResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResultados.GridColor = System.Drawing.Color.Teal;
            this.queryResultados.Location = new System.Drawing.Point(13, 90);
            this.queryResultados.Name = "queryResultados";
            this.queryResultados.ReadOnly = true;
            this.queryResultados.Size = new System.Drawing.Size(569, 117);
            this.queryResultados.TabIndex = 2;
            // 
            // txtNumCampos
            // 
            this.txtNumCampos.Location = new System.Drawing.Point(274, 16);
            this.txtNumCampos.MaxLength = 50;
            this.txtNumCampos.Name = "txtNumCampos";
            this.txtNumCampos.Size = new System.Drawing.Size(35, 20);
            this.txtNumCampos.TabIndex = 29;
            // 
            // labelNumCampos
            // 
            this.labelNumCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCampos.Location = new System.Drawing.Point(201, 16);
            this.labelNumCampos.Name = "labelNumCampos";
            this.labelNumCampos.Size = new System.Drawing.Size(67, 20);
            this.labelNumCampos.TabIndex = 28;
            this.labelNumCampos.Text = "# Campos";
            // 
            // labelTabla
            // 
            this.labelTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabla.Location = new System.Drawing.Point(13, 16);
            this.labelTabla.Name = "labelTabla";
            this.labelTabla.Size = new System.Drawing.Size(49, 20);
            this.labelTabla.TabIndex = 21;
            this.labelTabla.Text = "Tabla";
            // 
            // txtNomTabla
            // 
            this.txtNomTabla.Location = new System.Drawing.Point(68, 16);
            this.txtNomTabla.Name = "txtNomTabla";
            this.txtNomTabla.Size = new System.Drawing.Size(100, 20);
            this.txtNomTabla.TabIndex = 20;
            // 
            // panelNomTab
            // 
            this.panelNomTab.BackColor = System.Drawing.Color.CadetBlue;
            this.panelNomTab.Controls.Add(this.btnEjecutarQuery);
            this.panelNomTab.Controls.Add(this.btnNombreTabla);
            this.panelNomTab.Controls.Add(this.btnEliminar);
            this.panelNomTab.Controls.Add(this.labelNumCampos);
            this.panelNomTab.Controls.Add(this.txtNumCampos);
            this.panelNomTab.Controls.Add(this.btnAgregarCampos);
            this.panelNomTab.Controls.Add(this.txtNomTabla);
            this.panelNomTab.Controls.Add(this.labelTabla);
            this.panelNomTab.Location = new System.Drawing.Point(124, 240);
            this.panelNomTab.Name = "panelNomTab";
            this.panelNomTab.Size = new System.Drawing.Size(608, 51);
            this.panelNomTab.TabIndex = 30;
            this.panelNomTab.Visible = false;
            // 
            // tablaAtributos
            // 
            this.tablaAtributos.AllowUserToAddRows = false;
            this.tablaAtributos.AllowUserToDeleteRows = false;
            this.tablaAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombresCampos,
            this.infoCampos});
            this.tablaAtributos.Location = new System.Drawing.Point(1, 294);
            this.tablaAtributos.Name = "tablaAtributos";
            this.tablaAtributos.ReadOnly = true;
            this.tablaAtributos.Size = new System.Drawing.Size(117, 212);
            this.tablaAtributos.TabIndex = 32;
            // 
            // nombresCampos
            // 
            this.nombresCampos.HeaderText = "Campo";
            this.nombresCampos.Name = "nombresCampos";
            this.nombresCampos.ReadOnly = true;
            this.nombresCampos.Width = 40;
            // 
            // infoCampos
            // 
            this.infoCampos.HeaderText = "Tipo";
            this.infoCampos.Name = "infoCampos";
            this.infoCampos.ReadOnly = true;
            this.infoCampos.Width = 50;
            // 
            // btnEjecutarQuery
            // 
            this.btnEjecutarQuery.Image = global::ABD.Properties.Resources.Entypo_e754_0__64;
            this.btnEjecutarQuery.Location = new System.Drawing.Point(552, 9);
            this.btnEjecutarQuery.Name = "btnEjecutarQuery";
            this.btnEjecutarQuery.Size = new System.Drawing.Size(40, 35);
            this.btnEjecutarQuery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEjecutarQuery.TabIndex = 32;
            this.btnEjecutarQuery.TabStop = false;
            this.Mensajes.SetToolTip(this.btnEjecutarQuery, "Ejecutar Query");
            this.btnEjecutarQuery.Visible = false;
            this.btnEjecutarQuery.Click += new System.EventHandler(this.btnEjecutarQuery_Click);
            // 
            // btnNombreTabla
            // 
            this.btnNombreTabla.BackColor = System.Drawing.Color.Transparent;
            this.btnNombreTabla.Image = global::ABD.Properties.Resources.FontAwesome_f00c_0__32;
            this.btnNombreTabla.Location = new System.Drawing.Point(351, 16);
            this.btnNombreTabla.Name = "btnNombreTabla";
            this.btnNombreTabla.Size = new System.Drawing.Size(25, 23);
            this.btnNombreTabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNombreTabla.TabIndex = 31;
            this.btnNombreTabla.TabStop = false;
            this.Mensajes.SetToolTip(this.btnNombreTabla, "Usar Tabla");
            this.btnNombreTabla.Visible = false;
            this.btnNombreTabla.Click += new System.EventHandler(this.btnNombreTabla_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Image = global::ABD.Properties.Resources.Entypo_2796_0__241;
            this.btnEliminar.Location = new System.Drawing.Point(171, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(24, 24);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.TabStop = false;
            this.Mensajes.SetToolTip(this.btnEliminar, "Eliminar Tabla");
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarCampos
            // 
            this.btnAgregarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCampos.Image = global::ABD.Properties.Resources.Entypo_2795_0__24;
            this.btnAgregarCampos.Location = new System.Drawing.Point(315, 15);
            this.btnAgregarCampos.Name = "btnAgregarCampos";
            this.btnAgregarCampos.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarCampos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnAgregarCampos.TabIndex = 19;
            this.btnAgregarCampos.TabStop = false;
            this.Mensajes.SetToolTip(this.btnAgregarCampos, "Añadir Campos");
            this.btnAgregarCampos.Click += new System.EventHandler(this.AgregarCampo_Click);
            // 
            // pictureBD
            // 
            this.pictureBD.Image = global::ABD.Properties.Resources.Entypo_e754_0__64;
            this.pictureBD.Location = new System.Drawing.Point(534, 46);
            this.pictureBD.Name = "pictureBD";
            this.pictureBD.Size = new System.Drawing.Size(64, 64);
            this.pictureBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBD.TabIndex = 17;
            this.pictureBD.TabStop = false;
            // 
            // pictureBorrar
            // 
            this.pictureBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.pictureBorrar.Image = global::ABD.Properties.Resources.Entypo_2796_0__24;
            this.pictureBorrar.Location = new System.Drawing.Point(276, 60);
            this.pictureBorrar.Name = "pictureBorrar";
            this.pictureBorrar.Size = new System.Drawing.Size(24, 24);
            this.pictureBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBorrar.TabIndex = 19;
            this.pictureBorrar.TabStop = false;
            // 
            // pictureAñadir
            // 
            this.pictureAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.pictureAñadir.Image = global::ABD.Properties.Resources.Entypo_2795_1__24;
            this.pictureAñadir.Location = new System.Drawing.Point(120, 60);
            this.pictureAñadir.Name = "pictureAñadir";
            this.pictureAñadir.Size = new System.Drawing.Size(24, 24);
            this.pictureAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAñadir.TabIndex = 18;
            this.pictureAñadir.TabStop = false;
            // 
            // btnUsarTabla
            // 
            this.btnUsarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnUsarTabla.BackgroundImage = global::ABD.Properties.Resources.Entypo_d83d_1__64;
            this.btnUsarTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUsarTabla.FlatAppearance.BorderSize = 0;
            this.btnUsarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsarTabla.ForeColor = System.Drawing.Color.White;
            this.btnUsarTabla.Location = new System.Drawing.Point(351, 22);
            this.btnUsarTabla.Name = "btnUsarTabla";
            this.btnUsarTabla.Size = new System.Drawing.Size(86, 62);
            this.btnUsarTabla.TabIndex = 17;
            this.btnUsarTabla.UseVisualStyleBackColor = false;
            this.btnUsarTabla.Click += new System.EventHandler(this.btnUsarTabla_Click);
            // 
            // btnEliminarTabla
            // 
            this.btnEliminarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnEliminarTabla.BackgroundImage = global::ABD.Properties.Resources.Entypo_d83d_1__64;
            this.btnEliminarTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarTabla.FlatAppearance.BorderSize = 0;
            this.btnEliminarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTabla.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTabla.Location = new System.Drawing.Point(214, 22);
            this.btnEliminarTabla.Name = "btnEliminarTabla";
            this.btnEliminarTabla.Size = new System.Drawing.Size(86, 62);
            this.btnEliminarTabla.TabIndex = 15;
            this.btnEliminarTabla.UseVisualStyleBackColor = false;
            this.btnEliminarTabla.Click += new System.EventHandler(this.EliminarTabla);
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.btnCrearTabla.BackgroundImage = global::ABD.Properties.Resources.Entypo_d83d_1__64;
            this.btnCrearTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCrearTabla.FlatAppearance.BorderSize = 0;
            this.btnCrearTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTabla.ForeColor = System.Drawing.Color.White;
            this.btnCrearTabla.Location = new System.Drawing.Point(58, 22);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(86, 62);
            this.btnCrearTabla.TabIndex = 14;
            this.btnCrearTabla.UseVisualStyleBackColor = false;
            this.btnCrearTabla.Click += new System.EventHandler(this.CrearTabla);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ABD.Properties.Resources.Entypo_2715_0__24;
            this.pictureBox1.Location = new System.Drawing.Point(704, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CerrarVentana);
            // 
            // btnGuardarTabla
            // 
            this.btnGuardarTabla.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarTabla.FlatAppearance.BorderSize = 0;
            this.btnGuardarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTabla.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarTabla.Image = global::ABD.Properties.Resources.linea_b5_0__48;
            this.btnGuardarTabla.Location = new System.Drawing.Point(388, 76);
            this.btnGuardarTabla.Name = "btnGuardarTabla";
            this.btnGuardarTabla.Size = new System.Drawing.Size(86, 79);
            this.btnGuardarTabla.TabIndex = 22;
            this.btnGuardarTabla.Text = "Guardar";
            this.btnGuardarTabla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Mensajes.SetToolTip(this.btnGuardarTabla, "Guardar Tabla");
            this.btnGuardarTabla.UseVisualStyleBackColor = false;
            this.btnGuardarTabla.Click += new System.EventHandler(this.btnGuardarTabla_Click);
            // 
            // btnCancelarCreacionTabla
            // 
            this.btnCancelarCreacionTabla.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarCreacionTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelarCreacionTabla.FlatAppearance.BorderSize = 0;
            this.btnCancelarCreacionTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCreacionTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCreacionTabla.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCreacionTabla.Image = global::ABD.Properties.Resources.linea_b6_0__48;
            this.btnCancelarCreacionTabla.Location = new System.Drawing.Point(480, 76);
            this.btnCancelarCreacionTabla.Name = "btnCancelarCreacionTabla";
            this.btnCancelarCreacionTabla.Size = new System.Drawing.Size(86, 79);
            this.btnCancelarCreacionTabla.TabIndex = 29;
            this.btnCancelarCreacionTabla.Text = "Cancelar";
            this.btnCancelarCreacionTabla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Mensajes.SetToolTip(this.btnCancelarCreacionTabla, "Guardar Tabla");
            this.btnCancelarCreacionTabla.UseVisualStyleBackColor = false;
            this.btnCancelarCreacionTabla.Click += new System.EventHandler(this.btnCancelarCreacionTabla_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(728, 509);
            this.Controls.Add(this.tablaAtributos);
            this.Controls.Add(this.panelNomTab);
            this.Controls.Add(this.pictureBD);
            this.Controls.Add(this.panelOpTablas);
            this.Controls.Add(this.bdusetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dirUso);
            this.Controls.Add(this.PanelCrearTablas);
            this.Controls.Add(this.panelConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "VentanaTablas";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelOpTablas.ResumeLayout(false);
            this.panelOpTablas.PerformLayout();
            this.PanelCrearTablas.ResumeLayout(false);
            this.panelConsultas.ResumeLayout(false);
            this.panelConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultados)).EndInit();
            this.panelNomTab.ResumeLayout(false);
            this.panelNomTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNombreTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView dirUso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bdusetxt;
        private System.Windows.Forms.Button btnCrearTabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOpTablas;
        private System.Windows.Forms.PictureBox pictureBD;
        private System.Windows.Forms.Button btnEliminarTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUsarTabla;
        private System.Windows.Forms.PictureBox pictureAñadir;
        private System.Windows.Forms.PictureBox pictureBorrar;
        private System.Windows.Forms.Panel PanelCrearTablas;
        private System.Windows.Forms.PictureBox btnAgregarCampos;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Button btnGuardarTabla;
        private System.Windows.Forms.Label labelTabla;
        public System.Windows.Forms.TextBox txtNomTabla;
        private System.Windows.Forms.Label labelTamaño;
        private System.Windows.Forms.Label labelTipoDato;
        private System.Windows.Forms.TextBox txtNumCampos;
        private System.Windows.Forms.Label labelNumCampos;
        private System.Windows.Forms.Panel panelNomTab;
        private System.Windows.Forms.VScrollBar ScrollCrearTabla;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.Panel panelConsultas;
        private System.Windows.Forms.DataGridView queryResultados;
        private System.Windows.Forms.PictureBox btnNombreTabla;
        private System.Windows.Forms.DataGridView tablaAtributos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoCampos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox queryCondicion;
        private System.Windows.Forms.TextBox queryTexto;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.PictureBox btnEjecutarQuery;
        private System.Windows.Forms.ToolTip Mensajes;
        private System.Windows.Forms.Button btnCancelarCreacionTabla;
    }
}