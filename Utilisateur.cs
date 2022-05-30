using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagasinDAO_Paolo
{
    public class Utilisateur
    {
        #region attributs
        private int id;
        private string email;
        private string pseudo;
        private string prenom;
        private string nom;
        private string pays;
        private string ville;
        private string codePostal;
        private String adresse;
        private int idTypeUtilisateur;
        private float solde;
        #endregion

        #region constructeur
        public Utilisateur(int id,string email, string pseudo, string prenom, string nom, string ville, string codePostal, string adresse, int idTypeUtilisateur, string pays)
        {
            this.email = email;
            this.pseudo = pseudo;
            this.prenom = prenom;
            this.nom = nom;
            this.ville = ville;
            this.codePostal = codePostal;
            this.adresse = adresse;
            this.id = id;
            this.idTypeUtilisateur = idTypeUtilisateur;
            this.pays = pays;
            this.solde = 0;
        }

        public Utilisateur(int id, string email, string pseudo, string prenom, string nom, string ville, string codePostal, string adresse, int idTypeUtilisateur, string pays, float solde)
        {
            this.email = email;
            this.pseudo = pseudo;
            this.prenom = prenom;
            this.nom = nom;
            this.ville = ville;
            this.codePostal = codePostal;
            this.adresse = adresse;
            this.id = id;
            this.idTypeUtilisateur = idTypeUtilisateur;
            this.pays = pays;
            this.solde = solde;
        }
        #endregion

        #region Méthodes
        public string Email() { return email; }
        public string Pseudo() { return pseudo; }
        public string Prenom() { return prenom; }
        public string Nom() { return nom; }
        public string Ville() { return ville; }
        public string CodePostal() { return codePostal; }
        public string Adresse() { return adresse; }
        public int Id() { return id; }
        public int IdTypeUtilisateur() { return idTypeUtilisateur; }
        public string Pays() { return pays; }
        public float Solde() { return solde; }
        public void modifEmail(string unEmail) { email = unEmail; }
        public void modifPseudo(string unPseudo) { pseudo = unPseudo; }
        public void modifPrenom(string unPrenom) { prenom = unPrenom; }
        public void modifNom(string unNom) {  nom = unNom; }
        public void modifVille(string uneVille) { ville = uneVille; }
        public void modifCodePostal(string unCodePostal) { codePostal = unCodePostal; }
        public void modifAdresse(string uneAdresse) { adresse = uneAdresse; }
        public void modifPays(string unPays) { pays = unPays; }
        public void modifTypeUtilisateur(string unTypeUtilisateur) { idTypeUtilisateur = Convert.ToInt32(unTypeUtilisateur); }

        #endregion
    }
}
