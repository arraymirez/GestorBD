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
        public string usandoBD;
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

        public bool CrearTabla
        {
            get
            {
                return crearTabla;
            }

            set
            {
                crearTabla = value;
            }
        }

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
            
                Directorios dir = new Directorios();
                   dir.CreaTabla(nombrebd.Text + ".str",usandoBD);
                dir.CreaTabla(nombrebd.Text + ".data",usandoBD);

            }
            this.Hide();

        }
 
        }
    class Directorios
    {


        public void CrearDir(string nom)
        {
            string carpeta = Application.StartupPath + @"\Gestor\" + nom;
            Ventana1 v = new Ventana1();
            try
            {
                if (Directory.Exists(carpeta))
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        public void CreaTabla(string archivo,string bd)
        {
         
            string tabla = Application.StartupPath + @"\Gestor\" + bd + "\\" + archivo;

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
