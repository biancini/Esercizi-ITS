/*
Esercizio: scrivete un programma che, letti due numeri interi da
terminale, restituisca il loro rapporto
*/

using System;

namespace Esercizi_ITS
{
    class Esercizio1
    {
        static void Main(string[] args)
        {
            // Leggo i numeri da console, attenzione all'int.Parse per convertire la stringa letta in un numero intero
            Console.Write("Inserisci il primo numero a terminale: ");
            int val1 = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il secondo numero a terminale: ");
            int val2 = int.Parse(Console.ReadLine());

            // Attenzione alla conversione (double) per impostare la precisione delle operazioni
            double rapporto = (double) val1 / val2;
            Console.WriteLine("Il rapporto tra " + val1 + " e " + val2 + " è uguale a " + rapporto);

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
