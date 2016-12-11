/*
Esercizio: Scrivere una classe Istogramma che permetta di aggiungere numeri, fare la stampa e poi che implementi i metodi:
double GetMean() (che calcola il valor medio)
double GetRMS() (che calcola la deviazione standard)
*/

using System;
using System.Linq;

namespace Esercizi_ITS
{
    public class Istogramma
    {
        public int NumeroBin { get; private set; }
        public double ValoreMinimo { get; private set; }
        public double ValoreMassimo { get; private set; }
        public int[] ContenutoDeiBin { get; private set; }
        public int NumeroElementi { get; private set; }

        public Istogramma () {
	        NumeroBin = 0;
	        ValoreMinimo = 0;
	        ValoreMassimo = 0;
	        ContenutoDeiBin = null;
	        NumeroElementi = 0;
        }

        public Istogramma (int NumeroBin, double ValoreMinimo, double ValoreMassimo) {
            this.NumeroBin = NumeroBin;
            this.ValoreMinimo = ValoreMinimo;
            this.ValoreMassimo = ValoreMassimo;
            ContenutoDeiBin = new int[NumeroBin];
            NumeroElementi = 0;

            //azzero gli elementi dell'istogramma
            Array.Clear(ContenutoDeiBin, 0, ContenutoDeiBin.Length);
        }

        public int Fill(double Value) {
            if (Value < ValoreMinimo || Value >= ValoreMassimo) {
                return -1;
            }
            else {
                ++NumeroElementi;

                // Calcolo il bin in cui deve essere inserito l'elemento
                double InversoStep = NumeroBin / (ValoreMassimo - ValoreMinimo);
                int Bin = (int)((Value - ValoreMinimo) * InversoStep);

                ++ContenutoDeiBin[Bin];

                return Bin;
            }
        }

        public void Print() {
            // normalizza l'istogrammma al valore maggiore
            int Max = ContenutoDeiBin.Max();

            // fattore di dilatazione per la rappresentazione dell'istogramma
            int Scale = 50;

            // disegna l'asse y
            Console.WriteLine("        +---------------------------------------------------------------->");

            double Step = (ValoreMassimo - ValoreMinimo) / NumeroBin;
            // disegna il contenuto dei bin
            for (int i = 0; i < NumeroBin; ++i)
            {
                Console.Write((ValoreMinimo + i * Step).ToString("0.00").PadRight(8) + "|");
                int Frequenza = (int)(Scale * ContenutoDeiBin[i] / Max);
                for (int j = 0; j < Frequenza; ++j)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
            Console.WriteLine("        |\n");
        }

        public double GetMean()
        {
            double Step = (ValoreMassimo - ValoreMinimo) / NumeroBin;
            double Sum = 0;

            for (int i = 0; i < NumeroBin; ++i)
            {
                double Valore = i * Step + ValoreMinimo;
                Sum += Valore * ContenutoDeiBin[i];
            }

            return Sum / NumeroElementi;
        }

        public double GetRms()
        {
            double Step = (ValoreMassimo - ValoreMinimo) / NumeroBin;
            double Sum = 0;
            double SumSquares = 0;

            for (int i = 0; i < NumeroBin; ++i)
            {
                double Valore = i * Step + ValoreMinimo;
                Sum += Valore * ContenutoDeiBin[i];
                SumSquares += Math.Pow(Valore, 2) * ContenutoDeiBin[i];
            }

            return (SumSquares / NumeroElementi - Math.Pow(Sum / NumeroElementi, 2));
        }

        public int GetEntries()
        {
            return NumeroElementi;
        }
    }

    class Esercizio8
    {
        static Random RandomGenerator = new Random();

        static double RandFlat(double ValoreMinimo, double ValoreMassimo)
        {
            return ValoreMinimo + (ValoreMassimo - ValoreMinimo) * RandomGenerator.NextDouble();
        }

        static void Main()
        {
            //creo l'istogramma
            Console.WriteLine("Inserisci gli estremi dell'istogramma [min,max).");
            Console.Write("Estremo min: ");
            double Min = double.Parse(Console.ReadLine());
            Console.Write("Estremo max: ");
            double Max = double.Parse(Console.ReadLine());

            Console.Write("Inserisci il numero di bin dell'istogramma: ");
            int NumeroBin = int.Parse(Console.ReadLine());

            Console.Write("Inserisci quanti numeri casuali vuoi generare: ");
            int Numeri = int.Parse(Console.ReadLine());

            // ctor
            Istogramma Histo = new Istogramma(NumeroBin, Min, Max);

            // riempio l'istogramma
            for (int i = 0; i < Numeri; ++i)
            {
                double number = RandFlat(Min, Max);
                Histo.Fill(number);
            }

            // stampo 
            Console.WriteLine("Mean = " + Histo.GetMean().ToString("####0.00"));
            Console.WriteLine("RMS = " + Histo.GetRms().ToString("####0.00"));
            Histo.Print();

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
