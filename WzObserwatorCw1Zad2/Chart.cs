using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzObserwatorCw1Zad2
{
    public class Chart : IObserver
    {
        private string _chartName;

        public string ChartName
        {
            get { return this._chartName; }
        }

        public Chart(string name)
        {
            this._chartName  = name;
        }


        public void Update(Cell cell)
        {
            string title = cell.Title;
            byte value = cell.Value;
            string chart = new string('+', value);
            Console.WriteLine("-------------");
            Console.WriteLine("Powiadomienie dla wykresu: {0}", this._chartName);
            Console.WriteLine("Komorka {0} zmieniła wartosc na {1}", title, value);
            Console.WriteLine("Plot {0}:{1}",_chartName,chart);
        }

        
    }
}
