
public class Scopes {

	public static void main(String[] args) {
		Person one = new Person();
		Person two = new Person();
		one.age = 10;
		two.age = 20;
	    Person.planet = "Earth";
		System.out.println(two.age);

	}

}

class Person {
	int age;
	static String planet;
	
	public void move(int distance) {
		{
			int x = 10;
			distance = 10;
		}
		distance = 10;
	}
}
