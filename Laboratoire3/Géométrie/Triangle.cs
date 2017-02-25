using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Géométrie
{
    public class Triangle
    {
        public const int NB_SOMMETS = 3;
        public const int NB_ARRETES = 3;
        public Point[] Sommets = null;
        public Arrête[] Arrêtes = null;


        public Triangle()
        {
            Sommets = new Point[NB_SOMMETS];
            Arrêtes = new Arrête[NB_ARRETES];
            for (int i = 0; i< NB_SOMMETS; i++)
            {
                Sommets[i] = new Point();
                Arrêtes[i] = new Arrête();
            }
        }

        public Triangle(Point pPoint1, Point pPoint2, Point pPoint3)
        {
            Sommets = new Point[NB_SOMMETS];
            Arrêtes = new Arrête[NB_ARRETES];

            Sommets[0] = new Point(pPoint1);
            Sommets[1] = new Point(pPoint2);
            Sommets[2] = new Point(pPoint3);
            
            Arrêtes[0] = new Arrête(pPoint1, pPoint2);
            Arrêtes[1] = new Arrête(pPoint2, pPoint3);
            Arrêtes[2] = new Arrête(pPoint3, pPoint1);
        }

        public Triangle(Triangle pTriangle)
        {
            Sommets = new Point[NB_SOMMETS];
            Arrêtes = new Arrête[NB_ARRETES];

            for (int i = 0; i < NB_SOMMETS; i++)
            {
                Sommets[i] = new Point(pTriangle.Sommets[i]);
                Arrêtes[i] = new Arrête(pTriangle.Arrêtes[i]);
            }
        }




        public void AssignerSommets()
        {
            Sommets = new Point[NB_SOMMETS];
            for (int i=0; i< NB_SOMMETS; i++)
            {
                Sommets[i] = new Géométrie.Point();
            }
        }

        public void AssignerSommets(Point[] pSommets)
        {
            Sommets = new Point[NB_SOMMETS];
            for (int i = 0; i < NB_SOMMETS; i++)
            {
                Sommets[i] = new Géométrie.Point();
                Sommets[i].X = pSommets[i].X;
                Sommets[i].Y = pSommets[i].Y;
            }
        }

        public void AssignerArrêtes()
        {
            Arrêtes = new Arrête[NB_ARRETES];
            for (int i = 0; i < NB_ARRETES; i++)
            {
                Arrêtes[i] = new Géométrie.Arrête();
            }
        }

        public bool PointEncadrerParTriangle(Point lePoint)
        {
            bool estIntérieur = false;

            double AireTotale = Aire();
            double Aire1 = Aire(Sommets[0], Sommets[1], lePoint);
            double Aire2 = Aire(Sommets[1], lePoint, Sommets[2]);
            double Aire3 = Aire(Sommets[2], Sommets[0], lePoint);

            double diff = Math.Abs((Aire1 + Aire2 + Aire3) - AireTotale);
            double ratio = diff / AireTotale;

            if (ratio < 0.01)
            {
                estIntérieur = true;
            }

            return estIntérieur;
        }

        private double Aire()
        {
            double aire = 0.0;

            
            aire = 0.5 * (Sommets[0].X * (Sommets[1].Y - Sommets[2].Y)
                        - Sommets[0].Y * (Sommets[1].X - Sommets[2].X)
                        + (Sommets[1].X * Sommets[2].Y - Sommets[2].X * Sommets[1].Y));

            return aire;
        }

        private double Aire(Point pt1, Point pt2, Point pt3)
        {
            double aire = 0.0;
            int p23Y = (int)(pt2.Y - pt3.Y);
            int p23X = (int)(pt2.X - pt3.X);
            int p23 = (int)(pt2.X * pt3.Y - pt3.X * pt2.Y);

            aire = Math.Abs(0.5 * (pt1.X*p23Y - pt1.Y*p23X + p23));
            
            return aire;
        }

        public override string ToString()
        {
            string msg = "";

            for (int i=0; i<NB_ARRETES; i++)
            {
                msg += Arrêtes[i] + "\n";
            }

            return msg;
        }
    }
}
