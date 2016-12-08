#!/usr/bin/env node
/*
Esercizio: scrivere una funzione che calcoli il fattoriale di un numero intero
non negativo
*/

'use strict';

var readline = require('readline-sync');

var input = parseInt(readline.question("Inserisci un numero intero (piccolo!): "));

// Calcola il fattoriale
var output = 1;
for (var i = input; i > 0; i--) {
	output *= i;
}
// Stampo il risultato
console.log("Il fattoriale di " + input + " è " + output + ".");
