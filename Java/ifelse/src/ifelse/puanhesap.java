package ifelse;

public class puanhesap {

	public static void main(String[] args) {
		
		int puan = 44;
		
		if (puan >= 0&& puan <=40) {
			System.out.println("Kaldı");
		}
		else if (puan>=41 && puan<=60) {
			System.out.println("Sorumlu geçti");
		}
		else if (puan>=61 && puan<=80) {
			System.out.println("Geçti");
		}
		else if (puan>=81 && puan<=100) {
			System.out.println("Aferin");
		}
		else {
			System.out.println("Hata");
		}
	}

}
