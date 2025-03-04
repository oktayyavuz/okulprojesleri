#include <stdio.h>

int main()
{
	int yaricap;
	float cevre,alan;
	float pi = 3.14;
	printf("Yaricapi giriniz: ");
	scanf("%d" ,&yaricap);
	
	cevre = (float) (2 * pi * yaricap);
	alan = (float) (pi * (yaricap * yaricap));
	printf("\n\nDairenin cevresi: %f \n\nDairenin alani: %f\n\n\n\n",cevre,alan);
	
}
