using MySql.Data.MySqlClient;
using ProcedureEasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos_MySQL
{
    public partial class Conectar : Form
    {
        Conexion conexion = new Conexion();
        string mysqlConnect = null;
        public string basedatos;
        public Conectar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// medodo que se ejecuta al cargar la ventana conectar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Conectar_Load(object sender, EventArgs e)
        {   //activador de los eventos posteriores
            this.ActiveControl = label1;
            // activador de eventos para simular los placeholders en los textbox
            txtServidor.GotFocus += new EventHandler(this.textBoxGotFocus);
            txtServidor.LostFocus += new EventHandler(this.textBoxLostFocus);
            txtUsuario.GotFocus += new EventHandler(this.textBoxGotFocus);
            txtUsuario.LostFocus += new EventHandler(this.textBoxLostFocus);
        }

        /// <summary>
        /// metodo que se ejecuta en el evento click del boton conectar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                string mysqlString = "server=" + txtServidor.Text.Trim() +
                        "; user id=" + txtUsuario.Text.Trim() +
                        "; password=" + txtContraseña.Text.Trim() + ";" +
                        "database=" + cbxbases.SelectedItem.ToString() + ";";
                conexion.Connection = new MySqlConnection(mysqlString);
                conexion.Connection.Open();
                if (conexion.Connection.Ping())
                {
                    conexion.Connection.Close();
                    basedatos = conexion.Connection.Database;

                    MessageBox.Show("Conexión correcta", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.Close();
                   

                  

                }
                else
                {
                    MessageBox.Show("Parametros incorrectos, no hay una conexión establecida", "Parametros Incorrectos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:"+ex.Message + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       

     

        /// <summary>
        /// metodo que obtiene el valor del textbox cuando el foco se encuentra en el mismo
        /// </summary>
        /// <param name="sender"> objeto al que hace referencia</param>
        /// <param name="e"> eventos </param>
        public void textBoxGotFocus(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if (txb.Text=="localhost")
            {
                txb.Text = "";
                txb.ForeColor = Color.Black;
            }
            else if (txb.Text == "root")
            {
                txb.Text = "";
                txb.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Metodo que obtiene el valor del textbox cuando se pierde el foco del mismo 
        /// </summary>
        /// <param name="sender"> objeto al que hace referencia el evento</param>
        /// <param name="e"> eventos</param>
        public void textBoxLostFocus(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            
            if (txb.Text == "" && txb.Name == "txtServidor")
            {
                txb.Text = "localhost";
                txb.ForeColor = Color.DarkGray;
            }
            else if(txb.Text == "" && txb.Name == "txtUsuario")
            {
                txb.Text = "root";
                txb.ForeColor = Color.DarkGray;
            }
        }
        /// <summary>
        /// metodo que carga el comboBox en el eveto click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxbases_Click(object sender, EventArgs e)
        {
            try
            {

                if (!txtServidor.Text.Equals(null) || !txtUsuario.Text.Equals(null))
                {            // establecer conexion   
                    mysqlConnect = "server=" + txtServidor.Text.Trim() +
                        "; user id=" + txtUsuario.Text.Trim() +
                        "; password=" + txtContraseña.Text.Trim() + ";";
                    conexion.Connection = new MySqlConnection(mysqlConnect);
                    //uso de la API para cargar los schemas en la base de datos 
                    CreateProcedure sp = new CreateProcedure(conexion.Connection);
                    cbxbases.DataSource = sp.listaSchemas();
                    // cbxbases.ValueMember = "Bases de Datos";
                    cbxbases.DisplayMember = "Bases de Datos";


                }
                else
                {
                    MessageBox.Show("Los parametros no son correctos", "Parametros incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnprobar_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlConnect += "database=" + cbxbases.SelectedItem.ToString() + ";";
                conexion.Connection = new MySqlConnection(mysqlConnect);
                conexion.Connection.Open();
                if (conexion.Connection.Ping())
                {
                    MessageBox.Show("Conexión correcta...!", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Parametros incorrectos, no hay una conexión establecida", "Parametros Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                conexion.Connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Parametros incorrectos, no hay una conexión establecida \n" + ex.Message, "Parametros Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
