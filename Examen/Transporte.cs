using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Transporte
    {
       string nombre = " ", color = " ", marca = "";
        
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
        public Transporte(string nombre, string color, string numllantas)
        {
            this.nombre = nombre;
            this.color = color;
            this.marca = numllantas;
        }
        public void Encender()
        {
            Console.WriteLine(" el transporte se ha encendido");
        }
        public void Avanzar()
        {
            Console.WriteLine(" el transporte esta avanzando");
        }
        public void Apagar()
        {
            Console.WriteLine(" el transporte se ha apagado ");
        }
    }
}
