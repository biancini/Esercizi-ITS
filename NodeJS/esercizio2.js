#!/usr/bin/env node
/*
Esercizio: Scrivere un programma che scrive a terminale
la radice quadrata di 2, il cubo di 2 il seno di pigreco/4
*/

'use strict';

var due = 2;
var radice_due = Math.sqrt(due);
console.log("La radice quadrata di due è " + radice_due);

var due_al_cubo = Math.pow(due, 3);
console.log("Il cubo di 2 è: " + due_al_cubo);

var sin_45 = Math.sin(Math.PI/4);
console.log("Il seno di pi/4 è: " + sin_45);
