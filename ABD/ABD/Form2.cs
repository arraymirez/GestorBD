using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ABD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Regex nombreBDValidacion =  new Regex("^([a-zA-Z]+)([a-zA-Z]|([0-9]))*$");
        public string nombreDB;
       
        /*VARIABLES*/
        private bool crear;
        private bool usar;
        private bool borrar;
        private bool crearTabla;
        /*GETTERS AND SETTERS*/
        public bool Crear
        {
            get
            {
                return crear;
            }

            set
            {
                crear = value;
            }
        }

        public bool Usar
        {
            get
            {
                return usar;
            }

            set
            {
                usar = value;
            }
        }

        public bool Borrar
        {
            get
            {
                return borrar;
            }

            set
            {
                borrar = value;
            }
        }

        public bool CrearTabla { get => crearTabla; set => crearTabla = value; }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventana1 v = new Ventana1();
            nombreDB = nombrebd.Text;
            if (Crear)
            {
                Directorios dir = new Directorios();
                if (nombreBDValidacion.IsMatch(nombreDB))
                {
                    dir.CrearDir(nombreDB);
                    v.ListaDirectorio(v.getDir());
                    nombrebd.Text = "";
                }
                else
                {
                    MessageBox.Show("Nombre de Base de Datos Invalido");
                }
                Crear = false;
                v.ListaDirectorio(v.getDir());
            }

            if (Usar)
            {
                Form3 v3 = new Form3();
                v3.BaseEnUso = nombrebd.Text;
                v3.Show();
                Usar = false;
                v.ListaDirectorio(v.getDir());
            }
            if (CrearTabla) {
                Form3 v3 = new Form3();
                v3.CreaTabla(nombrebd.Text + ".str");
                v3.CreaTabla(nombrebd.Text + ".data");

            }
            this.Hide();

        }

        public class Directorios
        {


            public void CrearDir(string nom)
            {
                string carpeta = Application.StartupPath + @"\Gestor\" + nom;
                Ventana1  v = new Ventana1(); 
                try
                {
                    if(Directory.Exists(carpeta))
                    {
                        MessageBox.Show("La base de datos que intentas crear, ya existe");
                    }
                    else
                    {
                        Directory.CreateDirectory(carpeta);
                        MessageBox.Show("Base de Datos Creada");
                      v.ListaDirectorio(v.getDir());
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }

              
            }




        }
            
        }
}
