using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MagasinDAO_Paolo
{
    public class UtilisateurDAO
    {
        #region Attributs
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection conn;
        #endregion

        #region Méthodes
        public bool CreateUserDeBase(string nom, string prenom, string ville, string codePostal, string adresse, string pseudo , string email, string motDePasse, string pays)
        {
            bool result = false;
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT * FROM Utilisateur WHERE email = '"+email+"' OR pseudo = '"+pseudo+"'", conn);
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                dr.Close();
                dr = null;
                
                byte[] grainDeSel = new byte[8];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(grainDeSel);
                string selAStockerEnBase = Convert.ToBase64String(grainDeSel);
                Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(motDePasse, grainDeSel);
                string empreinteAStockerEnBase = Convert.ToBase64String(hash.GetBytes(100));
                cmd = new SqlCommand("INSERT INTO Utilisateur VALUES('" + adresse + "', '" + ville + "', '" + codePostal + "', '" + prenom + "', '" + nom + "'," +
                    " '" + pseudo + "', '" + email + "', '" + empreinteAStockerEnBase + "', '" + 2 + "', '" + selAStockerEnBase + "', " + 0 + ", '" + pays + "')", conn);
                try
                {
                    dr = cmd.ExecuteReader();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Le service n'a pas réussi à créer l'ulilisateur, veuillez réssayer ultérieurement. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Le pseudonyme ou l'email existe déjà, veuillez utiliser un autre email/pseudo pour créer un compte.");
            }
            dr = null;

            return result;
        }


        public Utilisateur connexionCompteUtilisateur(string pseudo, string password) //Le paramètre pseudo peut aussi correspondre à l'email.
        {                                                                             //L'utilisateur peut se connecter avec son email ou avec son pseudo
            Utilisateur unUtilisateur = null;
            dr = null;
            string selRecupBase = "";
            string empreinteRecupBase = "";
            string empreinteACompare;
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT * FROM utilisateur WHERE email = '" + pseudo + "' OR pseudo = '" + pseudo + "'", conn);
            try 
            {
                dr = cmd.ExecuteReader();
            }catch(Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }

            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    selRecupBase = dr["sel"].ToString();
                    empreinteRecupBase = dr["motDePasse"].ToString();
                }
                dr.Close();
                dr = null;
                byte[] grainDeSel = new byte[8];
                grainDeSel = Convert.FromBase64String(selRecupBase);
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                Rfc2898DeriveBytes hash = new Rfc2898DeriveBytes(password, grainDeSel);
                empreinteACompare = Convert.ToBase64String(hash.GetBytes(100));
                if(empreinteACompare == empreinteRecupBase)
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        try
                        {
                            MessageBox.Show("Connexion à votre compte réussie !");
                            unUtilisateur = new Utilisateur(Convert.ToInt32(dr[0]), dr[7].ToString(), dr[6].ToString(), dr[4].ToString(), dr[5].ToString(),
                              dr[2].ToString(), dr[3].ToString(), dr[1].ToString(), Convert.ToInt32(dr[9]), dr["pays"].ToString(), float.Parse(dr["solde"].ToString()));
                            
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Le mot de passe ne conrrespond pas.");
                }

            }
            else
            {
                MessageBox.Show("La connexion au compte à échoué. Le compte spécifié n'existe pas.");
            }

            
            dr = null;

            return unUtilisateur;
        }


        public List<string> getPseudoUtilisateurClient()
        {
            List<string> ret = new List<string>();
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT Pseudo FROM utilisateur WHERE idTypeUtilisateur = '2'", conn);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        ret.Add(dr["pseudo"].ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            dr = null;
            return ret;
        }

        public Utilisateur getInfoUtilisateurByPseudo(string pseudo)
        {
            Utilisateur unUtilisateur = null;
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("SELECT * FROM utilisateur WHERE pseudo = '"+pseudo+"'", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                unUtilisateur = new Utilisateur(Convert.ToInt32(dr["id"].ToString()), dr["email"].ToString(), dr["pseudo"].ToString(), dr["prenom"].ToString(), dr["nom"].ToString(), dr["ville"].ToString()
                    , dr["codePostal"].ToString(), dr["adresse"].ToString(), Convert.ToInt32(dr["idTypeUtilisateur"].ToString()), dr["pays"].ToString(), float.Parse(dr["solde"].ToString()));
            }
            dr = null;
            return unUtilisateur;
        }

        public void updateUtilisateur(Utilisateur unUtilisateur)
        {
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("UPDATE Utilisateur " +
                "SET email = '" + unUtilisateur.Email() + "', " +
                "pseudo = '" + unUtilisateur.Pseudo() + "', " +
                "prenom = '" + unUtilisateur.Prenom() + "', " +
                "nom = '" + unUtilisateur.Nom() + "', " +
                "ville = '" + unUtilisateur.Ville() + "', " +
                "codePostal = '" + unUtilisateur.CodePostal() + "', " +
                "adresse = '" + unUtilisateur.Adresse() + "', " +
                "pays = '" + unUtilisateur.Pays() + "' " +
                "WHERE id = "+unUtilisateur.Id()+"", conn);
            try
            {
                dr = cmd.ExecuteReader();
                MessageBox.Show("La modification à été effectuée avec succès !");
            }catch(Exception ex)
            {
                MessageBox.Show("Une erreur est survenue dans la modification : " + ex.Message);
            }
            dr = null;
        }

        public void deleteUtilisateur(Utilisateur unUtilisateur)
        {
            ConnexionBDD uneConnexion = new ConnexionBDD();
            conn = uneConnexion.getSqlConnection();
            cmd = new SqlCommand("DELETE FROM utilisateur WHERE id = " + unUtilisateur.Id(), conn);
            try
            {
                dr = cmd.ExecuteReader();
                MessageBox.Show("La suppresion du compte à été effectuée avec succès !");
            }catch(Exception ex)
            {
                MessageBox.Show("Une erreur est survenue dans la suppression : " + ex.Message);
            }
            dr = null;
        }
        #endregion
    }
}
