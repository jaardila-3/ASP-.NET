using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int edad = 32;
        int añoActual = 2020;

        static void Main(string[] args)
        {
            string numeroComoString = "128";
            int valorParseado;
            //tryparse
            bool exito = int.TryParse(numeroComoString, out valorParseado);
            if (exito)
                Console.WriteLine("Parsing exitoso - el numero es {0}", valorParseado);
            else
                Console.WriteLine("Parsing fallido");

            //operador ternario
            numeroComoString = valorParseado < 128 ? "menor a 128" : "mayor o igual a 128";
            Console.WriteLine(numeroComoString);

            numeroComoString = valorParseado < 128 ? "menor a 127" : valorParseado == 128 ? "igual a 128" : "mayor a 128";
            Console.WriteLine(numeroComoString);

            //concatenar segunda opcion
            string nombre = "Jorge";
            string apellido = "Ardila";
            int hijos = 1;
            Console.WriteLine("Hola! soy {0} {1} y tengo {2} hijo", nombre, apellido, hijos);
            //Console.ReadLine(); // para leer una linea de consola

            
            Console.Read();
        }

        //formas de usar el metodo get - set
        //los atributos se escriben con mayuscula inicial
        //se llama al atributo sin necesidad de especificar el get o set
        public int Edad
        {
            get
            {
                return edad; //too: return a*b*c;
            }
            set
            {
                edad = value;
            }
        }

        public int Año {
            get {
                return añoActual;
            } 
            set {
                if (value < 0) throw new Exception("El año debe ser positivo");
                //if (value < 0) value = -value;
                añoActual = value;
            } 
        }

        public int CualquierEdad
        {
            get => edad;
            set => edad = value;
        }
    }
}
