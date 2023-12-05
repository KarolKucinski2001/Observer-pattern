using System;

namespace WzObserwatorCw1Zad2
{

    class Program
    {
        static void Main(string[] args)
        {
            Cell cellA1 = new Cell(5, "A1");
            Cell cellB1 = new Cell(3, "B1");
            Cell cellC1 = new Cell(3, "C1");

            Chart chart1 = new Chart("wykres1");
            Chart chart2 = new Chart("wykres2");
            Chart chart3 = new Chart("wykres3");


            cellA1.Attach(chart1);
            cellB1.Attach(chart2);
            cellC1.Attach(chart3);

            cellA1.Value = 10;
            Console.WriteLine("komórka a1 obserwuje komorke b1");
            cellB1.Attach(cellA1);

            cellB1.Value = 1;
            cellB1.Value = 5;
            //cellB1.Value = 3;
            //cellB1.Value = 4;

            //cellC1.Value = 5;
            //cellC1.Value = 6;
            //cellC1.Value = 7;

            Console.ReadKey();
        }
    }
}
