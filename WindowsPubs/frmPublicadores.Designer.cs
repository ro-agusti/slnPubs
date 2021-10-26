
namespace WindowsPubs
{
    partial class frmPublicadores
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
            this.gridPublicadores = new System.Windows.Forms.DataGridView();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnMostrarXCiudad = new System.Windows.Forms.Button();
            this.btnMostrarCiudadEstado = new System.Windows.Forms.Button();
            this.btnMostrarXCiudadEstadoPais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarPublicadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicadores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPublicadores
            // 
            this.gridPublicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublicadores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPublicadores.Location = new System.Drawing.Point(0, 134);
            this.gridPublicadores.Name = "gridPublicadores";
            this.gridPublicadores.RowHeadersWidth = 51;
            this.gridPublicadores.RowTemplate.Height = 24;
            this.gridPublicadores.Size = new System.Drawing.Size(800, 316);
            this.gridPublicadores.TabIndex = 0;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(111, 31);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 22);
            this.txtCiudad.TabIndex = 1;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(111, 59);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 2;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(111, 87);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 22);
            this.txtPais.TabIndex = 3;
            // 
            // btnMostrarXCiudad
            // 
            this.btnMostrarXCiudad.Location = new System.Drawing.Point(257, 31);
            this.btnMostrarXCiudad.Name = "btnMostrarXCiudad";
            this.btnMostrarXCiudad.Size = new System.Drawing.Size(245, 22);
            this.btnMostrarXCiudad.TabIndex = 4;
            this.btnMostrarXCiudad.Text = "Mostrar por ciudad";
            this.btnMostrarXCiudad.UseVisualStyleBackColor = true;
            this.btnMostrarXCiudad.Click += new System.EventHandler(this.btnMostrarXCiudad_Click);
            // 
            // btnMostrarCiudadEstado
            // 
            this.btnMostrarCiudadEstado.Location = new System.Drawing.Point(257, 59);
            this.btnMostrarCiudadEstado.Name = "btnMostrarCiudadEstado";
            this.btnMostrarCiudadEstado.Size = new System.Drawing.Size(245, 22);
            this.btnMostrarCiudadEstado.TabIndex = 5;
            this.btnMostrarCiudadEstado.Text = "Mostrar por ciudad y estado";
            this.btnMostrarCiudadEstado.UseVisualStyleBackColor = true;
            this.btnMostrarCiudadEstado.Click += new System.EventHandler(this.btnMostrarCiudadEstado_Click);
            // 
            // btnMostrarXCiudadEstadoPais
            // 
            this.btnMostrarXCiudadEstadoPais.Location = new System.Drawing.Point(257, 87);
            this.btnMostrarXCiudadEstadoPais.Name = "btnMostrarXCiudadEstadoPais";
            this.btnMostrarXCiudadEstadoPais.Size = new System.Drawing.Size(245, 22);
            this.btnMostrarXCiudadEstadoPais.TabIndex = 6;
            this.btnMostrarXCiudadEstadoPais.Text = "Mostrar por ciudad, estado y pais";
            this.btnMostrarXCiudadEstadoPais.UseVisualStyleBackColor = true;
            this.btnMostrarXCiudadEstadoPais.Click += new System.EventHandler(this.btnMostrarXCiudadEstadoPais_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "CIUDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ESTADO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "PAIS:";
            // 
            // btnMostrarPublicadores
            // 
            this.btnMostrarPublicadores.Location = new System.Drawing.Point(572, 36);
            this.btnMostrarPublicadores.Name = "btnMostrarPublicadores";
            this.btnMostrarPublicadores.Size = new System.Drawing.Size(141, 73);
            this.btnMostrarPublicadores.TabIndex = 10;
            this.btnMostrarPublicadores.Text = "Mostrar PUBLICADORES";
            this.btnMostrarPublicadores.UseVisualStyleBackColor = true;
            this.btnMostrarPublicadores.Click += new System.EventHandler(this.btnMostrarPublicadores_Click);
            // 
            // frmPublicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarPublicadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarXCiudadEstadoPais);
            this.Controls.Add(this.btnMostrarCiudadEstado);
            this.Controls.Add(this.btnMostrarXCiudad);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.gridPublicadores);
            this.Name = "frmPublicadores";
            this.Text = "frmPublicadores";
            this.Load += new System.EventHandler(this.frmPublicadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPublicadores;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnMostrarXCiudad;
        private System.Windows.Forms.Button btnMostrarCiudadEstado;
        private System.Windows.Forms.Button btnMostrarXCiudadEstadoPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarPublicadores;
    }
}