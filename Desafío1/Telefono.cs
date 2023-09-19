using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafío1
{
    internal class Telefono
    {
        //Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).
        private string modelo;
        private string marca;
        private string numeroTelefono;
        private int codigoOperador;


        //        Modelo: solo lectura.Es decir, solo get.
        //Marca: solo lectura.
        //NumeroTelefonico: lectura y escritura.
        //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
        //Agregar Constructor que reciba Modelo y Marca.
        //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
        //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.


        //PROPIEDADES
        public string Marca
        {
            get { return marca; }
        }
        public string Modelo
        {
            get { return modelo; }
        }
        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set 
            {
                if (value == 1 || value == 2 || value == 3)
                {
                    codigoOperador = value;
                }
                else
                    codigoOperador = 0;
            }
        }

        //CONSTRUCTORES
        public Telefono(string marca, string modelo)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        // SOBRECARGA CONSTRUCTOR   
        public Telefono () { }

        // METODO LLAMAR
        public string Llamar()
        {
            return "Realizando llamada...";
        }

        //SOBRECARGA METODO
        public string Llamar( string contacto )
        {
            return "Llamando a " + contacto;       
        }
    }
}
