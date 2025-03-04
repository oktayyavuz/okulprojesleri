#include <stdio.h>

int main()
{
    int fiyat, miktar, kdvorani;
    float tutar;
    char ad[50]; 

    printf("Lutfen bir urun adi giriniz: ");
    scanf("%49s", ad);

    printf("Lutfen bir urun fiyati giriniz: ");
    scanf("%d", &fiyat);

    printf("Lutfen bir urun miktari giriniz: ");
    scanf("%d", &miktar); 
    printf("Lutfen bir kdv orani giriniz: ");
    scanf("%d", &kdvorani); 
    tutar = (float)fiyat * miktar * (1 + (kdvorani / 100.0)); 
    printf("\n\n\n\tNo\tUrun Adi\tMiktar\tKDV Orani\tFiyati\tTutari\n");
    printf("\t--\t--------\t------\t---------\t------\t------\n");
    printf("\t01\t%s\t\t  %d\t  %d%%\t\t  %d TL\t%.2f TL\n\n\n", ad, miktar, kdvorani, fiyat, tutar);

}