namespace CensoIBGE
{
    partial class AdicionarCadastro
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.salvaDados = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCivil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMoradia = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdade = new System.Windows.Forms.NumericUpDown();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.txtIdent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salvaDados
            // 
            this.salvaDados.Location = new System.Drawing.Point(15, 131);
            this.salvaDados.Name = "salvaDados";
            this.salvaDados.Size = new System.Drawing.Size(109, 23);
            this.salvaDados.TabIndex = 34;
            this.salvaDados.Text = "Salvar";
            this.salvaDados.UseVisualStyleBackColor = true;
            this.salvaDados.Click += new System.EventHandler(this.salvaDados_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Identidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Idade:";
            // 
            // comboCor
            // 
            this.comboCor.FormattingEnabled = true;
            this.comboCor.Items.AddRange(new object[] {
            "Parda",
            "Preta",
            "Branca",
            "Amarela",
            "Indígena"});
            this.comboCor.Location = new System.Drawing.Point(305, 38);
            this.comboCor.Name = "comboCor";
            this.comboCor.Size = new System.Drawing.Size(147, 21);
            this.comboCor.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Raça:";
            // 
            // comboCivil
            // 
            this.comboCivil.FormattingEnabled = true;
            this.comboCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viúvo",
            "Divorciado"});
            this.comboCivil.Location = new System.Drawing.Point(83, 100);
            this.comboCivil.Name = "comboCivil";
            this.comboCivil.Size = new System.Drawing.Size(147, 21);
            this.comboCivil.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado Civil:";
            // 
            // comboMoradia
            // 
            this.comboMoradia.FormattingEnabled = true;
            this.comboMoradia.Items.AddRange(new object[] {
            "Urbana",
            "Rural"});
            this.comboMoradia.Location = new System.Drawing.Point(82, 68);
            this.comboMoradia.Name = "comboMoradia";
            this.comboMoradia.Size = new System.Drawing.Size(148, 21);
            this.comboMoradia.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(82, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 22;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Moradia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(307, 68);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(47, 20);
            this.textIdade.TabIndex = 37;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(307, 98);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(73, 17);
            this.radioButtonM.TabIndex = 38;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Masculino";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(386, 99);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(67, 17);
            this.radioButtonF.TabIndex = 39;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Feminino";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(82, 6);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(148, 20);
            this.txtIdent.TabIndex = 40;
            this.txtIdent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdent_KeyPress);
            this.txtIdent.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdent_Validating);
            // 
            // AdicionarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 175);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salvaDados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboCivil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMoradia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarCadastro";
            this.Text = "Adicionar Cadastro";
            this.Load += new System.EventHandler(this.AdicionarCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button salvaDados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCivil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMoradia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textIdade;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.TextBox txtIdent;
    }
}