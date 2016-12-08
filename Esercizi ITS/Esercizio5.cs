/*
Esercizio: scrivere una funzione che calcoli il fattoriale di un numero intero
non negativo
*/

using System;

namespace Esercizi_ITS
{
    class Esercizio5
    {
        static void Main(string[] args)
        {
            // Richiedi il numero
            Console.Write("Inserisci un numero intero (piccolo!): ");
            int input = int.Parse(Console.ReadLine());

            // Calcola il fattoriale
            int output = 1;
            for (int i = input; i > 0; i--)
            {
                output *= i;
            }

            // Stampo il risultato
            Console.WriteLine("Il fattoriale di " + input + " è " + output + ".");

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
