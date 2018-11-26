namespace AppControle_Processo.Formularios
{
    partial class frmAtualizar
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.lblDt_Movi = new System.Windows.Forms.Label();
            this.txtDt_Movi = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMovi = new System.Windows.Forms.Label();
            this.txtMovimentacao = new System.Windows.Forms.TextBox();
            this.grpProcesso = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnArquivar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpProcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(109, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(15, 32);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(72, 13);
            this.lblProcesso.TabIndex = 1;
            this.lblProcesso.Text = "Nº Processo :";
            // 
            // lblDt_Movi
            // 
            this.lblDt_Movi.AutoSize = true;
            this.lblDt_Movi.Location = new System.Drawing.Point(15, 54);
            this.lblDt_Movi.Name = "lblDt_Movi";
            this.lblDt_Movi.Size = new System.Drawing.Size(36, 13);
            this.lblDt_Movi.TabIndex = 2;
            this.lblDt_Movi.Text = "Data :";
            // 
            // txtDt_Movi
            // 
            this.txtDt_Movi.Location = new System.Drawing.Point(109, 51);
            this.txtDt_Movi.Name = "txtDt_Movi";
            this.txtDt_Movi.Size = new System.Drawing.Size(100, 20);
            this.txtDt_Movi.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // lblMovi
            // 
            this.lblMovi.AutoSize = true;
            this.lblMovi.Location = new System.Drawing.Point(15, 77);
            this.lblMovi.Name = "lblMovi";
            this.lblMovi.Size = new System.Drawing.Size(83, 13);
            this.lblMovi.TabIndex = 10;
            this.lblMovi.Text = "Movimentação :";
            // 
            // txtMovimentacao
            // 
            this.txtMovimentacao.Location = new System.Drawing.Point(109, 77);
            this.txtMovimentacao.Multiline = true;
            this.txtMovimentacao.Name = "txtMovimentacao";
            this.txtMovimentacao.Size = new System.Drawing.Size(597, 103);
            this.txtMovimentacao.TabIndex = 9;
            // 
            // grpProcesso
            // 
            this.grpProcesso.Controls.Add(this.txtDt_Movi);
            this.grpProcesso.Controls.Add(this.lblMovi);
            this.grpProcesso.Controls.Add(this.txtNumero);
            this.grpProcesso.Controls.Add(this.txtMovimentacao);
            this.grpProcesso.Controls.Add(this.lblProcesso);
            this.grpProcesso.Controls.Add(this.lblDt_Movi);
            this.grpProcesso.Location = new System.Drawing.Point(31, 63);
            this.grpProcesso.Name = "grpProcesso";
            this.grpProcesso.Size = new System.Drawing.Size(734, 244);
            this.grpProcesso.TabIndex = 11;
            this.grpProcesso.TabStop = false;
            this.grpProcesso.Text = "Processo";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(287, 324);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnArquivar
            // 
            this.btnArquivar.Location = new System.Drawing.Point(378, 324);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(75, 23);
            this.btnArquivar.TabIndex = 12;
            this.btnArquivar.Text = "ARQUIVAR";
            this.btnArquivar.UseVisualStyleBackColor = true;
            this.btnArquivar.Click += new System.EventHandler(this.btnArquivar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(469, 324);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.grpProcesso);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAtualizar";
            this.Text = "Movimentação";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpProcesso.ResumeLayout(false);
            this.grpProcesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Label lblDt_Movi;
        private System.Windows.Forms.TextBox txtDt_Movi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Label lblMovi;
        private System.Windows.Forms.TextBox txtMovimentacao;
        private System.Windows.Forms.GroupBox grpProcesso;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnArquivar;
        private System.Windows.Forms.Button btnLimpar;
    }
}