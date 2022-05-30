namespace MagasinDAO_Paolo
{
    partial class GestUtilisateur
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
            this.cbBoxUtilisateurClientNom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPays = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxSolde = new System.Windows.Forms.TextBox();
            this.textBoxTypeUtilisateur = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBoxUtilisateurClientNom
            // 
            this.cbBoxUtilisateurClientNom.FormattingEnabled = true;
            this.cbBoxUtilisateurClientNom.Location = new System.Drawing.Point(178, 37);
            this.cbBoxUtilisateurClientNom.Name = "cbBoxUtilisateurClientNom";
            this.cbBoxUtilisateurClientNom.Size = new System.Drawing.Size(408, 21);
            this.cbBoxUtilisateurClientNom.TabIndex = 1;
            this.cbBoxUtilisateurClientNom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste de tous les utilisateurs de type client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "pseudo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "code postal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "adresse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "idTypeUtilisateur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Informations sur l\'utilisateur sélectionné";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "pays";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "solde";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(16, 151);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(107, 20);
            this.textBoxId.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(16, 207);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(107, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(15, 261);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(107, 20);
            this.textBoxPseudo.TabIndex = 17;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(15, 318);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(107, 20);
            this.textBoxPrenom.TabIndex = 18;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(15, 378);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(107, 20);
            this.textBoxNom.TabIndex = 19;
            // 
            // textBoxPays
            // 
            this.textBoxPays.Location = new System.Drawing.Point(299, 151);
            this.textBoxPays.Name = "textBoxPays";
            this.textBoxPays.Size = new System.Drawing.Size(107, 20);
            this.textBoxPays.TabIndex = 20;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(299, 207);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(107, 20);
            this.textBoxVille.TabIndex = 21;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(299, 261);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(107, 20);
            this.textBoxCodePostal.TabIndex = 22;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(299, 318);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(107, 20);
            this.textBoxAdresse.TabIndex = 23;
            // 
            // textBoxSolde
            // 
            this.textBoxSolde.Location = new System.Drawing.Point(299, 378);
            this.textBoxSolde.Name = "textBoxSolde";
            this.textBoxSolde.ReadOnly = true;
            this.textBoxSolde.Size = new System.Drawing.Size(107, 20);
            this.textBoxSolde.TabIndex = 24;
            // 
            // textBoxTypeUtilisateur
            // 
            this.textBoxTypeUtilisateur.Location = new System.Drawing.Point(559, 151);
            this.textBoxTypeUtilisateur.Name = "textBoxTypeUtilisateur";
            this.textBoxTypeUtilisateur.Size = new System.Drawing.Size(107, 20);
            this.textBoxTypeUtilisateur.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 51);
            this.button1.TabIndex = 26;
            this.button1.Text = "Supprimer L\'utilisateur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 51);
            this.button2.TabIndex = 27;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTypeUtilisateur);
            this.Controls.Add(this.textBoxSolde);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxPays);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxUtilisateurClientNom);
            this.Name = "GestUtilisateur";
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.GestUtilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBoxUtilisateurClientNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPays;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxSolde;
        private System.Windows.Forms.TextBox textBoxTypeUtilisateur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}