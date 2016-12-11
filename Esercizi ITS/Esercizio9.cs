/*
Esercizio: Scrivere la classe dei numeri complessi. Implementare i metodi:
- Re() (che restituisce la parte reale del numero)
- Im() (che resitutisce la parte immaginaria del numero)
- Mod() (che calcola il modulo)
- Rho() e Theta() (che restituisce la descrizione polare)
- Print() (stampa a console il valore Re + i Im)
Implementare gli operatori
- =(), +(), -(), *(), /()
- =(const double& original) (che esegue le operazioni con double)
- ^(const int& potenza) (che calcola l’elevazione a potenza intera)
*/

using System;

namespace Esercizi_ITS
{
    public class Complesso
    {
        public double ParteReale { get; private set; }
        public double ParteImmaginaria { get; private set; }

        public Complesso() {
        	ParteReale = 0;
            ParteImmaginaria = 0;
        }

        public Complesso (Complesso Original) {
	        ParteReale = Original.ParteReale;
	        ParteImmaginaria = Original.ParteImmaginaria;
        }

        public Complesso(double Reale, double Immaginaria) {
	        ParteReale = Reale;
	        ParteImmaginaria = Immaginaria;
        }

        public static Complesso operator +(Complesso Complesso1, Complesso Complesso2)
        {
            double Reale = Complesso1.ParteReale + Complesso2.ParteReale;
            double Immaginaria = Complesso1.ParteImmaginaria + Complesso2.ParteImmaginaria;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator -(Complesso Complesso1, Complesso Complesso2)
        {
            double Reale = Complesso1.ParteReale - Complesso2.ParteReale;
            double Immaginaria = Complesso1.ParteImmaginaria - Complesso2.ParteImmaginaria;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator *(Complesso Complesso1, Complesso Complesso2)
        {
            double Reale = Complesso1.ParteReale * Complesso2.ParteReale - Complesso1.ParteImmaginaria * Complesso2.ParteImmaginaria;
            double Immaginaria = Complesso1.ParteImmaginaria * Complesso2.ParteReale + Complesso1.ParteReale * Complesso2.ParteImmaginaria;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator /(Complesso Complesso1, Complesso Complesso2)
        {
            double Coefficiente = Math.Pow(Complesso2.ParteReale, 2) + Math.Pow(Complesso2.ParteImmaginaria, 2);
            double Reale = (Complesso1.ParteReale * Complesso2.ParteReale + Complesso1.ParteImmaginaria * Complesso2.ParteImmaginaria) / Coefficiente;
            double Immaginaria = (Complesso2.ParteReale * Complesso1.ParteImmaginaria - Complesso1.ParteReale * Complesso2.ParteImmaginaria) / Coefficiente;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator +(Complesso Complesso1, double Double2)
        {
            double Reale = Complesso1.ParteReale + Double2;
            double Immaginaria = Complesso1.ParteImmaginaria;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator -(Complesso Complesso1, double Double2)
        {
            double Reale = Complesso1.ParteReale - Double2;
            double Immaginaria = Complesso1.ParteImmaginaria;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator *(Complesso Complesso1, double Double2)
        {
            double Reale = Complesso1.ParteReale * Double2;
            double Immaginaria = Complesso1.ParteImmaginaria * Double2;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator /(Complesso Complesso1, double Double2)
        {
            double Coefficente = Math.Pow(Double2, 2);
            double Reale = (Complesso1.ParteReale * Double2) / Coeffificente;
            double Immaginaria = (Double2 * Complesso1.ParteImmaginaria) / Coefficente;

            return new Complesso(Reale, Immaginaria);
        }

        public static Complesso operator ^(Complesso Complesso1, int Potenza)
        {
            Complesso numero = new Complesso(Complesso1.ParteReale, Complesso1.ParteImmaginaria);

            for (int i = 0; i < Potenza; i++)
            {
                numero = numero * numero;
            }

            return numero;
        }

        public double Mod() {
	        return Math.Sqrt(Math.Pow(ParteReale, 2) + Math.Pow(ParteImmaginaria, 2));
        }

        public double Rho() {
	        return Math.Sqrt(Math.Pow(ParteReale, 2) + Math.Pow(ParteImmaginaria, 2));
        }

        public double Theta() {
	        if (ParteReale > 0) {
		        return Math.Atan(ParteImmaginaria/ParteReale);
	        }
	
	        if (ParteReale< 0) {
		        return Math.Atan(ParteImmaginaria/ParteReale) + Math.PI;
	        }

	        return (ParteImmaginaria > 0) ? Math.PI / 2 : -Math.PI / 2;
        }

        public void Print() {
            Console.WriteLine(ParteReale + "+" + ParteImmaginaria + "i");
        }
    }

    class Esercizio9
    {
        static void Main(string[] args)
        {
            Complesso a = new Complesso(1, 2);
            Complesso b = new Complesso(2, 5);
            Complesso c = new Complesso(a);

            // stampo 
            Console.Write("a = ");
            a.Print();
            Console.Write("b = ");
            b.Print();

            c = a + b;
            Console.Write("a+b = ");
            c.Print();
            c = a - b;
            Console.Write("a-b = ");
            c.Print();
            c = a * b;
            Console.Write("a*b = ");
            c.Print();
            c = a / b;
            Console.Write("a/b = ");
            c.Print();
            c = a ^ 2;
            Console.Write("a^2 = ");
            c.Print();

            // Comando per far mantenere aperta la console in attesa di un enter
            Console.ReadLine();
        }
    }
}
