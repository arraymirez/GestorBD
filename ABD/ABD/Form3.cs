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
using System.Text.RegularExpressions;
namespace ABD
{
    public partial class Form3 : Form
    {
       


        public Form3()
        {
            InitializeComponent();
            
        }
       
     

        //VARIABLES PARA AÑADIR NUEVO CAMPO       
        int y = 60;
        int numCampo = 1;
        string[] campos;

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
            //limpiar
            Limpiar();
            //mostrar controles
            panelNomTab.Visible = true;
            labelNumCampos.Visible = true;
            txtNumCampos.Visible = true;
            btnAgregarCampos.Visible = true;

            //ocultar controles no usados
            btnEliminar.Visible = false;


        }

        private void Limpiar()
        {
            txtNomTabla.Text = "";
            txtNumCampos.Text = "";
            
        }

        
        
        private void AgregarCampo_Click(object sender, EventArgs e)
        {
           
            
                //campo tabla vacio
                if (string.IsNullOrEmpty(txtNomTabla.Text))
                {
                    
                        MessageBox.Show("No ha ingresado un nombre de tabla");
                }
                else
                {
                    PanelCrearTablas.Visible = true;
                }

            if (txtNumCampos.Visible) { 
                     //insercion de #campos
                    try
                    {
                        int TotalCampos = Int32.Parse(txtNumCampos.Text);

                        for (int i = 1; i <= TotalCampos; i++)
                        {
                            AgregarNomCampo(i);
                            AgregarTipoCampo(i);
                            AgregarTamañoCampo(i);
                            y += 20;
                        }
                    }
                    catch(FormatException ex)
                    {
                        MessageBox.Show("Ingrese un Número Entero",ex.Message);
                    }
            
                }
        }

        //METODOS PARA LA CREACION DE NUEVOS CAMPOS
        public void AgregarNomCampo(int id)
        {         
            TextBox txtNomCampo = new TextBox();
            txtNomCampo.Name = "txtNomCampo" + id;
            txtNomCampo.Size = new System.Drawing.Size(100, 20);
            txtNomCampo.MaxLength = 30;
            txtNomCampo.Location = new Point(25, y);
            PanelCrearTablas.Controls.Add(txtNomCampo);
            
        }

        public void AgregarTipoCampo(int id)
        {
            ComboBox cbTipoDato = new ComboBox();
            cbTipoDato.Name = "cbTipoDato" + id;
            cbTipoDato.Size = new System.Drawing.Size(88, 21);
            cbTipoDato.Items.AddRange(new object[] {
            "texto",
            "entero",
            "decimal"});
            cbTipoDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTipoDato.Location = new Point(140, y);
            PanelCrearTablas.Controls.Add(cbTipoDato);
        }

        public void AgregarTamañoCampo(int id)
        {
            TextBox txtTamCampo = new TextBox();
            txtTamCampo.Name = "txtTamañoCampo" + id;
            txtTamCampo.Size = new System.Drawing.Size(64, 20);
            txtTamCampo.Location = new Point(245, y);
            PanelCrearTablas.Controls.Add(txtTamCampo);
        }
        
        private void EliminarTabla(object sender,EventArgs e)
        {
           
              panelNomTab.Visible = true;
              btnEliminar.Visible = true;

            Limpiar();
            //ocultar controles necesarios
            PanelCrearTablas.Visible = false;
            labelNumCampos.Visible = false;
            txtNumCampos.Visible = false;           
            btnAgregarCampos.Visible = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarTabla_Click(object sender, EventArgs e)
        {
            Directorios d = new Directorios();
            d.CreaTabla(txtNomTabla.Text, bdusetxt.Text,campos);
           


        }
    }
}
