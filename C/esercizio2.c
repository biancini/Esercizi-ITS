/*
Esercizio: Scrivere un programma che scrive a terminale
la radice quadrata di 2, il cubo di 2 il seno di pigreco/4
*/

#include <stdio.h>
#include <stdlib.h>
#include <math.hl>

int main () {
	double due = 2;
	double radice_due = sqrt(due);
	printf("La radice quadrata di due è %2.5f.\n", radice_due);

	double due_al_cubo = pow(2., 3);
	printf("Il cubo di 2 è: %2.5f.\n", due_al_cubo);

	double sin_45 = sin(M_PI/4.);
	printf("Il seno di pi/4 è: %2.5f.\n", sin_45);

	return 0;
}
