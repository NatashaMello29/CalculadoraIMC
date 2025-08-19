namespace CalculadoraIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Swis721 BlkCn BT", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(68, 44);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(197, 32);
            this.lblIMC.TabIndex = 0;
            this.lblIMC.Text = "Calcule seu IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(64, 123);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(61, 25);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(69, 187);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(68, 25);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(132, 127);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(111, 20);
            this.txbPeso.TabIndex = 3;
            this.txbPeso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPeso_KeyDown);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(143, 193);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(110, 20);
            this.txbAltura.TabIndex = 4;
            this.txbAltura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAltura_KeyDown);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Clarendon BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(69, 234);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(184, 39);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(90, 321);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(166, 25);
            this.lblCalculo.TabIndex = 6;
            this.lblCalculo.Text = "Resultado IMC";
            // 
            // txbResultado
            // 
            this.txbResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultado.Location = new System.Drawing.Point(36, 349);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(330, 29);
            this.txbResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 470);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblIMC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "\"\"Calculo do IMC\"\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.TextBox txbResultado;
    }
}

