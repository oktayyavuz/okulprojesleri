#include <stdio.h>

int main()
{
	int sayi1, sayi2 ,sayi3;
	float ort;
	printf("1. sayiyi giriniz: ");
	scanf("%d" ,&sayi1);
	printf("2. sayiyi giriniz: ");
	scanf("%d" ,&sayi2);
	printf("3. sayiyi giriniz: ");
	scanf("%d" ,&sayi3);
    ort = (float)(sayi1 + sayi2 + sayi3)/ 3;
	printf("\nSayilarin Ortalamasi: %f\n\n\n",ort);
	
	
}
