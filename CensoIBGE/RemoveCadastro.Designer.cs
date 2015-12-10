namespace CensoIBGE
{
    partial class RemoveCadastro
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
            this.txtCor = new System.Windows.Forms.ComboBox();
            this.txtMoradia = new System.Windows.Forms.ComboBox();
            this.txtEcivil = new System.Windows.Forms.ComboBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.naoRemove = new System.Windows.Forms.Button();
            this.RemoveIdent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemoveID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.txtCor.Location = new System.Drawing.Point(300, 78);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(147, 21);
            this.txtCor.TabIndex = 72;
            // 
            // txtMoradia
            // 
            this.txtMoradia.Enabled = false;
            this.txtMoradia.FormattingEnabled = true;
            this.txtMoradia.Items.AddRange(new object[] {
            "Urbana",
            "Rural"});
            this.txtMoradia.Location = new System.Drawing.Point(83, 106);
            this.txtMoradia.Name = "txtMoradia";
            this.txtMoradia.Size = new System.Drawing.Size(147, 21);
            this.txtMoradia.TabIndex = 71;
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
            this.txtEcivil.Location = new System.Drawing.Point(83, 138);
            this.txtEcivil.Name = "txtEcivil";
            this.txtEcivil.Size = new System.Drawing.Size(148, 21);
            this.txtEcivil.TabIndex = 70;
            // 
            // txtSexo
            // 
            this.txtSexo.Enabled = false;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.txtSexo.Location = new System.Drawing.Point(301, 140);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(147, 21);
            this.txtSexo.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Sexo:";
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(301, 110);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(29, 20);
            this.txtIdade.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Raça:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Estado Civil:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(83, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 63;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Moradia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 20);
            this.button1.TabIndex = 60;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // naoRemove
            // 
            this.naoRemove.Location = new System.Drawing.Point(165, 188);
            this.naoRemove.Name = "naoRemove";
            this.naoRemove.Size = new System.Drawing.Size(151, 23);
            this.naoRemove.TabIndex = 59;
            this.naoRemove.Text = "Cancelar";
            this.naoRemove.UseVisualStyleBackColor = true;
            this.naoRemove.Click += new System.EventHandler(this.naoRemove_Click);
            // 
            // RemoveIdent
            // 
            this.RemoveIdent.Enabled = false;
            this.RemoveIdent.Location = new System.Drawing.Point(11, 188);
            this.RemoveIdent.Name = "RemoveIdent";
            this.RemoveIdent.Size = new System.Drawing.Size(148, 23);
            this.RemoveIdent.TabIndex = 58;
            this.RemoveIdent.Text = "Remover";
            this.RemoveIdent.UseVisualStyleBackColor = true;
            this.RemoveIdent.Click += new System.EventHandler(this.RemoveIdent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Identidade:";
            // 
            // txtRemoveID
            // 
            this.txtRemoveID.Location = new System.Drawing.Point(83, 27);
            this.txtRemoveID.Name = "txtRemoveID";
            this.txtRemoveID.Size = new System.Drawing.Size(148, 20);
            this.txtRemoveID.TabIndex = 73;
            this.txtRemoveID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemoveID_KeyPress);
            // 
            // RemoveCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 232);
            this.Controls.Add(this.txtRemoveID);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtMoradia);
            this.Controls.Add(this.txtEcivil);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.naoRemove);
            this.Controls.Add(this.RemoveIdent);
            this.Controls.Add(this.label1);
            this.Name = "RemoveCadastro";
            this.Text = "Remover Cadastro";
            this.Load += new System.EventHandler(this.RemoveCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtCor;
        private System.Windows.Forms.ComboBox txtMoradia;
        private System.Windows.Forms.ComboBox txtEcivil;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button naoRemove;
        private System.Windows.Forms.Button RemoveIdent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemoveID;
    }
}