using ProcedureEasy;
using ProcedureEasy.Propiedades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Procedimientos_MySQL
{
    public partial class containt : Form
    {
        public static string nombrebase = null;
        List<Funciones> fun = null;
        // form ayuda inicializado 
        FrmAyuda frmayuda = new FrmAyuda();
      //  List<Procedimientos> fpro = null;

        public static List<String> OpenedFilesList = new List<String> { };
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
            //MainForm_Closing(sender, e);
            //  this.FormClosed += MainForm_Closing;

            this.Close();

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
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
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
            trvSintaxis.ImageIndex = 0;
            //trFunciones.SelectedNode.ImageIndex = 0;
            foreach (Funciones item in fun)
            {

                switch (item.grupo)
                {
                    case "matematicas":
                        //TreeNode mate = new TreeNode(item.nombre);
                        trFunciones.Nodes["mt"].Nodes.Add(item.nombre);

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

                    case "syndml":
                        trvSintaxis.Nodes["dml"].Nodes.Add(item.nombre);
                        break;
                    case "synddl":
                        trvSintaxis.Nodes["ddl"].Nodes.Add(item.nombre);
                        break;
                    case "syntrans":
                        trvSintaxis.Nodes["trans"].Nodes.Add(item.nombre);
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
            if (res == DialogResult.OK)
            {
                lbltitulo.Text = "EasyProcedure [" + conectar.basedatos + "]";

            }
        }

      

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        //***************************************************************************
        //         MainForm Load
        //***************************************************************************
        private void MainForm_Load(object sender, EventArgs e)
        {

            File_New_MenuItem_Click(sender, e);
            //UpdateReadyLabel();

        }

      

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmayuda = new FrmAyuda();
            frmayuda.Show(this);
            this.Enabled = true;
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
            //agregar los nodos raiz primero 
            TreeNode tablas = new TreeNode("Tablas");
            tablas.Name = "tbl";
            TreeNode vistas = new TreeNode("Views");
            vistas.Name = "viw";
            trvvarios.Nodes.Add(tablas);
            trvvarios.Nodes.Add(vistas);
            trvvarios.ImageIndex = 5;
            trvvarios.SelectedImageIndex = 6;
            foreach (var item in csp.listaTablas())
            {
                if (!item.TipoTabla.Equals("VIEW"))
                {
                    trvvarios.Nodes["tbl"].Nodes.Add(item.NombreTabla);
                }
                else
                {
                    trvvarios.Nodes["viw"].Nodes.Add(item.NombreTabla);
                   
                }
               
                
                
               
                
            }
         
            
        }

        private void tltNuevo_Click(object sender, EventArgs e)
        {
            File_New_MenuItem_Click(sender, e);
        }


        private void toolOpenSQL_Click(object sender, EventArgs e)
        {
            File_Open_SQL(sender, e);
        }



        private void toolSaveSql_Click(object sender, EventArgs e)
        {
            File_Save_MenuItem_Click(sender, e);
        }




        private void toolPrintSql_Click(object sender, EventArgs e)
        {
            File_Print_MenuItem_Click(sender, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                if (tabpagSQL.SelectedTab.Text != "Start Page")
                {
                    int select_index = tabpagSQL.SelectedIndex;
                    var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                    e.Graphics.DrawString(_myRichTextBox.Text, _myRichTextBox.Font, Brushes.Black, e.MarginBounds.Left, 0, new StringFormat());
                    e.Graphics.PageUnit = GraphicsUnit.World;
                }
            }
        }

        private void toolSaveAsSql_Click(object sender, EventArgs e)
        {
            File_SaveAll(sender, e);
        }



        #region barra de herramientas 
        //***************************************************************************
        //         File -> New
        //***************************************************************************
        public static int count = 1;
        private void File_New_MenuItem_Click(object sender, EventArgs e)
        {
            MyTabPage tabpage = new MyTabPage(this);
            tabpage.Text = "Untitled " + count;
            //agrega un pagetab
            tabpagSQL.TabPages.Add(tabpage);
            //slecciona el 
            tabpagSQL.SelectedTab = tabpage;

            var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
            _myRichTextBox.Select();

            //add contextmenustrip to richTextBox1
            // _myRichTextBox.ContextMenuStrip = myContextMenuStrip;

            //  this.UpdateDocumentSelectorList();

            //this.Text = " [ Untitled " + count + " ]";

            FilenameToolStripLabel.Text = tabpage.Text;

            //  UpdateWindowsList_WindowMenu();

            count++;
        }



        //***************************************************************************
        //         File -> Open 
        //***************************************************************************
        private void File_Open_SQL(object sender, EventArgs e)
        {
            StreamReader strReader;
            String str;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String[] files = openFileDialog1.FileNames;
                foreach (string filename in files)
                {
                    MyTabPage tabpage = new MyTabPage(this);

                    strReader = new StreamReader(filename);
                    str = strReader.ReadToEnd();
                    strReader.Close();

                    String fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                    tabpage.Text = fname;

                    //add contextmenustrip to richTextBox1
                    // tabpage._myRichTextBox.ContextMenuStrip = myContextMenuStrip;

                    tabpage._myRichTextBox.Text = str;
                    tabpagSQL.TabPages.Add(tabpage);
                    tabpagSQL.SelectedTab = tabpage;


                    // this.UpdateDocumentSelectorList();


                    /* check (*) is available on TabPage Text
                     adding filename to tab page by removing (*) */
                    fname = tabpage.Text;
                    if (fname.Contains("*"))
                    {
                        fname = fname.Remove(fname.Length - 1);
                    }
                    tabpage.Text = fname;

                    //adding filenames to OpenedFilesList list
                    OpenedFilesList.Add(filename);

                    FilenameToolStripLabel.Text = filename;
                    //this.Text = "Advanced Notepad in C# [ " + fname + " ]";
                }


                if (tabpagSQL.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                    _myRichTextBox.Select();
                }
                //   UpdateWindowsList_WindowMenu();
            }
        }

        //***************************************************************************
        //         File -> Save
        //***************************************************************************
        private void File_Save_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage seltab = tabpagSQL.SelectedTab;
            String selecttabname = seltab.Text;

            if (FilenameToolStripLabel.Text.Contains("\\"))
            {
                TabPage tabpage = tabpagSQL.SelectedTab;
                if (tabpage.Text.Contains("*"))
                {
                    String filename = FilenameToolStripLabel.Text;
                    if (File.Exists(filename))
                    {
                        var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                        File.WriteAllText(filename, "");
                        StreamWriter strwriter = System.IO.File.AppendText(filename);
                        strwriter.Write(_myRichTextBox.Text);
                        strwriter.Close();
                        strwriter.Dispose();
                        tabpage.Text = tabpage.Text.Remove(tabpage.Text.Length - 1);

                        //UpdateWindowsList_WindowMenu();

                        //this.UpdateDocumentSelectorList();
                    }
                }
            }
            else
            {
                File_SaveAs_MenuItem_Click(sender, e);
            }
        }

        //***************************************************************************
        //         File -> Save As
        //***************************************************************************
        private void File_SaveAs_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                TabPage tabpage = tabpagSQL.SelectedTab;
                if (tabpage != null)
                {
                    var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                    // _myRichTextBox.TextChanged += Txtsql_TextChanged;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        String filename = saveFileDialog1.FileName;
                        if (filename != "")
                        {
                            File.WriteAllText(filename, "");
                            StreamWriter strw = new StreamWriter(filename);
                            strw.Write(_myRichTextBox.Text);
                            strw.Close();
                            strw.Dispose();

                            String fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                            tabpage.Text = fname;
                            //this.Text = "Advanced Notepad in C# [ " + fname + " ]";
                            FilenameToolStripLabel.Text = filename;

                            //                  OpenedFilesList.Add(filename);
                            //                UpdateWindowsList_WindowMenu();

                            //              this.UpdateDocumentSelectorList();
                        }

                    }
                }
            }
        }
        //***************************************************************************
        //         File -> Print
        //***************************************************************************
        private void File_Print_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                // _myRichTextBox.Print();
            }
        }
        //*****************************************************************************************************************************
        //                          Edit
        //*****************************************************************************************************************************

        //***************************************************************************
        //         Edit -> Cut
        //***************************************************************************
        private void Edit_Cut_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                if (_myRichTextBox.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.SelectedText);
                        _myRichTextBox.SelectedText = "";
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.SelectedText);
                        _myRichTextBox.SelectedText = "";
                    }
                }
            }
        }

        //***************************************************************************
        //         Edit -> Copy
        //***************************************************************************
        private void Edit_Copy_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                if (_myRichTextBox.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.SelectedText);
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.SelectedText);
                    }
                }
            }
        }

        //***************************************************************************
        //         Edit -> Paste
        //***************************************************************************
        private void Edit_Paste_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];

                if (Clipboard.ContainsText())
                {
                    String str = Clipboard.GetText();
                    _myRichTextBox.Paste();
                }
            }
        }
        #endregion

        private void toolCopy_Click(object sender, EventArgs e)
        {
            Edit_Copy_MenuItem_Click(sender, e);
        }

        private void toolCut_Click(object sender, EventArgs e)
        {
            Edit_Cut_MenuItem_Click(sender, e);
        }

        private void toolPaste_Click(object sender, EventArgs e)
        {
            Edit_Paste_MenuItem_Click(sender, e);
        }
        //***************************************************************************
        //         MainForm Closing
        //***************************************************************************

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                TabControl.TabPageCollection tabcoll = tabpagSQL.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    tabpagSQL.SelectedTab = tabpage;
                    if (tabpage.Text.Contains("*"))
                    {
                        DialogResult dg = MessageBox.Show("Quieres guardar el siguiente archivo [" + tabpage.Text + "] antes de cerrar ?", "Guardar ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            File_Save_MenuItem_Click(sender, e);
                            tabpagSQL.TabPages.Remove(tabpage);
                            myTabControlZ_SelectedIndexChanged(sender, e);
                        }
                        else if (dg == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            tabpagSQL.Select();
                            break;
                        }
                    }
                    else
                    {
                        tabpagSQL.TabPages.Remove(tabpage);
                        myTabControlZ_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }
        private void toolPlay_Click(object sender, EventArgs e)
        {
            Conexion connect = new Conexion();
            dtgResultados.DataSource=null;
            DataTable datos = new DataTable();
            CreateProcedure sp = new CreateProcedure(connect.Connection);
            var txtsql  = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
            txtsql.Select();
            toolProBar.Value = 0;
            
            try
            {
                if (!txtsql.Selection.IsEmpty)
                {
                    
                    string selection = txtsql.SelectedText;
                    MessageBox.Show(selection);
                    splitwork.Panel1Collapsed = false;
                    
                    datos = sp.executarSql(selection);
                    //total = datos.Rows.Count;
                    toolProBar.Value = 100;
                    dtgResultados.DataSource = datos;
                  

                }
                else
                {
                    MessageBox.Show(txtsql.Text);
                    splitwork.Panel1Collapsed = false;
                    
                     datos = sp.executarSql(txtsql.Text);
                   
                    toolProBar.Value = 100;
                    dtgResultados.DataSource = datos;
                   
                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
           
        }
        //******************************************************************************************
        //         myTabControlZ_SelectedIndexChanged
        //******************************************************************************************
        private void myTabControlZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                TabPage tabpage = tabpagSQL.SelectedTab;
                if (tabpage.Text.Contains("Untitled"))
                {
                    FilenameToolStripLabel.Text = tabpage.Text;
                    this.Text = "Script  [ " + tabpage.Text + " ]";
                    //UpdateWindowsList_WindowMenu();
                }
                else
                {
                    foreach (String filename in OpenedFilesList)
                    {
                        if (tabpage != null)
                        {
                            String str = filename.Substring(filename.LastIndexOf("\\") + 1);
                            if (tabpage.Text.Contains("*"))
                            {
                                String str2 = tabpage.Text.Remove(tabpage.Text.Length - 1);
                                if (str == str2)
                                {
                                    FilenameToolStripLabel.Text = filename;
                                    this.Text = "Script  [ " + tabpage.Text + " ]";
                                }
                            }

                            else
                            {
                                if (str == tabpage.Text)
                                {
                                    FilenameToolStripLabel.Text = filename;
                                    this.Text = "Script  [ " + tabpage.Text + " ]";
                                }
                            }
                        }
                    }

                    //UpdateWindowsList_WindowMenu();
                }
            }
            else
            {
                FilenameToolStripLabel.Text = "Procedimietos Almacenados MySQL";
                //this.Text = "Advanced Notepad in C#";
                //UpdateWindowsList_WindowMenu();
            }
        }

        //***************************************************************************
        //         File -> Save All
        //***************************************************************************
        private void File_SaveAll(object sender, EventArgs e)
        {
            if (tabpagSQL.TabCount > 0)
            {
                OpenedFilesList.Reverse();
                TabControl.TabPageCollection tabcoll = tabpagSQL.TabPages;

                foreach (TabPage tabpage in tabcoll)
                {
                    tabpagSQL.SelectedTab = tabpage;
                    myTabControlZ_SelectedIndexChanged(sender, e);

                    if (!tabpage.Text.Contains("Untitled"))
                    {
                        try
                        {
                            var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                            File.WriteAllText(FilenameToolStripLabel.Text, "");
                            StreamWriter strwriter = System.IO.File.AppendText(FilenameToolStripLabel.Text);
                            strwriter.Write(_myRichTextBox.Text);
                            strwriter.Close();
                            strwriter.Dispose();
                        }
                        catch { }
                    }
                }

                System.Windows.Forms.TabControl.TabPageCollection tabcollection = tabpagSQL.TabPages;
                foreach (TabPage tabpage in tabcollection)
                {
                    String str = tabpage.Text;
                    if (str.Contains("*") && !str.Contains("Untitled"))
                    {
                        str = str.Remove(str.Length - 1);
                    }
                    tabpage.Text = str;
                }
                //UpdateWindowsList_WindowMenu();
            }
        }

        //***************************************************************************
        //         Button -> Quickly Access 
        //***************************************************************************
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            trvvarios.Nodes.Clear();

            lblsubtitulo.Text = "Operaciones Rapidas";
            trvvarios.ImageList = icons;
            foreach (Funciones item in fun)
            {
                if (item.grupo=="procedures")
                {
                    TreeNode uno = new TreeNode(item.nombre);
                    trvvarios.Nodes.Add(uno);
                    //cambiar imagen para las operaciones basicas de generacion para procedimientos almacenados 
                    trvvarios.ImageIndex = 0;
                    trvvarios.SelectedImageIndex = 0;
                }
                
            }
            //FrmListaTablas frmtablas = new FrmListaTablas();
            // frmtablas.ShowDialog();
        }
        //***************************************************************************
        //   doble click treeview -> Desplegar formulario para escojer las tablas 
        //***************************************************************************
        private void trvvarios_DoubleClick(object sender, EventArgs e)
        {
           
            CreateProcedure sp = new CreateProcedure();
            try
            {
                string operacion = trvvarios.SelectedNode.Text;

                var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                _myRichTextBox.Select();
                string menu = lblsubtitulo.Text;
                switch (menu)
                {
                    case "Procedimientos Almacenados":

                        foreach (var item in sp.listaProcedures())
                        {

                            if (item.NameProcedure == operacion)
                            {

                                //MessageBox.Show(operacion);
                                //MessageBox.Show(item.Definition);
                                File_New_MenuItem_Click(sender, e);
                                var nuevoText = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                                nuevoText.Select();
                                nuevoText.Text += " \n" + sp.codigoProcedimiento(item.NameProcedure);
                            }
                        }


                        break;
                    case "Operaciones Rapidas":
                        #region opciones de las operaciones rapidas


                        switch (operacion)
                        {
                            case "SP INSERT":
                                RetornarCodigos(Tipo.Insert);
                                break;

                            case "SP UPDATE":
                                RetornarCodigos(Tipo.Update);
                                break;
                            case "SP DELETE":
                                RetornarCodigos(Tipo.Delete);
                                break;
                            case "SP SELECT":
                                //RetornarCodigos(Tipo.Select);
                                FrmConsultas consultas = new FrmConsultas();
                                consultas.ShowDialog();

                                break;
                            case "SP SIMPLE":
                                 _myRichTextBox.Text = sp.createProcedimiento(Tipo.Simple, null);
                                break;
                            case "SP COMPLEJO":
                                _myRichTextBox.Text = sp.createProcedimiento(Tipo.Complejo, null);
                                // RetornarCodigos(Tipo.Complejo);
                                break;
                        }
                        #endregion
                        break;
                }
            }
            catch (Exception)
            {

                return;
            }
            

            }
            
            

          

          

        

        private void RetornarCodigos(Tipo tipoCodigo)
        {

            Conexion connect = new Conexion();
            CreateProcedure sp = new CreateProcedure(connect.Connection);

            FrmListaTablas frmtables = new FrmListaTablas();
            DialogResult res = frmtables.ShowDialog();
            string codigo_generado = null;
            if (tabpagSQL.TabCount > 0 && res == DialogResult.OK)
            {
                foreach (var item in frmtables.tablas_seleccionadas)
                {
                    codigo_generado += sp.createProcedimiento(tipoCodigo, item.ToString()) + "\n";
                }

                var _myRichTextBox = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
                _myRichTextBox.Select();
                _myRichTextBox.Text = codigo_generado;


                //MessageBox.Show(sp.createProcedimiento(Tipo.Insert, "clientes"),"procedimiento");
            }
        }
        private void trFunciones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Desplegar_informacion(sender, e, trFunciones);

        }
        //***************************************************************************
        //         Button -> Desplegar Informacion sobre la ventana de ayuda 
        //***************************************************************************
        private void Desplegar_informacion(object sender,TreeViewEventArgs e,TreeView trview)
        {
            string nom_funcion = trview.SelectedNode.Text;
            foreach (var item in fun)
            {
                if (item.nombre.Equals(nom_funcion))
                {
                    frmayuda.lblfuncion.Text = "   " + item.nombre +"\n";
                    frmayuda.lbldescripcion.Text = item.descripcion +"\n";
                    frmayuda.lblejemplo.Text = " Ejemplo: \n   " + item.ejemplo;
                }

            }
        }

        private void trvSintaxis_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Desplegar_informacion(sender, e, trvSintaxis);
        }

        private void trvvarios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Conexion connect = new Conexion();
            CreateProcedure csp = new CreateProcedure(connect.Connection);
         
            if (lblsubtitulo.Text.Contains("Tablas"))
            {
                string select = trvvarios.SelectedNode.Text;
            
                
            lblcampo.Text = "";
            lbltd.Text = "";
            lbltabla.Text = "      Tabla " + select +"     \n";
            lbltabla.ImageList = icons;
            lbltabla.ImageIndex = 6;
            foreach (var item in csp.estructuraTabla(select))
            {
                lblcampo.Text += item.Field + "\n";
                lblcampo.ForeColor = Color.Blue;
                lblcampo.Font = new Font("Arial", 8, FontStyle.Bold);
                lbltd.Text += item.Type + " " + item.Key + "\n";
                lbltd.Font = new Font("Arial", 8, FontStyle.Italic);

            }

            }

        }

        private void trFunciones_DoubleClick(object sender, EventArgs e)
        {
            treeview_DoubleClick(trFunciones, sender, e);
        }
        /******************************************************************************
         *  Metodo que remplaza la funcion en el campos selecionado 
         * ****************************************************************************/
        private void treeview_DoubleClick(TreeView trview, object sender, EventArgs e)
        {
            var txtsql = (FastColoredTextBoxNS.FastColoredTextBox)tabpagSQL.TabPages[tabpagSQL.SelectedIndex].Controls[0];
            txtsql.Select();
            string seleccion = txtsql.SelectedText;
            try
            {
                MessageBox.Show("seleciono: " + seleccion);
                if (seleccion != null)
                {
                    // seleccionamos el texto de la funcion selecicionada con doble click 
                    string funcion = trview.SelectedNode.Text;
                    MessageBox.Show("funcion : " + funcion);
                    if (funcion.Contains("(X"))
                    {
                        MessageBox.Show("la funcion contiene x -- " + txtsql.SelectedText);
                        txtsql.SelectedText = funcion.Replace("(X","("+seleccion);
                        
                       // txtsql.Selection.Text.Replace(seleccion, funcion);
                       // txtsql.SelectedText.Replace(seleccion, funcion); 
                 
                    }


                }
            }
            catch (Exception)
            {

                return;
            }

          
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e, int step)
        {
            
        }
    }
}
