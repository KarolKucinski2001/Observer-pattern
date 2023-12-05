using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzObserwatorCw1Zad2
{
    public class Cell : Subject, IObserver
    {
        private byte _value;
        private string _title;
        public byte Value
        {
            get { return this._value; }
            set
            {
                if (this._value != value)
                {
                    this._value = value;
                    Notify();
                }

            }
        }

        public string Title
        {
            get { return this._title; }
        }

        public Cell(byte value, string title)
        {
            this._value = value;
            this._title = title;
        }



        protected override void Notify()
        {
            foreach (IObserver observer in this._observerList)
            {
                observer.Update(this);
            }
        }

        public void Update(Cell cell)
        {
            Console.WriteLine("stara wartość komorki obserwujacej {0} to {1}", Title, Value);
            Value = cell.Value;
            Console.WriteLine("nowa wartośc komorki  {0} to {1}", Title, Value);
        }
    }
}
