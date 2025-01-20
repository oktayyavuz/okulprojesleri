package ifelse;

import java.util.Scanner;

public class urunfiyathesap {

	public static void main(String[] args) {
		Scanner urunadeti=new Scanner(System.in);
		
		System.out.println("Ürün adeti giriniz: ");
		
		int adet=urunadeti.nextInt();
		
		int fiyat= 56;
		
		int toplamfiyat= fiyat*adet;
		
		if (toplamfiyat >= 0&& toplamfiyat <=250) {
			int toplam= toplamfiyat+150;
			System.out.println("Kargo ücretiniz  150 TL. Ödenecek tutar: " + toplam);
		}
		else if (toplamfiyat >= 251&& toplamfiyat <=500) {
			int toplam= toplamfiyat+50;
			System.out.println("Kargo ücretiniz  50 TL. Ödenecek tutar: " + toplam);
		}
		else if (toplamfiyat >= 501) {
			int toplam= toplamfiyat;
			System.out.println("Kargonuz ücretsizdir. Ödenecek tutar: " + toplam);
		}

		else {
			System.out.println("Hatalı adet.");
		}
	}

}
