using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    public class Personne
    {
        /// <summary>
        /// Champs de la classe Personnes.
        /// </summary>
        public string Nom;
        public DateTime DateDeNaissance;
        public string AdresseCourriel;
        public string Nas;

        /// <summary>
        /// Décompte du nombre d'instances de la classe Personne.
        /// </summary>
        public static int NbInstance = 0;

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Personne()
        {
            Nom = "";
            DateDeNaissance = new DateTime(1,1,1);
            AdresseCourriel = "";
            Nas = "";
            NbInstance++;
        }

        /// <summary>
        /// Constructeur prenant en paramàtres des valeurs à affecter au quatre champs de la classe Compte.
        /// </summary>
        /// <param name="pNom"></param>
        /// <param name="pDateDeNaissance"></param>
        /// <param name="pAdresseCourriel"></param>
        /// <param name="pNas"></param>
        public Personne(string pNom, DateTime pDateDeNaissance, string pAdresseCourriel, string pNas)
        {
            Nom = string.Copy(pNom);
            DateDeNaissance = new DateTime(pDateDeNaissance.Year,
                                           pDateDeNaissance.Month,
                                           pDateDeNaissance.Day);
            AdresseCourriel = string.Copy(pAdresseCourriel); ;
            Nas = string.Copy(pNas); ;
            NbInstance++;
        }


        /// <summary>
        /// Constructeur de copie.
        /// </summary>
        /// <param name="pPersonne"></param>
        public Personne(Personne pPersonne)
        {
            Nom = string.Copy(pPersonne.Nom);
            DateDeNaissance = new DateTime(pPersonne.DateDeNaissance.Year,
                                           pPersonne.DateDeNaissance.Month,
                                           pPersonne.DateDeNaissance.Day);
            AdresseCourriel = string.Copy(pPersonne.AdresseCourriel);
            Nas = string.Copy(pPersonne.Nas);
            NbInstance++;
        }

        /// <summary>
        /// Destructeur afin de décrémenter le nombre d'instances de la classe Personnes.
        /// </summary>
        ~Personne()
        {
            NbInstance--;
        }

        /// <summary>
        /// Assignation d’une valeur au champ Nom
        /// </summary>
        /// <param name="pNom"></param>
        public void AssignerNom(string pNom)
        {
            Nom = String.Copy(pNom);
        }

        /// <summary>
        /// Assignation d’une valeur au champ DateDeNaissance
        /// </summary>
        /// <param name="pAnnee"></param>
        /// <param name="pMois"></param>
        /// <param name="pJour"></param>
        public void AssignerDateNaissance(int pAnnee, int pMois, int pJour)
        {
            DateDeNaissance = new DateTime(pAnnee, pMois, pJour);
        }

        /// <summary>
        /// Assignation d’une valeur au champ AdresseCourriel
        /// </summary>
        /// <param name="mCourriel"></param>
        public void AssignerCourriel(string pCourriel)
        {
            AdresseCourriel = String.Copy(pCourriel);
        }

        /// <summary>
        /// Assignation d’une valeur au champ Nas
        /// </summary>
        /// <param name="pNas"></param>
        public void AssignerNas(string pNas)
        {
            Nas = String.Copy(pNas);
        }

        
        /// <summary>
        /// Méthode ToString() affichant la valeur des champs d'un objet de la classe Personne.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string msg = String.Format("\tNom: {0}\n\tDate de naissance: {1}\n\tCourriel: {2}\n\tNAS: {3}", 
                                        Nom, DateDeNaissance.ToShortDateString(), AdresseCourriel, Nas);

            return msg;
        }
    }
}
