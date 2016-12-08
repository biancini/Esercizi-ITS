#!/usr/bin/env node
/*
Esercizio: scrivere un programma che, dato un array di n interi casuali, lo
ordini dal più piccolo al più grande.

Suggerimento: per generare i numeri casuali, usate la funzione rand()
contenuta in cstdlib
*/

'use strict';

// Array di input
var input = [ 3, 2, 6, 7, 9, 1, 5, 4 ];
	
// Ordino l'array
for (var i = 0; i < input.length; ++i) {
	for (var j = i; j < input.length; ++j) {
		if (input[i] > input[j]) {
			var temp = input[i];
			input[i] = input[j];
			input[j] = temp;
		}
	}
}

// Stampo il risultato
var messaggio = "L'array ordinato è [";
for (var i = 0; i < input.length; ++i) {
	messaggio += input[i];
	if (i != input.length - 1) {
		messaggio += ", ";
	}
}
messaggio += "].";
console.log(messaggio);
