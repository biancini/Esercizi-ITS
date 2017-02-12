using System;

namespace Esempi_Test
{
    public class Program
    {
        /// <summary>
        /// Metodo che effettua la somma di due addendi e ne restituisce il risultato.
        /// </summary>
        /// <param name="addend1">Primo addendo.</param>
        /// <param name="addend2">Secondo addendo.</param>
        /// <returns>Il risultato della somma dei due addendi.</returns>
        public int add(int addend1, int addend2)
        {
            return addend1 + addend2;
        }

        /// <summary>
        /// Metodo main che testa il metodo add
        /// </summary>
        static void Main()
        {
            // Leggo i numeri da console, attenzione all'int.Parse per convertire la stringa letta in un numero intero
            Console.Write("Inserisci il primo numero a terminale: ");
            int val1 = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il secondo numero a terminale: ");
            int val2 = int.Parse(Console.ReadLine());

            Program p = new Program();
            int somma = p.add(val1, val2);
            Console.WriteLine("La somma tra " + val1 + " e " + val2 + " è uguale a " + somma);

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
