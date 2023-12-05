using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzObserwatorCw1Zad2
{
    public abstract class Subject
    {
        // lista obserwatorów
        protected List<IObserver> _observerList = new List<IObserver>();

        // dodanie nowego obserwatora
        public void Attach(IObserver observer)
        {
            if (!this._observerList.Contains(observer))
                this._observerList.Add(observer);
        }



        // usuniecie danego obserwatora
        public void Detach(IObserver observer)
        {
            if (this._observerList.Contains(observer))
                this._observerList.Remove(observer);
        }

        // powiadamianie obserwatorów o zmianie danych w obserwowanycn podmiocie (Book)
        // implementacja powiadomenia znajduje się w klasie pochodnej Book
        abstract protected void Notify();
    }
}
