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
    public partial class Manual : Form {
        public Manual() {
            InitializeComponent();

        }

        private void Escreve() {

        }
        private void Manual_Load(object sender, EventArgs e) {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {

        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e) {

            
        }

        private void treeView1_Click(object sender, EventArgs e) {
            
        }

        private void treeView1_DoubleClick(object sender, EventArgs e) {
            
            TreeNode node = treeView1.SelectedNode;
            if (node.Text == "Registros") {
                label1.Visible = true;
                label1.Text = "Existem dois tipos arquivos de registros, ordenados e desordenados,\nrecomenda-se a busca binária somente no caso de arquivos ordenados" +
                 "\nInformações disponíveis sobre a população: \n- Identidade\n- Nome \n- Sexo \n- Idade \n- Moradia \n- Estado civil \n- Cor";
            }
            if (node.Text == "Adicionar registros") {
                label1.Visible = true;
                label1.Text = "Clique em Adicionar cadastro e espere a janela abrir, preencha os \ncampos com o dados do novo cadastrado,"
                + " estando tudo de acordo clique \nbem Salvar,caso não,clique em limpar e digite os dados novamente\nObs: Lembrando que só é possível cadastrar uma identidade uma vez,e \nnão é possível deixar algum campo vazio";
            }
            if (node.Text == "Remover registro") {
                label1.Visible = true;
                label1.Text = "Clique em Remover registro na tela principal, informe uma identidade \npara a busca,somente após a busca o botão de remover estará habilitado." +
                    "\nConfira as informações e clique em Remover\nObs: Confira bem os dados,a remoção é irreversível.";
            }
            if (node.Text == "Busca e Edição") {
                label1.Visible = true;
                label1.Text = "Clique em Busca e edição na tela principal, informe uma identidade \npara a busca, e aguarde.Se for encontrado o botão Habilitar Edição \nficará disponivel,clicando nele,fica possível editar dados,\nse tiver certeza da alteração salve,senão clique em Limpar ";
            }
        }
    }
}
