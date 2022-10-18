using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatronSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos el Singleton.
            SingletonLambda s = SingletonLambda.Instance;

            // Hacemos una pausa de 3 segundos.
            Thread.Sleep(3000);

            // Instanciamos el segundo Singleton.
            SingletonLambda s2 = SingletonLambda.Instance;

            // Comprobamos que ambos objetos son referencias a la misma instancia, que es única.
            Console.WriteLine(string.Format("Usando: {0} y creado a las {1}",
                s.Nombre, s.HoradeInicio.ToLongTimeString()));

            // Hacemos otra pausa de 2 segundos.
            Thread.Sleep(2000);

            Console.WriteLine(string.Format("Usando: {0} y creado a las {1}",
                s2.Nombre, s2.HoradeInicio.ToLongTimeString()));

            Console.ReadLine();
        }
    }
}
