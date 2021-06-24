
namespace Projeto_DA.Views
{
    partial class Compras
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label produtosCodProdutoLabel;
            System.Windows.Forms.Label utilizouCartaoLabel;
            System.Windows.Forms.Label clientes_IdPessoaLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_registar_produtos_vendidos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_clientesIdPessoa = new System.Windows.Forms.TextBox();
            this.tp_data = new System.Windows.Forms.DateTimePicker();
            this.tb_produtosCodProduto = new System.Windows.Forms.TextBox();
            this.tb_utilizouCartao = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            dataLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            produtosCodProdutoLabel = new System.Windows.Forms.Label();
            utilizouCartaoLabel = new System.Windows.Forms.Label();
            clientes_IdPessoaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(25, 185);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(48, 20);
            dataLabel.TabIndex = 13;
            dataLabel.Text = "Data:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(25, 48);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(80, 20);
            idClienteLabel.TabIndex = 15;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // produtosCodProdutoLabel
            // 
            produtosCodProdutoLabel.AutoSize = true;
            produtosCodProdutoLabel.Location = new System.Drawing.Point(25, 310);
            produtosCodProdutoLabel.Name = "produtosCodProdutoLabel";
            produtosCodProdutoLabel.Size = new System.Drawing.Size(170, 20);
            produtosCodProdutoLabel.TabIndex = 19;
            produtosCodProdutoLabel.Text = "Produtos Cod Produto:";
            // 
            // utilizouCartaoLabel
            // 
            utilizouCartaoLabel.AutoSize = true;
            utilizouCartaoLabel.Location = new System.Drawing.Point(25, 246);
            utilizouCartaoLabel.Name = "utilizouCartaoLabel";
            utilizouCartaoLabel.Size = new System.Drawing.Size(117, 20);
            utilizouCartaoLabel.TabIndex = 21;
            utilizouCartaoLabel.Text = "Utilizou Cartao:";
            // 
            // clientes_IdPessoaLabel
            // 
            clientes_IdPessoaLabel.AutoSize = true;
            clientes_IdPessoaLabel.Location = new System.Drawing.Point(20, 114);
            clientes_IdPessoaLabel.Name = "clientes_IdPessoaLabel";
            clientes_IdPessoaLabel.Size = new System.Drawing.Size(145, 20);
            clientes_IdPessoaLabel.TabIndex = 25;
            clientes_IdPessoaLabel.Text = "Clientes Id Pessoa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 376);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 20);
            label1.TabIndex = 42;
            label1.Text = "Quantidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_registar_produtos_vendidos);
            this.groupBox1.Location = new System.Drawing.Point(608, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(633, 352);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão de produtos vendidos";
            // 
            // lb_registar_produtos_vendidos
            // 
            this.lb_registar_produtos_vendidos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lb_registar_produtos_vendidos.FormattingEnabled = true;
            this.lb_registar_produtos_vendidos.ItemHeight = 20;
            this.lb_registar_produtos_vendidos.Location = new System.Drawing.Point(24, 44);
            this.lb_registar_produtos_vendidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_registar_produtos_vendidos.Name = "lb_registar_produtos_vendidos";
            this.lb_registar_produtos_vendidos.Size = new System.Drawing.Size(587, 284);
            this.lb_registar_produtos_vendidos.TabIndex = 47;
            this.lb_registar_produtos_vendidos.SelectedIndexChanged += new System.EventHandler(this.lb_registar_produtos_vendidos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_quantidade);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.tb_clientesIdPessoa);
            this.groupBox2.Controls.Add(dataLabel);
            this.groupBox2.Controls.Add(this.tp_data);
            this.groupBox2.Controls.Add(clientes_IdPessoaLabel);
            this.groupBox2.Controls.Add(produtosCodProdutoLabel);
            this.groupBox2.Controls.Add(this.tb_produtosCodProduto);
            this.groupBox2.Controls.Add(utilizouCartaoLabel);
            this.groupBox2.Controls.Add(this.tb_utilizouCartao);
            this.groupBox2.Controls.Add(idClienteLabel);
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Location = new System.Drawing.Point(21, 418);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(652, 460);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(234, 372);
            this.tb_quantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(344, 26);
            this.tb_quantidade.TabIndex = 43;
            // 
            // tb_clientesIdPessoa
            // 
            this.tb_clientesIdPessoa.Location = new System.Drawing.Point(234, 108);
            this.tb_clientesIdPessoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_clientesIdPessoa.Name = "tb_clientesIdPessoa";
            this.tb_clientesIdPessoa.Size = new System.Drawing.Size(172, 26);
            this.tb_clientesIdPessoa.TabIndex = 41;
            // 
            // tp_data
            // 
            this.tp_data.Location = new System.Drawing.Point(234, 174);
            this.tp_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_data.Name = "tp_data";
            this.tp_data.Size = new System.Drawing.Size(344, 26);
            this.tp_data.TabIndex = 14;
            // 
            // tb_produtosCodProduto
            // 
            this.tb_produtosCodProduto.Location = new System.Drawing.Point(234, 306);
            this.tb_produtosCodProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_produtosCodProduto.Name = "tb_produtosCodProduto";
            this.tb_produtosCodProduto.Size = new System.Drawing.Size(344, 26);
            this.tb_produtosCodProduto.TabIndex = 20;
            // 
            // tb_utilizouCartao
            // 
            this.tb_utilizouCartao.Location = new System.Drawing.Point(234, 240);
            this.tb_utilizouCartao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_utilizouCartao.Name = "tb_utilizouCartao";
            this.tb_utilizouCartao.Size = new System.Drawing.Size(344, 26);
            this.tb_utilizouCartao.TabIndex = 22;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(234, 41);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(172, 26);
            this.tb_id.TabIndex = 16;
            // 
            // btn_Registar
            // 
            this.btn_Registar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Registar.Location = new System.Drawing.Point(893, 465);
            this.btn_Registar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(179, 88);
            this.btn_Registar.TabIndex = 10;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = true;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click_1);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Apagar.Location = new System.Drawing.Point(893, 732);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(179, 88);
            this.btn_Apagar.TabIndex = 11;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Alterar.Location = new System.Drawing.Point(893, 599);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(179, 88);
            this.btn_Alterar.TabIndex = 12;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxClientes);
            this.groupBox3.Location = new System.Drawing.Point(45, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(530, 352);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes:";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 20;
            this.listBoxClientes.Location = new System.Drawing.Point(24, 44);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(474, 284);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1302, 891);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Registar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Alterar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Compras";
            this.Text = " Gestão de Produtos Vendidos";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker tp_data;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_produtosCodProduto;
        private System.Windows.Forms.TextBox tb_utilizouCartao;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.ListBox lb_registar_produtos_vendidos;
        private System.Windows.Forms.TextBox tb_clientesIdPessoa;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxClientes;
    }
}