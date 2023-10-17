namespace AppDolarReal2
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
            this.components = new System.ComponentModel.Container();
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorReal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertDollar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCotacaoDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCotacaoDolar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotacaoDolar.Location = new System.Drawing.Point(308, 109);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(163, 26);
            this.txtCotacaoDolar.TabIndex = 0;
            this.txtCotacaoDolar.TextChanged += new System.EventHandler(this.txtCotacaoDolar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cotação do Dolar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor em Real";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtValorReal
            // 
            this.txtValorReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtValorReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorReal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorReal.Location = new System.Drawing.Point(308, 209);
            this.txtValorReal.Name = "txtValorReal";
            this.txtValorReal.Size = new System.Drawing.Size(163, 26);
            this.txtValorReal.TabIndex = 3;
            this.txtValorReal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 421);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Location = new System.Drawing.Point(625, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 421);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::AppDolarReal2.Properties.Resources.dinheiro;
            this.label5.Location = new System.Drawing.Point(196, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResultado.Location = new System.Drawing.Point(293, 334);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(134, 19);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "       Valor em U$:";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnConvertDollar
            // 
            this.btnConvertDollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConvertDollar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertDollar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDollar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConvertDollar.Image = global::AppDolarReal2.Properties.Resources.converter__1_;
            this.btnConvertDollar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertDollar.Location = new System.Drawing.Point(314, 282);
            this.btnConvertDollar.Name = "btnConvertDollar";
            this.btnConvertDollar.Size = new System.Drawing.Size(157, 38);
            this.btnConvertDollar.TabIndex = 5;
            this.btnConvertDollar.Text = "Converter p/ Dolar";
            this.btnConvertDollar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvertDollar.UseVisualStyleBackColor = false;
            this.btnConvertDollar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertDollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorReal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCotacaoDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorReal;
        private System.Windows.Forms.Button btnConvertDollar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}

