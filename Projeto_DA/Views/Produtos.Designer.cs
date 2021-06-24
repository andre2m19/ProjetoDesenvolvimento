
namespace Projeto_DA.Views
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.lb_produtos = new System.Windows.Forms.ListBox();
            this.tb_Stock_Existente = new System.Windows.Forms.TextBox();
            this.tb_CTP = new System.Windows.Forms.TextBox();
            this.tb_Preco = new System.Windows.Forms.TextBox();
            this.tb_designacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeInscriçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_produtos
            // 
            this.lb_produtos.FormattingEnabled = true;
            this.lb_produtos.ItemHeight = 20;
            this.lb_produtos.Location = new System.Drawing.Point(27, 38);
            this.lb_produtos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_produtos.Name = "lb_produtos";
            this.lb_produtos.Size = new System.Drawing.Size(831, 244);
            this.lb_produtos.TabIndex = 24;
            // 
            // tb_Stock_Existente
            // 
            this.tb_Stock_Existente.Location = new System.Drawing.Point(245, 204);
            this.tb_Stock_Existente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Stock_Existente.Name = "tb_Stock_Existente";
            this.tb_Stock_Existente.Size = new System.Drawing.Size(112, 26);
            this.tb_Stock_Existente.TabIndex = 22;
            // 
            // tb_CTP
            // 
            this.tb_CTP.Location = new System.Drawing.Point(245, 154);
            this.tb_CTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CTP.Name = "tb_CTP";
            this.tb_CTP.Size = new System.Drawing.Size(112, 26);
            this.tb_CTP.TabIndex = 21;
            // 
            // tb_Preco
            // 
            this.tb_Preco.Location = new System.Drawing.Point(245, 104);
            this.tb_Preco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Preco.Name = "tb_Preco";
            this.tb_Preco.Size = new System.Drawing.Size(112, 26);
            this.tb_Preco.TabIndex = 20;
            // 
            // tb_designacao
            // 
            this.tb_designacao.Location = new System.Drawing.Point(245, 64);
            this.tb_designacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_designacao.Name = "tb_designacao";
            this.tb_designacao.Size = new System.Drawing.Size(112, 26);
            this.tb_designacao.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "StockExistente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "CodTipoProduto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Designcação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_produtos);
            this.groupBox1.Location = new System.Drawing.Point(32, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(884, 318);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão de Vendas de Produtos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Registar);
            this.groupBox2.Controls.Add(this.btn_Consultar);
            this.groupBox2.Controls.Add(this.btn_Apagar);
            this.groupBox2.Controls.Add(this.btn_Alterar);
            this.groupBox2.Controls.Add(this.tb_CTP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_Stock_Existente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_designacao);
            this.groupBox2.Controls.Add(this.tb_Preco);
            this.groupBox2.Location = new System.Drawing.Point(32, 424);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(904, 360);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_Registar
            // 
            this.btn_Registar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Registar.Location = new System.Drawing.Point(274, 295);
            this.btn_Registar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(106, 29);
            this.btn_Registar.TabIndex = 23;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = true;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Consultar.Location = new System.Drawing.Point(610, 295);
            this.btn_Consultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(106, 29);
            this.btn_Consultar.TabIndex = 26;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Apagar.Location = new System.Drawing.Point(386, 295);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(106, 29);
            this.btn_Apagar.TabIndex = 24;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Alterar.Location = new System.Drawing.Point(498, 295);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(106, 29);
            this.btn_Alterar.TabIndex = 25;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatosToolStripMenuItem,
            this.fichaDeInscriçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1302, 36);
            this.menuStrip1.TabIndex = 93;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formatosToolStripMenuItem
            // 
            this.formatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatoTextoToolStripMenuItem,
            this.formatoPDFToolStripMenuItem});
            this.formatosToolStripMenuItem.Name = "formatosToolStripMenuItem";
            this.formatosToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.formatosToolStripMenuItem.Text = "Ficheiros";
            // 
            // formatoTextoToolStripMenuItem
            // 
            this.formatoTextoToolStripMenuItem.Name = "formatoTextoToolStripMenuItem";
            this.formatoTextoToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.formatoTextoToolStripMenuItem.Text = "Recibo de venda";
            // 
            // formatoPDFToolStripMenuItem
            // 
            this.formatoPDFToolStripMenuItem.Name = "formatoPDFToolStripMenuItem";
            this.formatoPDFToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.formatoPDFToolStripMenuItem.Text = "Formato PDF";
            // 
            // fichaDeInscriçãoToolStripMenuItem
            // 
            this.fichaDeInscriçãoToolStripMenuItem.Name = "fichaDeInscriçãoToolStripMenuItem";
            this.fichaDeInscriçãoToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.fichaDeInscriçãoToolStripMenuItem.Text = "Recibo de venda";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 891);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Produtos";
            this.Text = " Gestão de Vendas de Produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_produtos;
        private System.Windows.Forms.TextBox tb_Stock_Existente;
        private System.Windows.Forms.TextBox tb_CTP;
        private System.Windows.Forms.TextBox tb_Preco;
        private System.Windows.Forms.TextBox tb_designacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeInscriçãoToolStripMenuItem;
    }
}