
namespace WindowsPubs
{
    partial class Form1
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
            this.gridDataAutores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorCiudad = new System.Windows.Forms.Button();
            this.btnMostrarAutores = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrarPorEstado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTraerXCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataAutores
            // 
            this.gridDataAutores.AllowUserToAddRows = false;
            this.gridDataAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataAutores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDataAutores.Location = new System.Drawing.Point(0, 219);
            this.gridDataAutores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridDataAutores.Name = "gridDataAutores";
            this.gridDataAutores.RowHeadersWidth = 51;
            this.gridDataAutores.RowTemplate.Height = 24;
            this.gridDataAutores.Size = new System.Drawing.Size(900, 343);
            this.gridDataAutores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(105, 40);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(112, 26);
            this.txtCiudad.TabIndex = 2;
            // 
            // btnFiltrarPorCiudad
            // 
            this.btnFiltrarPorCiudad.Location = new System.Drawing.Point(256, 35);
            this.btnFiltrarPorCiudad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrarPorCiudad.Name = "btnFiltrarPorCiudad";
            this.btnFiltrarPorCiudad.Size = new System.Drawing.Size(242, 39);
            this.btnFiltrarPorCiudad.TabIndex = 3;
            this.btnFiltrarPorCiudad.Text = "Filtrar por ciudad";
            this.btnFiltrarPorCiudad.UseVisualStyleBackColor = true;
            this.btnFiltrarPorCiudad.Click += new System.EventHandler(this.btnFiltrarPorCiudad_Click);
            // 
            // btnMostrarAutores
            // 
            this.btnMostrarAutores.Location = new System.Drawing.Point(518, 40);
            this.btnMostrarAutores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrarAutores.Name = "btnMostrarAutores";
            this.btnMostrarAutores.Size = new System.Drawing.Size(84, 72);
            this.btnMostrarAutores.TabIndex = 4;
            this.btnMostrarAutores.Text = "Mostrar todo los autores";
            this.btnMostrarAutores.UseVisualStyleBackColor = true;
            this.btnMostrarAutores.Click += new System.EventHandler(this.btnMostrarAutores_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(105, 90);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(112, 26);
            this.txtEstado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado:";
            // 
            // btnFiltrarPorEstado
            // 
            this.btnFiltrarPorEstado.Location = new System.Drawing.Point(256, 85);
            this.btnFiltrarPorEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrarPorEstado.Name = "btnFiltrarPorEstado";
            this.btnFiltrarPorEstado.Size = new System.Drawing.Size(242, 39);
            this.btnFiltrarPorEstado.TabIndex = 7;
            this.btnFiltrarPorEstado.Text = "Filtrar Por estado y ciudad";
            this.btnFiltrarPorEstado.UseVisualStyleBackColor = true;
            this.btnFiltrarPorEstado.Click += new System.EventHandler(this.btnFiltrarPorEstado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Traer por Ciudad:";
            // 
            // cbTraerXCiudad
            // 
            this.cbTraerXCiudad.FormattingEnabled = true;
            this.cbTraerXCiudad.Location = new System.Drawing.Point(185, 154);
            this.cbTraerXCiudad.Name = "cbTraerXCiudad";
            this.cbTraerXCiudad.Size = new System.Drawing.Size(121, 28);
            this.cbTraerXCiudad.TabIndex = 9;
            this.cbTraerXCiudad.SelectionChangeCommitted += new System.EventHandler(this.cbTraerXCiudad_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.cbTraerXCiudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrarPorEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarAutores);
            this.Controls.Add(this.btnFiltrarPorCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDataAutores);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDataAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnFiltrarPorCiudad;
        private System.Windows.Forms.Button btnMostrarAutores;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrarPorEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTraerXCiudad;
    }
}

