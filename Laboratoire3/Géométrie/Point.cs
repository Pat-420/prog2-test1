using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Géométrie
{
    public class Point
    {
        // Position du point à l'écran.
        public uint X, Y;

        /// <summary>
        /// Constructeur par défault de la classe point.
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Contructeur recevant coordonnées x et y d'un point.
        /// </summary>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        public Point(uint pX, uint pY)
        {
            X = pX;
            Y = pY;
        }

        public Point(Point pPoint)
        {
            X = pPoint.X;
            Y = pPoint.Y;
        }


        /// <summary>
        /// Assigne une valeur aux champs X et Y .
        /// </summary>
        /// <param name="mX"></param>
        /// <param name="mY"></param>
        public void AssignerPosition(uint mX, uint mY)
        {
            X = mX;
            Y = mY;
        }

        
        override public string ToString()
        {
            string msg = "";

            msg += "(" + X + "," + Y + ")";

            return msg;
        }

       
    } // Fin de la classe Point.
}
