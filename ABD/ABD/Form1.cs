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
        
        
        /*BOTON MOSTRAR CREAR BD*/
        private void CrerBD_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            v2.Show();
            v2.Crear = true;
        }
        /*OCULTA CREAR BD*/
        private void CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*MUESTRA  USAR BD*/
        private void UsarBD_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            
        
            v2.Usar = true;
            v2.Show();
            if(v2.Usar)
            {
                this.Hide();
            }

        }

        private void BorrarDB_Click(object sender, EventArgs e)
        {
            Form2 v2 = new Form2();
            v2.Show();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {
            ListaDirectorio(directorio);
        }
        //Recibe el treeview al que se desean actualizar los archivos
        public void ListaDirectorio(TreeView dir)
        {
           
            dir.Nodes.Clear();
            var raiz = new DirectoryInfo(Application.StartupPath + @"\Gestor");
            string rutaRaiz = Application.StartupPath + @"\Gestor";
            if (!Directory.Exists(rutaRaiz)) { Directory.CreateDirectory(rutaRaiz); }
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
