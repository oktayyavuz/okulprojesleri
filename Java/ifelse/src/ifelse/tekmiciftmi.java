package ifelse;

import java.util.Scanner;

public class tekmiciftmi {

	public static void main(String[] args) {
		Scanner tekcift=new Scanner(System.in);
		
		System.out.println("0 ve 10 aralığında bir sayı giriniz: ");
		
		int sayi=tekcift.nextInt();
		
		
		
		if (sayi >= 0&& sayi <=10) {
			if (sayi %2 == 0) {
				System.out.println("Sayı çifttir.");
			} else {
				System.out.println("Sayı tektir.");

			}
		}

		else {
			System.out.println("Hatalı sayı girdiniz.");
		}
	}

}
