#include <stdio.h>

int main()
{
	int sayi;
	printf("L�tfen bir sayi giriniz:");
	scanf("%d",&sayi);
	if(sayi > 0){
		printf("\n\nSayi Pozitifitir.\n\n");
	}
	else if(sayi < 0){
		printf("\n\nSayi Negatifitir.\n\n");
	}
	else{
		printf("\n\nSayi Sifirdir.\n\n");
	}	
}
