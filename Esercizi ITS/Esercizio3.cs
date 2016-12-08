/*
Esercizio: scrivere un programma che:
- chieda all'utente di inserire un intero a scelta tra 1 e 2, e
  restituisca a terminale il valore inserito, o un messaggio di errore
  in caso di inserimento di altri interi
*/

using System;

namespace Esercizi_ITS
{
    class Esercizio3
    {
        static void Main(string[] args)
        {
            // Richiedo il numero da inserire
            Console.Write("Inserisi un numero intero uguale a 1 o a 2 da tastiera: ");
            int valore = int.Parse(Console.ReadLine());

            switch (valore)
            {
                case 1:
                    Console.WriteLine("Bravo, hai inserito 1...");
                    break;
                case 2:
                    Console.WriteLine("Bravissimo, hai inserito 2...");
                    break;
                default:
                    Console.WriteLine("Vabbè, ma ti avevo detto di inserire 1 o 2........ non " + valore + "!!!");
                    break;
            }

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
