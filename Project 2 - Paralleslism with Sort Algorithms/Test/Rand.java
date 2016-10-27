import java.util.Random;
public class Rand
{
	public static int generate_random(int min, int max)
	{
		Random rand = new Random();
    	int randomNum = rand.nextInt((max - min) + 1) + min;
    	return randomNum;
	}

	public static void random_1_to_99()
	{
		int n;
		for(int i = 1; i < 100; i++)
		{
			n = generate_random(1, 99);
			Files.append_file("1_99.txt", String.valueOf(n));
		}
	}

	public static void random_100_to_499()
	{
		int n;
		for(int i = 100; i < 500; i++)
		{
			n = generate_random(100, 499);
			Files.append_file("100_499.txt", String.valueOf(n));
		}
	}

	public static void random_500_to_999()
	{
		int n;
		for(int i = 500; i < 1000; i++)
		{
			n = generate_random(500, 999);
			Files.append_file("500_999.txt", String.valueOf(n));
		}
	}

	public static void random_1000_to_4999()
	{
		int n;
		for(int i = 1000; i < 5000; i++)
		{
			n = generate_random(1000, 4999);
			Files.append_file("1000_4999.txt", String.valueOf(n));
		}
	}

	public static void random_5000_to_9999()
	{
		int n;
		for(int i = 5000; i < 10000; i++)
		{
			n = generate_random(5000, 9999);
			Files.append_file("5000_9999.txt", String.valueOf(n));
		}
	}

	public static void random_10000_to_24999()
	{
		int n;
		for(int i = 10000; i < 25000; i++)
		{
			n = generate_random(10000, 24999);
			Files.append_file("10000_24999.txt", String.valueOf(n));
		}
	}

	public static void random_25000_to_49999()
	{
		int n;
		for(int i = 25000; i < 50000; i++)
		{
			n = generate_random(25000, 49999);
			Files.append_file("25000_49999.txt", String.valueOf(n));
		}
	}

	public static void random_50000_to_99999()
	{
		int n;
		for(int i = 50000; i < 100000; i++)
		{
			n = generate_random(50000, 99999);
			Files.append_file("50000_99999.txt", String.valueOf(n));
		}
	}

	public static void random_100000_to_500000()
	{
		int n;
		for(int i = 100000; i <= 500000; i++)
		{
			n = generate_random(100000, 500000);
			Files.append_file("100000_500000.txt", String.valueOf(n));
		}
	}
	public static void main(String [] args)
	{
		random_1_to_99();
		random_100_to_499();
		random_500_to_999();
		random_1000_to_4999();
		random_5000_to_9999();
		random_10000_to_24999();
		random_25000_to_49999();
		random_50000_to_99999();
		random_100000_to_500000();
		//System.out.println(generate_random(1,2));
	}
}