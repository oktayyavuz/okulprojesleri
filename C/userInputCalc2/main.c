#include <stdio.h>

int main()
{
	int sayi1, sayi2 ,toplam,carpim,fark;
	float bolum;
	printf("1. sayiyi giriniz: ");
	scanf("%d" ,&sayi1);
	printf("2. sayiyi giriniz: ");
	scanf("%d" ,&sayi2);
	carpim = sayi1 * sayi2;
	toplam = sayi1 + sayi2;
	bolum = (float)sayi1 / sayi2;
	fark = sayi1 - sayi2;
	printf("\nSayilarin Toplami: %d\n",toplam);
	printf("Sayilarin Carpimi: %d\n",carpim);
	printf("Sayilarin Bolumu: %f\n",bolum);
	printf("Sayilarin Farki: %d\n\n\n\n",fark);
	
}
