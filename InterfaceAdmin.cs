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
    public partial class InterfaceAdmin : Form
    {
        public static Utilisateur utilisateurActif;
        public InterfaceAdmin(Utilisateur unAdmin)
        {
            InitializeComponent();
            utilisateurActif = unAdmin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InterfaceAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGestUtilisateur_Click(object sender, EventArgs e)
        {
            GestUtilisateur p = new GestUtilisateur();
            p.ShowDialog();
        }

        private void buttonGestStock_Click(object sender, EventArgs e)
        {
            GestStock q = new GestStock();
            q.ShowDialog();
        }

        private void buttonGestCommande_Click(object sender, EventArgs e)
        {
            GestCommande r = new GestCommande();
            r.ShowDialog();
        }
    }
}
