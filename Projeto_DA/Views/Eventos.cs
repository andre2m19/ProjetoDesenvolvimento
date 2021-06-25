using Projeto_DA.Base_de_dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Eventos : Form
    {
       
        private BooKidsContainer4 booKidsContainer4;
       
        public Eventos()
        {
            InitializeComponent();
            booKidsContainer4 = new BooKidsContainer4();
        }

        // ----------------- Registar Evento -------------------------
        private void btn_Registar_Click(object sender, EventArgs e)
        {
            string Descricao = tb_descricao.Text;
            string Local = tb_local.Text;
            DateTime DataHora = dtp_Data_Hora.Value;
            string LimiteParticipacoes = tb_limite_participacoes.Text;
            int IdadeSuperior = int.Parse(tb_Idade_Superior.Text);
            int IdadeInferior = int.Parse(tb_Idade_Inferior.Text);
            string TipoEvento = tb_tipo_evento.Text;
            
            // Instanciar Evento
            Evento evento = new Evento(Descricao, Local, DataHora, LimiteParticipacoes, IdadeSuperior, IdadeInferior, TipoEvento);

            // Função que vai verificar a idade inferior e superior
            if (IdadeInferior < 18 && IdadeSuperior >= 18)
            {
                MessageBox.Show("A sua Idade é inferior a 18 e a sua idade é superior a 18 anos", "Caixa de dialogo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Adiciona um Evento
                booKidsContainer4.Eventoes.Add(evento);

                // Atualiza a base de dados
                lb_registar_eventos.DataSource = null;
                lb_registar_eventos.DataSource = booKidsContainer4.Eventoes.ToList<Evento>();
               
                // Salva as alterações
                booKidsContainer4.SaveChanges();
            }
            else
            {    // Mensagem de aviso caso a idade esteja incorreta
                MessageBox.Show("A sua idade tem que ser inferior a 18" + "\n" + "A sua idade superior tem que ser superior a 18 ", "Messangem de Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // --------------------- Função LerDados ---------------------------
        private void LerDados()
        {
            lb_registar_eventos.DataSource = booKidsContainer4.Eventoes.ToList<Evento>();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            booKidsContainer4 = new BooKidsContainer4();
           
            // Chama a função LerDados
            LerDados();
        }

        // ----------------------- Apagar Evento -------------------------
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (lb_registar_eventos.SelectedIndex == 1)
                return;
            Evento eventoSelecionado = (Evento)lb_registar_eventos.SelectedItem;
            
            // Remove um Evento
            booKidsContainer4.Eventoes.Remove(eventoSelecionado);

            // Salva as alterações
            booKidsContainer4.SaveChanges();

            // Atualiza a base de dados
            lb_registar_eventos.DataSource = null;
            lb_registar_eventos.DataSource = booKidsContainer4.Eventoes.ToList<Evento>();
        }

       
        // --------------------- Alterar dados -------------------------------
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string descricao = tb_descricao.Text, limite_descricao = tb_limite_participacoes.Text, local = tb_local.Text
                , tipo_evento = tb_tipo_evento.Text;
            DateTime hora = DateTime.Parse(dtp_Data_Hora.Text);
        }



        // ------------------- Guardar lista de inscrições de Eventos ---------------------
        private void formatoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_registar_eventos.SelectedIndex == -1)
                return;
            //criação do ficheiro txt
            saveFileDialogTexto.FileName = "Lista de Inscrições" + ".txt";
            if (saveFileDialogTexto.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StreamWriter ficheiro = new StreamWriter(saveFileDialogTexto.FileName, false);


            foreach (Evento c in booKidsContainer4.Eventoes)
            {
                ficheiro.WriteLine("_____________________________");
                ficheiro.WriteLine("Efetuada em: " + c.DataHora);
                foreach (Evento b in booKidsContainer4.Eventoes)
                {
                    ficheiro.WriteLine(b.ToString());
                }

            }
            ficheiro.WriteLine("_____________________________");

            ficheiro.Close();
            MessageBox.Show("O ficheiro foi guardado com o nome: " + saveFileDialogTexto.FileName);
        }

        // ---------------- Criar a ficha de incrições -----------------------
        private void formatoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_registar_eventos.SelectedIndex == -1)
                return;
            //criação do ficheiro txt
            saveFileDialogTexto.FileName = "Ficha de Inscrição" + ".txt";
            if (saveFileDialogTexto.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StreamWriter ficheiro = new StreamWriter(saveFileDialogTexto.FileName, false);
            
            
                ficheiro.WriteLine("\t\t\tFICHA DE INCRIÇÃO - EVENTO" );
                ficheiro.WriteLine("\n\nData e Hora: ____/____/____  ____:____");
                ficheiro.WriteLine("\nDescrição do evento: __________________________________________________");
                ficheiro.WriteLine("\nIdade Inferior: _____ anos");
                ficheiro.WriteLine("\nIdade Superior: _____ anos");
                ficheiro.WriteLine("\nLimite de Participações: ________ crianças");
                ficheiro.WriteLine("\nLocal do evento: _________________________");
                ficheiro.WriteLine("\nTipo de evento: __________________________");
            

            ficheiro.Close();
            MessageBox.Show("O ficheiro foi guardado com o nome: " + saveFileDialogTexto.FileName);
        }
    }
}
