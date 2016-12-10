/**
c++ -o esercizio2 esercizio2.cc esercizio2.cpp
*/

#include <iostream>
#include <cmath>
#include "esercizio2.h"

int main()
{
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

