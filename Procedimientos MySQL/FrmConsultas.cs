using ProcedureEasy;
using ProcedureEasy.Propiedades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos_MySQL
{
    public partial class FrmConsultas : Form
    {
        List<Relaciones> relacion = new List<Relaciones>(); 
        public FrmConsultas()
        {
            InitializeComponent();
            cargarTrvTablas();
            cargarRelaciones();
        }
       
       
        private void cargarRelaciones()
        {
            Conexion connect = new Conexion();
            CreateProcedure csp = new CreateProcedure(connect.Connection);
            relacion = csp.listaRelaciones();      
        }
        private void cargarTrvTablas()
        {
            Conexion connect = new Conexion();
            CreateProcedure csp = new CreateProcedure(connect.Connection);
            trvTablas.Nodes.Clear();
            
            //limpia el contenido del gridview
            foreach (var item in csp.listaTablas())
            {
                TreeNode tablas = new TreeNode(item.NombreTabla);
               trvTablas.Nodes.Add(tablas);
               
                
            }
            trvTablas.SelectedImageIndex = 5;           //dataGridView1.Dispose();


        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }
       
        private void trvTablas_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Conexion connect = new Conexion();
            CreateProcedure csp = new CreateProcedure(connect.Connection);
            FrmModelo modelo = new FrmModelo();
            //DataTable gridData = new DataTable();
            //string alias = e.Node.Text.Substring(0, 3);
            modelo.txtAlias.Text = e.Node.Text.Substring(0, 3);
            //gridData.Columns.Add("Campos");
            //modelo.dtgCampos.ColumnCount = 2;

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "campos";
            modelo.dtgCampos.Columns.Add(column);
            //modelo.dtgCampos.Columns.Add(gridData.Columns[0]);
            //foreach (DataColumn col in gridData.Columns)
            //{
            //    var c = new DataGridViewColumn() { HeaderText = col.ColumnName }; //Let say that the default column template of DataGridView is DataGridViewTextBoxColumn
            //    modelo.dtgCampos.Columns.Add(c);
            //}
            
      
            //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            //modelo.dtgCampos.Columns.Add(checkColumn1);
            trvTablas.SelectedNode = e.Node;
           
            if (e.Node.Checked)
            {
                modelo.Text = e.Node.Text;
                modelo.Name = e.Node.Text;
                modelo.TopLevel = false;
                modelo.AutoScroll = true;
                
                foreach (var item in csp.estructuraTabla(e.Node.Text))
                {
                    modelo.dtgCampos.Rows.Add(item.Field);
                    

                }

               //  modelo.dtgCampos.DataSource = gridData;
                modelo.dtgCampos.Columns[0].ReadOnly = true;
                DataGridViewCheckBoxColumn checkColumn1 = new DataGridViewCheckBoxColumn();
                checkColumn1.HeaderText = "*";
                checkColumn1.Width = 50;
                checkColumn1.ReadOnly = false;
                checkColumn1.FillWeight = 10;
               
                modelo.dtgCampos.Columns.Add(checkColumn1);
                flpnRelacional.Controls.Add(modelo);
                modelo.dtgCampos.CellEndEdit += IngresarSelects;
                modelo.Show();

                int i = 0;
                foreach (var item in csp.estructuraTabla(e.Node.Text))
                {
                    if (item.Key.Equals("PRI"))
                        modelo.dtgCampos.Rows[i].Cells[0].Style.BackColor = Color.FromArgb(108, 226, 108);
                    else if (item.Key.Equals("MUL"))
                        modelo.dtgCampos.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                      
                    i++;
                }


            }
            else
            {
                var formulario = (Form)flpnRelacional.Controls[e.Node.Text];
                flpnRelacional.Controls.Remove(formulario);
            }
        }

        private void IngresarSelects(object sender, DataGridViewCellEventArgs e)
        {
            String Selects, Froms, Where, Mywhere, Group, Having, Limit;

            try
            { // guardar los cambios realizados en el gridview
                FlowLayoutPanel.ControlCollection ventanas = flpnRelacional.Controls;
                foreach (var item in ventanas)
                {
                    var frmMdl = (FrmModelo)item;
                    frmMdl.Select();
                    //frmMdl.dtgCampos.Select();
                    //frmMdl.dtgCampos.EndEdit();
                   // MessageBox.Show(frmMdl.dtgCampos.Rows[e.RowIndex].Cells[0].Value.ToString());

                    foreach (DataGridViewRow row in frmMdl.dtgCampos.Rows)
                   { ///recorrer todos los check de la columna insert

                        DataGridViewCheckBoxCell cell = row.Cells[1] as DataGridViewCheckBoxCell;
                        // condicional si el valor es verdadero
                        if (Convert.ToBoolean(cell.Value) == true)
                        {
                            MessageBox.Show(row.Cells[0].Value.ToString());
                            // escribirCodigo(row.Cells[0].Value.ToString(),frmMdl.txtAlias.Text );
                            //select += sp.createProcedimiento(Tipo.Insert, row.Cells[0].Value.ToString()) + "\n";

                            //MessageBox.Show(csp.createProcedimiento(Tipo.Insert));
                            // MessageBox.Show(procedures);
                            //insertProcedure(row.Cells[0].Value.ToString());
                            //        }


                       }

                    }
                }
                //var frmMdl = (FrmModelo)flpnRelac;





                // foreach (DataGridViewRow row in frmMdl.dtgCampos.Rows)
                //   {   ///recorrer todos los check de la columna insert

                //        DataGridViewCheckBoxCell cell = row.Cells[1] as DataGridViewCheckBoxCell;
                //        // condicional si el valor es verdadero
                //        if (Convert.ToBoolean(cell.Value) == true)
                //        {
                //            //MessageBox.Show(row.Cells[0].Value.ToString());
                //            escribirCodigo(row.Cells[0].Value.ToString(),frmMdl.txtAlias.Text );
                //            //procedures += sp.createProcedimiento(Tipo.Insert, row.Cells[0].Value.ToString()) + "\n";

                //            //MessageBox.Show(csp.createProcedimiento(Tipo.Insert));
                //            // MessageBox.Show(procedures);
                //            //insertProcedure(row.Cells[0].Value.ToString());
                //        }

                //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
       

        private void escribirCodigo(string campo, string alias)
        {
            string procedure = txtconsulta.Text;
            procedure.Replace("*",alias+"."+campo+",");

        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Recorrer(Control.ControlCollection controls)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i].Controls != null && controls[i].Controls.Count > 0)
                {
                    this.Recorrer(controls[i].Controls);
                }
                else
                {
                    DataGrid LB = controls[i] as DataGrid;

                    if (LB != null)
                    {
                        foreach (DataGridViewRow row in Control.dtgCampos.Rows)
                             { 
                            DataGridViewCheckBoxCell cell = row.Cells[1] as DataGridViewCheckBoxCell;
                        //        // condicional si el valor es verdadero
                        //        if (Convert.ToBoolean(cell.Value) == true)
                        //        {
                        //            //MessageBox.Show(row.Cells[0].Value.ToString());
                        //            escribirCodigo(row.Cells[0].Value.ToString(),frmMdl.txtAlias.Text );
                        //            //procedures += sp.createProcedimiento(Tipo.Insert, row.Cells[0].Value.ToString()) + "\n";

                        //            //MessageBox.Show(csp.createProcedimiento(Tipo.Insert));
                        //            // MessageBox.Show(procedures);
                        //            //insertProcedure(row.Cells[0].Value.ToString());
                        //        }
                        // Clipboard.SetText(LB.SelectedItem.ToString());
                    }

                    //Aqui podes agregar codigo para los demas tipos de control
                }
            }
        }
    }
}
