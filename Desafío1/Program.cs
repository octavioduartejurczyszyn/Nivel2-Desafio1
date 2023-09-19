using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Iphone", "11");
                Console.WriteLine("Marque el nro al que desea llamar: ");
            t1.NumeroTelefono = Console.ReadLine();
                Console.WriteLine("Marque el nro de código: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());
                Console.WriteLine("Código de operador: " + t1.CodigoOperador);
                if(t1.CodigoOperador == 1 || t1.CodigoOperador == 2 || t1.CodigoOperador == 3) 
            { 
                Console.WriteLine("El número de teléfono es: " + t1.NumeroTelefono + ", marca " + t1.Marca + " y modelo " + t1.Modelo);
                Console.WriteLine(t1.Llamar());
                Console.ReadKey();
            }
                else 
            { 
                Console.WriteLine("No se puede realizar ninguna llamada dado que el código es inválido.");           
                Console.ReadKey();
            }
        }
    }
}
