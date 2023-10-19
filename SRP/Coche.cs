using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    public class Coche
    {
        private string Marca { get; set; }

        public Coche(string marca)
        {
            Marca = marca;
        }
    }
}
