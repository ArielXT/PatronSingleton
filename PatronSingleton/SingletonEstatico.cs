using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public sealed class SingletonEstatico
    {
        // El atributo _instancia es readonly, por lo que únicamente podrá ser instanciado una sola vez (la primera vez que la clase sea accedida).
        private static readonly SingletonEstatico _instancia = new SingletonEstatico();

        public string Nombre { get; set; }
        public DateTime HoradeInicio { get; set; }

        //Constructor Privado
        private SingletonEstatico()
        {
            Nombre = "Patrón Singleton con Inicializacion Estatica";
            HoradeInicio = DateTime.Now;
        }

        public static SingletonEstatico Instance
        {
            get { return _instancia; }
        }
    }
}
