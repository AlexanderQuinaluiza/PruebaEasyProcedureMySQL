namespace Procedimientos_MySQL
{
    partial class FrmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Matematicas", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tiempo", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cadena", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Incriptado", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Información", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Group by", 2, 2);
            this.pnl1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trvTablas = new System.Windows.Forms.TreeView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpnRelacional = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtconsulta = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.trFunciones = new System.Windows.Forms.TreeView();
            this.pnl1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.Control;
            this.pnl1.Controls.Add(this.tabControl1);
            this.pnl1.Controls.Add(this.trvTablas);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.flpnRelacional);
            this.pnl1.Location = new System.Drawing.Point(3, 2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(818, 293);
            this.pnl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(538, 20);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(274, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Where";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(145, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 121);
            this.listBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group by";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(247, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Having";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // trvTablas
            // 
            this.trvTablas.CheckBoxes = true;
            this.trvTablas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvTablas.ImageIndex = 6;
            this.trvTablas.ImageList = this.icons;
            this.trvTablas.Location = new System.Drawing.Point(12, 20);
            this.trvTablas.Name = "trvTablas";
            this.trvTablas.SelectedImageIndex = 0;
            this.trvTablas.Size = new System.Drawing.Size(190, 270);
            this.trvTablas.TabIndex = 5;
            this.trvTablas.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvTablas_AfterCheck);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "0908-formula01-512.png");
            this.icons.Images.SetKeyName(1, "funcionLARGO.png");
            this.icons.Images.SetKeyName(2, "closed-folder-yellow.png");
            this.icons.Images.SetKeyName(3, "flow-tree-icon.jpg");
            this.icons.Images.SetKeyName(4, "Procedures.png");
            this.icons.Images.SetKeyName(5, "table.jpg");
            this.icons.Images.SetKeyName(6, "database_table-128.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campos y filtros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione una o varias tablas";
            // 
            // flpnRelacional
            // 
            this.flpnRelacional.AutoScroll = true;
            this.flpnRelacional.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flpnRelacional.Location = new System.Drawing.Point(208, 20);
            this.flpnRelacional.Name = "flpnRelacional";
            this.flpnRelacional.Size = new System.Drawing.Size(328, 270);
            this.flpnRelacional.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(2, 301);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(819, 10);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(2, 481);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(797, 10);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // txtconsulta
            // 
            this.txtconsulta.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtconsulta.AutoIndentCharsPatterns = "";
            this.txtconsulta.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtconsulta.BackBrush = null;
            this.txtconsulta.CharHeight = 14;
            this.txtconsulta.CharWidth = 8;
            this.txtconsulta.CommentPrefix = "--";
            this.txtconsulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconsulta.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtconsulta.IsReplaceMode = false;
            this.txtconsulta.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtconsulta.LeftBracket = '(';
            this.txtconsulta.Location = new System.Drawing.Point(3, 317);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Paddings = new System.Windows.Forms.Padding(0);
            this.txtconsulta.RightBracket = ')';
            this.txtconsulta.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtconsulta.Size = new System.Drawing.Size(577, 158);
            this.txtconsulta.TabIndex = 4;
            this.txtconsulta.Zoom = 100;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // trFunciones
            // 
            this.trFunciones.ImageKey = "closed-folder-yellow.png";
            this.trFunciones.ImageList = this.icons;
            this.trFunciones.Location = new System.Drawing.Point(633, 317);
            this.trFunciones.Name = "trFunciones";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "mt";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Matematicas";
            treeNode1.ToolTipText = "Contiene todas las funciones matemáticas de MySQL.";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "tp";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Tiempo";
            treeNode2.ToolTipText = "Contiene todas las funciones que facilitan el manejo de fechas y horas de MySQL.";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "cd";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Cadena";
            treeNode3.ToolTipText = "Contiene todas las funciones que facilitan el manejo de cadenas de caracteres en " +
    "MySQL.\t";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "inp";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Incriptado";
            treeNode4.ToolTipText = "Contiene funciones que facilitan el manejo de encriptación y des-encriptación  en" +
    " MySQL.";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "info";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Información";
            treeNode5.ToolTipText = "Contiene funciones que retornan información importante sobre MySQL.\t";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "grp";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Group by";
            treeNode6.ToolTipText = "Contiene funciones que retornar valores calculados de un grupo de registros.";
            this.trFunciones.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.trFunciones.SelectedImageIndex = 0;
            this.trFunciones.Size = new System.Drawing.Size(188, 158);
            this.trFunciones.TabIndex = 9;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 532);
            this.Controls.Add(this.trFunciones);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultas";
            this.Text = "Asistente de creacion de consultas MySQL. ";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtconsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private FastColoredTextBoxNS.FastColoredTextBox txtconsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.FlowLayoutPanel flpnRelacional;
        private System.Windows.Forms.TreeView trvTablas;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView trFunciones;
    }
}