using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class Singleton
    {
        // Declaramos un atributo del mismo tipo de la clase con carácter estático.
        private static Singleton _instancia = null;

        public string Nombre { get; set; }
        public DateTime HoradeInicio { get; set; }

        // Creamos el constructor privado. Únicamente puede ser invocado desde el interior de la propia clase.
        private Singleton()
        {
            Nombre = "Patrón Singleton";
            HoradeInicio = DateTime.Now;
        }

        public static Singleton Instance
        {
            get
            {
                // Si el singleton no ha sido creado previamente, se instancia.
                // Caso contrario, se devolverá el que haya sido creado previamente
                if (_instancia == null)
                    _instancia = new Singleton();

                // Se devuelve la instancia
                return _instancia;
            }
        }
    }
}