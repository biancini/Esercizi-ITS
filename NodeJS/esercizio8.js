#!/usr/bin/env node
/*
Esercizio: Scrivere una classe Istogramma che permetta di aggiungere numeri, fare la stampa e poi che implementi i metodi:
double GetMean() (che calcola il valor medio)
double GetRMS() (che calcola la deviazione standard)
*/

'use strict';

function Istogramma(nBin, min, max) {
	var numeroBin = (nBin) ? nBin : 0;
	var valoreMinimo = (min) ? min : 0;
	var valoreMassimo = (max) ? max : 0;
	var binContent = new Array();
	var entries = 0;
	if (nBin) {
		for (var i = 0; i < numeroBin; ++i) {
			binContent.push(0);
		}
	}
	
	return {
		Fill: function(value) {
			if (value < valoreMinimo || value >= valoreMassimo) {
				return -1;
			}
			else {
				entries += 1;

				var invStep = numeroBin / (valoreMassimo - valoreMinimo);
				var bin = Math.floor((value - valoreMinimo) * invStep);

				binContent[bin] += 1;

				return bin;
			}
		},
		Print: function() {
			// normalizza l'istogrammma al valore maggiore
			var max = 0;
			for (var i = 0; i < numeroBin; ++i) {
				if (binContent[i] > max) {
					max = binContent[i];
				}
			}

			// fattore di dilatazione per la rappresentazione dell'istogramma
			var scale = 50;

			// disegna l'asse y
			var output = "	+---------------------------------------------------------------->\n";
			var invStep = numeroBin / (valoreMassimo - valoreMinimo);

			// disegna il contenuto dei bin
			for (var i = 0; i < numeroBin; ++i) {
				var label = (valoreMinimo + i / invStep).toFixed(2);
				output += ("        " + label).slice(8-label.length) + "|";
				var freq = Math.floor(scale * binContent[i] / max);
				for (var j = 0; j < freq; ++j) {
					output += "#";
				}

				output += "\n";
			}
			output += "	|\n";
			
			console.log(output);
		},
		GetMean: function() {
			var step = (valoreMassimo - valoreMinimo) / numeroBin;
			var sum = 0;

			for (var i = 0; i < numeroBin; ++i) {
				var val = i * step + valoreMinimo;
				sum += val * binContent[i];
			}

			return sum / entries;
		},
		GetRMS: function() {
			var step = (valoreMassimo - valoreMinimo) / numeroBin;
			var sum = 0;
			var sum2 = 0;

			for (var i = 0; i < numeroBin; ++i) {
				var val = i * step + valoreMinimo;
				sum += val * binContent[i];
				sum2 += Math.pow(val, 2) * binContent[i];
			}

			return (sum2 / entries - (sum / entries) * (sum / entries));
		},
		GetEntries: function() {
			return entries;
		}
	};
}

function RandFlat(a, b) {
	var r = a + (b - a) * Math.random();
	return r;
}

var readline = require('readline-sync');

//creo l'istogramma
console.log("Inserisci gli estremi dell'istogramma [min,max).");
var min = parseFloat(readline.question("Estremo min: "));
var max = parseFloat(readline.question("Estremo max: "));

var nBin = parseInt(readline.question("Inserisci il numero di bin dell'istogramma: "));
var numeri = parseInt(readline.question("Inserisci quanti numeri casuali vuoi generare: "));

// ctor
var histo = new Istogramma(nBin, min, max);

// riempio l'istogramma
for (var i = 0; i < numeri; ++i) {
	var number = RandFlat(min, max);
	histo.Fill(number);
}

// stampo 
console.log("Mean = " +  histo.GetMean().toFixed(2));
console.log("RMS = " + histo.GetRMS().toFixed(2));
histo.Print();
