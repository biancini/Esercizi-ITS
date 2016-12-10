/*
Esercizio: Scrivere una classe Istogramma che permetta di aggiungere numeri, fare la stampa e poi che implementi i metodi:
double GetMean() (che calcola il valor medio)
double GetRMS() (che calcola la deviazione standard)
*/

using System;

namespace Esercizi_ITS
{
    public class Istogramma
    {
        int nBin_p { get; set; }
        double min_p { get; set; }
        double max_p { get; set; }
        int[] binContent_p { get; set; }
        int entries_p { get; set; }

        public Istogramma () {
	        nBin_p = 0;
	        min_p = 0;
	        max_p = 0;
	        binContent_p = null;
	        entries_p = 0;
        }

        public Istogramma (int nBin, double min, double max) {
            nBin_p = nBin;
            min_p = min;
            max_p = max;
            binContent_p = new int[nBin_p];
            entries_p = 0;
	
            //azzero gli elementi dell'istogramma
            for (int i = 0; i<nBin_p; ++i) {
	            binContent_p[i] = 0;
            }
        }

        public int Fill(double value) {
            if (value < min_p || value >= max_p) {
                return -1;
            }
            else {
                ++entries_p;

                double invStep = nBin_p / (max_p - min_p);
                int bin = (int)((value - min_p) * invStep);

                ++binContent_p[bin];

                return bin;
            }
        }

        public void Print() {
            // normalizza l'istogrammma al valore maggiore
            int max = 0;
            for (int i = 0; i < nBin_p; ++i)
            {
                if (binContent_p[i] > max)
                {
                    max = binContent_p[i];
                }
            }

            // fattore di dilatazione per la rappresentazione dell'istogramma
            int scale = 50;

            // disegna l'asse y
            Console.WriteLine("        +---------------------------------------------------------------->");

            double invStep = nBin_p / (max_p - min_p);
            // disegna il contenuto dei bin
            for (int i = 0; i < nBin_p; ++i)
            {
                Console.Write((min_p + i / invStep).ToString("####0.00") + "|");
                int freq = (int)(scale * binContent_p[i] / max);
                for (int j = 0; j < freq; ++j)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
            Console.WriteLine("        |\n");
        }

        public double GetMean()
        {
            double step = (max_p - min_p) / nBin_p;
            double sum = 0;

            for (int i = 0; i < nBin_p; ++i)
            {
                double val = i * step + min_p;
                sum += val * binContent_p[i];
            }

            return sum / entries_p;
        }

        public double GetRMS()
        {
            double step = (max_p - min_p) / nBin_p;
            double sum = 0;
            double sum2 = 0;

            for (int i = 0; i < nBin_p; ++i)
            {
                double val = i * step + min_p;
                sum += val * binContent_p[i];
                sum2 += Math.Pow(val, 2) * binContent_p[i];
            }

            return (sum2 / entries_p - (sum / entries_p) * (sum / entries_p));
        }

        public int GetEntries()
        {
            return entries_p;
        }
    }

    class Esercizio8
    {
        static Random random = new Random();

        static double RandFlat(double a, double b)
        {
            double r = a + (b - a) * random.NextDouble();
            return r;
        }

        static void Main(string[] args)
        {
            Console.Write("Inserisci gli estremi dell'intervallo [a,b) in cui generare i numeri: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.Write("Inserisci quanti numeri casuali vuoi generare: ");
            int numeri = int.Parse(Console.ReadLine());

            //creo l'istogramma
            Console.Write("Inserisci gli estremi dell'istogramma [min,max): ");
            double min = double.Parse(Console.ReadLine());
            double max = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il numero di bin dell'istogramma: ");
            int nBin = int.Parse(Console.ReadLine());

            // ctor
            Istogramma histo = new Istogramma(nBin, min, max);

            // riempio l'istogramma
            for (int i = 0; i < numeri; ++i)
            {
                double number = RandFlat(a, b);
                histo.Fill(number);
            }

            // stampo 
            Console.WriteLine("Mean = " + histo.GetMean().ToString("####0.00"));
            Console.WriteLine("RMS = " + histo.GetRMS().ToString("####0.00"));
            histo.Print();

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
