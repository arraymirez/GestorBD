using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    public partial class Form3 : Form
    {
       


        public Form3()
        {
            InitializeComponent();
            
        }

       
        public string getBd()
        {
            return bdusetxt.Text;

        }
        private string baseEnUso;
        private string _superBase;

        public string BaseEnUso
        {
            get
            {
                return baseEnUso;
            }

            set
            {
                baseEnUso = value;
            }
        }

        public string SuperBase
        {
            get
            {
                return _superBase;
            }

            set
            {
                _superBase = value;
            }
        }

     

        private void Form3_Load(object sender, EventArgs e)
        {
          
            Ventana1 v = new Ventana1();

            bdusetxt.Text = BaseEnUso;
            v.ListaDirectorio(dirUso);
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearTabla(object sender, EventArgs e)
        {
            PanelCrearTablas.Visible = true;
            //Form2 f2 = new Form2();
            //f2.Show();
            //f2.usandoBD = getBd();
            //f2.CrearTabla = true;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            

        }
        
       

       
    }
}
