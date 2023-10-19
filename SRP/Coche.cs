using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    public class Coche
    {
        private int Id {  get; set; }
        private string Marca { get; set; }
        private string Modelo {  get; set; }
        private int Anio {  get; set; }

        public Coche(int id, string marca, string modelo, int anio)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }
    }
}
