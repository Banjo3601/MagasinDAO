
namespace MagasinDAO_Paolo
{
    partial class PageDeConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.labelBienvenue2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelAdressePseudo = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonCreationCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.AutoSize = true;
            this.labelBienvenue.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.Location = new System.Drawing.Point(100, 29);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(671, 40);
            this.labelBienvenue.TabIndex = 1;
            this.labelBienvenue.Text = "Bienvenue sur le service Magasin DAO";
            this.labelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBienvenue2
            // 
            this.labelBienvenue2.AutoSize = true;
            this.labelBienvenue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue2.Location = new System.Drawing.Point(265, 125);
            this.labelBienvenue2.Name = "labelBienvenue2";
            this.labelBienvenue2.Size = new System.Drawing.Size(462, 26);
            this.labelBienvenue2.TabIndex = 2;
            this.labelBienvenue2.Text = "Veuillez vous connectez pour utiliser le service";
            this.labelBienvenue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(429, 261);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(340, 26);
            this.textBoxLogin.TabIndex = 3;
            // 
            // labelAdressePseudo
            // 
            this.labelAdressePseudo.AutoSize = true;
            this.labelAdressePseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdressePseudo.Location = new System.Drawing.Point(424, 229);
            this.labelAdressePseudo.Name = "labelAdressePseudo";
            this.labelAdressePseudo.Size = new System.Drawing.Size(225, 20);
            this.labelAdressePseudo.TabIndex = 4;
            this.labelAdressePseudo.Text = "Pseudonyme ou adresse email";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.Location = new System.Drawing.Point(510, 313);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(105, 20);
            this.labelMdp.TabIndex = 5;
            this.labelMdp.Text = "Mot de passe";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(429, 345);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(340, 26);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(429, 377);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(340, 52);
            this.buttonConnexion.TabIndex = 7;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonCreationCompte
            // 
            this.buttonCreationCompte.Location = new System.Drawing.Point(429, 435);
            this.buttonCreationCompte.Name = "buttonCreationCompte";
            this.buttonCreationCompte.Size = new System.Drawing.Size(340, 52);
            this.buttonCreationCompte.TabIndex = 8;
            this.buttonCreationCompte.Text = "Créer un compte";
            this.buttonCreationCompte.UseVisualStyleBackColor = true;
            this.buttonCreationCompte.Click += new System.EventHandler(this.button1_Click);
            // 
            // PageDeConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 525);
            this.Controls.Add(this.buttonCreationCompte);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelAdressePseudo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelBienvenue2);
            this.Controls.Add(this.labelBienvenue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PageDeConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.PageDeConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Label labelBienvenue2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelAdressePseudo;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonCreationCompte;
    }
}

