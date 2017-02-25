using Géométrie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test des constructeurs de la classe Point.
            Point premierPoint = new Point();
            Console.WriteLine("\npremierPoint : " + premierPoint);

            Point deuxièmePoint = new Point(150, 150);
            Console.WriteLine("\ndeuxièmePoint : " + deuxièmePoint);

            //Point troisièmePoint = new Point(new Point(200,200));
            Point troisièmePoint = new Point(new Point(200,200));
            Console.WriteLine("\ntroisièmePoint : " + troisièmePoint);

            Arrête arrête1 = new Arrête();
            Console.WriteLine("\narrête1 : " + arrête1);
            Arrête arrête2 = new Arrête(100,200, 300, 400);
            Console.WriteLine("\narrête2 : " + arrête2);
            Arrête arrête3 = new Arrête(premierPoint, new Point(300, 400));
            Console.WriteLine("\narrête3 : " + arrête3);
            Arrête arrête4 = new Arrête(arrête3);
            Console.WriteLine("\narrête4 : " + arrête4);

            Triangle triangle1 = new Triangle();
            Console.WriteLine("\ntriangle1 : " + triangle1);
            Triangle triangle2 = new Triangle(new Point(100, 100),
                                              new Point(200, 200),
                                              new Point(50, 150));
            Console.WriteLine("\ntriangle2 : " + triangle2);


            Triangle triangle3 = new Triangle(triangle2);
            Console.WriteLine("\ntriangle3 : " + triangle3);
        }
    }
}
