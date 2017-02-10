/**
Scrivere una classe Istogramma che permetta di aggiungere numeri, fare la stampa e poi che implementi i metodi:
double GetMean() (che calcola il valor medio)
double GetRMS() (che calcola la deviazione standard)

Comando per la compilazione: c++ -o esercizio8 esercizio8.cc esercizio8.cpp
*/

#include <iostream>
#include <iomanip>
#include <cmath>
#include <ctime>
#include <cstdlib>
#include "esercizio8.h"

// Funzione di supporto che genera un numero Random
double randFlat(double a, double b) {
	double r =  a + (b - a) * rand() / (1. * RAND_MAX);
	return r;
}

int main() {
	srand (time(NULL));

	//creo l'istogramma
	double min = 0.;
	double max = 1.;
	std::cout << "Inserisci gli estremi dell'istogramma [min,max)." << std::endl;
	std::cout << "Estremo min: ";
	std::cin >> min;
	std::cout << "Estremo max: ";
	std::cin >> max;

	int nBin = 0;
	std::cout << "Inserisci il numero di bin dell'istogramma: ";
	std::cin >> nBin;

	int numeri = 0;
	std::cout << "Inserisci quanti numeri casuali vuoi generare: ";
	std::cin >> numeri;


	// ctor
	istogramma histo(nBin, min, max);

	// riempio l'istogramma
	for (int i = 0; i < numeri; ++i) {
		double number = randFlat(min, max);
		histo.Fill(number);
	}

	histo.Print();
	// stampo 
	std::cout << "Mean = " << std::setprecision(5) << histo.GetMean() << std::endl; 
	std::cout << "RMS  = " << std::setprecision(5) << histo.GetRMS() << std::endl; 
	//histo.Print();

	return 0;
}

