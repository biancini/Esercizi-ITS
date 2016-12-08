#!/usr/bin/env node
/*
Esercizio: scrivere un programma che:
- chieda all'utente di inserire un intero a scelta tra 1 e 2, e
  restituisca a terminale il valore inserito, o un messaggio di errore
  in caso di inserimento di altri interi
*/

'use strict';

var readline = require('readline-sync');

var valore = parseInt(readline.question('Digita un numero intero x compreso fra 1 e 3: '));
switch(valore) {
	case 1:
		console.log("Bravo, hai inserito 1...");
		break;
	case 2:
		console.log("Bravissimo, hai inserito 2...");
		break;
	default:
		console.log("Vabbè, ma ti avevo detto di inserire 1 o 2........ non " + valore + "!!!");
}
