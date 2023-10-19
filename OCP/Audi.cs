using SolidPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public class Audi : Coche
    {
        public Audi(string marca) : base(marca)
        {
        }

        public override int precioMedioCoche()
        {
            return 25000;
        }
    }
}
