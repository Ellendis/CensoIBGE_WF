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
    public partial class Relatorio1 : Form {

        Pessoa aux = Estruturas.Lista.prox;
        public Relatorio1() {
            InitializeComponent();
            label1.Text = "População Total: " + Estruturas.Lista.Qtd();
            Rela_Car();
            Relatorio();
            //MedianaGeral();
        }
        //Gera o relatorio de caracterização e exibe por labels
        public void Rela_Car() {
            Pessoa aux = Estruturas.Lista.prox;
            int[] RelaSexo = new int[2];
            int[] RelaMoradia = new int[2];
            int[] RelaCor = new int[5];
            int[] RelaCivil = new int[4];
            int[] RelaIdade = new int[7];
            while (aux.prox != null) {
                if (aux.prox.Sexo == 'M') {
                    RelaSexo[0]++;
                }
                if (aux.prox.Sexo == 'F') {
                    RelaSexo[1]++;
                }
                if (aux.prox.Moradia == "Urbana") {
                    RelaMoradia[0]++;
                }
                if (aux.prox.Moradia == "Rural") {
                    RelaMoradia[1]++;
                }
                if (aux.prox.Cor == "Parda") {
                    RelaCor[0]++;
                }
                if (aux.prox.Cor == "Preta") {
                    RelaCor[1]++;
                }
                if (aux.prox.Cor == "Branca") {
                    RelaCor[2]++;
                }
                if (aux.prox.Cor == "Amarela") {
                    RelaCor[3]++;
                }
                if (aux.prox.Cor == "Indígena") {
                    RelaCor[4]++;
                }
                if (aux.prox.Ecivil == "Solteiro") {
                    RelaCivil[0]++;
                }
                if (aux.prox.Ecivil == "Casado") {
                    RelaCivil[1]++;
                }
                if (aux.prox.Ecivil == "Divorciado") {
                    RelaCivil[2]++;
                }
                if (aux.prox.Ecivil == "Viúvo") {
                    RelaCivil[3]++;
                }
                if (aux.prox.Idade >= 0 && aux.prox.Idade <= 12) {
                    RelaIdade[0]++;
                }
                if (aux.prox.Idade >= 12 && aux.prox.Idade <= 19) {
                    RelaIdade[1]++;
                }
                if (aux.prox.Idade >= 20 && aux.prox.Idade <= 25) {
                    RelaIdade[2]++;
                }
                if (aux.prox.Idade >= 25 && aux.prox.Idade <= 30) {
                    RelaIdade[3]++;
                }
                if (aux.prox.Idade >= 30 && aux.prox.Idade <= 45) {
                    RelaIdade[4]++;
                }
                if (aux.prox.Idade >= 45 && aux.prox.Idade <= 65) {
                    RelaIdade[5]++;
                }
                if (aux.prox.Idade > 65) {
                    RelaIdade[6]++;
                }
                aux = aux.prox;
            }
            labelSexoQtd.Text = "Masculino: " + RelaSexo[0] + "\nFeminino: " + RelaSexo[1];
            labelSexoPerc.Text = ((double)(RelaSexo[0] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%" + "\n" + ((double)(RelaSexo[1] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%";
            labelMoradiaQtd.Text = "Urbana: " + RelaMoradia[0] + "\nRural: " + RelaMoradia[1];
            labelMoradiaPerc.Text = ((double)(RelaMoradia[0] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%" + "\n" + ((double)(RelaMoradia[1] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%";
            labelRacaQtd.Text = "Parda: " + RelaCor[0] + "\nPreta: " + RelaCor[1] + "\nBranca: " + RelaCor[2] + "\nAmarela: " + RelaCor[3] + "\nIndígena: " + RelaCor[4];
            labelRacaPerc.Text = ((double)(RelaCor[0] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%" + "\n" + ((double)(RelaCor[1] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n" +
                ((double)(RelaCor[2] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%" + "\n" + ((double)(RelaCor[3] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n" + ((double)(RelaCor[4] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%";
            labelEcivilQtd.Text = "Solteiro: " + RelaCivil[0] + "\nCasado: " + RelaCivil[1] + "\nDivorciado: " + RelaCivil[2] + "\nViúvo: " + RelaCivil[3];
            labelEcivilPerc.Text = ((double)(RelaCivil[0] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%" + "\n" + ((double)(RelaCivil[1] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n" +
                ((double)(RelaCivil[2] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%" + "\n" + ((double)(RelaCivil[3] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%";
            labelIdadeQtd.Text = "0 a 12 anos: " + RelaIdade[0] + "\n12 a 19 anos: " + RelaIdade[1] + "\n20 a 25 anos: " + RelaIdade[2] + "\n25 a 30 anos: " + RelaIdade[3]
            + "\n30 a 45 anos: " + RelaIdade[4] + "\n45 a 65 anos: " + RelaIdade[5] + "\nMaiores que 65: " + RelaIdade[6];
            labelIdadePerc.Text = ((double)(RelaIdade[0] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n" + ((double)(RelaIdade[1] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n"
            + ((double)(RelaIdade[2] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n" + ((double)(RelaIdade[3] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n"
            + ((double)(RelaIdade[4] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n" + ((double)(RelaIdade[5] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%\n"
            + ((double)(RelaIdade[6] * 100) / Estruturas.Lista.Qtd()).ToString("0.00") + "%";
        }
        public void Relatorio() {

            double total = Estruturas.Lista.Qtd();
            //indices sexo  F = 0 - M = 1; 
            long[] sexo = new long[] { 0, 0 };

            //indice estado civil: 0:solteiro 1: casado 2: viuvo 3: divorciado

            long[] estadocivil = new long[] { 0, 0, 0, 0 };
            long[] estadocivilF = new long[] { 0, 0, 0, 0 };
            long[] estadocivilM = new long[] { 0, 0, 0, 0 };

            //indice raça: 0:parda 1: preta 2: branca 3: amarela 4:indigena

            long[] raca = new long[] { 0, 0, 0, 0, 0 };
            long[] racaF = new long[] { 0, 0, 0, 0, 0 };
            long[] racaM = new long[] { 0, 0, 0, 0, 0 };

            //indice moradia: 0: urbana 1: rural
            long[] moradia = new long[] { 0, 0 };
            long[] moradiaF = new long[] { 0, 0 };
            long[] moradiaM = new long[] { 0, 0 };

            //indice para faixas de idade: 0 - (0 a 12 anos) / 1 - (12 a 19 anos) / 2 - (20 a 25 anos) 
            // 3 - (25 a 30 anos) / 4 - (30 a 45 anos) / 5 - (45 a 65 anos) / 6 - (maiores de 65 anos)

            long[] idade = new long[] { 0, 0, 0, 0, 0, 0, 0 };
            long[] idadeF = new long[] { 0, 0, 0, 0, 0, 0, 0 };
            long[] idadeM = new long[] { 0, 0, 0, 0, 0, 0, 0 };


            int posec = 0, posr = 0, posid = 0, pmoradia = 0;
            Pessoa alguem = Estruturas.Lista.prox;

            while (alguem != null) {
                //verificação por moradia
                if (alguem.Moradia == "Urbana") {
                    pmoradia = 0;
                }
                else {
                    pmoradia = 1;
                }
                
                //verificação por estado civil
                if (alguem.Ecivil == "Solteiro") {

                    posec = 0;
                }
                else if (alguem.Ecivil == "Casado") {
                    posec = 1;
                }
                else if (alguem.Ecivil == "Viúvo") {
                    posec = 2;
                }
                else {
                    posec = 3;
                }

                //somando +1 na posição indicada no vetor
                estadocivil[posec]++;

                //verificação por raça

                if (alguem.Cor == "Parda") {

                    posr = 0;
                }
                else if (alguem.Cor == "Preta") {

                    posr = 1;
                }
                else if (alguem.Cor == "Branca") {

                    posr = 2;
                }
                else if (alguem.Cor == "Amarela") {

                    posr = 3;
                }

                else {
                    posr = 4;
                }

                raca[posr]++;

                //verificação por faixa etaria

                if (alguem.Idade < 12) {

                    posid = 0;

                }
                else if (alguem.Idade <= 19) {

                    posid = 1;
                }

                else if (alguem.Idade < 25) {

                    posid = 2;
                }
                else if (alguem.Idade < 30) {

                    posid = 3;
                }
                else if (alguem.Idade < 45) {

                    posid = 4;
                }
                else if (alguem.Idade < 65) {

                    posid = 5;
                }
                else {
                    posid = 6;
                }

                idade[posid]++;


                if (alguem.Sexo == 'F') {

                    estadocivilF[posec]++;
                    racaF[posr]++;
                    moradiaF[pmoradia]++;
                    idadeF[posid]++;
                    sexo[0]++;

                }
                else {
                    estadocivilM[posec]++;
                    racaM[posr]++;
                    moradiaM[pmoradia]++;
                    idadeM[posid]++;
                    sexo[1]++;

                }

                alguem = alguem.prox;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Por Masculino
            labelMM.Text = "Urbana: " + moradiaM[0] + "\nRural: " + moradiaM[1];
            labelMMP.Text = (moradiaM[0] * 100) / Estruturas.Lista.Masc() + "%\n" + (moradiaM[1] * 100) / Estruturas.Lista.Masc() + "%";
            labelMR.Text = "Parda: " + racaM[0] + "\nPreta: " + racaM[1] + "\nBranca: " + racaM[2] + "\nAmarela: " + racaM[3] + "\nIndígena: " + racaM[4];
            labelMRP.Text = ((double)(racaM[0] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%" + "\n" + ((double)(racaM[1] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n" +
                ((double)(racaM[2] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%" + "\n" + ((double)(racaM[3] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n" + ((double)(racaM[4] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%";
            labelME.Text = "Solteiro: " + estadocivilM[0] + "\nCasado: " + estadocivilM[1] + "\nDivorciado: " + estadocivilM[2] + "\nViúvo: " + estadocivilM[3];
            labelMEP.Text = ((double)(estadocivilM[0] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%" + "\n" + ((double)(estadocivilM[1] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n" +
                ((double)(estadocivilM[2] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%" + "\n" + ((double)(estadocivilM[3] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%";
            labelMI.Text = "0 a 12 anos: " + idadeM[0] + "\n12 a 19 anos: " + idadeM[1] + "\n20 a 25 anos: " + idadeM[2] + "\n25 a 30 anos: " + idadeM[3]
                + "\n30 a 45 anos: " + idadeM[4] + "\n45 a 65 anos: " + idadeM[5] + "\nMaiores que 65: " + idadeM[6];
            labelMIP.Text = ((double)(idadeM[0] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n" + ((double)(idadeM[1] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n"
            + ((double)(idadeM[2] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n" + ((double)(idadeM[3] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n"
            + ((double)(idadeM[4] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n" + ((double)(idadeM[5] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%\n"
            + ((double)(idadeM[6] * 100) / Estruturas.Lista.Masc()).ToString("0.00") + "%";
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Por Feminino
            labelFM.Text = "Urbana: " + moradiaF[0] + "\nRural: " + moradiaF[1];
            labelFMP.Text = (moradiaF[0] * 100) / Estruturas.Lista.Fem() + "%\n" + (moradiaF[1] * 100) / Estruturas.Lista.Fem() + "%";
            labelFR.Text = "Parda: " + racaF[0] + "\nPreta: " + racaF[1] + "\nBranca: " + racaF[2] + "\nAmarela: " + racaF[3] + "\nIndígena: " + racaF[4];
            labelFRP.Text = ((double)(racaF[0] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%" + "\n" + ((double)(racaF[1] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n" +
                ((double)(racaF[2] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%" + "\n" + ((double)(racaF[3] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n" + ((double)(racaF[4] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%";
            labelFE.Text = "Solteiro: " + estadocivilF[0] + "\nCasado: " + estadocivilF[1] + "\nDivorciado: " + estadocivilF[2] + "\nViúvo: " + estadocivilF[3];
            labelFEP.Text = ((double)(estadocivilF[0] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%" + "\n" + ((double)(estadocivilF[1] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n" +
                ((double)(estadocivilF[2] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%" + "\n" + ((double)(estadocivilF[3] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%";
            labelFI.Text = "0 a 12 anos: " + idadeF[0] + "\n12 a 19 anos: " + idadeF[1] + "\n20 a 25 anos: " + idadeF[2] + "\n25 a 30 anos: " + idadeF[3]
                  + "\n30 a 45 anos: " + idadeF[4] + "\n45 a 65 anos: " + idadeF[5] + "\nMaiores que 65: " + idadeF[6];
            labelFIP.Text = ((double)(idadeF[0] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n" + ((double)(idadeF[1] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n"
          + ((double)(idadeF[2] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n" + ((double)(idadeF[3] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n"
          + ((double)(idadeF[4] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n" + ((double)(idadeF[5] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%\n"
          + ((double)(idadeF[6] * 100) / Estruturas.Lista.Fem()).ToString("0.00") + "%";
        }
        //public void MedianaGeral() {
        //    Pessoa aux = Estruturas.Lista.prox;
        //    int[] vet = new int[300];
          
        //    int i = 0;
        //    while (aux != null) {
        //         if (aux.Idade != vet[i]) {
        //             vet[i] = aux.Idade;
        //             i++;
        //         }
        //        aux = aux.prox;
        //    }
        //    Array.Sort(vet);

        //}
        private void Relatorio1_Load(object sender, EventArgs e) {

        }
    }
}
