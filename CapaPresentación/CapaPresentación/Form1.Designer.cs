namespace CapaPresentación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPersona = new System.Windows.Forms.DataGridView();
            this.dataGridViewComentarios = new System.Windows.Forms.DataGridView();
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.cboCanton = new System.Windows.Forms.ComboBox();
            this.btnCanton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Persona";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridPersona
            // 
            this.dataGridPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersona.Location = new System.Drawing.Point(12, 36);
            this.dataGridPersona.Name = "dataGridPersona";
            this.dataGridPersona.Size = new System.Drawing.Size(601, 99);
            this.dataGridPersona.TabIndex = 1;
            // 
            // dataGridViewComentarios
            // 
            this.dataGridViewComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComentarios.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewComentarios.Name = "dataGridViewComentarios";
            this.dataGridViewComentarios.Size = new System.Drawing.Size(601, 102);
            this.dataGridViewComentarios.TabIndex = 2;
            // 
            // cboProvincias
            // 
            this.cboProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(16, 270);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(240, 33);
            this.cboProvincias.TabIndex = 3;
            this.cboProvincias.Text = "Provincias";
            // 
            // cboCanton
            // 
            this.cboCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.Location = new System.Drawing.Point(292, 270);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(240, 33);
            this.cboCanton.TabIndex = 4;
            this.cboCanton.Text = "Cantones";
            // 
            // btnCanton
            // 
            this.btnCanton.Location = new System.Drawing.Point(509, 336);
            this.btnCanton.Name = "btnCanton";
            this.btnCanton.Size = new System.Drawing.Size(75, 23);
            this.btnCanton.TabIndex = 5;
            this.btnCanton.Text = "Cantones";
            this.btnCanton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.btnCanton);
            this.Controls.Add(this.cboCanton);
            this.Controls.Add(this.cboProvincias);
            this.Controls.Add(this.dataGridViewComentarios);
            this.Controls.Add(this.dataGridPersona);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Practica de datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPersona;
        private System.Windows.Forms.DataGridView dataGridViewComentarios;
        private System.Windows.Forms.ComboBox cboProvincias;
        private System.Windows.Forms.ComboBox cboCanton;
        private System.Windows.Forms.Button btnCanton;
    }
}

