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
        private string baseEnUso;

        public string BaseEnUso { get => baseEnUso; set => baseEnUso = value; }

        private void Form3_Load(object sender, EventArgs e)
        {
          
            Ventana1 v = new Ventana1();

            bdusetxt.Text = baseEnUso;
            v.ListaDirectorio(dirUso);
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearTabla(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.CrearTabla = true;

        }


        public void CreaTabla(string archivo)
        {
            string tabla = Application.StartupPath + @"\Gestor\" + bdusetxt.Text + "\\" + archivo;
            
            try
            {
                if (File.Exists(tabla))
                {
                    MessageBox.Show("La tabla ya existe.");
                }
                else
                {
                    File.CreateText(tabla);
                    MessageBox.Show("Tabla creada");
                  
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
    }
}
