using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MagasinDAO_Paolo
{
    public class ArticleDAO
    {
        #region Attributs
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection conn;
        #endregion

        #region méthodes
        public List<string> getIdArticle()
        {
            List<string> uneListe = new List<string>();
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT id FROM article", conn);
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
                    MessageBox.Show("Il n'y a pas d'article en base.");
                }
                }catch(Exception ex){
                MessageBox.Show("Une erreur s'est produit : " + ex.Message);
            }
            
            return uneListe;
        }

        public Article getInfoArticleByID(string id)
        {
            Article unArticle = null;
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT *, Fournisseur.nom FROM Article JOIN Fournisseur ON Article.idFournisseur = Fournisseur.id WHERE Article.id = " + id, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                unArticle = new Article(Convert.ToInt32(id), dr["libelle"].ToString(), dr["couleur"].ToString(), Convert.ToInt32(dr["stock"].ToString()),
                            float.Parse(dr["prixUnite"].ToString()), dr["nom"].ToString(), Convert.ToInt32(dr["poids"].ToString()));
            }
            dr = null;
            return unArticle;
        }

        public void deleteArticleById(string id)
        {
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("DELETE FROM Article WHERE Article.id = " + id, conn);
            try
            {
                dr = cmd.ExecuteReader();
                MessageBox.Show("La suppresion de l'article est un succès !");
            } catch(Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }
        }

        public void updateArticle(Article unArticle)
        {
            string idFournisseur = this.getFournisseurIdByNameFournisseur(unArticle.Fournisseur);
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("UPDATE Article " +
                "SET libelle = '" + unArticle.Libelle + "', " +
                "poids = " + unArticle.Poids + ", " +
                "couleur = '" + unArticle.Couleur + "', " +
                "stock = " + unArticle.Stock + ", " +
                "prixUnite = " + unArticle.PrixUnite + ", " +
                "idFournisseur = " + idFournisseur + " " +
                "WHERE article.id = " + unArticle.Id, conn);
            try
            {
                dr = cmd.ExecuteReader();
                MessageBox.Show("La modification à été effectuée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue dans la modification : " + ex.Message);
            }
            dr = null;
        }

        public string getFournisseurIdByNameFournisseur(string nomFournisseur) {
            string result = "";
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT Fournisseur.id FROM Fournisseur WHERE Fournisseur.nom = '" + nomFournisseur + "'", conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    result = dr["id"].ToString();
                }
                dr = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("L'obtention de l'id fournisseur à échoué : " + ex.Message);
            }
            return result;
        }

        public List<string> getNomFournisseur()
        {
            List<string> result = new List<string>();
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT nom FROM Fournisseur", conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    result.Add(dr["nom"].ToString());
                }
                dr = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le chargement des noms de fournisseur à échoué : " + ex.Message);
            }

            return result;
        }

        public void addArticle(Article unArticle)
        {
            string idFournisseur = this.getFournisseurIdByNameFournisseur(unArticle.Fournisseur);
            int nombreArticle = this.countArticle();
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("INSERT INTO Article VALUES ("+(nombreArticle+1)+",'"+unArticle.Libelle+"', '"+unArticle.Poids+"', " +
                "'"+unArticle.Couleur+"', '"+unArticle.Stock+"', '"+unArticle.PrixUnite+"', '"+idFournisseur+"' )", conn);
            try
            {
                dr = cmd.ExecuteReader();
                MessageBox.Show("L'ajout de l'article est un succès !");
            }catch(Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'insertion : " + ex.Message);
            }
            dr = null;
        }

        public int countArticle()
        {
            int result = 0;
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT COUNT(*) as nbArticle FROM Article", conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    result = (Convert.ToInt32(dr["nbArticle"].ToString()));
                }
                dr = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du comptage : " + ex.Message);
            }
            dr = null;
            return result;
        }
        #endregion
    }
}
