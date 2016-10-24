import java.util.Random;

public class Rand
{
	public static int generate_random(int min, int max)
	{
		Random rand = new Random();
		int rand_number = (int)(rand.nextDouble() * max + min);
		return rand_number;
	}
	public static void main(String [] args)
	{
		int numero = generate_random(1,100);
		System.out.println(numero);
	}
}