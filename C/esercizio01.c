/*
Esercizio: scrivete un programma che, letti due numeri interi da
terminale, restituisca il loro rapporto
*/

#include <stdio.h>
#include <stdlib.h>

int main () {
	int numero1, numero2;
	
	printf("Inserisci il primo numero: ");
	scanf("%d", &numero1);
	
	printf("Inserisci il secondo numero: ");
	scanf("%d", &numero2);

	float rapporto = (float)numero1 / numero2;

	printf("Il repporto tra i due numeri è: %2.5f.\n", rapporto);
	return 0;
}
