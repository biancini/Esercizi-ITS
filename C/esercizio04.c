/*
Esercizio: scrivere un programma che, dato un array di n interi casuali, lo
ordini dal più piccolo al più grande.

Suggerimento: per generare i numeri casuali, usate la funzione rand()
contenuta in cstdlib
*/

#include <stdio.h>
#include <stdlib.h>

int main() {
	// Array di input
	int input[8] = { 3, 2, 6, 7, 9, 1, 5, 4 };
	
	// Ordino l'array
	for (int i = 0; i < 8; ++i) {
		for (int j = i; j < 8; ++j) {
			if (input[i] > input[j]) {
				int temp = input[i];
				input[i] = input[j];
				input[j] = temp;
			}
		}
	}

	// Stampo il risultato
	printf("L'array ordinato è [");
	for (int i = 0; i < 8; ++i) {
		printf("%d", input[i]);
		if (i != 7) {
			printf(", ");
		}
	}
	printf("].\n");

	return 0;
}

