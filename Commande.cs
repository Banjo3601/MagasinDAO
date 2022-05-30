using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagasinDAO_Paolo
{
    public class Commande
    {
        #region attributs
        private int id;
        private DateTime dateC;
        #endregion

        #region constructeur
        public Commande(int id, DateTime dateC)
        {
            this.id = id;
            this.dateC = dateC;
        }

        public int Id { get => id; }
        public DateTime DateC { get => dateC; }
        #endregion

        #region méthodes

        #endregion
    }
}
