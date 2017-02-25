using CompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'objets de la classe Personne.
            Console.WriteLine("UN GROUPE DE PERSONNES:");
            Personne[] groupeDePersonnes = new Personne[3];
            groupeDePersonnes[0] = new Personne();
            groupeDePersonnes[0].AssignerNom("Robert Charlebois");
            groupeDePersonnes[0].AssignerDateNaissance(1955,6,25);
            groupeDePersonnes[0].AssignerCourriel("rcharlebois@latribu.ca");
            groupeDePersonnes[0].AssignerNas("000 000 000");
            Console.WriteLine("\n" + groupeDePersonnes[0]);
            groupeDePersonnes[1] = new Personne("Plume Latreverse", new DateTime(1946, 5, 11), "nboulais@phaneuf.ca", "who cares!");
            Console.WriteLine("\n" + groupeDePersonnes[1]);
            groupeDePersonnes[2] = new Personne(new Personne("Elvis Gratton", new DateTime(1946, 5, 20), "elvisgratton@gmail.com", "Yeah!"));
            Console.WriteLine("\n" + groupeDePersonnes[2]);

            Console.WriteLine("\nNombre d'instances de la classe Personne: " + Personne.NbInstance);

            // Création d'objets de la classe Compte.
            Console.WriteLine("\n\nCLIENTS DE MA BANQUES: ");
            Compte[] clients = new Compte[3];
            clients[0] = new Compte();
            clients[0].AssignerUnTitulaire(new Personne("Vinny Gambini", new DateTime(1953, 6, 21), "mgambini@gmail.com", "My Cousin Vinny"));
            Console.WriteLine("\n" + clients[0]);

            Personne leParrain = new Personne("Michael Corleone", new DateTime(1920, 10, 15), "mauvaiseidée@hotmail.com", "666 666 666");
            clients[1] = new Compte(leParrain, 3000000000);
            Console.WriteLine("\n" + clients[1]);

            clients[2] = new Compte(clients[1]);
            clients[2].AssignerUnTitulaire(groupeDePersonnes[2]);
            clients[2].DépsoserUnMontant(100000);
            Console.WriteLine("\n" + clients[2]);
            clients[2].RetirerUnMontant(20000);
            clients[2].AfficherSolde();

            Console.WriteLine("\nNombre d'instances de la classe Compte: " + Compte.NbInstance);
            Console.WriteLine("Nombre d'instances de la classe Personne: " + Personne.NbInstance);
        }
    }
}
