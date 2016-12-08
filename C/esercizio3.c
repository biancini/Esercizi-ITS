/*
Esercizio: scrivere un programma che:
- chieda all'utente di inserire un intero a scelta tra 1 e 2, e
  restituisca a terminale il valore inserito, o un messaggio di errore
  in caso di inserimento di altri interi
*/

#include <stdio.h>
#include <stdlib.h>

int main () {
	// Leggo un numero intero e stampo il suo valore in lettere usando uno switch
	int valore;
	printf("Digita un numero intero x compreso fra 1 e 3: ");
	scanf("%d", &valore);
	
	switch(valore) {
		case 1:
			printf("Bravo, hai inserito 1...\n");
			break;

		case 2:
			printf("Bravissimo, hai inserito 2...\n");
			break;

		default:
			printf("Vabbè, ma ti avevo detto di inserire 1 o 2........ non %d!!!...\n", valore);
	}
    
	return 0;
}
