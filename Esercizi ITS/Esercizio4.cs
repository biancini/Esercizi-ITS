/*
Esercizio: scrivere un programma che, dato un array di n interi casuali, lo
ordini dal più piccolo al più grande.

Suggerimento: per generare i numeri casuali, usate la funzione rand()
contenuta in cstdlib
*/

using System;

namespace Esercizi_ITS
{
    class Esercizio4
    {
        static void Main(string[] args)
        {
            // Array di input
            int[] input = { 3, 2, 6, 7, 9, 1, 5, 4 };
            
            // Ordino l'array
            for (int i = 0; i < input.Length -1; ++i)
            {
                for (int j = i; j < input.Length; ++j)
                {
                    if (input[i] > input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }

            // Stampo il risultato
            Console.Write("L'array ordinato è [");
            for (int i = 0; i < input.Length; ++i)
            {
                Console.Write(input[i]);
                if (i != input.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("].");

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
