using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace MagasinDAO_Paolo
{
    public partial class PageDeConnexion : Form
    {
        public Utilisateur utilisateurActif;
        InterfaceAdmin uneInterfaceAdmin;
        InterfaceClient uneInterfaceClient;
        public PageDeConnexion()
        {
            InitializeComponent();
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.PasswordChar = '*';
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void PageDeConnexion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageCreationCompte p = new PageCreationCompte();
            p.Show();
        }

        public void buttonConnexion_Click(object sender, EventArgs e)
        {
            UtilisateurDAO testUtilisateur = new UtilisateurDAO();
            utilisateurActif = testUtilisateur.connexionCompteUtilisateur(textBoxLogin.Text, textBoxPassword.Text);
            if (utilisateurActif != null)
            {
                if(utilisateurActif.IdTypeUtilisateur() == 1){
                    MessageBox.Show("Bienvenue à vous " + utilisateurActif.Nom() + " " + utilisateurActif.Prenom() + " !");
                    uneInterfaceAdmin = new InterfaceAdmin(utilisateurActif);
                    uneInterfaceAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bienvenue à vous " + utilisateurActif.Nom()+ " " + utilisateurActif.Prenom() + " !");
                    uneInterfaceClient = new InterfaceClient(utilisateurActif);
                    uneInterfaceClient.ShowDialog();
                }
            }
        }
    }
}
