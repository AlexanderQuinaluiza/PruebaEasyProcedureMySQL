namespace Procedimientos_MySQL
{
    partial class Conectar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnprobar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxbases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConectar);
            this.panel2.Controls.Add(this.btnprobar);
            this.panel2.Location = new System.Drawing.Point(-1, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 51);
            this.panel2.TabIndex = 15;
            // 
            // btnConectar
            // 
            this.btnConectar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConectar.Location = new System.Drawing.Point(164, 7);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(83, 34);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnprobar
            // 
            this.btnprobar.Location = new System.Drawing.Point(20, 7);
            this.btnprobar.Name = "btnprobar";
            this.btnprobar.Size = new System.Drawing.Size(107, 34);
            this.btnprobar.TabIndex = 5;
            this.btnprobar.Text = "Probar Conexión";
            this.btnprobar.UseVisualStyleBackColor = true;
            this.btnprobar.Click += new System.EventHandler(this.btnprobar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtServidor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxbases);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 120);
            this.panel1.TabIndex = 14;
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUsuario.Location = new System.Drawing.Point(129, 36);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "root";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Base de Datos:";
            // 
            // txtServidor
            // 
            this.txtServidor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtServidor.Location = new System.Drawing.Point(129, 10);
            this.txtServidor.MaxLength = 100;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(121, 22);
            this.txtServidor.TabIndex = 0;
            this.txtServidor.Text = "localhost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // cbxbases
            // 
            this.cbxbases.FormattingEnabled = true;
            this.cbxbases.Location = new System.Drawing.Point(129, 88);
            this.cbxbases.Name = "cbxbases";
            this.cbxbases.Size = new System.Drawing.Size(121, 24);
            this.cbxbases.TabIndex = 4;
            this.cbxbases.Click += new System.EventHandler(this.cbxbases_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(129, 62);
            this.txtContraseña.MaxLength = 16;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(121, 22);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "uta007008%";
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servidor:";
            // 
            // Conectar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Conectar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectar con MySQL";
            this.Load += new System.EventHandler(this.Conectar_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnprobar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxbases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
    }
}