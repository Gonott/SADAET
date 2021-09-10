using SERVICIOS.ObserverIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public  abstract class Subject  //de aca hereda el objeto a ser observado en este caso idioma.
    {

        private static List<IIdiomaObserver> Observers = new List<IIdiomaObserver>();

        public static void AgregarObserver(IIdiomaObserver observer)
        {
            Observers.Add(observer);
        }

        public static void RemoverObserver(IIdiomaObserver observer)
        {
            Observers.Remove(observer);
        }

        public static void Notify(Idioma idioma)
        {
            foreach (var observer in Observers)
            {
                observer.Update(idioma);

            }
        }


    }
}
