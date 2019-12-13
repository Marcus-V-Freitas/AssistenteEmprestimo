namespace AssistenteEmprestimo
{
    partial class frmPrincipal
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblPagamentos = new System.Windows.Forms.Label();
            this.lblAnalise = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.txtAnalise = new System.Windows.Forms.TextBox();
            this.lblMensal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(24, 56);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(165, 20);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo do Empréstimo:";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(24, 110);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(112, 20);
            this.lblTaxa.TabIndex = 1;
            this.lblTaxa.Text = "Taxa de Juros:";
            // 
            // lblPagamentos
            // 
            this.lblPagamentos.AutoSize = true;
            this.lblPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamentos.Location = new System.Drawing.Point(24, 169);
            this.lblPagamentos.Name = "lblPagamentos";
            this.lblPagamentos.Size = new System.Drawing.Size(185, 20);
            this.lblPagamentos.TabIndex = 2;
            this.lblPagamentos.Text = "Número de Pagamentos:";
            // 
            // lblAnalise
            // 
            this.lblAnalise.AutoSize = true;
            this.lblAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalise.Location = new System.Drawing.Point(571, 50);
            this.lblAnalise.Name = "lblAnalise";
            this.lblAnalise.Size = new System.Drawing.Size(176, 20);
            this.lblAnalise.TabIndex = 3;
            this.lblAnalise.Text = "Análise do Empréstimo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(215, 50);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(236, 26);
            this.txtSaldo.TabIndex = 4;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxa.Location = new System.Drawing.Point(215, 107);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(236, 26);
            this.txtTaxa.TabIndex = 5;
            this.txtTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxa_KeyPress);
            // 
            // txtMeses
            // 
            this.txtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeses.Location = new System.Drawing.Point(215, 166);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(236, 26);
            this.txtMeses.TabIndex = 6;
            this.txtMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            // 
            // txtPagamento
            // 
            this.txtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.Location = new System.Drawing.Point(215, 222);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(236, 26);
            this.txtPagamento.TabIndex = 7;
            this.txtPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagamento_KeyPress);
            // 
            // txtAnalise
            // 
            this.txtAnalise.BackColor = System.Drawing.Color.White;
            this.txtAnalise.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnalise.Location = new System.Drawing.Point(545, 83);
            this.txtAnalise.Multiline = true;
            this.txtAnalise.Name = "txtAnalise";
            this.txtAnalise.ReadOnly = true;
            this.txtAnalise.Size = new System.Drawing.Size(218, 223);
            this.txtAnalise.TabIndex = 8;
            // 
            // lblMensal
            // 
            this.lblMensal.AutoSize = true;
            this.lblMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensal.Location = new System.Drawing.Point(24, 225);
            this.lblMensal.Name = "lblMensal";
            this.lblMensal.Size = new System.Drawing.Size(150, 20);
            this.lblMensal.TabIndex = 9;
            this.lblMensal.Text = "Pagamento Mensal:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(28, 286);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(250, 37);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Pagamento Mensal";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Enabled = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(28, 344);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(250, 37);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo Empréstimo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(688, 358);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnMeses
            // 
            this.btnMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeses.Location = new System.Drawing.Point(490, 166);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(46, 23);
            this.btnMeses.TabIndex = 13;
            this.btnMeses.Text = "X";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamentos.Location = new System.Drawing.Point(490, 225);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(46, 23);
            this.btnPagamentos.TabIndex = 14;
            this.btnPagamentos.Text = "X";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMensal);
            this.Controls.Add(this.txtAnalise);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblAnalise);
            this.Controls.Add(this.lblPagamentos);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.lblSaldo);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Assistente de Empréstimo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblPagamentos;
        private System.Windows.Forms.Label lblAnalise;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.TextBox txtAnalise;
        private System.Windows.Forms.Label lblMensal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.Button btnPagamentos;
    }
}

