
namespace Projeto_DA.Views
{
    partial class Escolas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codPostalLabel1;
            System.Windows.Forms.Label localidadeLabel1;
            System.Windows.Forms.Label mailLabel1;
            System.Windows.Forms.Label moradaLabel1;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escolas));
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.escolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.localidadeTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxEscolas = new System.Windows.Forms.ListBox();
            codPostalLabel1 = new System.Windows.Forms.Label();
            localidadeLabel1 = new System.Windows.Forms.Label();
            mailLabel1 = new System.Windows.Forms.Label();
            moradaLabel1 = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codPostalLabel1
            // 
            codPostalLabel1.AutoSize = true;
            codPostalLabel1.Location = new System.Drawing.Point(120, 115);
            codPostalLabel1.Name = "codPostalLabel1";
            codPostalLabel1.Size = new System.Drawing.Size(90, 20);
            codPostalLabel1.TabIndex = 29;
            codPostalLabel1.Text = "Cod Postal:";
            // 
            // localidadeLabel1
            // 
            localidadeLabel1.AutoSize = true;
            localidadeLabel1.Location = new System.Drawing.Point(122, 154);
            localidadeLabel1.Name = "localidadeLabel1";
            localidadeLabel1.Size = new System.Drawing.Size(90, 20);
            localidadeLabel1.TabIndex = 33;
            localidadeLabel1.Text = "Localidade:";
            // 
            // mailLabel1
            // 
            mailLabel1.AutoSize = true;
            mailLabel1.Location = new System.Drawing.Point(122, 198);
            mailLabel1.Name = "mailLabel1";
            mailLabel1.Size = new System.Drawing.Size(41, 20);
            mailLabel1.TabIndex = 35;
            mailLabel1.Text = "Mail:";
            // 
            // moradaLabel1
            // 
            moradaLabel1.AutoSize = true;
            moradaLabel1.Location = new System.Drawing.Point(122, 242);
            moradaLabel1.Name = "moradaLabel1";
            moradaLabel1.Size = new System.Drawing.Size(67, 20);
            moradaLabel1.TabIndex = 37;
            moradaLabel1.Text = "Morada:";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(122, 74);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(55, 20);
            nomeLabel1.TabIndex = 39;
            nomeLabel1.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(122, 291);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 20);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone:";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(893, 599);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(156, 58);
            this.btn_Alterar.TabIndex = 13;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(893, 726);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(156, 58);
            this.btn_Apagar.TabIndex = 12;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Registar
            // 
            this.btn_Registar.Location = new System.Drawing.Point(893, 485);
            this.btn_Registar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(156, 58);
            this.btn_Registar.TabIndex = 11;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = true;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // escolaBindingSource
            // 
            this.escolaBindingSource.DataSource = typeof(Projeto_DA.Base_de_dados.Escola);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(codPostalLabel1);
            this.groupBox1.Controls.Add(this.codPostalTextBox);
            this.groupBox1.Controls.Add(this.buttonClean);
            this.groupBox1.Controls.Add(localidadeLabel1);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(this.localidadeTextBox);
            this.groupBox1.Controls.Add(nomeLabel1);
            this.groupBox1.Controls.Add(mailLabel1);
            this.groupBox1.Controls.Add(this.moradaTextBox);
            this.groupBox1.Controls.Add(this.mailTextBox);
            this.groupBox1.Controls.Add(moradaLabel1);
            this.groupBox1.Location = new System.Drawing.Point(39, 454);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(684, 354);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(218, 285);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(343, 26);
            this.telefoneTextBox.TabIndex = 14;
            this.telefoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefoneTextBox_KeyPress);
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "CodPostal", true));
            this.codPostalTextBox.Location = new System.Drawing.Point(218, 109);
            this.codPostalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(343, 26);
            this.codPostalTextBox.TabIndex = 30;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(0, 318);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(84, 36);
            this.buttonClean.TabIndex = 26;
            this.buttonClean.Text = "Apagar";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(218, 68);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(343, 26);
            this.nomeTextBox.TabIndex = 40;
            // 
            // localidadeTextBox
            // 
            this.localidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Localidade", true));
            this.localidadeTextBox.Location = new System.Drawing.Point(218, 150);
            this.localidadeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.localidadeTextBox.Name = "localidadeTextBox";
            this.localidadeTextBox.Size = new System.Drawing.Size(343, 26);
            this.localidadeTextBox.TabIndex = 34;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(218, 232);
            this.moradaTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(343, 26);
            this.moradaTextBox.TabIndex = 38;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(218, 191);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(343, 26);
            this.mailTextBox.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxEscolas);
            this.groupBox2.Location = new System.Drawing.Point(50, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1249, 354);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolas:";
            // 
            // listBoxEscolas
            // 
            this.listBoxEscolas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxEscolas.FormattingEnabled = true;
            this.listBoxEscolas.ItemHeight = 20;
            this.listBoxEscolas.Location = new System.Drawing.Point(240, 40);
            this.listBoxEscolas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxEscolas.Name = "listBoxEscolas";
            this.listBoxEscolas.Size = new System.Drawing.Size(718, 284);
            this.listBoxEscolas.TabIndex = 0;
            this.listBoxEscolas.SelectedIndexChanged += new System.EventHandler(this.listBoxEscolas_SelectedIndexChanged);
            // 
            // Escolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1311, 891);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Registar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Escolas";
            this.Text = " Gestão de Escolas";
            this.Load += new System.EventHandler(this.Escolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.BindingSource escolaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxEscolas;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.TextBox codPostalTextBox;
        private System.Windows.Forms.TextBox localidadeTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
    }
}