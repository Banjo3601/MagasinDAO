using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MagasinDAO_Paolo
{
    public class ConnexionBDD
    {
        #region Attributs
        private string ChaineDeConnexion = "Data source=DESKTOP-QNJJMKF;Initial Catalog=bdd_magasin_dao;Integrated Security = SSPI;";

        public SqlConnection ObjetDeConnexion;
        public bool ConnexionEtablie;
        #endregion


        #region Constructeur
        public ConnexionBDD()
        {
            try
            {
                ObjetDeConnexion = new SqlConnection(ChaineDeConnexion);
                ObjetDeConnexion.Open();
                ConnexionEtablie = true;
            }
            catch(Exception ex){
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
                ConnexionEtablie=false;
            }
        }
        #endregion

        #region Méthodes
        public SqlConnection getSqlConnection()
        {
            return ObjetDeConnexion;
        }
        #endregion
    }
}
