import java.util.ArrayList;

public class Main
{
	public static void BurbbleSort_1_99()
	{
		int [] array = new int[100];
		// burbble sort
		Files.readfile_by_line_array("1_99.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_100_499()
	{
		int [] array = new int[400];
		// burbble sort
		Files.readfile_by_line_array("100_499.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_500_999()
	{
		int [] array = new int[500];
		// burbble sort
		Files.readfile_by_line_array("500_999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_1000_4999()
	{
		int [] array = new int[4000];
		// burbble sort
		Files.readfile_by_line_array("1000_4999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_5000_9999()
	{
		int [] array = new int[5000];
		// burbble sort
		Files.readfile_by_line_array("5000_9999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_10000_24999()
	{
		int [] array = new int[15000];
		// burbble sort
		Files.readfile_by_line_array("10000_24999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_25000_49999()
	{
		int [] array = new int[25000];
		// burbble sort
		Files.readfile_by_line_array("25000_49999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_50000_99999()
	{
		int [] array = new int[50000];
		// burbble sort
		Files.readfile_by_line_array("50000_99999.txt", array);
		//BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void BurbbleSort_100000_500000()
	{
		int [] array = new int[400001];
		// burbble sort
		Files.readfile_by_line_array("100000_500000.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
	}

	public static void main(String [] args)
	{
		long time_start, time_end, time;
		time_start = System.currentTimeMillis();
		BurbbleSort_100000_500000();
		time_end = System.currentTimeMillis();
		time = time_end - time_start;
		System.out.println("Time : " + time);
		
	}	
}