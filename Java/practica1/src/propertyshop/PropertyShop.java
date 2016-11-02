package propertyshop;

import java.util.Scanner;

public class PropertyShop {

    public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int index = sc.nextInt();
		
		Property p1 = new Property();
		
		if (index == 0) {
			p1.setName("Juan");
			System.out.print(p1.getName());
			return;
		}
		
		if (index == 1) {
			p1.setName("Paco");
			p1.setName(null);
			System.out.print(p1.getName());
			return;
		}
		
		if (index == 2) {
			p1.setAddress("Juan");
			System.out.print(p1.getAddress());
			return;
		}
		
		if (index == 3) {
			p1.setAddress("Juan");
			p1.setAddress(null);
			String value = p1.getAddress();
			System.out.print(value == null || value.equals("juan") || value.equals(""));
			return;
		}
		
		if (index == 4) {
			double value = 1;
			p1.setConstructedSurface(value);
			System.out.print(p1.getConstructedSurface() == 1.0);
			return;
		}
		
		if (index == 5) {
			double value = 1;
			p1.setConstructedSurface(value);
			p1.setConstructedSurface(-1);
			System.out.print(p1.getConstructedSurface() == 1.0);
			return;
		}
		
		if (index == 6) {
			double value = 1;
			p1.setConstructedSurface(value);
			p1.setConstructedSurface(0);
			System.out.print(p1.getConstructedSurface() == 1.0);
			return;
		}
		
		if (index == 7) {
			p1.setOwner("Juan");
			String value = p1.getOwner();
			System.out.print(value.equals("juan"));
			return;
		}
		
		if (index == 8) {
			p1.setOwner("Juan");
			p1.setOwner(null);
			String value = p1.getOwner();
			System.out.print(value == null || value.equals("juan") || value.equals(""));
			return;
		}
	
		if (index == 9) {
			p1.setAddress("Juan");
			String value = p1.getAddress();
			System.out.print(value.equals("juan"));
			return;
		}
		
		if (index == 10) {
			p1.setAddress("Juan");
			p1.setAddress(null);
			String value = p1.getAddress();
			System.out.print(value == null || value.equals("juan") || value.equals(""));
			return;
		}
	
		if (index == 11) {
			int value = 1;
			p1.setPrice(value);
			System.out.print(p1.getPrice() == 1.0);
			return;
		}
		
		if (index == 12) {
			int value = 1;
			p1.setPrice(value);
			p1.setPrice(-1);
			System.out.print(p1.getPrice() == 1.0);
			return;
		}
		
		if (index == 13) {
			int value = 1;
			p1.setPrice(value);
			p1.setPrice(0);
			System.out.print(p1.getPrice() == 1.0);
		}
		
    }
    
}
