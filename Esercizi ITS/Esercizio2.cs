using System;

namespace Esercizi_ITS
{
    class Esercizio2
    {
        static void Main(string[] args)
        {
            // Uso la libreria Math per fare i calcoli
            double radice2 = Math.Sqrt(2);
            double cubo2 = Math.Pow(2, 3);
            double sinPi4 = Math.Sin(Math.PI / 4);

            Console.WriteLine("La radice di due è uguale a " + radice2);
            Console.WriteLine("Il cubo di due è uguale a " + cubo2);
            Console.WriteLine("Il seno di pigrego/4 è uguale a " + sinPi4);

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
