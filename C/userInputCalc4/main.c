#include <stdio.h>

int main()
{
	int vize, final;
	float gecmenotu;
	printf("Vize Notu: ");
	scanf("%d",&vize);
	printf("Final Notu: ");
	scanf("%d",&final);
	gecmenotu = (float) ((float)vize * 40/100) + ((float)final * 60/100);
	

	
	if(vize <=100 && vize >=0 && final <= 100 && final >= 0){
		printf("\n\nNotunuz: %.2f",gecmenotu);
		
		if(gecmenotu >= 60){
			printf("\nGectiniz\n\n");
		}
		else{
			printf("\nKaldiniz\n\n");
		}
	}
	else{
		printf("\nLutfen gecerli final ve vize notu giriniz. (0-100)\n\n");
	}

}
