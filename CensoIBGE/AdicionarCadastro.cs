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
    public partial class AdicionarCadastro : Form {
        Pessoa aux = null;
        Pessoa lista = null;
        public AdicionarCadastro() {
            InitializeComponent();
            aux = new Pessoa();
            lista = Estruturas.Lista;
        }
        
        //verifica se a identidade existe e retorna true ou false
        public Boolean VerificaID(long id) {
            Pessoa aux = Estruturas.Lista.prox;
            while (aux != null) {
                if (aux.Ident == id) {
                    return true;
                }
                aux = aux.prox;
            }
            return false;
        }
        private void AdicionarCadastro_Load(object sender, EventArgs e) {

        }
        //salvar dados novos no txt e mandar pra lista encadeada 
        private void salvaDados_Click(object sender, EventArgs e) {
            
            
            try {
                if (VerificaID(long.Parse(txtIdent.Text)) == true) {
                    MessageBox.Show("Essa identidade já existe,tente novamente", "Aviso!");
                    txtIdent.Text = null;
                }
                else {
                    
                    if (txtNome.Text == "" || comboMoradia.Text == "" || comboCor.Text == "" || comboCivil.Text == "" || (radioButtonF.Checked == false && radioButtonM.Checked == false)) {
                        MessageBox.Show("Preencha todos os campos antes de salvar!", "Aviso!");
                    }
                    else {
                        aux.Ident = long.Parse(txtIdent.Text);
                        if (radioButtonM.Checked == true) {
                            aux.Sexo = 'M';
                        }
                        if (radioButtonF.Checked == true) {
                            aux.Sexo = 'F';
                        }
                        aux.Nome = txtNome.Text;
                        aux.Idade = int.Parse(textIdade.Text);
                        aux.Moradia = comboMoradia.Text;
                        aux.Ecivil = comboCivil.Text;
                        aux.Cor = comboCor.Text;

                        aux.prox = null;
                        lista.Add(aux);
                        Estruturas.salvaCadastro(lista);
                        MessageBox.Show("Dados salvos com sucesso!", "Salvo");
                        Application.Run(new Form1());
                        this.Close();
                        
                    }
                }
            }
            catch { MessageBox.Show("O campo identidade está vazio,tente novamente!", "Aviso!"); }
            finally { }
        }
        //limpar campos
        private void button1_Click(object sender, EventArgs e) {
            txtIdent.Clear();
            txtNome.Clear();
            textIdade.Text = null;
            comboCor.Text = null;
            comboCivil.Text = null;
            comboMoradia.Text = null;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        //faz o text box aceitar apenas numeros
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) && !Char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }
        }
        //faz o text box aceitar apenas letras
        private void txtIdent_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsDigit(e.KeyChar)) && !Char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtIdent_Validating(object sender, CancelEventArgs e) {
            if (txtIdent != null) {
                button1.Enabled = true;
            }
        }
    }
}
