/*
Esercizio: Scrivere un programma che, data una stringa, restituisca un conteggio delle lettere in essa presenti.
(si consiglia di usare un array con 26 posizioni, una per ogni lettera dell'alfabeto, inizializzato tutto a zeri scorrere la stringa
 e incrementare il contatore della lettera corrispondente).
*/

using System;
using System.Text;

namespace Esercizi_ITS
{
    class Esercizio7
    {
        static void Main(string[] args)
        {
            // Richiedi il nome
            Console.Write("Inserisci una stringa: ");
            string stringa = Console.ReadLine();

            // Conta le lettere contenute nella stringa
            int charNumA = Convert.ToInt32('a');
            int[] lettere = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            byte[] chars = Encoding.ASCII.GetBytes(stringa);
            for (int i = 0; i < chars.Length; ++i)
            {
                int charNum = Convert.ToInt32(chars[i]);
                if (charNum >= charNumA)
                {
                    lettere[charNum - charNumA]++;
                }
            }

            // Stampo il risultato
            Console.WriteLine("La stringa inserita contiene le seguenti lettere:");
            for (int i = 0; i < lettere.Length; ++i)
            {
                if (lettere[i] > 0)
                {
                    Console.WriteLine(" - " + lettere[i] + " lettere " + Convert.ToChar(i + charNumA));
                }
            }

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
