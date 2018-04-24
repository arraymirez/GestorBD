namespace ABD
{
    partial class Form2
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
            this.txtnombrebd = new System.Windows.Forms.TextBox();
            this.labelNomDB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureDBFondo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDBFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombrebd
            // 
            this.txtnombrebd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombrebd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnombrebd.Location = new System.Drawing.Point(134, 75);
            this.txtnombrebd.MaxLength = 50;
            this.txtnombrebd.Name = "txtnombrebd";
            this.txtnombrebd.Size = new System.Drawing.Size(184, 19);
            this.txtnombrebd.TabIndex = 0;
            this.txtnombrebd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNomDB
            // 
            this.labelNomDB.AutoSize = true;
            this.labelNomDB.Font = new System.Drawing.Font("Trajan Pro", 16F);
            this.labelNomDB.ForeColor = System.Drawing.Color.White;
            this.labelNomDB.Location = new System.Drawing.Point(65, 35);
            this.labelNomDB.Name = "labelNomDB";
            this.labelNomDB.Size = new System.Drawing.Size(357, 28);
            this.labelNomDB.TabIndex = 1;
            this.labelNomDB.Text = "Nombre de la base de datos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 23);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ABD.Properties.Resources.Entypo_2715_0__24;
            this.pictureBox3.Location = new System.Drawing.Point(443, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ABD.Properties.Resources.Entypo_2715_0__24;
            this.pictureBox2.Location = new System.Drawing.Point(676, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
            this.btnAceptar.Image = global::ABD.Properties.Resources.FontAwesome_f00c_0__48;
            this.btnAceptar.Location = new System.Drawing.Point(176, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 48);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureDBFondo
            // 
            this.pictureDBFondo.Image = global::ABD.Properties.Resources.databases_2;
            this.pictureDBFondo.Location = new System.Drawing.Point(102, 75);
            this.pictureDBFondo.Name = "pictureDBFondo";
            this.pictureDBFondo.Size = new System.Drawing.Size(256, 167);
            this.pictureDBFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureDBFondo.TabIndex = 2;
            this.pictureDBFondo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(467, 299);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelNomDB);
            this.Controls.Add(this.txtnombrebd);
            this.Controls.Add(this.pictureDBFondo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseDeDatos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDBFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtnombrebd;
        private System.Windows.Forms.Label labelNomDB;
        private System.Windows.Forms.PictureBox pictureDBFondo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAceptar;
    }
}