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

function Complesso(Reale, Immaginaria) {
	var parteReale = 0;
	var parteImmaginaria = 0;

	if (typeof Reale === 'number') {
		parteReale = Reale;
		parteImmaginaria = Immaginaria;
	}
	else {
		parteReale = Reale.getParteReale();
		parteImmaginaria = Reale.getParteImmaginaria();
	}
	
	return {
		getParteReale: function() {
			return parteReale;
		},
		getParteImmaginaria: function() {
			return parteImmaginaria;
		},
		sum: function (c) {
			var Reale = 0;
			var Immaginaria = 0;
			if (typeof c === 'number') {
				Reale = parteReale + c;
				Immaginaria = parteImmaginaria;
			}
			else {
				Reale = parteReale + c.getParteReale();
				Immaginaria = parteImmaginaria + c.getParteImmaginaria();
			}

			return new Complesso(Reale, Immaginaria);
		},
		subtract: function (c) {
			var Reale = 0;
			var Immaginaria = 0;
			if (typeof c === 'number') {
				Reale = parteReame - c;
				Immaginaria = parteImmaginaria;
			}
			else {
				Reale = parteReale - c.getParteReale();
				Immaginaria = parteImmaginaria - c.getParteImmaginaria();
			}

			return new Complesso(Reale, Immaginaria);
		},
		times: function (c) {
			var Reale = 0;
			var Immaginaria = 0;
			if (typeof c === 'number') {
				Reale = parteReale * c;
				Immaginaria = parteImmaginaria * c;
			}
			else {
				Reale = parteReale * c.getParteReale() - parteImmaginaria * c.getParteImmaginaria();
				Immaginaria = parteImmaginaria * c.getParteReale() + parteReale * c.getParteImmaginaria();
			}

			return new Complesso(Reale, Immaginaria);
		},
		divided: function (c) {
			var Reale = 0;
			var Immaginaria = 0;
			if (typeof c === 'number') {
				var coeff = Math.pow(c, 2);
				Reale = (parteReale * c) / coeff;
				Immaginaria = (parteImmaginaria * c) / coeff;
			}
			else {
				var coeff = Math.pow(c.getParteReale(), 2) + Math.pow(c.getParteImmaginaria(), 2);
				Reale = (parteReale * c.getParteReale() + parteImmaginaria * c.getParteImmaginaria()) / coeff;
				Immaginaria = (c.getParteReale() * parteImmaginaria - parteReale * c.getParteImmaginaria()) / coeff;
			}

			return new Complesso(Reale, Immaginaria);
		},
		pow: function (potenza) {
			var numero = new Complesso(parteReale, parteImmaginaria);

			for (var i = 0; i < potenza; i++) {
				numero = numero.times(numero);
			}

			return numero;
		},
		Mod: function () {
			return Math.sqrt(Math.pow(parteReale, 2) + Math.pow(parteImmaginaria, 2));
		},
		Rho: function () {
			return Math.sqrt(Math.pow(parteReale, 2) + Math.pow(parteImmaginaria, 2));
		},
		Theta: function () {
			if (parteReale > 0) {
				return Math.atan(parteImmaginaria/parteReale);
			}
	
			if (parteReale < 0) {
				return Math.atan(parteImmaginaria/parteReale) + Math.PI;
			}

			return (parteImmaginaria > 0) ? Math.PI / 2 : -Math.PI / 2;
		},
		Print: function () {
			console.log(parteReale + "+" + parteImmaginaria + "i");
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
