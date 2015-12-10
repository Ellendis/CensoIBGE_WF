using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CensoIBGE {
    public partial class Form1 : Form {

        public Form1() {
            Estruturas est = new Estruturas("dados2.txt");
            Estruturas.CadastroPessoa();
            InitializeComponent();
            detectaSistema();
            AddGrid();
            Pessoa aux = Estruturas.Lista.prox;
            label3.Text = "Registros: " + Estruturas.Lista.Qtd();
            //Cria um balão de informação ao passar o mouse por cima
            toolTip1.SetToolTip(button1, "Adicionar novos cadastros para o arquivo!");
            toolTip1.SetToolTip(button2, "Deletar cadastros do arquivo,procurando por ID");
            toolTip1.SetToolTip(button3, "Buscar e editar dados do arquivo,buscando por ID");
            
        }

        private void button1_Click(object sender, EventArgs e) {
            AdicionarCadastro add = new AdicionarCadastro();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            RemoveCadastro remove = new RemoveCadastro();
            remove.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            BuscaEdit be = new BuscaEdit();
            be.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e) {
            calendar calendario = new calendar();
            calendario.Show();
        }
        //Preenche o grid com os dados da lista encadeada,depois de puxar os dados do arquivo
        public void AddGrid() {

            Pessoa aux = null;
            aux = Estruturas.Lista.prox;
            int i = 0;
            while (aux.prox != null && i < 3500) {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = aux.prox.Ident;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = aux.prox.Nome;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = aux.prox.Sexo;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = aux.prox.Idade;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = aux.prox.Moradia;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = aux.prox.Ecivil;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = aux.prox.Cor;

                dataGridView1.Rows.Add(aux.Ident, aux.Nome, aux.Sexo, aux.Idade, aux.Moradia, aux.Ecivil, aux.Cor);
                i++;
                aux = aux.prox;
            }

        }
        
        private void relatórioCaracterizaçãoToolStripMenuItem_Click(object sender, EventArgs e) {
            //Chama form Relatorio1
            Relatorio1 carac = new Relatorio1();
            carac.ShowDialog();
        }

       

        //Tipo Datetime, para exibir data e hora no momento e manter atualizando
        private void timer1_Tick(object sender, EventArgs e) {
            DateTime datahora = new DateTime();
            datahora = DateTime.Now;
            label1.Text = "Data.: " + datahora.ToLongDateString() + "\nHora.: " + datahora.ToLongTimeString();
        }
        //Detecta o sistema operacional e build do computador usando o resultado da classe OperatingSystem
        public void detectaSistema() {
            OperatingSystem os = Environment.OSVersion;
            Version ver = os.Version;
            String resultado = "";
            int majorVer = ver.Major;
            int minorver = ver.Minor;

            switch (majorVer) {
                case 5: resultado = "XP";
                    break;
                case 6:
                    if (minorver == 0) { resultado = "Vista"; }
                    if (minorver == 1) { resultado = "Seven"; }
                    if (minorver == 2) { resultado = "8"; }
                    if (minorver == 3) { resultado = "8.1"; }
                    break;
            }
            label2.Text = "Windows " + resultado + "\nBuild " + ver.Build;
        }

        

        private void manualToolStripMenuItem_Click(object sender, EventArgs e) {
            Manual manu = new Manual();
            manu.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
