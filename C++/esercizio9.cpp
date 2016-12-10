/**
Scrivere la classe dei numeri complessi. Implementare i metodi:
- Re() (che restituisce la parte reale del numero)
- Im() (che resitutisce la parte immaginaria del numero)
- Mod() (che calcola il modulo)
- Rho() e Theta() (che restituisce la descrizione polare)
- Print() (stampa a console il valore Re + i Im)
Implementare gli operatori
- =(), +(), -(), *(), /()
- =(const double& original) (che esegue le operazioni con double)
- ^(const int& potenza) (che calcola l’elevazione a potenza intera)

Comando per la compilazione: c++ -o esercizio9 esercizio9.cc esercizio9.cpp
*/

#include <iostream>
#include <cmath>
#include "esercizio9.h"

int main() {
	complesso a(1., 2.);
	complesso b(2., 5.);
	complesso c = a;

	// stampo 
	std::cout << "a = ";
	a.Print();
	std::cout << "b = ";
	b.Print();

	c = a+b;
	std::cout << "a+b = ";
	c.Print();  
	c = a-b;
	std::cout << "a-b = ";
	c.Print();  
	c = a*b;
	std::cout << "a*b = ";
	c.Print();  
	c = a/b;
	std::cout << "a/b = ";
	c.Print();  
	c = a^2;
	std::cout << "a^2 = ";
	c.Print();  

	return 0;
}
