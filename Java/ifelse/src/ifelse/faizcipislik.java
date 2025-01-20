package ifelse;

import java.util.Scanner;

public class faizcipislik {

	public static void main(String[] args) {
		Scanner kredinotu=new Scanner(System.in);
		System.out.print("Kredi notunuzu giriniz: ");
		int kredino=kredinotu.nextInt();
		Scanner istenenpara=new Scanner(System.in);
		System.out.print("İstediğinizi ücret: ");
		int para=istenenpara.nextInt();

		
		
		if (kredino >= 0&& kredino <=50) {
			int faizmiktari = para / 2;
			int sonpara= para + faizmiktari;
			System.out.println("Faiz miktarınız %50'dir. Geri ödenecek para miktarı: " +sonpara);
		}else if (kredino >= 51&& kredino <=75) {
			int faizmiktari = (int) (para *0.35);
			int sonpara= para + faizmiktari;
			System.out.println("Faiz miktarınız %35'dir Geri ödenecek para miktarı: " +sonpara);
		}else if (kredino >= 76&& kredino <=100) {
			int faizmiktari = (int) (para *0.20);
			int sonpara= para + faizmiktari;
			System.out.println("Faiz miktarınız %20'dir Geri ödenecek para miktarı: " +sonpara);
		}

		else {
			System.out.println("Hatalı sayı girdiniz.");
		}
	}

}
