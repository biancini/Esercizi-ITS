/*
Esercizio: Scrivere la funzione fattoriale in modo ricorsivo, cioe facendo in modo che la funzione che calcola il fattoriale chiami se stessa.
*/

#include <stdio.h>
#include <stdlib.h>

int fattoriale(int input) {
	if (input == 0 || input == 1) {
		return 1;
	}

	return input * fattoriale(input - 1);
}

int main() {
	int input;
	
	// Richiedi il numero
	printf("Inserisci un numero intero (piccolo!): ");
	scanf("%d", &input);

	// Calcola il fattoriale
	int output = fattoriale(input);

	// Stampo il risultato
	printf("Il fattoriale di %d è %d.\n", input, output);

	return 0;
}

