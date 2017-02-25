using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Géométrie
{
    public class Arrête
    {
        /// <summary>
        /// Les sommets de la droite.
        /// </summary>
        public Point[] Sommets = null;
        /// <summary>
        /// La longeur de la droite.
        /// </summary>
        public uint Longueur = 0;

        public Arrête()
        {
            Sommets = new Point[2];
            for (int i=0; i<2; i++ )
            {
                Sommets[i] = new Point();
            }
        }

        public Arrête(uint pX1, uint pY1, uint pX2, uint pY2)
        {
            Sommets = new Point[2];
            Sommets[0] = new Point(pX1, pY1);
            Sommets[1] = new Point(pX2, pY2);
            CalulerLongeur();
        }

        public Arrête(Point pPoint1, Point pPoint2)
        {
            Sommets = new Point[2];
            Sommets[0] = new Point(pPoint1);
            Sommets[1] = new Point(pPoint2);
            CalulerLongeur();
        }

        public Arrête(Arrête pArrête)
        {
            Sommets = new Point[2];
            Sommets[0] = new Point(pArrête.Sommets[0]);
            Sommets[1] = new Point(pArrête.Sommets[1]);
            CalulerLongeur();
        }

        /// <summary>
        /// Méthode qui assigne les deux sommets de l'arrête.
        /// </summary>
        /// <param name="pX1"></param>
        /// <param name="pY1"></param>
        /// <param name="pX2"></param>
        /// <param name="pY2"></param>
        public void AssignerSommets(uint pX1, uint pY1, uint pX2, uint pY2)
        {
            Sommets = new Point[2];
            Sommets[0] = new Point();
            Sommets[0].AssignerPosition(pX1, pY1);

            Sommets[1] = new Point();
            Sommets[1].AssignerPosition(pX2, pY2);
        }

        /// <summary>
        /// Calcule de la longueur de l'arrête.
        /// </summary>
        public void CalulerLongeur()
        {
            double diffY = ((double)Sommets[1].Y - (double)Sommets[0].Y);
            double diffX = ((double)Sommets[1].X - (double)Sommets[0].X);
            double longeurDouble = Math.Sqrt((diffY * diffY) + (diffX * diffX));
            Longueur = (uint)Math.Round(longeurDouble,0);
        }

        /// <summary>
        /// Achichage de l'arrête selon le format suivant:
        /// Du sommet (x,y) au sommet (x,y)
        /// Longeur : valeur de Longeur pixels
        /// </summary>
        override public string ToString()
        {
            string msg = "";

            msg += "Du sommet " + Sommets[0] + " au sommet " + Sommets[1];
            msg += "\nLongueur: " + Longueur + " pixels";

            return msg;
        }
    }
}
