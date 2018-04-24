namespace ABD
{
    partial class Ventana1
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("bd1");
            this.PanelOpDB = new System.Windows.Forms.Panel();
            this.labelCrearDB = new System.Windows.Forms.Label();
            this.labelUsarDB = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelBorrarDB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelGBD = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directorio = new System.Windows.Forms.TreeView();
            this.PanelOpDB.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOpDB
            // 
            this.PanelOpDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.PanelOpDB.Controls.Add(this.labelCrearDB);
            this.PanelOpDB.Controls.Add(this.labelUsarDB);
            this.PanelOpDB.Controls.Add(this.button3);
            this.PanelOpDB.Controls.Add(this.labelBorrarDB);
            this.PanelOpDB.Controls.Add(this.button1);
            this.PanelOpDB.Controls.Add(this.button2);
            this.PanelOpDB.Location = new System.Drawing.Point(123, 171);
            this.PanelOpDB.Name = "PanelOpDB";
            this.PanelOpDB.Size = new System.Drawing.Size(683, 158);
            this.PanelOpDB.TabIndex = 4;
            // 
            // labelCrearDB
            // 
            this.labelCrearDB.AutoSize = true;
            this.labelCrearDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCrearDB.ForeColor = System.Drawing.Color.LightGray;
            this.labelCrearDB.Location = new System.Drawing.Point(114, 129);
            this.labelCrearDB.Name = "labelCrearDB";
            this.labelCrearDB.Size = new System.Drawing.Size(66, 17);
            this.labelCrearDB.TabIndex = 5;
            this.labelCrearDB.Text = "Crear DB";
            // 
            // labelUsarDB
            // 
            this.labelUsarDB.AutoSize = true;
            this.labelUsarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUsarDB.ForeColor = System.Drawing.Color.LightGray;
            this.labelUsarDB.Location = new System.Drawing.Point(323, 129);
            this.labelUsarDB.Name = "labelUsarDB";
            this.labelUsarDB.Size = new System.Drawing.Size(61, 17);
            this.labelUsarDB.TabIndex = 4;
            this.labelUsarDB.Text = "Usar DB";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button3.Image = global::ABD.Properties.Resources.icons8_eliminar_base_de_datos_50;
            this.button3.Location = new System.Drawing.Point(483, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 93);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BorrarDB_Click);
            // 
            // labelBorrarDB
            // 
            this.labelBorrarDB.AutoSize = true;
            this.labelBorrarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBorrarDB.ForeColor = System.Drawing.Color.LightGray;
            this.labelBorrarDB.Location = new System.Drawing.Point(519, 129);
            this.labelBorrarDB.Name = "labelBorrarDB";
            this.labelBorrarDB.Size = new System.Drawing.Size(71, 17);
            this.labelBorrarDB.TabIndex = 3;
            this.labelBorrarDB.Text = "Borrar DB";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button1.Image = global::ABD.Properties.Resources.icons8_agregar_base_de_datos_50;
            this.button1.Location = new System.Drawing.Point(70, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 93);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CrerBD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button2.Image = global::ABD.Properties.Resources.icons8_base_de_datos_50;
            this.button2.Location = new System.Drawing.Point(279, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.UsarBD_Click);
            // 
            // labelGBD
            // 
            this.labelGBD.AutoSize = true;
            this.labelGBD.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGBD.ForeColor = System.Drawing.Color.Silver;
            this.labelGBD.Location = new System.Drawing.Point(159, 69);
            this.labelGBD.Name = "labelGBD";
            this.labelGBD.Size = new System.Drawing.Size(387, 45);
            this.labelGBD.TabIndex = 0;
            this.labelGBD.Text = "Gestor  de  Base  de  Datos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 23);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ABD.Properties.Resources.Entypo_2715_0__24;
            this.pictureBox1.Location = new System.Drawing.Point(783, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CerrarVentana_Click);
            // 
            // directorio
            // 
            this.directorio.Location = new System.Drawing.Point(0, 22);
            this.directorio.Name = "directorio";
            treeNode2.Name = "Node0";
            treeNode2.Text = "bd1";
            this.directorio.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.directorio.Size = new System.Drawing.Size(123, 440);
            this.directorio.TabIndex = 8;
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(20)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(807, 462);
            this.Controls.Add(this.directorio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelGBD);
            this.Controls.Add(this.PanelOpDB);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ventana1_Load);
            this.PanelOpDB.ResumeLayout(false);
            this.PanelOpDB.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelOpDB;
        private System.Windows.Forms.Label labelCrearDB;
        private System.Windows.Forms.Label labelUsarDB;
        private System.Windows.Forms.Label labelBorrarDB;
        private System.Windows.Forms.Label labelGBD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView directorio;
    }
}

