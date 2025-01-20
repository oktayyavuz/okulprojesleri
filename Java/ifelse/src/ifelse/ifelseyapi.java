package ifelse;

public class ifelseyapi {

	public static void main(String[] args) {
		int x = 5;
		int y = 14; 
		int toplam = x+ y;
		if (x>0&&y>0) {
			System.out.println("Toplam sonucumuz: " +toplam);
			
		} else {
			System.out.println("Sayılardan biri veya ikisi birden negatif işlem yapmayacağım!");
		}
	}

}
