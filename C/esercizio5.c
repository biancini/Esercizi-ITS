/*
Esercizio: scrivere una funzione che calcoli il fattoriale di un numero intero
non negativo
*/

#include <stdio.h>
#include <stdlib.h>

int main() {
	int input;
	
	// Richiedi il numero
	printf("Inserisci un numero intero (piccolo!): ");
	scanf("%d", &input);

	// Calcola il fattoriale
	int output = 1;
	for (int i = input; i > 0; i--) {
		output *= i;
	}

	// Stampo il risultato
	printf("Il fattoriale di %d è %d.\n", input, output);

	return 0;
}

