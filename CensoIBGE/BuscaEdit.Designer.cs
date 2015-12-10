namespace CensoIBGE
{
    partial class BuscaEdit
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
            this.button5 = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.ComboBox();
            this.txtMoradia = new System.Windows.Forms.ComboBox();
            this.txtEcivil = new System.Windows.Forms.ComboBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.NumericUpDown();
            this.buscaID = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(12, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 63;
            this.button5.Text = "Habilitar Edição";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtCor
            // 
            this.txtCor.Enabled = false;
            this.txtCor.FormattingEnabled = true;
            this.txtCor.Items.AddRange(new object[] {
            "Parda",
            "Preta",
            "Branca",
            "Amarela",
            "Indígena"});
            this.txtCor.Location = new System.Drawing.Point(315, 48);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(147, 21);
            this.txtCor.TabIndex = 62;
            // 
            // txtMoradia
            // 
            this.txtMoradia.Enabled = false;
            this.txtMoradia.FormattingEnabled = true;
            this.txtMoradia.Items.AddRange(new object[] {
            "Urbana",
            "Rural"});
            this.txtMoradia.Location = new System.Drawing.Point(79, 70);
            this.txtMoradia.Name = "txtMoradia";
            this.txtMoradia.Size = new System.Drawing.Size(146, 21);
            this.txtMoradia.TabIndex = 61;
            // 
            // txtEcivil
            // 
            this.txtEcivil.Enabled = false;
            this.txtEcivil.FormattingEnabled = true;
            this.txtEcivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viúvo",
            "Divorciado"});
            this.txtEcivil.Location = new System.Drawing.Point(79, 97);
            this.txtEcivil.Name = "txtEcivil";
            this.txtEcivil.Size = new System.Drawing.Size(147, 21);
            this.txtEcivil.TabIndex = 60;
            // 
            // txtSexo
            // 
            this.txtSexo.Enabled = false;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.txtSexo.Location = new System.Drawing.Point(315, 94);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(147, 21);
            this.txtSexo.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(117, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 58;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Voltar ao Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Identidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Raça:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Estado Civil:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(79, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 47;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Moradia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome:";
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(315, 70);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(51, 20);
            this.txtIdade.TabIndex = 64;
            // 
            // buscaID
            // 
            this.buscaID.Location = new System.Drawing.Point(79, 15);
            this.buscaID.Name = "buscaID";
            this.buscaID.Size = new System.Drawing.Size(146, 20);
            this.buscaID.TabIndex = 65;
            this.buscaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscaID_KeyPress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(312, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 23);
            this.button6.TabIndex = 66;
            this.button6.Text = "Busca Binária";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BuscaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 185);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buscaID);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtMoradia);
            this.Controls.Add(this.txtEcivil);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscaEdit";
            this.Text = "Busca e Edição";
            this.Load += new System.EventHandler(this.BuscaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox txtCor;
        private System.Windows.Forms.ComboBox txtMoradia;
        private System.Windows.Forms.ComboBox txtEcivil;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtIdade;
        private System.Windows.Forms.TextBox buscaID;
        private System.Windows.Forms.Button button6;
    }
}