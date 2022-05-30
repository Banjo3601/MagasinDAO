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
    public partial class GestStock : Form
    {
        List<string> uneListe = new List<string>();
        List<string> listeNomF = new List<string>();
        Article unArticle = null;
        ArticleDAO unArticleDAO = new ArticleDAO();
        public GestStock()
        {
            InitializeComponent();
            uneListe = unArticleDAO.getIdArticle();
            foreach (string e in uneListe)
            {
                comboBoxArticle.Items.Add(e);
            }
            listeNomF = unArticleDAO.getNomFournisseur();
            foreach (string f in listeNomF)
            {
                comboBoxFournisseur.Items.Add(f);
            }
        }

        private void GestStock_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArticle.Text != null)
            {

                unArticle = unArticleDAO.getInfoArticleByID(comboBoxArticle.Text);
                if (unArticle != null)
                {
                    textBoxId.Text = Convert.ToString(unArticle.Id);
                    textBoxLibelle.Text = unArticle.Libelle;
                    textBoxCouleur.Text = unArticle.Couleur;
                    textBoxStock.Text = Convert.ToString(unArticle.Stock);
                    textBoxPrixUnite.Text = Convert.ToString(unArticle.PrixUnite);
                    comboBoxFournisseur.Text = unArticle.Fournisseur;
                    textBoxPoids.Text = Convert.ToString(unArticle.Poids);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(unArticle != null)
            {
                unArticleDAO.deleteArticleById(textBoxId.Text);
            }
            else
            {
                MessageBox.Show("Aucun article n'a été sélectionné.");
            }
            textBoxId.Text = null;
            textBoxLibelle.Text = null;
            textBoxCouleur.Text = null;
            textBoxStock.Text = null;
            textBoxPrixUnite.Text = null;
            comboBoxFournisseur.Text = null;
            textBoxPoids.Text = null;
            comboBoxArticle.Text = null;
            comboBoxArticle.Items.Clear();
            comboBoxFournisseur.Text = null;
            comboBoxFournisseur.Items.Clear();
            listeNomF.Clear();
            uneListe.Clear();
            uneListe = unArticleDAO.getIdArticle();
            foreach (string q in uneListe)
            {
                comboBoxArticle.Items.Add(q);
            }
            listeNomF = unArticleDAO.getNomFournisseur();
            foreach(string z in listeNomF)
            {
                comboBoxFournisseur.Items.Add(z);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(unArticle != null)
            {
                unArticle.Libelle = textBoxLibelle.Text;
                unArticle.Couleur = textBoxCouleur.Text;
                unArticle.Stock = Convert.ToInt32(textBoxStock.Text);
                unArticle.PrixUnite = float.Parse(textBoxPrixUnite.Text);
                unArticle.Fournisseur = comboBoxFournisseur.Text;
                unArticle.Poids = Convert.ToInt32(textBoxPoids.Text);
                unArticleDAO.updateArticle(unArticle);
            }
        }

        
        private void buttonAddArticle_Click(object sender, EventArgs e)
        {
            if (unArticle != null)
            {
                unArticle.Libelle = textBoxLibelle.Text;
                unArticle.Couleur = textBoxCouleur.Text;
                unArticle.Stock = Convert.ToInt32(textBoxStock.Text);
                unArticle.PrixUnite = float.Parse(textBoxPrixUnite.Text);
                unArticle.Fournisseur = comboBoxFournisseur.Text;
                unArticle.Poids = Convert.ToInt32(textBoxPoids.Text);
                unArticleDAO.addArticle(unArticle);
            }
            else
            {
                MessageBox.Show("Tous les champs ne sont pas renseignés.");
            }
        }
    }
}
