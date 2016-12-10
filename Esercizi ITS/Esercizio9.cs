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
        double re_p { get; set; }
        double im_p { get; set; }

        public Complesso() {
        	re_p = 0;
            im_p = 0;
        }

        public Complesso (Complesso original) {
	        re_p = original.re_p;
	        im_p = original.im_p;
        }

        public Complesso(double re, double im) {
	        re_p = re;
	        im_p = im;
        }

        
        public static Complesso operator +(Complesso c1, Complesso c2)
        {
            double re = c1.re_p + c2.re_p;
            double im = c1.im_p + c2.im_p;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator -(Complesso c1, Complesso c2)
        {
            double re = c1.re_p - c2.re_p;
            double im = c1.im_p - c2.im_p;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator *(Complesso c1, Complesso c2)
        {
            double re = c1.re_p * c2.re_p - c1.im_p * c2.im_p;
            double im = c1.im_p * c2.re_p + c1.re_p * c2.im_p;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator /(Complesso c1, Complesso c2)
        {
            double coeff = Math.Pow(c2.re_p, 2) + Math.Pow(c2.im_p, 2);
            double re = (c1.re_p * c2.re_p + c1.im_p * c2.im_p) / coeff;
            double im = (c2.re_p * c1.im_p - c1.re_p * c2.im_p) / coeff;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator +(Complesso c, double d)
        {
            double re = c.re_p + d;
            double im = c.im_p;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator -(Complesso c, double d)
        {
            double re = c.re_p - d;
            double im = c.im_p;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator *(Complesso c, double d)
        {
            double re = c.re_p * d;
            double im = c.im_p * d;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator /(Complesso c, double d)
        {
            double coeff = Math.Pow(d, 2);
            double re = (c.re_p * d) / coeff;
            double im = (d * c.im_p) / coeff;

            Complesso rit = new Complesso(re, im);
            return rit;
        }

        public static Complesso operator ^(Complesso c, int potenza)
        {
            Complesso numero = new Complesso(c.re_p, c.im_p);

            for (int i = 0; i < potenza; i++)
            {
                numero = numero * numero;
            }

            return numero;
        }

        public double Mod() {
	        return Math.Sqrt(Math.Pow(re_p, 2) + Math.Pow(im_p, 2));
        }

        public double Rho() {
	        return Math.Sqrt(Math.Pow(re_p, 2) + Math.Pow(im_p, 2));
        }

        public double Theta() {
	        if (re_p > 0) {
		        return Math.Atan(im_p/re_p);
	        }
	
	        if (re_p< 0) {
		        return Math.Atan(im_p/re_p) + Math.PI;
	        }

	        return (im_p > 0) ? Math.PI / 2 : -Math.PI / 2;
        }

        public void Print() {
            Console.WriteLine(re_p + "+" + im_p + "i");
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
