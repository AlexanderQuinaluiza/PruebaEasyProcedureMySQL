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
    public partial class containt : Form
    {
        public static string nombrebase = null;
        List<Funciones> fun = null;
        List<Procedimientos> fpro = null;
        public containt()
        {
            InitializeComponent();
            logo.Visible = false;
            CreateProcedure sp = new CreateProcedure();
            fun = sp.cargarFunciones();
           // tree();
           cargarTreeview();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (menu.Width == 50)
            {
                btnmenu.Location = new Point(156, 6);
               
                menu.Visible = false;
                menu.Width = 200;
                panelAnim.ShowSync(menu);
                logoAnim.ShowSync(logo);
            }
            else
            {
                logoAnim.Hide(logo);
                btnmenu.Location = new Point(12, 6);
               
                menu.Visible = false;
                menu.Width = 50;
                panelAnim.ShowSync(menu);

            }
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void herramientas_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cargarTreeview()
        {
            // trFunciones.ImageList = icons;
            //mt.Tag = " contiene Funciones matematicas de MYSQL";

            //  trFunciones.SelectedImageIndex = 2;

            trFunciones.ImageIndex = 0;
            //trFunciones.SelectedNode.ImageIndex = 0;
            foreach (Funciones item in fun)
            {

                switch (item.grupo)
                {
                    case "matematicas":
                        TreeNode mate = new TreeNode(item.nombre);
                        trFunciones.Nodes["mt"].Nodes.Add(mate);
                        
                        break;
                    case "tiempo":
                        trFunciones.Nodes["tp"].Nodes.Add(item.nombre);

                        break;

                   case "cadena":
                        trFunciones.Nodes["cd"].Nodes.Add(item.nombre);

                        break;
                    case "encriptado":
                      trFunciones.Nodes["inp"].Nodes.Add(item.nombre);

                    break;
                    case "informacion":
                      trFunciones.Nodes["info"].Nodes.Add(item.nombre);

                    break;
                    case "groupby":
                    trFunciones.Nodes["grp"].Nodes.Add(item.nombre);

                        break;


                }
            }
        }

         private void tree()
        {
            trFunciones.ImageList = icons;
            TreeNode desktop = new TreeNode();
            desktop.Text = "Desktop";
            desktop.Tag = "Desktop";
            trFunciones.ImageIndex = 0;
            trFunciones.SelectedImageIndex = 1;
            desktop.Nodes.Add("");
            trFunciones.Nodes.Add(desktop);

            TreeNode Mycomputer = new TreeNode("My Computer");
            Mycomputer.ImageIndex = 0;
            Mycomputer.SelectedImageIndex = 1;
            trFunciones.Nodes.Add(Mycomputer);
        }
     
               
         

        private void btnconectar_Click(object sender, EventArgs e)
        {
            Conectar conectar = new Conectar();
            //creamos un objeto del formulario 2
            DialogResult res = conectar.ShowDialog();
            if (res==DialogResult.OK)
            {
                lbltitulo.Text="EasyProcedure ["+conectar.basedatos+"]";
                txtSQL.a
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Open_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Save_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveAs_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Print_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Cut_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Copy_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Paste_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Undo_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Redo_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Find_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void GoTo_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Font_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void PreviewHTMLPage_ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnprocedures_Click(object sender, EventArgs e)
        {
            //limpiar el trvvarios
            trvvarios.Nodes.Clear();
            lblsubtitulo.Text = "Procedimientos Almacenados";
            Conexion connect = new Conexion();

            CreateProcedure csp = new CreateProcedure(connect.Connection);
            trvvarios.ImageList = icons;
            foreach (var item in csp.listaProcedures())
            {
                TreeNode uno = new TreeNode(item.NameProcedure);
                trvvarios.Nodes.Add(uno);
                trvvarios.ImageIndex = 3;
                trvvarios.SelectedImageIndex = 4;
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            //limpiar el trvvarios
            trvvarios.Nodes.Clear();
            
            lblsubtitulo.Text = "Tablas y Vistas";
            Conexion connect = new Conexion();
            CreateProcedure csp = new CreateProcedure(connect.Connection);
            trvvarios.ImageList = icons;
            foreach (var item in csp.listaTablas())
            {
                TreeNode uno = new TreeNode(item);
                trvvarios.Nodes.Add(uno);
                trvvarios.ImageIndex = 5;
                trvvarios.SelectedImageIndex = 6;
            }
        }
    }
}
