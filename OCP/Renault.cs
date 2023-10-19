using SolidPrinciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    public class Renault : Coche
    {
        public Renault(string marca) : base(marca)
        {
            
        }

        public override int precioMedioCoche()
        {
            return 18000;
        }
    }
}
