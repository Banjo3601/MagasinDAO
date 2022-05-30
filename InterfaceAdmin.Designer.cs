namespace MagasinDAO_Paolo
{
    partial class InterfaceAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGestUtilisateur = new System.Windows.Forms.Button();
            this.buttonGestStock = new System.Windows.Forms.Button();
            this.buttonGestCommande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue sur l\'interface administrateur !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonGestUtilisateur
            // 
            this.buttonGestUtilisateur.Location = new System.Drawing.Point(405, 134);
            this.buttonGestUtilisateur.Name = "buttonGestUtilisateur";
            this.buttonGestUtilisateur.Size = new System.Drawing.Size(150, 150);
            this.buttonGestUtilisateur.TabIndex = 1;
            this.buttonGestUtilisateur.Text = "Gestion des utilisateurs";
            this.buttonGestUtilisateur.UseVisualStyleBackColor = true;
            this.buttonGestUtilisateur.Click += new System.EventHandler(this.buttonGestUtilisateur_Click);
            // 
            // buttonGestStock
            // 
            this.buttonGestStock.Location = new System.Drawing.Point(561, 134);
            this.buttonGestStock.Name = "buttonGestStock";
            this.buttonGestStock.Size = new System.Drawing.Size(150, 150);
            this.buttonGestStock.TabIndex = 2;
            this.buttonGestStock.Text = "Gestion du stock";
            this.buttonGestStock.UseVisualStyleBackColor = true;
            this.buttonGestStock.Click += new System.EventHandler(this.buttonGestStock_Click);
            // 
            // buttonGestCommande
            // 
            this.buttonGestCommande.Location = new System.Drawing.Point(717, 134);
            this.buttonGestCommande.Name = "buttonGestCommande";
            this.buttonGestCommande.Size = new System.Drawing.Size(150, 150);
            this.buttonGestCommande.TabIndex = 3;
            this.buttonGestCommande.Text = "Gestion des commandes";
            this.buttonGestCommande.UseVisualStyleBackColor = true;
            this.buttonGestCommande.Click += new System.EventHandler(this.buttonGestCommande_Click);
            // 
            // InterfaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 422);
            this.Controls.Add(this.buttonGestCommande);
            this.Controls.Add(this.buttonGestStock);
            this.Controls.Add(this.buttonGestUtilisateur);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfaceAdmin";
            this.Text = "Interface Administrateur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceAdmin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGestUtilisateur;
        private System.Windows.Forms.Button buttonGestStock;
        private System.Windows.Forms.Button buttonGestCommande;
    }
}