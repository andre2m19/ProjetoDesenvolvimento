
namespace Projeto_DA.Views
{
    partial class Animacao
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
            System.Windows.Forms.Label especialidadeLabel;
            System.Windows.Forms.Label localidadeLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animacao));
            this.btn_Registar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.animadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadeTextBox = new System.Windows.Forms.TextBox();
            this.localidadeTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxAnimadores = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxPessoas = new System.Windows.Forms.ListBox();
            especialidadeLabel = new System.Windows.Forms.Label();
            localidadeLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animadorBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(163, 713);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(112, 20);
            especialidadeLabel.TabIndex = 8;
            especialidadeLabel.Text = "Especialidade:";
            // 
            // localidadeLabel
            // 
            localidadeLabel.AutoSize = true;
            localidadeLabel.Location = new System.Drawing.Point(163, 588);
            localidadeLabel.Name = "localidadeLabel";
            localidadeLabel.Size = new System.Drawing.Size(90, 20);
            localidadeLabel.TabIndex = 12;
            localidadeLabel.Text = "Localidade:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(163, 650);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(41, 20);
            mailLabel.TabIndex = 14;
            mailLabel.Text = "Mail:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(163, 525);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 18;
            nomeLabel.Text = "Nome:";
            // 
            // btn_Registar
            // 
            this.btn_Registar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registar.Location = new System.Drawing.Point(924, 489);
            this.btn_Registar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(156, 58);
            this.btn_Registar.TabIndex = 1;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = true;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Apagar.Location = new System.Drawing.Point(924, 694);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(156, 58);
            this.btn_Apagar.TabIndex = 2;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.Location = new System.Drawing.Point(924, 592);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(156, 58);
            this.btn_Alterar.TabIndex = 3;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voltar";
            // 
            // animadorBindingSource
            // 
            this.animadorBindingSource.DataSource = typeof(Projeto_DA.Base_de_dados.Animador);
            // 
            // especialidadeTextBox
            // 
            this.especialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animadorBindingSource, "Especialidade", true));
            this.especialidadeTextBox.Location = new System.Drawing.Point(324, 706);
            this.especialidadeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.especialidadeTextBox.Name = "especialidadeTextBox";
            this.especialidadeTextBox.Size = new System.Drawing.Size(258, 26);
            this.especialidadeTextBox.TabIndex = 9;
            // 
            // localidadeTextBox
            // 
            this.localidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animadorBindingSource, "Localidade", true));
            this.localidadeTextBox.Location = new System.Drawing.Point(324, 582);
            this.localidadeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.localidadeTextBox.Name = "localidadeTextBox";
            this.localidadeTextBox.Size = new System.Drawing.Size(258, 26);
            this.localidadeTextBox.TabIndex = 13;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animadorBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(324, 644);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(258, 26);
            this.mailTextBox.TabIndex = 15;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animadorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(324, 519);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(258, 26);
            this.nomeTextBox.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(55, 452);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(603, 344);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animador:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxAnimadores);
            this.groupBox2.Location = new System.Drawing.Point(699, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(578, 344);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animadores:";
            // 
            // listBoxAnimadores
            // 
            this.listBoxAnimadores.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxAnimadores.FormattingEnabled = true;
            this.listBoxAnimadores.ItemHeight = 20;
            this.listBoxAnimadores.Location = new System.Drawing.Point(20, 26);
            this.listBoxAnimadores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxAnimadores.Name = "listBoxAnimadores";
            this.listBoxAnimadores.Size = new System.Drawing.Size(541, 284);
            this.listBoxAnimadores.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxPessoas);
            this.groupBox3.Location = new System.Drawing.Point(56, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(603, 344);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pessoas:";
            // 
            // listBoxPessoas
            // 
            this.listBoxPessoas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxPessoas.FormattingEnabled = true;
            this.listBoxPessoas.ItemHeight = 20;
            this.listBoxPessoas.Location = new System.Drawing.Point(22, 26);
            this.listBoxPessoas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxPessoas.Name = "listBoxPessoas";
            this.listBoxPessoas.Size = new System.Drawing.Size(556, 284);
            this.listBoxPessoas.TabIndex = 0;
            this.listBoxPessoas.SelectedIndexChanged += new System.EventHandler(this.listBoxPessoas_SelectedIndexChanged);
            // 
            // Animacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1302, 891);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(especialidadeLabel);
            this.Controls.Add(this.especialidadeTextBox);
            this.Controls.Add(localidadeLabel);
            this.Controls.Add(this.localidadeTextBox);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Registar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Animacao";
            this.Text = " Gestão de Animadores ";
            this.Load += new System.EventHandler(this.Animacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animadorBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource animadorBindingSource;
        private System.Windows.Forms.TextBox especialidadeTextBox;
        private System.Windows.Forms.TextBox localidadeTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxAnimadores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxPessoas;
    }
}