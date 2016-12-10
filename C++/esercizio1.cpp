/**
c++ -o esempio1 esempio1.cc esempio1.cpp
*/

#include <iostream>
#include <iomanip>
#include <cmath>
#include <ctime>
#include <cstdlib>
#include "esercizio1.h"

float randFlat(float a, float b)
{
  float r =  a + (b - a) * rand() / (1. * RAND_MAX);
  return r;
}

int main()
{
  srand (time (NULL));
  
  float a = 0.;
  float b = 1.;
  std::cout << "Inserisci gli estremi dell'intervallo [a,b) in cui generare i numeri: ";
  std::cin >> a >> b;
  
  int numeri = 0;
  std::cout << "Inserisci quanti numeri casuali vuoi generare: ";
  std::cin >> numeri;
  
  //creo l'istogramma
  float min = 0.;
  float max = 1.;
  std::cout << "Inserisci gli estremi dell'istogramma [min,max): ";
  std::cin >> min >> max;

  int nBin = 0;
  std::cout << "Inserisci il numero di bin dell'istogramma: ";
  std::cin >> nBin;
  
  // ctor
  istogramma histo(nBin, min, max);
  
  
  // riempio l'istogramma
  for(int i = 0; i < numeri; ++i)
  {
    float number = randFlat(a, b);
    histo.Fill(number);
  }
  
  
  // stampo 
  std::cout << "Mean = "<<  std::setprecision(5) << histo.GetMean()<<std::endl; 
  std::cout << "RMS  = "<<  std::setprecision(5) << histo.GetRMS()<<std::endl; 
  std::cout << "overflow  = "<< histo.GetOverflow()<<std::endl; 
  std::cout << "underflow = "<< histo.GetUnderflow()<<std::endl; 
  histo.Print();
  
  return 0;
}

