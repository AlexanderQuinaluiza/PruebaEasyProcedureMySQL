using ProcedureEasy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Procedimientos_MySQL
{
    public partial class FrmListaTablas : Form
    {
        public FrmListaTablas()
        {
            InitializeComponent();
        }

        private void FrmListaTablas_Load(object sender, EventArgs e)
        {
            cargarDgvGeneral();
        }
        private void cargarDgvGeneral()
        {
            Conexion connect = new Conexion();
            CreateProcedure csp = new CreateProcedure(connect.Connection);
            dtgTables.Columns.Clear();
            //limpia el contenido del gridview
            dtgTables.Refresh();
            //dataGridView1.Dispose();

            DataTable gridData = new DataTable();
            gridData.Columns.Add("Tablas");

            string[] names = new string[] { "*" };
            //carga las filas con los datos de la lista que nos da la API
            foreach (var item in csp.listaTablas())
            {
                if (item.TipoTabla!="VIEW")
                {
                    gridData.Rows.Add(item.NombreTabla);
                }
               
            }
            dtgTables.DataSource = gridData;
            /**  agregando otras columnas check box column */

            for (int i = 0; i < names.Length; i++)
            {
                DataGridViewCheckBoxColumn checkColumn1 = new DataGridViewCheckBoxColumn();
                checkColumn1.Name = names[i];
                checkColumn1.HeaderText = names[i];
                checkColumn1.Width = 50;
                checkColumn1.ReadOnly = false;
                checkColumn1.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                dtgTables.Columns.Add(checkColumn1);
            }
            dtgTables.Columns[0].ReadOnly = true;
            dtgTables.Columns[0].Width = 150;


            gridData.Dispose();
        }

      

        public List<string> tablas_seleccionadas = new List<string>();
        private void bntAceptar_Click(object sender, EventArgs e)
        {
            Conexion connect = new Conexion();

            CreateProcedure sp = new CreateProcedure(connect.Connection);
            try
            { // guardar los cambios realizados en el gridview
                dtgTables.EndEdit();
                foreach (DataGridViewRow row in dtgTables.Rows)
                {   ///recorrer todos los check de la columna insert

                    DataGridViewCheckBoxCell cell = row.Cells[1] as DataGridViewCheckBoxCell;
                    // condicional si el valor es verdadero
                    if (Convert.ToBoolean(cell.Value) == true)
                    {
                        //MessageBox.Show(row.Cells[0].Value.ToString());
                        tablas_seleccionadas.Add(row.Cells[0].Value.ToString());
                        //procedures += sp.createProcedimiento(Tipo.Insert, row.Cells[0].Value.ToString()) + "\n";

                        //MessageBox.Show(csp.createProcedimiento(Tipo.Insert));
                       // MessageBox.Show(procedures);
                        //insertProcedure(row.Cells[0].Value.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        /************************************************************************
         * Metodo-> al cambiar el checkbox selecciona todas o ninguna de las tablas
         * **********************************************************************/
        private void chAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chAll.Checked)
            {
                foreach (DataGridViewRow row in dtgTables.Rows)
                {
                    row.Cells[1].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dtgTables.Rows)
                {
                    row.Cells[1].Value = false;
                }
            }
           
        }
    }
    
}
