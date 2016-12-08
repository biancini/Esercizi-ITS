#!/usr/bin/env node

/*
Esercizio: scrivere una funzione che calcoli il fattoriale di un numero intero
non negativo
*/

'use strict';

function fattoriale(input) {
	if (input == 0 || input == 1) {
		return 1;
	}

	return input * fattoriale(input - 1);
}

var readline = require('readline-sync');

var input = parseInt(readline.question("Inserisci un numero intero (piccolo!): "));

// Calcola il fattoriale
var output = fattoriale(input);

// Stampo il risultato
console.log("Il fattoriale di " + input + " è " + output + ".");
