
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escolas));
            System.Windows.Forms.Label telefoneLabel;
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.escolaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.escolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.escolaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codPostalTextBox = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.localidadeTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxEscolas = new System.Windows.Forms.ListBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            codPostalLabel1 = new System.Windows.Forms.Label();
            localidadeLabel1 = new System.Windows.Forms.Label();
            mailLabel1 = new System.Windows.Forms.Label();
            moradaLabel1 = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingNavigator)).BeginInit();
            this.escolaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codPostalLabel1
            // 
            codPostalLabel1.AutoSize = true;
            codPostalLabel1.Location = new System.Drawing.Point(107, 92);
            codPostalLabel1.Name = "codPostalLabel1";
            codPostalLabel1.Size = new System.Drawing.Size(80, 17);
            codPostalLabel1.TabIndex = 29;
            codPostalLabel1.Text = "Cod Postal:";
            // 
            // localidadeLabel1
            // 
            localidadeLabel1.AutoSize = true;
            localidadeLabel1.Location = new System.Drawing.Point(108, 123);
            localidadeLabel1.Name = "localidadeLabel1";
            localidadeLabel1.Size = new System.Drawing.Size(81, 17);
            localidadeLabel1.TabIndex = 33;
            localidadeLabel1.Text = "Localidade:";
            // 
            // mailLabel1
            // 
            mailLabel1.AutoSize = true;
            mailLabel1.Location = new System.Drawing.Point(108, 158);
            mailLabel1.Name = "mailLabel1";
            mailLabel1.Size = new System.Drawing.Size(37, 17);
            mailLabel1.TabIndex = 35;
            mailLabel1.Text = "Mail:";
            // 
            // moradaLabel1
            // 
            moradaLabel1.AutoSize = true;
            moradaLabel1.Location = new System.Drawing.Point(108, 194);
            moradaLabel1.Name = "moradaLabel1";
            moradaLabel1.Size = new System.Drawing.Size(60, 17);
            moradaLabel1.TabIndex = 37;
            moradaLabel1.Text = "Morada:";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(108, 59);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(49, 17);
            nomeLabel1.TabIndex = 39;
            nomeLabel1.Text = "Nome:";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(794, 479);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(139, 46);
            this.btn_Alterar.TabIndex = 13;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(794, 581);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(139, 46);
            this.btn_Apagar.TabIndex = 12;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Registar
            // 
            this.btn_Registar.Location = new System.Drawing.Point(794, 388);
            this.btn_Registar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(139, 46);
            this.btn_Registar.TabIndex = 11;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = true;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // escolaBindingNavigator
            // 
            this.escolaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.escolaBindingNavigator.BindingSource = this.escolaBindingSource;
            this.escolaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.escolaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.escolaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.escolaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.escolaBindingNavigatorSaveItem});
            this.escolaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.escolaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.escolaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.escolaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.escolaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.escolaBindingNavigator.Name = "escolaBindingNavigator";
            this.escolaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.escolaBindingNavigator.Size = new System.Drawing.Size(1165, 27);
            this.escolaBindingNavigator.TabIndex = 14;
            this.escolaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // escolaBindingSource
            // 
            this.escolaBindingSource.DataSource = typeof(Projeto_DA.Base_de_dados.Escola);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // escolaBindingNavigatorSaveItem
            // 
            this.escolaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.escolaBindingNavigatorSaveItem.Enabled = false;
            this.escolaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("escolaBindingNavigatorSaveItem.Image")));
            this.escolaBindingNavigatorSaveItem.Name = "escolaBindingNavigatorSaveItem";
            this.escolaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.escolaBindingNavigatorSaveItem.Text = "Salvar Dados";
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
            this.groupBox1.Location = new System.Drawing.Point(35, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 283);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escola:";
            // 
            // codPostalTextBox
            // 
            this.codPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "CodPostal", true));
            this.codPostalTextBox.Location = new System.Drawing.Point(194, 87);
            this.codPostalTextBox.Name = "codPostalTextBox";
            this.codPostalTextBox.Size = new System.Drawing.Size(305, 22);
            this.codPostalTextBox.TabIndex = 30;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(0, 254);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 29);
            this.buttonClean.TabIndex = 26;
            this.buttonClean.Text = "Apagar";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(194, 54);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(305, 22);
            this.nomeTextBox.TabIndex = 40;
            // 
            // localidadeTextBox
            // 
            this.localidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Localidade", true));
            this.localidadeTextBox.Location = new System.Drawing.Point(194, 120);
            this.localidadeTextBox.Name = "localidadeTextBox";
            this.localidadeTextBox.Size = new System.Drawing.Size(305, 22);
            this.localidadeTextBox.TabIndex = 34;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(194, 186);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(305, 22);
            this.moradaTextBox.TabIndex = 38;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(194, 153);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(305, 22);
            this.mailTextBox.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxEscolas);
            this.groupBox2.Location = new System.Drawing.Point(35, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1110, 283);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolas:";
            // 
            // listBoxEscolas
            // 
            this.listBoxEscolas.FormattingEnabled = true;
            this.listBoxEscolas.ItemHeight = 16;
            this.listBoxEscolas.Location = new System.Drawing.Point(213, 32);
            this.listBoxEscolas.Name = "listBoxEscolas";
            this.listBoxEscolas.Size = new System.Drawing.Size(639, 228);
            this.listBoxEscolas.TabIndex = 0;
            this.listBoxEscolas.SelectedIndexChanged += new System.EventHandler(this.listBoxEscolas_SelectedIndexChanged);
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(108, 233);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(68, 17);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(194, 228);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(305, 22);
            this.telefoneTextBox.TabIndex = 14;
            this.telefoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefoneTextBox_KeyPress);
            // 
            // Escolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1165, 713);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.escolaBindingNavigator);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Registar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Escolas";
            this.Text = " Gestão de Escolas";
            this.Load += new System.EventHandler(this.Escolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingNavigator)).EndInit();
            this.escolaBindingNavigator.ResumeLayout(false);
            this.escolaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.BindingSource escolaBindingSource;
        private System.Windows.Forms.BindingNavigator escolaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton escolaBindingNavigatorSaveItem;
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