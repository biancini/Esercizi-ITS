#!/usr/bin/env node
/*
Esercizio: scrivete un programma che, letti due numeri interi da
terminale, restituisca il loro rapporto
*/

'use strict';

var readline = require('readline-sync');

var numero1 = parseInt(readline.question('Inserisci il primo numero: '));
var numero2 = parseInt(readline.question('Inserisci il secondo numero: '));

var rapporto = numero1/numero2;
console.log("Il rapporto tra i due numeri è: " + rapporto);
