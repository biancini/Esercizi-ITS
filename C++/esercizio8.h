#ifndef istogramma_h
#define istogramma_h

#include <iostream>
#include <iomanip>

class istogramma {
	public:
		// default ctor
		istogramma();
		// ctor
		istogramma(const int& nBin, const double& min, const double& max);
		// copy ctor
		istogramma(const istogramma& original);
		// dtor
		~istogramma();
  
		// operator =
		istogramma& operator= (const istogramma& original);
  
		//metodi
		int Fill(const double& value);
		void Print() const;
		double GetMean() const;
		double GetRMS() const;
		int GetEntries() const { return entries_p; };
  
	private:  
		int nBin_p;
		double min_p;
		double max_p;
		int* binContent_p;
		int entries_p;
};

#endif
