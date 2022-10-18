using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public sealed class SingletonLambda
    {
        // Usamos el tipo Lazy<T> para generar la instancia de forma diferida
        private static readonly Lazy<SingletonLambda> _instancia = new Lazy<SingletonLambda>(() => new SingletonLambda());
        public string Nombre { get; set; }
        public DateTime HoradeInicio { get; set; }

        //Constructor Privado
        private SingletonLambda()
        {
            Nombre = "Patrón Singleton con Lazy<T> y expresión Lambda";
            HoradeInicio = DateTime.Now;
        }

        // Accedemos a la propiedad Value de Lazy<SingletonLambda>, provocando su instanciado en el momento de su primer acceso.
        public static SingletonLambda Instance
        {
            get { return _instancia.Value; }
        }
    }
}
