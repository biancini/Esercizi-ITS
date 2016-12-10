#define _USE_MATH_DEFINES
#include <cmath>
#include <iostream>
#include "esercizio2.h"

complesso::complesso()
{
  re_p = 0.;
  im_p = 0.;
}

complesso::complesso (const complesso& original)
{
  re_p = original.re_p;
  im_p = original.im_p;
}

complesso::complesso(const double& re, const double& im)
{
  re_p = re;
  im_p = im;
}

complesso& complesso::operator= (const complesso& original)
{
  re_p = original.re_p;
  im_p = original.im_p;
  
  return *this;
}

complesso complesso::operator+ (const complesso& original)
{
  double re = re_p + original.re_p;
  double im = im_p + original.im_p;
  
  complesso rit(re, im);
  return rit;
}

complesso complesso::operator- (const complesso& original)
{
  double re = re_p - original.re_p;
  double im = im_p - original.im_p;
  
  complesso rit(re, im);
  return rit;
}

complesso complesso::operator* (const complesso& original)
{
  double re = re_p * original.re_p - im_p * original.im_p;
  double im = im_p * original.re_p + re_p * original.im_p;
  
  complesso rit(re, im);
  return rit;
}

complesso complesso::operator/ (const complesso& original)
{
  double coeff = pow(original.re_p, 2) + pow(original.im_p, 2);
  double re = (re_p * original.re_p + im_p * original.im_p) / coeff;
  double im = (original.re_p * im_p - re_p * original.im_p) / coeff;
  
  complesso rit(re, im);
  return rit;
}

complesso& complesso::operator= (const double& original)
{
  re_p = original;
  im_p = 0.;

  return *this;
}

complesso complesso::operator+ (const double& original)
{
  double re = re_p + original;
  double im = im_p;
  
  complesso rit(re, im);
  return rit;
}

complesso complesso::operator- (const double& original)
{
  double re = re_p - original;
  double im = im_p;
  
  complesso rit(re, im);
  return rit;
}

complesso complesso::operator* (const double& original)
{
  double re = re_p * original;
  double im = im_p * original;
  
  complesso rit(re, im);
  return rit;
}

complesso complesso::operator/ (const double& original)
{
  double coeff = pow(original, 2);
  double re = (re_p * original) / coeff;
  double im = (original * im_p) / coeff;
  
  complesso rit(re, im);
  return rit;
}

complesso complesso::operator^ (const int& potenza)
{
  complesso c(re_p, im_p);
  for (int i = 0; i < potenza; i++)
  {
    c = c*c;
  }
  
  return c;
}

double complesso::Re() const
{
  return re_p;
}

double complesso::Im() const
{
  return im_p;
}

double complesso::Mod() const
{
  return sqrt(pow(re_p, 2) + pow(im_p, 2));
}

double complesso::Rho() const
{
  return sqrt(pow(re_p, 2) + pow(im_p, 2));
}

double complesso::Theta() const
{
  if (re_p > 0)
  {
    return atan(im_p/re_p);
  }
  if (re_p < 0)
  {
    return atan(im_p/re_p) + M_PI;
  }

  if (im_p > 0) return M_PI / 2;
  return -M_PI / 2;
}

void complesso::Print() const
{
  std::cout << re_p << "+" << im_p << "i" << std::endl;
}
