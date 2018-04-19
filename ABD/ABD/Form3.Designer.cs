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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("bd1");
            this.dirUso = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bdusetxt = new System.Windows.Forms.TextBox();
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dirUso
            // 
            this.dirUso.Location = new System.Drawing.Point(1, 22);
            this.dirUso.Name = "dirUso";
            treeNode4.Name = "Node0";
            treeNode4.Text = "bd1";
            this.dirUso.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.dirUso.Size = new System.Drawing.Size(123, 439);
            this.dirUso.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 23);
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
            this.bdusetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bdusetxt.Location = new System.Drawing.Point(374, 72);
            this.bdusetxt.Name = "bdusetxt";
            this.bdusetxt.ReadOnly = true;
            this.bdusetxt.Size = new System.Drawing.Size(200, 26);
            this.bdusetxt.TabIndex = 12;
            this.bdusetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCrearTabla.BackgroundImage = global::ABD.Properties.Resources.createTable;
            this.btnCrearTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCrearTabla.FlatAppearance.BorderSize = 0;
            this.btnCrearTabla.Location = new System.Drawing.Point(169, 182);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(129, 131);
            this.btnCrearTabla.TabIndex = 14;
            this.btnCrearTabla.UseVisualStyleBackColor = false;
            this.btnCrearTabla.Click += new System.EventHandler(this.CrearTabla);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ABD.Properties.Resources.Entypo_2715_0__24;
            this.pictureBox1.Location = new System.Drawing.Point(706, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.CerrarVentana);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(177, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Crear nueva tabla";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(730, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrearTabla);
            this.Controls.Add(this.bdusetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dirUso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}