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
        bool CreandoTabla = false;
        TextBox[] campoNombre;
        ComboBox[] campoTipo;
        TextBox[] campoLongitud;

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
            Ventana1 v = new Ventana1();
            v.Show();
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
            panelConsultas.SendToBack();
            panelConsultas.Visible = false;
            btnNombreTabla.Visible = false;

        }

        private void Limpiar()
        {
            int total = (txtNumCampos.Text!="")?Convert.ToInt32(txtNumCampos.Text):0;
            for (int i = 0; i < total; i++)
            {

            borrado:
                foreach (Control item in PanelCrearTablas.Controls)
                {
                    if (item.Name == "txtNomCampo" + i || item.Name == "cbTipoDato" + i || item.Name == "txtTamañoCampo" + i) {
                        PanelCrearTablas.Controls.Remove(item);
                        goto borrado;
                    }
                }

            }


            y = 60;
            txtNomTabla.Text = "";
            txtNumCampos.Text = "";
            txtNomTabla.ReadOnly = false;
            txtNumCampos.ReadOnly = false;
            PanelCrearTablas.Visible = false;
        }
       


        private void AgregarCampo_Click(object sender, EventArgs e)
        {
            CreandoTabla = true;

            //campo tabla vacio
            if (string.IsNullOrEmpty(txtNomTabla.Text))
            {

                MessageBox.Show("No ha ingresado un nombre de tabla");
            }
            else
            {
                txtNomTabla.ReadOnly = true;
                txtNumCampos.ReadOnly = true;
                PanelCrearTablas.Visible = true;
            }

            if (txtNumCampos.Visible) {
                //insercion de #campos
                try
                {
                    int TotalCampos = Convert.ToInt32(txtNumCampos.Text);
                    campoNombre = new TextBox[TotalCampos];
                    campoLongitud = new TextBox[TotalCampos];
                    campoTipo = new ComboBox[TotalCampos];
                    for (int i = 0; i < TotalCampos; i++)
                    {
                        AgregarNomCampo(i);
                        AgregarTipoCampo(i);
                        AgregarTamañoCampo(i);
                        y += 20;
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese un Número Entero", ex.Message);
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
            campoNombre[id] = txtNomCampo;
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
            campoTipo[id] = cbTipoDato;
            PanelCrearTablas.Controls.Add(cbTipoDato);
        }

        public void AgregarTamañoCampo(int id)
        {
            TextBox txtTamCampo = new TextBox();
            txtTamCampo.Name = "txtTamañoCampo" + id;
            txtTamCampo.Size = new System.Drawing.Size(64, 20);
            txtTamCampo.Location = new Point(245, y);
            campoLongitud[id] = txtTamCampo;
            PanelCrearTablas.Controls.Add(txtTamCampo);
        }

        private void EliminarTabla(object sender, EventArgs e)
        {
            if (CreandoTabla == false)
            {
                panelNomTab.Visible = true;
                btnEliminar.Visible = true;

                Limpiar();
                //ocultar controles necesarios
                PanelCrearTablas.Visible = false;
                labelNumCampos.Visible = false;
                txtNumCampos.Visible = false;
                btnAgregarCampos.Visible = false;
                btnNombreTabla.Visible = false;
                panelConsultas.Visible = false;
            }
            else
                MessageBox.Show("Aun no terminas de Crear la Tabla");
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string tablaStr = Application.StartupPath + @"\Gestor\" + bdusetxt.Text + "\\" + txtNomTabla.Text.Trim() + ".str";
            string tablaData = Application.StartupPath + @"\Gestor\" + bdusetxt.Text + "\\" + txtNomTabla.Text.Trim() + ".data";
            try
            {

            File.Delete(tablaStr);
            File.Delete(tablaData);
                MessageBox.Show("Tabla Eliminado con exito.");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            
            }

            
        }

        private void btnGuardarTabla_Click(object sender, EventArgs e)
        {
            CreandoTabla = false;
            bool vacio = false;
            Directorios d = new Directorios();
            int inputs = Convert.ToInt32(txtNumCampos.Text);
            string[] lineas = new string[inputs];
            
            for (int i = 0; i < inputs; i++)
            {
                string cadena = campoNombre[i].Text + "|" + campoTipo[i].Text + "|" + campoLongitud[i].Text;
                if (campoNombre[i] != null || campoTipo[i]!=null || campoLongitud[i]!=null )
                {
                    vacio = false;
                    lineas[i] = cadena;
                }
                else
                    vacio = true;

            }
            if (!vacio) { 
            d.CreaTabla(txtNomTabla.Text, bdusetxt.Text, lineas);
            Limpiar();
            
            }
            else
                MessageBox.Show("Campos vacios");

        }

        private void btnUsarTabla_Click(object sender, EventArgs e)
        {
            if (CreandoTabla == false)
            {
                panelNomTab.Visible = true;
                panelConsultas.Visible = true;
                PanelCrearTablas.SendToBack();//manda el panel atras 
                PanelCrearTablas.Visible = false;


                txtNumCampos.Visible = false;
                labelNumCampos.Visible = false;
                btnAgregarCampos.Visible = false;
                btnEliminar.Visible = false;
                btnNombreTabla.Visible = true;
            }
            else
                MessageBox.Show("Aun no terminas de Crear la Tabla");
            


        }



        public void obtenerAtributos(string nombreTabla)
        {
            Directorios dir = new Directorios(); tablaAtributos.Rows.Clear();
            List<string> campos = dir.LeerAtributosTabla(nombreTabla, bdusetxt.Text);
            if(campos!=null)
            foreach (string linea in campos)
            {

                tablaAtributos.Rows.Add(linea.Split('|')[0].ToString(), linea.Split('|')[1] + "," + linea.Split('|')[2]);
                //MessageBox.Show("Campo: " + linea.Split('|')[0] + "Tipo: " + linea.Split('|')[1]+"Longitud: " + linea.Split('|')[2]);


            }


        }

        private void btnNombreTabla_Click(object sender, EventArgs e)
        {
            if (txtNomTabla.Text.Trim() != "") {

            obtenerAtributos(txtNomTabla.Text.Trim());
            btnEjecutarQuery.Visible = true;
            }
        }

        private void btnEjecutarQuery_Click(object sender, EventArgs e)
        {
            preGuardado();
        }



        private void preGuardado() {

            //obtenemos el tipo de busqueda

            string tipoBusqueda = cmbOperacion.Text;
            string query = queryTexto.Text;


            switch (tipoBusqueda)
            {
                case "Insertar":
                    if (query.Split(',').Count() == tablaAtributos.RowCount)
                    {
                      string row = "";
                        bool error = false;
                        for (int i = 0; i < query.Split(',').Count(); i++)
                        {
                            //se obtiene el tipo de dato del atributo.
                            string tipo = tablaAtributos.Rows[i].Cells[1].Value.ToString();

                            if (tipo.Split(',')[0] == "entero")
                            {
                                Regex numeros = new Regex(@"[0-9]+");
                                if (numeros.Match(query.Split(',')[i]).Success && query.Split(',')[i].Length <= Convert.ToInt32(tipo.Split(',')[1]))
                                {
                                   
                                    row += query.Split(',')[i] + ((i == tablaAtributos.RowCount - 1) ? "" : "|");
                                }
                                else
                                {
                                    error = true;
                                    break;
                                }
                            }
                            else if (tipo.Split(',')[0] == "decimal")
                            {
                                Regex numeros = new Regex(@"[0-9]+");
                                if (query.Split(',')[i].Split('.').Count() != 2)
                                {
                                    error = true;
                                    break;

                                }
                                else {
                                    if ((numeros.Match(query.Split(',')[i].Split('.')[0]).Success && numeros.Match(query.Split(',')[i].Split('.')[1]).Success) && query.Split(',')[i].Split('.')[1].Length <= Convert.ToInt32(tipo.Split(',')[1]))
                                    {
                                        //query.Split(',')[i] += (i == tablaAtributos.RowCount - 1) ? "" : "|";
                                        row += query.Split(',')[i] + ((i == tablaAtributos.RowCount - 1) ? "" : "|");
                                    }
                                    else
                                    {
                                        error = true;
                                        break;
                                    }
                                }
                            }
                            else {
                                Regex texto = new Regex(@"[A-Za-z0-9-_]+");

                                if (texto.Match(query.Split(',')[i]).Success && query.Split(',').Length <= Convert.ToInt32(tipo.Split(',')[1]))
                                {
                                    //query.Split(',')[i] += (i == tablaAtributos.RowCount - 1) ? "" : "|";
                                    row += query.Split(',')[i] + ((i == tablaAtributos.RowCount - 1) ? "" : "|");
                                }
                                else {
                                    error = true;
                                    break;
                                }

                            }
                        }
                        if (!error)
                        {
                            guardarDatos(row);

                        }
                        else {
                            MessageBox.Show("Ocurrio un error con los valores del registro.");
                        }
                    }
                    else {
                        MessageBox.Show("Faltan atributos para insertar.");
                    }

                    break;
                case "Buscar":
                    if (query != "*") {
                        bool encontrado = true;
                        for (int i = 0; i < query.Split(',').Count(); i++)
                        {
                            for (int j = 0; j < tablaAtributos.RowCount; j++)
                            {
                                if (query.Split(',')[i].ToUpper() == tablaAtributos.Rows[j].Cells[0].Value.ToString().ToUpper())
                                {
                                    encontrado = true; break;
                                }
                                else { encontrado = false; }
                            }
                            if (!encontrado) break;
                        }


                        if (encontrado)
                        {
                            buscarDatos(query);
                        }
                        else {
                            MessageBox.Show("Atributo(s) no encontrado(s).");
                        }
                    } else { buscarDatos(query); }

                    break;
                case "Eliminar":
                    string where = queryCondicion.Text;
                    if (where != "")
                    {
                        bool existe = true;
                        for (int j = 0; j < tablaAtributos.RowCount; j++)
                        {
                            if (where.Split('=')[0].ToUpper() == tablaAtributos.Rows[j].Cells[0].Value.ToString().ToUpper())
                            {
                                existe = true; break;
                            }
                            else { existe = false; }

                        }

                        if (existe)
                        {
                            eliminarDatos(where);
                        }
                        else
                        {
                            MessageBox.Show("Atributo(s) no encontrado(s).");
                        }
                    }
                    else {
                        MessageBox.Show("Ingrese un valor para eliminar.");
                    }

                    break;

                case "Actualizar":
                    string row1 = "";
                    bool error1 = false;
                    bool encontrado1 = true;


                for (int i = 0; i < tablaAtributos.RowCount; i++)
                {
                        //se obtiene el tipo de dato del atributo.
                        string nombreCampo = "";
                    string tipo = tablaAtributos.Rows[i].Cells[1].Value.ToString();
                    for (int j = 0; j < query.Split(',').Count(); j++)
                    {


                            nombreCampo = tablaAtributos.Rows[i].Cells[0].Value.ToString();
                            if (query.Split(',')[j].Split('=')[0].ToUpper().Trim() == nombreCampo.ToUpper().Trim())
                            {
                                encontrado1 = true; break;
                            }
                            else { encontrado1 = false; }
                     }
                    if (encontrado1)
                    {
                            for (int v = 0; v < query.Split(',').Count(); v++)
                            {


                                if (tipo.Split(',')[0] == "entero")
                                {
                                    Regex numeros = new Regex(@"[0-9]+");
                                    if (numeros.Match(query.Split(',')[v].Split('=')[1]).Success && query.Split(',')[v].Split('=')[1].Length <= Convert.ToInt32(tipo.Split(',')[1]) && query.Split(',')[v].Split('=')[0] == nombreCampo)
                                    {
                                        
                                        row1 += query.Split(',')[v] +(( v == query.Split(',').Count() - 1) ? "" : "|");
                                        error1 = false;
                                    }
                                    else
                                    {
                                        error1 = true;
                                     
                                    }
                                }
                                else if (tipo.Split(',')[0] == "decimal")
                                {
                                    Regex numeros = new Regex(@"[0-9]+");
                                    if (query.Split(',')[v].Split('=')[1].Split('.').Count() != 2)
                                    {
                                        error1 = true;
                                  

                                    }
                                    else
                                    {
                                        if ((numeros.Match(query.Split(',')[v].Split('=')[1].Split('.')[0]).Success && numeros.Match(query.Split(',')[v].Split('=')[1].Split('.')[1]).Success) && query.Split(',')[v].Split('=')[1].Split('.')[1].Length <= Convert.ToInt32(tipo.Split(',')[1]) && query.Split(',')[v].Split('=')[0] == nombreCampo)
                                        {
                                            
                                            row1 += query.Split(',')[v].Split('=')[1] +( (v == query.Split(',').Count() - 1) ? "" : "|");
                                            error1 = false;
                                        }
                                        else
                                        {
                                            error1 = true;
                                            
                                        }
                                    }
                                }
                                else
                                {
                                    Regex texto = new Regex(@"[A-Za-z0-9-_]+");

                                    if (texto.Match(query.Split(',')[v]).Success && query.Split(',').Length <= Convert.ToInt32(tipo.Split(',')[1]) && query.Split(',')[v].Split('=')[0] == nombreCampo)
                                    {
                                       
                                        row1 += query.Split(',')[v] +( (v == query.Split(',').Count() - 1) ? "" : "|");
                                        error1 = false;
                                    }
                                    else
                                    {
                                        error1 = true;
                                   
                                    }

                                }
                            }
                           
                        }
                     
                    }
                    if (!error1)
                    {//simon si procede
                        actualizarDatos(row1);

                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error con los valores del registro.");
                    }


                    break;
                default:
                    MessageBox.Show("Seleccione un tipo de operacion valido.");
                    break;
            }

        }


        void guardarDatos(string registro) {
            try
            {
                string rutaTabla = Application.StartupPath + @"\Gestor\" + bdusetxt.Text + "\\" + txtNomTabla.Text.Trim() + ".data";
                if (File.Exists(rutaTabla)) {

                    File.AppendAllText(rutaTabla, registro + Environment.NewLine);
                    MessageBox.Show("Comando completado correctamente.");
                } else {
                    MessageBox.Show("Error al guardar datos.");

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }


        }

        void buscarDatos(string campos) {
            try
            {
                string datosTabla = Application.StartupPath + @"\Gestor\" + bdusetxt.Text + "\\" + txtNomTabla.Text.Trim() + ".data";
                if (campos == "*")
                {  
                    List<string> atributos = File.ReadAllLines(datosTabla).ToList();//lo que esta en el archivo
                    int columnas = 0;//tamaño del datagrid.
                    queryResultados.Columns.Clear();
                    queryResultados.Rows.Clear();

                    if (atributos.Count > 0) columnas = atributos[0].Split('|').Count();
                    queryResultados.ColumnCount = columnas;
                    for (int i = 0; i < columnas; i++)
                    {
                        queryResultados.Columns[i].Name = tablaAtributos.Rows[i].Cells[0].Value.ToString();

                    }
                    foreach (var item in atributos)
                    {
                        var row = new DataGridViewRow();//renglon a agregar
                        for (int k = 0; k < item.Split('|').Count(); k++)
                        {
                            if (queryCondicion.Text != "")//si tiene condicion
                            {
                                int indice = 0;
                                for (int c = 0; c < tablaAtributos.RowCount; c++)
                                {
                                    if (queryCondicion.Text.Split('=')[0] == tablaAtributos.Rows[c].Cells[0].Value.ToString())
                                    {
                                        indice = c;
                                        break;
                                    }

                                }

                                if (item.Split('|')[indice].Contains(queryCondicion.Text.Split('=')[1]))
                                {
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Split('|')[k].ToString() });
                                }
                            }
                            else {
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Split('|')[k].ToString() });
                            }
                        }
                        queryResultados.Rows.Add(row);
                    }


                }
                else {
                    int camposBuscados = campos.Split(',').Count();

                    queryResultados.Columns.Clear();
                    queryResultados.Rows.Clear();
                    queryResultados.ColumnCount = camposBuscados;
                    string[] datos = File.ReadAllLines(datosTabla);
                    int cont = 0;
                    for (int i = 0; i < datos.Length; i++)
                    {
                        var row = new DataGridViewRow();
                            cont = 0;
                        for (int b = 0; b < datos[i].Split('|').Count(); b++)
                        {
                            for (int k = 0; k < campos.Split(',').Count(); k++)
                            {
                                
                                if (campos.Split(',')[k].ToString() == tablaAtributos.Rows[b].Cells[0].Value.ToString())
                                {
                                queryResultados.Columns[cont++].Name = tablaAtributos.Rows[b].Cells[0].Value.ToString();
                                    if (queryCondicion.Text != "")
                                    {
                                        if (datos[i].Contains(queryCondicion.Text.Split('=')[1]))
                                        {
                                            row.Cells.Add(new DataGridViewTextBoxCell { Value = datos[i].Split('|')[b].ToString() });
                                        }

                                    }
                                    else {

                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = datos[i].Split('|')[b].ToString() });
                                    }
                               
                                }
                         }

                        }
                         queryResultados.Rows.Add(row);

                    }
                    
                }
                //limpia
                inicio:
                foreach (DataGridViewRow item in queryResultados.Rows)
                {
                    if (item.Cells[0].Value == null)
                    {
                        queryResultados.Rows.Remove(item);
                        goto inicio;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

            
        }

        void eliminarDatos(string borrar)
        {
            string datosTabla = Application.StartupPath + @"\Gestor\" + bdusetxt.Text + "\\" + txtNomTabla.Text.Trim() + ".data";
            string [] datos=File.ReadAllLines(datosTabla);
            string campo = queryCondicion.Text.Split('=')[0];
            string valor = queryCondicion.Text.Split('=')[1];
            int columna = 0;
            int longitud = datos.Length;
            string[] temp = new string[longitud];
            for (int i = 0; i < tablaAtributos.RowCount; i++)
            {
                if (campo == tablaAtributos.Rows[i].Cells[0].Value.ToString())
                {
                    columna = i;
                    break;
                }

            }
            
            using (var sr = new StreamReader(datosTabla))
            {
                // lectura
                int row = 0;
                // escritura
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {

                    if (!linea.Contains(valor))
                    {
                        temp[row++] = linea;

                    }
                    List<string> aux = temp.ToList<string>();
                    aux.RemoveAll(b => string.IsNullOrEmpty(b));
                    temp = aux.ToArray();
                    
                }
            }

            File.WriteAllLines(datosTabla, temp);
            MessageBox.Show("Registro eliminado correctamente");

        }

        void actualizarDatos(string linea)//valores
        {
            try
            {

            string archivo = Application.StartupPath + @"\Gestor\" + bdusetxt.Text + "\\" + txtNomTabla.Text.Trim() + ".data";
            string[] datos = File.ReadAllLines(archivo);
            string condicion = queryCondicion.Text;
            for (int i = 0; i < linea.Split('|').Count() && linea.Split('|')[i] != ""; i++)//obtener los campos que se modificaran
            {
                string campo = linea.Split('|')[i].Split('=')[0];
                string valor = linea.Split('|')[i].Split('=')[1];
                int columna = 0;
                for (int k = 0; k < tablaAtributos.RowCount; k++)
                {
                    if (tablaAtributos.Rows[k].Cells[0].Value.ToString() == campo) {
                        columna = k;
                        break;
                    }
                }
                
                for (int j = 0; j < datos.Length; j++)
                {
                    if (condicion != "")
                    {
                        string campoCondicion = condicion.Split('=')[0];
                        string valorCondicion = condicion.Split('=')[1];
                        int columnaCondicion = 0;
                        for (int c = 0; c < tablaAtributos.RowCount; c++)
                        {
                            if (tablaAtributos.Rows[c].Cells[0].Value.ToString() == campoCondicion)
                            {
                                columnaCondicion = c;
                                break;
                            }
                        }

                        if (datos[j].Split('|')[columnaCondicion] == valorCondicion)
                        {
                                string[] temp = datos[j].Split('|');
                                string reemplazo = "";
                                for (int x = 0; x < temp.Length; x++)
                                {
                                    if(x==columna)reemplazo+=valor+((x==temp.Length-1)?"":"|");
                                   else reemplazo += temp[x] + ((x == temp.Length - 1) ? "" : "|");
                                }
                                datos[j] = reemplazo;
                        }


                    }
                    else
                    {
                    datos[j].Split('|')[columna] = valor;
                    }
                }
                
            }

            File.WriteAllLines(archivo,datos);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCreacionTabla_Click(object sender, EventArgs e)
        {
            CreandoTabla = false;
            Limpiar();
           
        }

        //arbol
        //Recibe el treeview al que se desean actualizar los archivos
        public void ListaDirectorio(TreeView dir)
        {

            dir.Nodes.Clear();
            var raiz = new DirectoryInfo(Application.StartupPath + @"\Gestor");
            string rutaRaiz = Application.StartupPath + @"\Gestor";
            if (!Directory.Exists(rutaRaiz)) { Directory.CreateDirectory(rutaRaiz); }
            dir.Nodes.Add(ActualizarRaiz(raiz));

        }
        public static TreeNode ActualizarRaiz(DirectoryInfo dir)
        {

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListaDirectorio(dirUso);
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
