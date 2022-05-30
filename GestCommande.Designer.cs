namespace MagasinDAO_Paolo
{
    partial class GestCommande
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
            this.comboBoxCommande = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDateCommande = new System.Windows.Forms.TextBox();
            this.buttonDeleteCommande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des toutes les commandes";
            // 
            // comboBoxCommande
            // 
            this.comboBoxCommande.FormattingEnabled = true;
            this.comboBoxCommande.Location = new System.Drawing.Point(227, 75);
            this.comboBoxCommande.Name = "comboBoxCommande";
            this.comboBoxCommande.Size = new System.Drawing.Size(315, 21);
            this.comboBoxCommande.TabIndex = 1;
            this.comboBoxCommande.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommande_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de la commande";
            // 
            // textBoxDateCommande
            // 
            this.textBoxDateCommande.Location = new System.Drawing.Point(279, 179);
            this.textBoxDateCommande.Name = "textBoxDateCommande";
            this.textBoxDateCommande.Size = new System.Drawing.Size(226, 20);
            this.textBoxDateCommande.TabIndex = 3;
            // 
            // buttonDeleteCommande
            // 
            this.buttonDeleteCommande.Location = new System.Drawing.Point(315, 223);
            this.buttonDeleteCommande.Name = "buttonDeleteCommande";
            this.buttonDeleteCommande.Size = new System.Drawing.Size(161, 49);
            this.buttonDeleteCommande.TabIndex = 4;
            this.buttonDeleteCommande.Text = "Supprimer la commande";
            this.buttonDeleteCommande.UseVisualStyleBackColor = true;
            this.buttonDeleteCommande.Click += new System.EventHandler(this.buttonDeleteCommande_Click);
            // 
            // GestCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.buttonDeleteCommande);
            this.Controls.Add(this.textBoxDateCommande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCommande);
            this.Controls.Add(this.label1);
            this.Name = "GestCommande";
            this.Text = "Gestion des commandes";
            this.Load += new System.EventHandler(this.GestCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDateCommande;
        private System.Windows.Forms.Button buttonDeleteCommande;
    }
}