package ifelse;

import java.util.Scanner;

public class hizsiniri {

	public static void main(String[] args) {
		
		Scanner kullanici=new Scanner (System.in);
		
		System.out.println("Hızınızı giriniz: ");
		
		int hiz=kullanici.nextInt();
		
		if (hiz >= 60&& hiz <=80) {
			System.out.println("Yüksek hızdan dolayı 1500 Türk lirası cezaya çarptırıldınız.");
		}
		else if (hiz>=81 && hiz<=100) {
			System.out.println("Aşırı Yüksek hızdan dolayı 2500 Türk lirası cezaya çarptırıldınız.");
		}
		else if (hiz>=101) {
			System.out.println("Aşırı Yüksek hızdan dolayı 5000 Türk lirası cezaya çarptırıldınız.");
		}

		else {
			System.out.println("Kullanıcı 50 km/sa hız sınırını aşmadı veya yanlış değer girdin.");
		}
	}

}
