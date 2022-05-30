using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MagasinDAO_Paolo
{
    public class CommandeDAO
    {
        #region Attributs
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection conn;
        #endregion

        #region méthodes
        public List<string> getIdCommande()
        {
            List<string> uneListe = new List<string>();
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT * FROM CommandeUser", conn);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        uneListe.Add(dr["id"].ToString());
                    }
                    dr.Close();
                    dr = null;
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de commande en base.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produit : " + ex.Message);
            }

            return uneListe;
        }

        public Commande getInfoCommandeById(string id)
        {
            Commande uneCommande = null;
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT dateC FROM CommandeUser WHERE id = " + id, conn);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        uneCommande = new Commande(Convert.ToInt32(id), Convert.ToDateTime(dr["dateC"].ToString()));
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : "+ex.Message);
            }
            return uneCommande;
        }

        public void deleteCommandeById(string id)
        {
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("DELETE FROM LigneCmdUser WHERE idCommandeUser = "+id+"" +
                "DELETE FROM LigneLivArticle WHERE idLivraisonArticle = (SELECT id FROM LivraisonArticle WHERE idCommandeUser = "+id+")" +
                "DELETE FROM LivraisonArticle WHERE idCommandeUser = "+id+"" +
                "DELETE FROM CommandeUser WHERE id = "+id+"", conn);
            try
            {
                dr = cmd.ExecuteReader();
                MessageBox.Show("La suppression de la commande à été faite avec succès !");
            }catch(Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la supression de la commande : " + ex.Message);
            }
            dr = null;
        }
        #endregion
    }
}
