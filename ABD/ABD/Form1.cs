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
{ /*TODA LA VENTANA PRINCIPAL*/
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();


        }
        /*VARIABLES*/
        string bd;

        /*retorna el treeview de este form (getter) */
        public TreeView getDir() {
            return directorio;
        }

           



        private void label4_Click(object sender, EventArgs e)
        {

        }
        /*BOTON MOSTRAR CREAR BD*/
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            v2.Show();
            v2.Crear = true;
        }
        /*OCULTA CREAR BD*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*MUESTRA  USAR BD*/
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            this.Hide();
            v2.Usar = true;
            v2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            v2.Show();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {
            ListaDirectorio(directorio);
        }
        public void ListaDirectorio(TreeView dir)
        {
           
            dir.Nodes.Clear();
            var raiz = new DirectoryInfo(Application.StartupPath);
            dir.Nodes.Add(ActualizarRaiz(raiz));

        }
        public static TreeNode ActualizarRaiz(DirectoryInfo dir) {

            var carpeta = new TreeNode(dir.Name);
            foreach (var carp in dir.GetDirectories())
            {
                carpeta.Nodes.Add(ActualizarRaiz(carp));
            }
            foreach (var archivo in dir.GetFiles())
            {
                carpeta.Nodes.Add(new TreeNode(archivo.Name));
            }

            return carpeta;
        }
    }
}
