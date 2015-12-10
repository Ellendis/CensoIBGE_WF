using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CensoIBGE {
    public partial class BuscaEdit : Form {

        Pessoa aux = null;
        Pessoa lista = null;
        Pessoa auxTree = null;
        Pessoa arvore = null;

        AdicionarCadastro add = new AdicionarCadastro();
        public BuscaEdit() {
            InitializeComponent();
            aux = new Pessoa();
            auxTree = new Pessoa();
            lista = Estruturas.Lista;
            arvore = Estruturas.Arvore.root;
        }

        private void BuscaEdit_Load(object sender, EventArgs e) {


        }
        //faz o text box aceitar apenas numeros
        private void buscaID_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
        //faz o text box aceitar apenas letras
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) && !Char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }
        }

        //realiza a busca da pessoa de acordo com a identidade 
        private void button2_Click(object sender, EventArgs e) {
            try {

                long ident = long.Parse(buscaID.Text);
                lista = Estruturas.Lista;
                aux = lista.prox;
                if (add.VerificaID(int.Parse(buscaID.Text)) == false) {
                    MessageBox.Show("Ocorreu um erro ou essa identidade não existe,tente novamente por favor...", "Aviso!");
                    buscaID.Text = null;
                }
                else {
                    while ((aux != null) && (aux.Ident != ident)) {
                        aux = aux.prox;
                    }

                    if ((aux != null) && (aux.Ident == ident)) {

                        buscaID.Text = aux.Ident.ToString();
                        txtNome.Text = aux.Nome;
                        txtIdade.Text = aux.Idade.ToString();
                        txtMoradia.Text = aux.Moradia;
                        txtEcivil.Text = aux.Ecivil;
                        txtSexo.Text = aux.Sexo.ToString();
                        txtCor.Text = aux.Cor;
                    }
                    button5.Enabled = true;
                    button4.Enabled = true;
                }
            }
            catch { MessageBox.Show("Informe uma identidade para busca!", "Aviso!"); }
            finally { }
        }


        //metodo para habilitar a edição dos campos
        private void button5_Click(object sender, EventArgs e) {
            txtCor.Enabled = true;
            txtEcivil.Enabled = true;
            txtIdade.Enabled = true;
            txtMoradia.Enabled = true;
            txtNome.Enabled = true;
            txtSexo.Enabled = true;
        }

        //salvar alteração feita no txt
        private void button4_Click(object sender, EventArgs e) {
            if (txtNome.Text == "" || txtMoradia.Text == "" || txtCor.Text == "" || txtEcivil.Text == "" || txtSexo.Text == "") {
                MessageBox.Show("Preencha todos os campos antes de salvar!", "Aviso!");
            }
            else {
                aux.Ident = long.Parse(buscaID.Text);
                aux.Nome = txtNome.Text;
                if (txtSexo.SelectedIndex == 0) {
                    aux.Sexo = 'M';
                }
                else {
                    aux.Sexo = 'F';
                }
                aux.Idade = int.Parse(txtIdade.Text);
                aux.Moradia = txtMoradia.Text;
                aux.Ecivil = txtEcivil.Text;
                aux.Cor = txtCor.Text;

                Estruturas.salvaCadastro(lista);

                MessageBox.Show("Alteração Salva com sucesso");
            }
        }

        //limpa os campos de dados
        private void button3_Click(object sender, EventArgs e) {
            buscaID.Text = null;
            txtNome.Text = null;
            txtIdade.Text = null;
            txtMoradia.Text = null;
            txtEcivil.Text = null;
            txtSexo.Text = null;
            txtCor.Text = null;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void txtNome_TextChanged(object sender, EventArgs e) {

        }
        //realiza a busca binária
        private void button6_Click(object sender, EventArgs e) {
            try {
                long ident = long.Parse(buscaID.Text);
                Estruturas.Arvore.Search2(ident);
                arvore = Estruturas.Arvore.Search2(ident);
                auxTree = arvore;

                if (auxTree == null) {
                    MessageBox.Show("Ocorreu um erro ou essa identidade não existe,tente novamente por favor...", "Aviso!");
                    Estruturas.CadastroPessoa();
                    buscaID.Text = null;
                }
                else {

                    if ((auxTree.Ident == ident)) {

                        buscaID.Text = auxTree.Ident.ToString();
                        txtNome.Text = auxTree.Nome;
                        txtIdade.Text = auxTree.Idade.ToString();
                        txtMoradia.Text = auxTree.Moradia;
                        txtEcivil.Text = auxTree.Ecivil;
                        txtSexo.Text = auxTree.Sexo.ToString();
                        txtCor.Text = auxTree.Cor;
                    }
                }
            }
            catch { MessageBox.Show("Informe uma identidade para busca!", "Aviso!"); }
            finally { }
        }
    }
}
