namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.cmbSigno = new System.Windows.Forms.ComboBox();
            this.txbPriOperando = new System.Windows.Forms.TextBox();
            this.txbSegOperando = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(323, 52);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 0;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(36, 223);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(176, 223);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(301, 223);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBin
            // 
            this.btnBin.Location = new System.Drawing.Point(72, 284);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(121, 23);
            this.btnBin.TabIndex = 6;
            this.btnBin.Text = "Convertir a Binario";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            this.btnBin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBin_MouseClick);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(249, 284);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(114, 23);
            this.btnDec.TabIndex = 7;
            this.btnDec.Text = "Convertir a Decimal";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // cmbSigno
            // 
            this.cmbSigno.FormattingEnabled = true;
            this.cmbSigno.ItemHeight = 13;
            this.cmbSigno.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbSigno.Location = new System.Drawing.Point(156, 102);
            this.cmbSigno.Name = "cmbSigno";
            this.cmbSigno.Size = new System.Drawing.Size(121, 21);
            this.cmbSigno.TabIndex = 1;
            this.cmbSigno.SelectedIndexChanged += new System.EventHandler(this.cmbSigno_SelectedIndexChanged);
            // 
            // txbPriOperando
            // 
            this.txbPriOperando.Location = new System.Drawing.Point(36, 103);
            this.txbPriOperando.Name = "txbPriOperando";
            this.txbPriOperando.Size = new System.Drawing.Size(100, 20);
            this.txbPriOperando.TabIndex = 0;
            // 
            // txbSegOperando
            // 
            this.txbSegOperando.Location = new System.Drawing.Point(301, 103);
            this.txbSegOperando.Name = "txbSegOperando";
            this.txbSegOperando.Size = new System.Drawing.Size(100, 20);
            this.txbSegOperando.TabIndex = 2;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 336);
            this.Controls.Add(this.txbSegOperando);
            this.Controls.Add(this.txbPriOperando);
            this.Controls.Add(this.cmbSigno);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lblResultado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de Tomás Hurtado de 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.ComboBox cmbSigno;
        private System.Windows.Forms.TextBox txbPriOperando;
        private System.Windows.Forms.TextBox txbSegOperando;
    }
}

