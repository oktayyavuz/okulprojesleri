#include <stdio.h>
#include <math.h>

int main()
{
	int a, b, c,delta;
	float kok,kok1,kok2;
	printf("a katsayisini giriniz: ");
	scanf("%d",&a);
	printf("b katsayisini giriniz: ");
	scanf("%d",&b);
	printf("c katsayisini giriniz: ");
	scanf("%d",&c);
	delta = b*b-4*a*c;
	
	printf("Delta = %d\n\n",delta);
	
	if(delta < 0){
		printf("\n\nDenklemin reel kokleri yoktur.\n\n");
		return 0;
	}
	else if(delta == 0){
		kok = -b/(2*a);
		printf("\n\nDenklemin 1 adet reel koku vardir.\nKok: %.2f\n\n",kok);
	}
	else
	{
		kok1 = (-b+sqrt(delta))/(2*a);
		kok2 = (-b-sqrt(delta))/(2*a);
		printf("\n\nDenklemin 2 adet reel koku vardir.\n\nKok 1: %.2f\nKok 2: %.2f\n\n",kok1,kok2);
	}
}
