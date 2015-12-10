using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoIBGE {
    class Pessoa {
        //atributos da classe Pessoa
        String nome, moradia, ecivil, cor;
        int idade;
        long identidade;
        char sexo;
        // atributos da lista encadeada
        public Pessoa prox;
        public Pessoa root;
        public Pessoa ultimo;
        public Pessoa left;
        public Pessoa right;
        
        //Construtor sem parâmetro que inicializa a lista encadeada
        public Pessoa() {
            this.ultimo = null;
            this.prox = null;
            this.left = null;
            this.right = null;
            this.root = null;
        }
        //Segundo construtor que inicializa os atributos da classe 
        public Pessoa(long identidade, string nome, char sexo, int idade, string moradia, string estadoCivil, string raca) {
            this.identidade = identidade;
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
            this.moradia = moradia;
            this.ecivil = estadoCivil;
            this.cor = raca;
            this.prox = null;
            this.root = null;
        }
        //Propriedades dos atributos da classe
        #region 
        public String Nome {
            get { return nome; }
            set { nome = value; }
        }
        public char Sexo {
            get { return sexo; }
            set { sexo = value; }
        }
        public String Moradia {
            get { return moradia; }
            set { moradia = value; }
        }
        public String Cor {
            get { return cor; }
            set { cor = value; }
        }
        public String Ecivil {
            get { return ecivil; }
            set { ecivil = value; }
        }
        public long Ident {
            get { return identidade; }
            set { identidade = value; }
        }
        public int Idade {
            get { return idade; }
            set { idade = value; }
        }
        #endregion
        
        //remove um cadastro da lista pegando como parâmetro a identidade 
        //como referência para exclusão   
        public void Remove(long identidade) {
            Pessoa aux;
            if (prox != null) {
                aux = prox;
                if (aux.Ident == identidade) {
                    prox = aux.prox;
                    return;
                }

                while ((aux.prox != null) && (aux.prox.Ident != identidade)) {
                    aux = aux.prox;
                }
                if (aux.prox != null)
                    aux.prox = aux.prox.prox;
            }
        }
        //Adiciona um cadastro ao final da lista,verificando se a lista está vazia
        public void Add(Pessoa nova) {
            if (ultimo == null) {
                ultimo = nova;
                prox = nova;
            }
            else {
                ultimo.prox = nova;
                ultimo = nova;
            }
        }
        
        //Metodos para fins estatisticos
        #region
        public int Qtd() {
            int i = 0;
            Pessoa aux = prox;
            while (aux != null) {
                i++;
                aux = aux.prox;
            }
            return i;
        }
        public int Masc() {
            int i = 0;
            Pessoa aux = prox;
            while (aux != null) {
                if (aux.Sexo == 'M') {
                    i++;
                }
                aux = aux.prox;
            }
            return i;
        }
        public int Fem() {
            int i = 0;
            Pessoa aux = prox;
            while (aux != null) {
                if (aux.Sexo == 'F') {
                    i++;
                }
                aux = aux.prox;
            }
            return i;
        }
        public Double GeralIdade() {
            int i = 0;
            Pessoa aux = prox;
            while (aux != null) {
                i += aux.Idade;
                aux = aux.prox;
            }
            return i / Qtd();
        }
        public Double GeralIdadeM() {
            Double i = 0;
            Pessoa aux = prox;
            int cont = 0;
            while (aux != null) {
                if (aux.Sexo == 'M') {
                    i += aux.Idade;
                    cont++;
                }
                aux = aux.prox;
            }
            return i / cont;
        }
        public Double GeralIdadeF() {
            Double i = 0;
            Pessoa aux = prox;
            int cont = 0;
            while (aux != null) {
                if (aux.Sexo == 'F') {
                    i += aux.Idade;
                    cont++;
                }
                aux = aux.prox;
            }
            return i / cont;
        }
        public Double GeralIdadeU() {
            Double i = 0;
            Pessoa aux = prox;
            int cont = 0;
            while (aux != null) {
                if (aux.Moradia == "Urbana") {
                    i += aux.Idade;
                    cont++;
                }
                aux = aux.prox;
            }
            return i / cont;
        }
        public Double GeralIdadeR() {
            Double i = 0;
            Pessoa aux = prox;
            int cont = 0;
            while (aux != null) {
                if (aux.Moradia == "Rural") {
                    i += aux.Idade;
                    cont++;
                }
                aux = aux.prox;
            }
            return i / cont;
        }
        #endregion

        //Métodos Árvore binária
        #region
        //////////////////////////////////////////////////////////////////

        //verifica se a arvore está vazia
        public Boolean treeempty() {

            return (root == null);
        }

        /////////////////////////////////////////////////////////////////////////

        //verifica posição(raiz) que a nova pessoa será inserida
        public Pessoa Add(Pessoa rootx, Pessoa nperson) {

            if (rootx == null) {
                rootx = nperson;
            }
            else {
                if (rootx.Ident > nperson.Ident) {

                    rootx.left = Add(rootx.left, nperson);
                }
                else if (rootx.Ident < nperson.Ident) {

                    rootx.right = Add(rootx.right, nperson);
                }
                else {

                    rootx = null;
                }
            }

            return rootx;
        }
        //metodo para passar como parametro a nova pessoa a ser inserida na arvore

        public void insert(Pessoa person) {

            this.root = Add(this.root, person);
        }
        /////////////////////////////////////////////////////////////////////////

        //definir o antecessor para o caso o nó a ser excluído tenha dois filhos
        public Pessoa Forefather(Pessoa Pout, Pessoa Proot) {

            if (Proot.right != null) {

                Proot.right = Forefather(Pout, Proot.right);
                return Proot;
            }
            else {

                Pout.Ident = Proot.Ident;
                Pout.Nome = Proot.Nome;
                Pout.Sexo = Proot.Sexo;
                Pout.Idade = Proot.Idade;
                Pout.Moradia = Proot.Moradia;
                Pout.Ecivil = Proot.Ecivil;
                Pout.Cor = Proot.Cor;
            }

            return Proot.left;
        }

        /////////////////////////////////////////////////////////////////////
        //metodo recursivo para busca

         Pessoa Search(Pessoa Proot, long x) {

           
            if (Proot == null) {
                return null;
            }
            else if (Proot.Ident > x) {

                return Proot.left = Search(Proot.left, x);

            }
            else if (Proot.Ident < x) {

                return Proot.right = Search(Proot.right, x);

            }
            return Proot;

        }
        

        public Pessoa Search2(long x) {
            return this.Search(this.root, x);
        }
        //////////////////////////////////////////////////////////////////////

        //localizar nó que será removido 

        public Pessoa Delete(Pessoa Proot, long x) {

            //se a arvore está vazia não a nada o que fazer
            if (Proot == null) {

                return null;
            }

                //se não..
            else {

                //se a identidade do nó a ser excluido é igual a entrada

                if (Proot.Ident == x) {

                    //verifica se esse nó tem só filho à esquerda 
                    if (Proot.right == null) {

                        //se nao tem filho a direita, o nó a ser excluido será substituido pelo filho da esquerda
                        return Proot.left;

                    }
                    //se nao, verifica se esse nó só tem filho à direita
                    else if (Proot.left == null) {

                        //se nao tem filho a esquerda, o nó a ser excluido será substituido pelo filho da direita
                        return Proot.right;

                    }
                    //se nao, esse nó possui filhos à esquerda e à direita
                    else {

                        //nesse caso é necessario escolher o antencessor que irá substituir o nó a ser excluido
                        //o metodo recursivo abaixo retorna o antecessor, que é o nó mais à direita da sub-arvore à esquerda 
                        Proot.left = Forefather(Proot, Proot.left);
                        //o antencessor escolhido substituirá o nó que será excluido
                        return Proot;
                    }
                }

                else {

                    //se a identidade da raíz é maior que a identidade informada, verifica na raíz à esquerda
                    if (Proot.Ident > x) {

                        Proot.left = Delete(Proot.left, x);
                    }
                    //se não, verifica na raíz à direita
                    else {

                        Proot.right = Delete(Proot.right, x);
                    }

                    //retorna o nó
                    return Proot;
                }
            }
        }

        //metodo para passar a identidade ao metodo recursivo de retirada
        public void remove(long x) {

            this.root = Delete(this.root, x);
        }
        #endregion
    }
}
