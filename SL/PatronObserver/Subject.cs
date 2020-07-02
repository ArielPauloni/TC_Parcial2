using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.PatronObserver
{
    public abstract class Subject
    {
        private static List<IObserver> _observers = new List<IObserver>();
        public static void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public static void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public static void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.TraducirTexto();
            }
        }
    }
}
