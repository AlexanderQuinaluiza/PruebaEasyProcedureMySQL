namespace Procedimientos_MySQL
{
    partial class FrmModelo
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
            this.LbComplemento = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.dtgCampos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // LbComplemento
            // 
            this.LbComplemento.AutoSize = true;
            this.LbComplemento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbComplemento.Location = new System.Drawing.Point(0, 137);
            this.LbComplemento.Name = "LbComplemento";
            this.LbComplemento.Size = new System.Drawing.Size(41, 17);
            this.LbComplemento.TabIndex = 0;
            this.LbComplemento.Text = "Alias:";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(47, 136);
            this.txtAlias.MaxLength = 3;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(29, 20);
            this.txtAlias.TabIndex = 1;
            // 
            // dtgCampos
            // 
            this.dtgCampos.AllowUserToAddRows = false;
            this.dtgCampos.AllowUserToDeleteRows = false;
            this.dtgCampos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCampos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCampos.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dtgCampos.Location = new System.Drawing.Point(3, 0);
            this.dtgCampos.Name = "dtgCampos";
            this.dtgCampos.RowHeadersWidth = 10;
            this.dtgCampos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgCampos.ShowEditingIcon = false;
            this.dtgCampos.Size = new System.Drawing.Size(121, 130);
            this.dtgCampos.TabIndex = 2;
            this.dtgCampos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCampos_CellEndEdit);
            // 
            // FrmModelo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(127, 159);
            this.ControlBox = false;
            this.Controls.Add(this.dtgCampos);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.LbComplemento);
            this.Name = "FrmModelo";
            this.Text = "FrmModelo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbComplemento;
        public System.Windows.Forms.DataGridView dtgCampos;
        public System.Windows.Forms.TextBox txtAlias;
    }
}