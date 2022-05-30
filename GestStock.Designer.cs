namespace MagasinDAO_Paolo
{
    partial class GestStock
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
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.textBoxCouleur = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrixUnite = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAddArticle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPoids = new System.Windows.Forms.TextBox();
            this.comboBoxFournisseur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Location = new System.Drawing.Point(293, 95);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(187, 21);
            this.comboBoxArticle.TabIndex = 0;
            this.comboBoxArticle.SelectedIndexChanged += new System.EventHandler(this.comboBoxArticle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des articles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informations de l\'article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "libelle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "couleur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "prix à l\'unité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Le fournisseur";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 210);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 9;
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(12, 282);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibelle.TabIndex = 10;
            // 
            // textBoxCouleur
            // 
            this.textBoxCouleur.Location = new System.Drawing.Point(12, 351);
            this.textBoxCouleur.Name = "textBoxCouleur";
            this.textBoxCouleur.Size = new System.Drawing.Size(100, 20);
            this.textBoxCouleur.TabIndex = 11;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(235, 282);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxStock.TabIndex = 13;
            // 
            // textBoxPrixUnite
            // 
            this.textBoxPrixUnite.Location = new System.Drawing.Point(235, 351);
            this.textBoxPrixUnite.Name = "textBoxPrixUnite";
            this.textBoxPrixUnite.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrixUnite.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 17;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddArticle
            // 
            this.buttonAddArticle.Location = new System.Drawing.Point(654, 254);
            this.buttonAddArticle.Name = "buttonAddArticle";
            this.buttonAddArticle.Size = new System.Drawing.Size(75, 75);
            this.buttonAddArticle.TabIndex = 18;
            this.buttonAddArticle.Text = "Ajouter";
            this.buttonAddArticle.UseVisualStyleBackColor = true;
            this.buttonAddArticle.Click += new System.EventHandler(this.buttonAddArticle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 19;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "poids";
            // 
            // textBoxPoids
            // 
            this.textBoxPoids.Location = new System.Drawing.Point(235, 210);
            this.textBoxPoids.Name = "textBoxPoids";
            this.textBoxPoids.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoids.TabIndex = 21;
            // 
            // comboBoxFournisseur
            // 
            this.comboBoxFournisseur.FormattingEnabled = true;
            this.comboBoxFournisseur.Location = new System.Drawing.Point(410, 210);
            this.comboBoxFournisseur.Name = "comboBoxFournisseur";
            this.comboBoxFournisseur.Size = new System.Drawing.Size(175, 21);
            this.comboBoxFournisseur.TabIndex = 22;
            // 
            // GestStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFournisseur);
            this.Controls.Add(this.textBoxPoids);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddArticle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxPrixUnite);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxCouleur);
            this.Controls.Add(this.textBoxLibelle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxArticle);
            this.Name = "GestStock";
            this.Text = "Gestion du stock";
            this.Load += new System.EventHandler(this.GestStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.TextBox textBoxCouleur;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrixUnite;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAddArticle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPoids;
        private System.Windows.Forms.ComboBox comboBoxFournisseur;
    }
}