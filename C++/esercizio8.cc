#include "esercizio8.h"
#include <iostream>
#include <iomanip>
#include <cmath>

// default ctor ------------------------------------------------------------------------------------
istogramma::istogramma () {
	nBin_p = 0;
	min_p = 0.;
	max_p = 0.;
	binContent_p = 0;
	entries_p = 0;
}

// ctor --------------------------------------------------------------------------------------------
istogramma::istogramma (const int &nBin, const double &min, const double &max) {
	nBin_p = nBin;
	min_p = min;
	max_p = max;
	binContent_p = new int[nBin_p];
	entries_p = 0;
	
	//azzero gli elementi dell'istogramma
	for (int i = 0; i < nBin_p; ++i) {
		binContent_p[i] = 0;
	}
}

// copy ctor ---------------------------------------------------------------------------------------
istogramma::istogramma (const istogramma& original) {
	nBin_p = original.nBin_p;
	min_p = original.min_p;
	max_p = original.max_p;
	binContent_p = new int[original.nBin_p];
	entries_p = original.entries_p;
	
	//copio gli elementi dell'istogramma
	for (int i = 0; i < nBin_p; ++i) {
		binContent_p[i] = original.binContent_p[i];
	}
}

// dtor --------------------------------------------------------------------------------------------
istogramma::~istogramma() {
	delete[] binContent_p;
}

// operator= ---------------------------------------------------------------------------------------
istogramma& istogramma::operator= (const istogramma& original) {
	if (binContent_p) delete[] binContent_p;

	nBin_p = original.nBin_p;
	min_p = original.min_p;
	max_p = original.max_p;
	binContent_p = new int[original.nBin_p];
	entries_p = original.entries_p;

	//copio gli elementi dell'istogramma
	for (int i = 0; i < nBin_p; ++i) {
		binContent_p[i] = original.binContent_p[i];
	}

	return *this;
}

// methods -----------------------------------------------------------------------------------------
int istogramma::Fill(const double& value) {
	if (value < min_p || value >= max_p) {
		return -1;
	}
	else  {
		++entries_p;
    
		double invStep = nBin_p/(max_p-min_p);
		int bin = int((value-min_p)*invStep);
		++binContent_p[bin];
		
		return bin;
	}
}

double istogramma::GetMean() const {
	double step = (max_p-min_p)/nBin_p;
	double sum = 0.;
	
	for (int i = 0; i < nBin_p; ++i) {
		double val = i * step + min_p;
		sum += val * binContent_p[i];	
	}
	
	return sum/entries_p;
}

double istogramma::GetRMS() const {
	double step = (max_p-min_p)/nBin_p;
	double sum = 0.;
	double sum2 = 0.;
	
	for (int i = 0; i < nBin_p; ++i) {
		double val = i * step + min_p;
		sum += val * binContent_p[i];
		sum2 += pow(val, 2) * binContent_p[i];
	}
	
	return (sum2/entries_p - (sum/entries_p)*(sum/entries_p));
}

void istogramma::Print() const {
	// normalizza l'istogrammma al valore maggiore
	int max = 0;
	for (int i = 0; i < nBin_p; ++i) {
		if (binContent_p[i] > max) {
			max = binContent_p[i];
		}
	}

	// fattore di dilatazione per la rappresentazione dell'istogramma
	int scale = 50;

	// disegna l'asse y
	std::cout << "        +---------------------------------------------------------------->" << std::endl;

	double invStep = nBin_p/(max_p-min_p);
	// disegna il contenuto dei bin
	for (int i = 0; i < nBin_p; ++i) {
		std::cout << std::fixed << std::setw(8) << std::setprecision(2) << min_p + i / invStep <<"|";
		int freq = int(scale * binContent_p[i] / max);
		for (int j = 0; j < freq; ++j) {
			std::cout << "#";
		}

		std::cout << std::endl;
	}
	std::cout << "        |\n" << std::endl;
}
