#!/usr/bin/env node
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

'use strict';

function Complesso(re, im) {
	var re_p = (re) ? re : 0;
	var im_p = (im) ? im : 0;
	
	return {
		getRe: function() {
			return re_p;
		},
		getIm: function() {
			return im_p;
		},
        sum: function (c) {
			var re = re_p + c.getRe();
            var im = im_p + c.getIm();
            var rit = new Complesso(re, im);
            return rit;
        },
		subtract: function (c) {
			var re = re_p - c.getRe();
            var im = im_p - c.getIm();

            var rit = new Complesso(re, im);
            return rit;
        },
		times: function (c) {
            var re = re_p * c.getRe() - im_p * c.getIm();
            var im = im_p * c.getRe() + re_p * c.getIm();

            var rit = new Complesso(re, im);
            return rit;
        },
		divided: function (c) {
            var coeff = Math.pow(c.getRe(), 2) + Math.pow(c.getIm(), 2);
            var re = (re_p * c.getRe() + im_p * c.getIm()) / coeff;
            var im = (c.getRe() * im_p - re_p * c.getIm()) / coeff;

            var rit = new Complesso(re, im);
            return rit;
        },
		pow: function (potenza) {
            var numero = new Complesso(re_p, im_p);

            for (var i = 0; i < potenza; i++) {
                numero = numero.times(numero);
            }

            return numero;
        },
        Mod: function () {
	        return Math.sqrt(Math.pow(re_p, 2) + Math.pow(im_p, 2));
        },
		Rho: function () {
	        return Math.sqrt(Math.pow(re_p, 2) + Math.pow(im_p, 2));
        },
		Theta: function () {
	        if (re_p > 0) {
		        return Math.atan(im_p/re_p);
	        }
	
	        if (re_p < 0) {
		        return Math.atan(im_p/re_p) + Math.PI;
	        }

	        return (im_p > 0) ? Math.PI / 2 : -Math.PI / 2;
        },
		Print: function () {
            console.log(re_p + "+" + im_p + "i");
        }
    };
}

var a = new Complesso(1, 2);
var b = new Complesso(2, 5);
var c;

// stampo 
process.stdout.write("a = ");
a.Print();
process.stdout.write("b = ");
b.Print();

c = a.sum(b);
process.stdout.write("a+b = ");
c.Print();
c = a.subtract(b);
process.stdout.write("a-b = ");
c.Print();
c = a.times(b);
process.stdout.write("a*b = ");
c.Print();
c = a.divided(b);
process.stdout.write("a/b = ");
c.Print();
c = a.pow(2);
process.stdout.write("a^2 = ");
c.Print();