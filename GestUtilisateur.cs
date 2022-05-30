using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagasinDAO_Paolo
{
    public partial class GestUtilisateur : Form
    {
        
        List<string> uneListe = new List<string>();
        Utilisateur unUtilisateur = null;
        UtilisateurDAO unUtilisateurDAO = new UtilisateurDAO();
        public GestUtilisateur()
        {
            InitializeComponent();
            uneListe = unUtilisateurDAO.getPseudoUtilisateurClient();
            foreach (string e in uneListe)
            {
                cbBoxUtilisateurClientNom.Items.Add(e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            unUtilisateur = unUtilisateurDAO.getInfoUtilisateurByPseudo(cbBoxUtilisateurClientNom.Text);
            if (unUtilisateur != null)
            {
                textBoxEmail.Text = unUtilisateur.Email();
                textBoxPseudo.Text = unUtilisateur.Pseudo();
                textBoxPrenom.Text = unUtilisateur.Prenom();
                textBoxNom.Text = unUtilisateur.Nom();
                textBoxVille.Text = unUtilisateur.Ville();
                textBoxCodePostal.Text = unUtilisateur.CodePostal();
                textBoxAdresse.Text = unUtilisateur.Adresse();
                textBoxId.Text = Convert.ToString(unUtilisateur.Id());
                textBoxTypeUtilisateur.Text = Convert.ToString(unUtilisateur.IdTypeUtilisateur());
                textBoxPays.Text = unUtilisateur.Pays();
                textBoxSolde.Text = Convert.ToString(unUtilisateur.Solde());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(unUtilisateur != null)
            {
                unUtilisateur.modifEmail(textBoxEmail.Text);
                unUtilisateur.modifPseudo(textBoxPseudo.Text);
                unUtilisateur.modifPrenom(textBoxPrenom.Text);
                unUtilisateur.modifNom(textBoxNom.Text);
                unUtilisateur.modifVille(textBoxVille.Text);
                unUtilisateur.modifCodePostal(textBoxCodePostal.Text);
                unUtilisateur.modifAdresse(textBoxAdresse.Text);
                unUtilisateur.modifTypeUtilisateur(textBoxTypeUtilisateur.Text);
                unUtilisateur.modifPays(textBoxPays.Text);
                unUtilisateurDAO.updateUtilisateur(unUtilisateur);
            }
            else
            {
                MessageBox.Show("Aucun utilisateur n'a été sélectionné.");
            }
            cbBoxUtilisateurClientNom.Text = null;
            uneListe = null;
            cbBoxUtilisateurClientNom.Items.Clear();
            uneListe = unUtilisateurDAO.getPseudoUtilisateurClient();
            foreach (string unPseudo in uneListe)
            {
                cbBoxUtilisateurClientNom.Items.Add(unPseudo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (unUtilisateur != null)
            {
                unUtilisateurDAO.deleteUtilisateur(unUtilisateur);
            }
            else
            {
                MessageBox.Show("Aucun utilisateur n'a été sélectionné.");
            }
            textBoxEmail.Text = null;
            textBoxPseudo.Text = null;
            textBoxPrenom.Text = null;
            textBoxNom.Text = null;
            textBoxVille.Text = null;
            textBoxCodePostal.Text = null;
            textBoxAdresse.Text = null;
            textBoxId.Text = null;
            textBoxTypeUtilisateur.Text = null;
            textBoxPays.Text = null;
            textBoxSolde.Text = null;
            cbBoxUtilisateurClientNom.Text = null;
            uneListe = null;
            cbBoxUtilisateurClientNom.Items.Clear();
            uneListe = unUtilisateurDAO.getPseudoUtilisateurClient();
            foreach (string unPseudo in uneListe)
            {
                cbBoxUtilisateurClientNom.Items.Add(unPseudo);
            }
        }

        private void GestUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
