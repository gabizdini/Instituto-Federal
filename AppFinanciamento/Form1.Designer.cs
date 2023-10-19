namespace AppFinanciamento
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
            this.txtValorPrincipal = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTaxaAnual = new System.Windows.Forms.TextBox();
            this.txtNumParcelas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblTotalJuros = new System.Windows.Forms.Label();
            this.lblTotalpago = new System.Windows.Forms.Label();
            this.btnCalcularJuros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtValorPrincipal
            // 
            this.txtValorPrincipal.Location = new System.Drawing.Point(256, 111);
            this.txtValorPrincipal.Name = "txtValorPrincipal";
            this.txtValorPrincipal.Size = new System.Drawing.Size(125, 20);
            this.txtValorPrincipal.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTaxaAnual
            // 
            this.txtTaxaAnual.Location = new System.Drawing.Point(255, 192);
            this.txtTaxaAnual.Name = "txtTaxaAnual";
            this.txtTaxaAnual.Size = new System.Drawing.Size(125, 20);
            this.txtTaxaAnual.TabIndex = 2;
            // 
            // txtNumParcelas
            // 
            this.txtNumParcelas.Location = new System.Drawing.Point(255, 276);
            this.txtNumParcelas.Name = "txtNumParcelas";
            this.txtNumParcelas.Size = new System.Drawing.Size(125, 20);
            this.txtNumParcelas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Principal do Empréstimo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Taxa de Juros Anual (%): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de Parcelas:";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorParcela.Location = new System.Drawing.Point(447, 154);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(116, 16);
            this.lblValorParcela.TabIndex = 7;
            this.lblValorParcela.Text = "Valor da parcela:";
            // 
            // lblTotalJuros
            // 
            this.lblTotalJuros.AutoSize = true;
            this.lblTotalJuros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalJuros.Location = new System.Drawing.Point(447, 192);
            this.lblTotalJuros.Name = "lblTotalJuros";
            this.lblTotalJuros.Size = new System.Drawing.Size(101, 16);
            this.lblTotalJuros.TabIndex = 8;
            this.lblTotalJuros.Text = "Total em juros:";
            // 
            // lblTotalpago
            // 
            this.lblTotalpago.AutoSize = true;
            this.lblTotalpago.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalpago.Location = new System.Drawing.Point(447, 231);
            this.lblTotalpago.Name = "lblTotalpago";
            this.lblTotalpago.Size = new System.Drawing.Size(79, 16);
            this.lblTotalpago.TabIndex = 9;
            this.lblTotalpago.Text = "Total Pago:";
            // 
            // btnCalcularJuros
            // 
            this.btnCalcularJuros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularJuros.Location = new System.Drawing.Point(257, 328);
            this.btnCalcularJuros.Name = "btnCalcularJuros";
            this.btnCalcularJuros.Size = new System.Drawing.Size(124, 24);
            this.btnCalcularJuros.TabIndex = 10;
            this.btnCalcularJuros.Text = "Calcular Juros";
            this.btnCalcularJuros.UseVisualStyleBackColor = true;
            this.btnCalcularJuros.Click += new System.EventHandler(this.btnCalcularJuros_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 444);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(623, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 444);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcularJuros);
            this.Controls.Add(this.lblTotalpago);
            this.Controls.Add(this.lblTotalJuros);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumParcelas);
            this.Controls.Add(this.txtTaxaAnual);
            this.Controls.Add(this.txtValorPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorPrincipal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTaxaAnual;
        private System.Windows.Forms.TextBox txtNumParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblTotalJuros;
        private System.Windows.Forms.Label lblTotalpago;
        private System.Windows.Forms.Button btnCalcularJuros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

