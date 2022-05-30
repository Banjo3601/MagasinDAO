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
    public partial class InterfaceClient : Form
    {
        public static Utilisateur utilisateurActif;
        public InterfaceClient(Utilisateur uneUtilisateur)
        {
            utilisateurActif = uneUtilisateur;
            InitializeComponent();
        }

        private void InterfaceClient_Load(object sender, EventArgs e)
        {

        }
    }
}
