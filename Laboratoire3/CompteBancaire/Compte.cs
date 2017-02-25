using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class Compte
    {
        /// <summary>
        /// Solde de l'objet compte.
        /// </summary>
        public decimal Solde;

        /// <summary>
        /// Numéro du compte.
        /// </summary>
        public int NuméroCompte;

        /// <summary>
        /// Titulaire du compte.
        /// </summary>
        public Personne Titulaire;

        /// <summary>
        /// Nombre d'instances de la classe comptes. 
        /// </summary>
        public static int NbInstance = 0;

        /// <summary>
        /// Constructer de défaut.
        /// </summary>
        public Compte()
        {
            Solde = 0.0M;
            Titulaire = null;
            générerNumCompte();
            NbInstance++;
        }

        /// <summary>
        /// Constructeur recevant en paramètre, une personne qui sera titulaire du compte.
        /// </summary>
        /// <param name="pTitulaire"></param>
        public Compte(Personne pTitulaire, decimal pDépot)
        {
            Solde = pDépot;
            Titulaire = new Personne(pTitulaire);
            générerNumCompte();
            NbInstance++;
        }

        /// <summary>
        /// Constructer de copie.
        /// </summary>
        public Compte(Compte pCompte)
        {
            Solde = 0.0M;
            Titulaire = new Personne(pCompte.Titulaire);
            générerNumCompte();
            NbInstance++;
        }

        /// <summary>
        /// Destructeur de la classe Compte implémenté afin de décrémenter le nombre d'instances
        /// de cette classes.
        /// </summary>
        ~Compte()
        {
            NbInstance++;
        }

        /// <summary>
        /// Génération d'un numéro de compte aléatoirement.
        /// </summary>
        private void générerNumCompte()
        {
            Random rdm = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            NuméroCompte = rdm.Next(100000, 1000000);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pTitulaire"></param>
        public void AssignerUnTitulaire(Personne pTitulaire)
        {
            Titulaire = new Personne(pTitulaire);
        }

        /// <summary>
        /// Méthode permettant d'effeuctuer un retrait du compte.
        /// </summary>
        /// <param name="retrait"></param>
        public void RetirerUnMontant(decimal montant)
        {
            Solde -= montant;
        }

        /// <summary>
        /// Méthode permettant de déposer un montant dans le compte.
        /// </summary>
        /// <param name="retrait"></param>
        public void DépsoserUnMontant(decimal montant)
        {
            Solde += montant;
        }

        /// <summary>
        /// Afficher le solde dans le compte.
        /// </summary>
        public void AfficherSolde()
        {
            Console.WriteLine("\n\tNuméro de compte: {0}", NuméroCompte);
            Console.WriteLine("\tSolde.............{0} $\n", Decimal.Round(Solde, 2));
        }


        override public string ToString()
        {
            string msg = "";

            msg = String.Format("Information sur le compte: \n\n{0}", Titulaire);
            msg += String.Format("\n\tNuméro de compte: {0}", NuméroCompte);
            msg += String.Format("\n\tSolde.............{0} $\n", Decimal.Round(Solde, 2));

            return msg;
        }
    }
}
