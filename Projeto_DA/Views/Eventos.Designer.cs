
namespace Projeto_DA.Views
{
    partial class Eventos
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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.tb_Idade_Superior = new System.Windows.Forms.TextBox();
            this.tb_tipo_evento = new System.Windows.Forms.TextBox();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.tb_limite_participacoes = new System.Windows.Forms.TextBox();
            this.tb_Idade_Inferior = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.dtp_Data_Hora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_registar_eventos = new System.Windows.Forms.ListBox();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bg_eventos = new System.Windows.Forms.GroupBox();
            this.gb_dados = new System.Windows.Forms.GroupBox();
            this.tb_confirmada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialogTexto = new System.Windows.Forms.SaveFileDialog();
            this.colaboracoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label11 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.bg_eventos.SuspendLayout();
            this.gb_dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(47, 610);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(118, 20);
            label11.TabIndex = 87;
            label11.Text = "Idade Superior:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(47, 652);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(151, 20);
            label7.TabIndex = 78;
            label7.Text = "Limite Partcipacoes:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(47, 700);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(51, 20);
            label8.TabIndex = 79;
            label8.Text = "Local:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(47, 752);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(97, 20);
            label10.TabIndex = 80;
            label10.Text = "Tipo Evento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(45, 573);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 20);
            label3.TabIndex = 77;
            label3.Text = "Idade Inferior:";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(577, 436);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(106, 29);
            this.btn_alterar.TabIndex = 90;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(463, 436);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(106, 29);
            this.btn_Apagar.TabIndex = 89;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // tb_Idade_Superior
            // 
            this.tb_Idade_Superior.Location = new System.Drawing.Point(245, 615);
            this.tb_Idade_Superior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Idade_Superior.Name = "tb_Idade_Superior";
            this.tb_Idade_Superior.Size = new System.Drawing.Size(118, 26);
            this.tb_Idade_Superior.TabIndex = 88;
            // 
            // tb_tipo_evento
            // 
            this.tb_tipo_evento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracoesBindingSource, "Eventos.TipoEvento", true));
            this.tb_tipo_evento.Location = new System.Drawing.Point(245, 748);
            this.tb_tipo_evento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tipo_evento.Name = "tb_tipo_evento";
            this.tb_tipo_evento.Size = new System.Drawing.Size(118, 26);
            this.tb_tipo_evento.TabIndex = 86;
            // 
            // tb_local
            // 
            this.tb_local.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracoesBindingSource, "Eventos.Local", true));
            this.tb_local.Location = new System.Drawing.Point(245, 700);
            this.tb_local.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(118, 26);
            this.tb_local.TabIndex = 85;
            // 
            // tb_limite_participacoes
            // 
            this.tb_limite_participacoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracoesBindingSource, "Eventos.Local", true));
            this.tb_limite_participacoes.Location = new System.Drawing.Point(245, 652);
            this.tb_limite_participacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_limite_participacoes.Name = "tb_limite_participacoes";
            this.tb_limite_participacoes.Size = new System.Drawing.Size(118, 26);
            this.tb_limite_participacoes.TabIndex = 84;
            // 
            // tb_Idade_Inferior
            // 
            this.tb_Idade_Inferior.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracoesBindingSource, "Eventos.IdadeInferior", true));
            this.tb_Idade_Inferior.Location = new System.Drawing.Point(245, 575);
            this.tb_Idade_Inferior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Idade_Inferior.Name = "tb_Idade_Inferior";
            this.tb_Idade_Inferior.Size = new System.Drawing.Size(118, 26);
            this.tb_Idade_Inferior.TabIndex = 83;
            // 
            // tb_descricao
            // 
            this.tb_descricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracoesBindingSource, "Eventos.Descricao", true));
            this.tb_descricao.Location = new System.Drawing.Point(245, 532);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(118, 26);
            this.tb_descricao.TabIndex = 82;
            // 
            // dtp_Data_Hora
            // 
            this.dtp_Data_Hora.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.colaboracoesBindingSource, "Eventos.DataHora", true));
            this.dtp_Data_Hora.Location = new System.Drawing.Point(245, 496);
            this.dtp_Data_Hora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Data_Hora.Name = "dtp_Data_Hora";
            this.dtp_Data_Hora.Size = new System.Drawing.Size(210, 26);
            this.dtp_Data_Hora.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Descricao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Data Hora:";
            // 
            // lb_registar_eventos
            // 
            this.lb_registar_eventos.FormattingEnabled = true;
            this.lb_registar_eventos.ItemHeight = 20;
            this.lb_registar_eventos.Location = new System.Drawing.Point(26, 40);
            this.lb_registar_eventos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_registar_eventos.Name = "lb_registar_eventos";
            this.lb_registar_eventos.Size = new System.Drawing.Size(1224, 264);
            this.lb_registar_eventos.TabIndex = 74;
            // 
            // btn_Registar
            // 
            this.btn_Registar.Location = new System.Drawing.Point(351, 436);
            this.btn_Registar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(106, 29);
            this.btn_Registar.TabIndex = 73;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = true;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1351, 33);
            this.menuStrip1.TabIndex = 92;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formatosToolStripMenuItem
            // 
            this.formatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatoTextoToolStripMenuItem,
            this.formatoPDFToolStripMenuItem});
            this.formatosToolStripMenuItem.Name = "formatosToolStripMenuItem";
            this.formatosToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.formatosToolStripMenuItem.Text = "Ficheiros";
            // 
            // formatoTextoToolStripMenuItem
            // 
            this.formatoTextoToolStripMenuItem.Name = "formatoTextoToolStripMenuItem";
            this.formatoTextoToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.formatoTextoToolStripMenuItem.Text = "Lista de inscriçoes do evento";
            this.formatoTextoToolStripMenuItem.Click += new System.EventHandler(this.formatoTextoToolStripMenuItem_Click);
            // 
            // formatoPDFToolStripMenuItem
            // 
            this.formatoPDFToolStripMenuItem.Name = "formatoPDFToolStripMenuItem";
            this.formatoPDFToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.formatoPDFToolStripMenuItem.Text = "Ficha de inscrição";
            this.formatoPDFToolStripMenuItem.Click += new System.EventHandler(this.formatoPDFToolStripMenuItem_Click);
            // 
            // bg_eventos
            // 
            this.bg_eventos.Controls.Add(this.lb_registar_eventos);
            this.bg_eventos.Location = new System.Drawing.Point(25, 62);
            this.bg_eventos.Name = "bg_eventos";
            this.bg_eventos.Size = new System.Drawing.Size(1272, 324);
            this.bg_eventos.TabIndex = 94;
            this.bg_eventos.TabStop = false;
            this.bg_eventos.Text = "Gestão de Eventos";
            // 
            // gb_dados
            // 
            this.gb_dados.Controls.Add(this.btn_alterar);
            this.gb_dados.Controls.Add(this.tb_confirmada);
            this.gb_dados.Controls.Add(this.btn_Apagar);
            this.gb_dados.Controls.Add(this.label4);
            this.gb_dados.Controls.Add(this.btn_Registar);
            this.gb_dados.Location = new System.Drawing.Point(25, 424);
            this.gb_dados.Name = "gb_dados";
            this.gb_dados.Size = new System.Drawing.Size(1272, 522);
            this.gb_dados.TabIndex = 95;
            this.gb_dados.TabStop = false;
            this.gb_dados.Text = "Dados";
            // 
            // tb_confirmada
            // 
            this.tb_confirmada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboracoesBindingSource, "Eventos.TipoEvento", true));
            this.tb_confirmada.Location = new System.Drawing.Point(220, 374);
            this.tb_confirmada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_confirmada.Name = "tb_confirmada";
            this.tb_confirmada.Size = new System.Drawing.Size(118, 26);
            this.tb_confirmada.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Confirmada";
            // 
            // colaboracoesBindingSource
            // 
            this.colaboracoesBindingSource.DataSource = typeof(Projeto_DA.Base_de_dados.Colaboracao);
            // 
            // participacoesBindingSource
            // 
            this.participacoesBindingSource.DataSource = typeof(Projeto_DA.Base_de_dados.Participacao);
            // 
            // inscricaosBindingSource
            // 
            this.inscricaosBindingSource.DataSource = typeof(Projeto_DA.Base_de_dados.Inscricao);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1351, 1050);
            this.Controls.Add(this.tb_Idade_Superior);
            this.Controls.Add(label11);
            this.Controls.Add(this.tb_tipo_evento);
            this.Controls.Add(this.tb_local);
            this.Controls.Add(this.tb_limite_participacoes);
            this.Controls.Add(this.tb_Idade_Inferior);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.dtp_Data_Hora);
            this.Controls.Add(label7);
            this.Controls.Add(label8);
            this.Controls.Add(label10);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bg_eventos);
            this.Controls.Add(this.gb_dados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Eventos";
            this.Text = " Gestão de Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bg_eventos.ResumeLayout(false);
            this.gb_dados.ResumeLayout(false);
            this.gb_dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboracoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource participacoesBindingSource;
        private System.Windows.Forms.BindingSource inscricaosBindingSource;
        private System.Windows.Forms.BindingSource colaboracoesBindingSource;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.TextBox tb_Idade_Superior;
        private System.Windows.Forms.TextBox tb_tipo_evento;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.TextBox tb_limite_participacoes;
        private System.Windows.Forms.TextBox tb_Idade_Inferior;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.DateTimePicker dtp_Data_Hora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_registar_eventos;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox bg_eventos;
        private System.Windows.Forms.GroupBox gb_dados;
        private System.Windows.Forms.TextBox tb_confirmada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTexto;
        private System.Windows.Forms.ToolStripMenuItem formatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoPDFToolStripMenuItem;
    }
}