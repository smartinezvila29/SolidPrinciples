using SolidPrinciples.OCP;
using SolidPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {

            Coche[] arrayCoches = {
            new Renault("Renault"),
            new Audi("Audi"),
            new Mercedes("Mercedes")
        };

            imprimirPrecioMedioCoche(arrayCoches);
        }
        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach(Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }
    }
}
