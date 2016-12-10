#!/usr/bin/env node
/*
Esercizio: Scrivere una classe Istogramma che permetta di aggiungere numeri, fare la stampa e poi che implementi i metodi:
double GetMean() (che calcola il valor medio)
double GetRMS() (che calcola la deviazione standard)
*/

'use strict';

function Istogramma(nBin, min, max) {
	var nBin_p = (nBin) ? nBin : 0;
	var min_p = (min) ? min : 0;
	var max_p = (max) ? max : 0;
	var binContent_p = new Array();
	var entries_p = 0;
	if (nBin) {
		for (var i = 0; i < nBin_p; ++i) {
			binContent_p.push(0);
		}
	}
	
	return {
        Fill: function(value) {
			if (value < min_p || value >= max_p) {
                return -1;
            }
            else {
                entries_p += 1;

                var invStep = nBin_p / (max_p - min_p);
                var bin = Math.floor((value - min_p) * invStep);

                binContent_p[bin] += 1;

                return bin;
            }
		},
		Print: function() {
            // normalizza l'istogrammma al valore maggiore
            var max = 0;
            for (var i = 0; i < nBin_p; ++i) {
                if (binContent_p[i] > max) {
                    max = binContent_p[i];
                }
            }

            // fattore di dilatazione per la rappresentazione dell'istogramma
            var scale = 50;

            // disegna l'asse y
			var output = "        +---------------------------------------------------------------->\n";
			var invStep = nBin_p / (max_p - min_p);

            // disegna il contenuto dei bin
            for (var i = 0; i < nBin_p; ++i) {
				var label = (min_p + i / invStep).toFixed(2);
				label = "        " + label;
                output += label.slice(-8) + "|";
                var freq = Math.floor(scale * binContent_p[i] / max);
                for (var j = 0; j < freq; ++j) {
                    output += "#";
                }

                output += "\n";
            }
            output += "        |\n";
			
			console.log(output);
        },
		GetMean: function() {
            var step = (max_p - min_p) / nBin_p;
            var sum = 0;

            for (var i = 0; i < nBin_p; ++i) {
                var val = i * step + min_p;
                sum += val * binContent_p[i];
            }

            return sum / entries_p;
        },
        GetRMS: function() {
            var step = (max_p - min_p) / nBin_p;
            var sum = 0;
            var sum2 = 0;

            for (var i = 0; i < nBin_p; ++i) {
                var val = i * step + min_p;
                sum += val * binContent_p[i];
                sum2 += Math.pow(val, 2) * binContent_p[i];
            }

            return (sum2 / entries_p - (sum / entries_p) * (sum / entries_p));
        },
        GetEntries: function() {
            return entries_p;
        }
    };
}

function RandFlat(a, b) {
	var r = a + (b - a) * Math.random();
	return r;
}

var readline = require('readline-sync');
console.log("Inserisci gli estremi dell'intervallo [a,b) in cui generare i numeri.");
var a = parseFloat(readline.question("Estremo a: "));
var b = parseFloat(readline.question("Estremo b: "));

var numeri = parseInt(readline.question("Inserisci quanti numeri casuali vuoi generare: "));

//creo l'istogramma
console.log("Inserisci gli estremi dell'istogramma [min,max).");
var min = parseFloat(readline.question("Estremo min: "));
var max = parseFloat(readline.question("Estremo max: "));

var nBin = parseInt(readline.question("Inserisci il numero di bin dell'istogramma: "));

// ctor
var histo = new Istogramma(nBin, min, max);

// riempio l'istogramma
for (var i = 0; i < numeri; ++i) {
	var number = RandFlat(a, b);
	histo.Fill(number);
}

// stampo 
console.log("Mean = " +  histo.GetMean().toFixed(2));
console.log("RMS = " + histo.GetRMS().toFixed(2));
histo.Print();
