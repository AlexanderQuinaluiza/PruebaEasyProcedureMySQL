namespace Procedimientos_MySQL
{
    partial class FrmListaTablas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaTablas));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTables = new System.Windows.Forms.DataGridView();
            this.bntAceptar = new System.Windows.Forms.Button();
            this.chAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una o varias tablas";
            // 
            // dtgTables
            // 
            this.dtgTables.AllowUserToAddRows = false;
            this.dtgTables.AllowUserToDeleteRows = false;
            this.dtgTables.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTables.Location = new System.Drawing.Point(3, 25);
            this.dtgTables.Name = "dtgTables";
            this.dtgTables.Size = new System.Drawing.Size(266, 246);
            this.dtgTables.TabIndex = 1;
            // 
            // bntAceptar
            // 
            this.bntAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntAceptar.Location = new System.Drawing.Point(102, 277);
            this.bntAceptar.Name = "bntAceptar";
            this.bntAceptar.Size = new System.Drawing.Size(87, 26);
            this.bntAceptar.TabIndex = 3;
            this.bntAceptar.Text = "Aceptar";
            this.bntAceptar.UseVisualStyleBackColor = false;
            this.bntAceptar.Click += new System.EventHandler(this.bntAceptar_Click);
            // 
            // chAll
            // 
            this.chAll.AutoSize = true;
            this.chAll.Location = new System.Drawing.Point(213, 30);
            this.chAll.Name = "chAll";
            this.chAll.Size = new System.Drawing.Size(15, 14);
            this.chAll.TabIndex = 4;
            this.chAll.UseVisualStyleBackColor = true;
            this.chAll.CheckedChanged += new System.EventHandler(this.chAll_CheckedChanged);
            // 
            // FrmListaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(272, 306);
            this.Controls.Add(this.chAll);
            this.Controls.Add(this.bntAceptar);
            this.Controls.Add(this.dtgTables);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmListaTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Tablas";
            this.Load += new System.EventHandler(this.FrmListaTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dtgTables;
        private System.Windows.Forms.Button bntAceptar;
        private System.Windows.Forms.CheckBox chAll;
    }
}