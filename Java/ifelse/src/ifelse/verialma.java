package ifelse;

import java.util.Scanner;

public class verialma {

	public static void main(String[] args) {
		Scanner test=new Scanner(System.in);
		
		System.out.println("Bir sayı girin: ");
		int a=test.nextInt();
		
		
		if (a>0) {
			System.out.println( a + " Saysısı Pozitiftir.");
		} else if(a<0){
			System.out.println( a + " Saysısı Negatiftir.");
		}else {
			System.out.println(a + " Saysısı Sıfırdır.");
		}
	}
	


}
