using System;

namespace Esercizi_ITS
{
    class Esercizio6
    {
        static int fattoriale(int input)
        {
            if (input == 0 || input == 1)
            {
                return 1;
            }

            return input * fattoriale(input - 1);
        }

        static void Main(string[] args)
        {
            // Richiedi il numero
            Console.Write("Inserisci un numero intero (piccolo!): ");
            int input = int.Parse(Console.ReadLine());

            // Calcola il fattoriale
            int output = fattoriale(input);

            // Stampo il risultato
            Console.WriteLine("Il fattoriale di " + input + " è " + output + ".");

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
