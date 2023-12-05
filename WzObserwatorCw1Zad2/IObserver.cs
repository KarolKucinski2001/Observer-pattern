using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzObserwatorCw1Zad2
{
    public interface IObserver
    {
        void Update(Cell cell);
    }
}
