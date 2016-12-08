#!/usr/bin/env node
/*
Esercizio: Scrivere un programma che, data una stringa, restituisca un conteggio delle lettere in essa presenti.
(si consiglia di usare un array con 26 posizioni, una per ogni lettera dell'alfabeto, inizializzato tutto a zeri scorrere la stringa
 e incrementare il contatore della lettera corrispondente).
*/

'use strict';

var readline = require('readline-sync');

var stringa = readline.question("Inserisci una stringa a piacimento: ");

var conteggio = new Array(26);
for (var i = 0; i < 26; ++i) {
	conteggio[i] = 0;
}

var codeA = 'a'.charCodeAt(0);
for (var i = 0; i < stringa.length; ++i) {
	conteggio[stringa.charCodeAt(i) - codeA]++;
}

for (var i = 0; i < 26; ++i) {
	if (conteggio[i] > 0) {
		var lettera = codeA + i;
		console.log("Lettera " + String.fromCharCode(lettera) + " presente " + conteggio[i] + " volte.");
	}
}
