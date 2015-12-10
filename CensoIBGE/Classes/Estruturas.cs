using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CensoIBGE {

    class Estruturas {

        //cria uma referência a classe Pessoa e atribui uma variavel estática para o arquivo txt 
        
        public Estruturas(String entrada) {
            arquivoEntrada = entrada;
        }
        
        static String arquivoEntrada = "";
        
        static Pessoa lista = null;
        static Pessoa arvore = null;
        

        public static Pessoa Arvore{

            get {return Estruturas.arvore;}
            set { Estruturas.arvore = value; }
        }

        //Cria uma propriedade estatica para acesso a classe Pessoa(que contem a lista em si) 
        public static Pessoa Lista {
            get { return Estruturas.lista; }
            set { Estruturas.lista = value; }
        }
        
        public static void CadastroPessoa() {
            //inicializa a lista
            Estruturas.lista = new Pessoa();
            //inicializa a árvore
            Estruturas.Arvore = new Pessoa();
            //joga os dados do txt para a lista encadeada e para a árvore binária
            using (StreamReader Leitura = new StreamReader(arquivoEntrada, Encoding.Default)) {
                String cad = Leitura.ReadLine();
                while (cad != null) {
                    String[] dados = cad.Split('-');
                    Pessoa nova = new Pessoa(long.Parse(dados[0]), dados[1], char.Parse(dados[2]), int.Parse(dados[3]), dados[4], dados[5], dados[6]);
                    Estruturas.lista.Add(nova);
                    Estruturas.arvore.insert(nova);
                    cad = Leitura.ReadLine();
                }
                Leitura.Close();
            }
    
        }
        //metodo para atualizar o txt de acordo com as modificações na lista
        public static void salvaCadastro(Pessoa nova) {
            StreamWriter Leitura = new StreamWriter(arquivoEntrada, false, Encoding.Default);
            Pessoa aux = nova.prox;

            while (aux.prox != null) {
                if (aux != null) {
                    Leitura.WriteLine(aux.Ident + "-" + aux.Nome + "-" + aux.Sexo + "-" + aux.Idade + "-" + aux.Moradia + "-" + aux.Ecivil + "-" + aux.Cor);
                }
                aux = aux.prox;
            }
            if (aux != null) {
                Leitura.WriteLine(aux.Ident + "-" + aux.Nome + "-" + aux.Sexo + "-" + aux.Idade + "-" + aux.Moradia + "-" + aux.Ecivil + "-" + aux.Cor);
            }
            Leitura.Close();
        }
    }
}
