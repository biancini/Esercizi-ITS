#ifndef esempio1_h
#define esempio1_h

#include <iostream>
#include <iomanip>



class istogramma
{
 
 public:
  
  // default ctor
  istogramma ();
  // ctor
  istogramma (const int& nBin, const float& min, const float& max);
  // copy ctor
  istogramma (const istogramma& original);
  // dtor
  ~istogramma ();
  
  
  // operator =
  istogramma& operator= (const istogramma& original);
  
  
  //metodi
  int Fill (const float& value);
  void Print () const;
  float GetMean () const;
  float GetRMS () const;
  int GetEntries () const { return entries_p; };
  int GetOverflow () const { return overflow_p; };
  int GetUnderflow () const { return underflow_p; };
  
  
  
 private:
  
  int nBin_p;
  float min_p;
  float max_p;
  float invStep_p;
  int* binContent_p;
  int entries_p;
  int overflow_p;
  int underflow_p;
  float sum_p;
  float sum2_p;
  
};

#endif
