namespace Procedimientos_MySQL
{
    partial class FrmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyuda));
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblejemplo = new System.Windows.Forms.Label();
            this.lblfuncion = new System.Windows.Forms.Label();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.lblfuncion);
            this.flowLayoutPanel3.Controls.Add(this.lbldescripcion);
            this.flowLayoutPanel3.Controls.Add(this.lblejemplo);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
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
            // lbldescripcion
            // 
            resources.ApplyResources(this.lbldescripcion, "lbldescripcion");
            this.lbldescripcion.Name = "lbldescripcion";
            // 
            // lblejemplo
            // 
            resources.ApplyResources(this.lblejemplo, "lblejemplo");
            this.lblejemplo.Name = "lblejemplo";
            // 
            // lblfuncion
            // 
            resources.ApplyResources(this.lblfuncion, "lblfuncion");
            this.lblfuncion.ImageList = this.icons;
            this.lblfuncion.Name = "lblfuncion";
            // 
            // FrmAyuda
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.flowLayoutPanel3);
            this.MaximizeBox = false;
            this.Name = "FrmAyuda";
            this.Load += new System.EventHandler(this.FrmAyuda_Load);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ImageList icons;
        public System.Windows.Forms.Label lblfuncion;
        public System.Windows.Forms.Label lbldescripcion;
        public System.Windows.Forms.Label lblejemplo;
    }
}