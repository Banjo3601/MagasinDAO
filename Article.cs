using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagasinDAO_Paolo
{
    public class Article
    {
        #region Attributs
        private int id;
        private string libelle;
        private string couleur;
        private int stock;
        private float prixUnite;
        private string fournisseur;
        private int poids;
        #endregion

        # region Constructeur
        public Article(int id, string libelle, string couleur, int stock, float prixUnite, string fournisseur, int poids)
        {
            this.id = id;
            this.Libelle = libelle;
            this.couleur = couleur;
            this.Stock = stock;
            this.PrixUnite = prixUnite;
            this.fournisseur = fournisseur;
            this.poids = poids;
        }

        #endregion

        #region Méthodes

        public int Id { get => id; }
        public string Libelle { get => libelle; set => libelle = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Stock { get => stock; set => stock = value; }
        public float PrixUnite { get => prixUnite; set => prixUnite = value; }
        public string Fournisseur { get => fournisseur; set => fournisseur = value; }
        public int Poids { get => poids; set => poids = value; }

        #endregion
    }
}
