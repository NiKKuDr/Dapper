
public class Constructors {

	public static void main(String[] args) {
		// 1 pizza
		Pizza pizza = new Pizza();
		pizza.slices = 8;
		// 2 pie
		Pizza pie = new Pizza(6);
		// 1
		pizza.eat();
		System.out.println(pizza.slices);
		System.out.println(pie.slices);
	}
}

class Pizza {
	int slices;
	String topping;
	Pizza () {}
	Pizza(int pieces) {
		slices = pieces;
	}
	public void eat() {
		slices = slices - 1;
	}
}
