using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagasinDAO_Paolo
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnexionBDD tentativeDeConnexion = new ConnexionBDD();
            if (tentativeDeConnexion.ConnexionEtablie)
            {
                MessageBox.Show("Connexion à la base de données réussie !");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PageDeConnexion());

            }
        }
    }
}
