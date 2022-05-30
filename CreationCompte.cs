using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MagasinDAO_Paolo
{
    public partial class PageCreationCompte : Form
    {
        public PageCreationCompte()
        {
            InitializeComponent();
            textBoxMotDePasseCreation.ForeColor = Color.Black;
            textBoxMotDePasseCreation.PasswordChar = '*';
            textBoxValidationMotDePasse.ForeColor = Color.Black;
            textBoxValidationMotDePasse.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreationCompte_Click(object sender, EventArgs e)
        {
            if(textBoxMotDePasseCreation.Text == textBoxValidationMotDePasse.Text)
            {
                if (textBoxMotDePasseCreation.Text.Length >= 12) {
                    var regexItem = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                    if (regexItem.IsMatch(textBoxMotDePasseCreation.Text) && textBoxMotDePasseCreation.Text.Any(char.IsUpper)
                        && textBoxMotDePasseCreation.Text.Any(char.IsLower) && textBoxMotDePasseCreation.Text.Any(char.IsDigit)) {
                        UtilisateurDAO p = new UtilisateurDAO();
                        bool verif = p.CreateUserDeBase(textBoxNomCreation.Text, textBoxPrenomCreation.Text, textBoxVilleCreation.Text,
                            textBoxCodePostalCreation.Text, textBoxAdresseCreation.Text, textBoxPseudoCreation.Text,
                            textBoxEmailCreation.Text, textBoxMotDePasseCreation.Text, textBoxPays.Text);
                        if (verif)
                        {
                            MessageBox.Show("La création de votre compte a été effectuée avec succès !");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("La création de votre compte a échoué, veuillez essayer ultérieurement.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe manque au moins un type de caractère. (Lettre majuscule, minuscule, chiffre ou caractère spécial.)");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur, Le mot de passe fait moins de 12 caractères.");
                }
            }
            else
            {
                MessageBox.Show("Les deux mot de passe ne correspondent pas. Assurez-vous de donner deux fois le même mot de passe");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
