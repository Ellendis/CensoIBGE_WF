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
    public partial class RemoveCadastro : Form {
        Pessoa aux = null;
        Pessoa lista = null;
        AdicionarCadastro add = new AdicionarCadastro();
        public RemoveCadastro() {
            InitializeComponent();
        }

        private void naoRemove_Click(object sender, EventArgs e) {
            MessageBox.Show("Cadastro não excluido!", "Remoção cancelada");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            
            lista = Estruturas.Lista;
            aux = lista.prox;

            try {
                long ident = long.Parse(txtRemoveID.Text);
                if (add.VerificaID(int.Parse(txtRemoveID.Text)) == false) {
                    MessageBox.Show("Essa identidade não existe,tente novamente...", "Aviso!");
                    txtRemoveID.Text = null;
                }
                else {
                    while ((aux.prox != null) && (aux.Ident != ident)) {
                        aux = aux.prox;
                    }
                    if ((aux != null) && (aux.Ident == ident)) {
                        txtRemoveID.Text = aux.Ident.ToString();
                        txtNome.Text = aux.Nome;
                        txtIdade.Text = aux.Idade.ToString();
                        txtMoradia.Text = aux.Moradia;
                        txtEcivil.Text = aux.Ecivil;
                        txtSexo.Text = aux.Sexo.ToString();
                        txtCor.Text = aux.Cor;
                    }
                    RemoveIdent.Enabled = true;
                }
            }
            catch { MessageBox.Show("Informe uma identidade para remover", "Aviso!"); }
            finally { }
        }

        private void RemoveIdent_Click(object sender, EventArgs e) {
            //chama o metodo para remover da lista
            // e chama o metodo para salvar as novas informações atualizadas o arquivo txt 
            Pessoa lista = Estruturas.Lista;
            lista.Remove(long.Parse(txtRemoveID.Text));
            Estruturas.salvaCadastro(lista);
            MessageBox.Show("Cadastro Excluido com sucesso!", "Cadastro Removido");

            this.Close();
        }

        private void RemoveCadastro_Load(object sender, EventArgs e) {

        }

        //faz o text box aceitar apenas numeros
        private void txtRemoveID_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
        //faz o text box aceitar apenas letras
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e) {
           
        }
    }
}
