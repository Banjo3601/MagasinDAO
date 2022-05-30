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
    public partial class GestCommande : Form
    {
        List<string> listeDesIdCommandes = new List<string>();
        Commande uneCommande = null;
        CommandeDAO uneCommandeDAO = new CommandeDAO(); 
        public GestCommande()
        {
            InitializeComponent();
            listeDesIdCommandes = uneCommandeDAO.getIdCommande();
            foreach(string e in listeDesIdCommandes)
            {
                comboBoxCommande.Items.Add(e);
            }

        }

        private void GestCommande_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            uneCommande = uneCommandeDAO.getInfoCommandeById(comboBoxCommande.Text);
            if(uneCommande != null)
            {
                textBoxDateCommande.Text = Convert.ToString(uneCommande.DateC);
            }
        }

        private void buttonDeleteCommande_Click(object sender, EventArgs e)
        {
            if(comboBoxCommande.Text != null)
            {
                uneCommandeDAO.deleteCommandeById(comboBoxCommande.Text);
            }
            else
            {
                MessageBox.Show("Aucune commande n'a été sélectionnée");
            }
            listeDesIdCommandes = null;
            comboBoxCommande.Text = "";
            comboBoxCommande.Items.Clear();
            textBoxDateCommande.Text = "";
            listeDesIdCommandes = new List<string>();
            listeDesIdCommandes = uneCommandeDAO.getIdCommande();
            foreach (string f in listeDesIdCommandes)
            {
                comboBoxCommande.Items.Add(f);
            }
        }
    }
}
