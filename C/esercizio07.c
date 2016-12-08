/*
Esercizio: Scrivere un programma che, data una stringa, restituisca un conteggio delle lettere in essa presenti.
(si consiglia di usare un array con 26 posizioni, una per ogni lettera dell'alfabeto, inizializzato tutto a zeri scorrere la stringa
 e incrementare il contatore della lettera corrispondente).
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
	char stringa[256];
	printf("Inserisci una stringa a piacimento: ");
	scanf("%[^\n]s", stringa);

	int conteggio[26];
	for (int i = 0; i < 26; ++i) {
		conteggio[i] = 0;
	}

	for (int i = 0; i < strlen(stringa); ++i) {
		conteggio[stringa[i] - 'a']++;
	}

	for (int i = 0; i < 26; ++i) {
		if (conteggio[i] > 0) {
			char lettera = 'a' + i;
			printf("Lettere %c presente %d volte.\n", lettera, conteggio[i]);
		}
	}
	return 0;
}
