class BurbbleSort_1_n extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[MainRange.cant_numeros];
		String file_name = "1_" + MainRange.cant_numeros + ".txt";
		String file_name_sorted = "Burbblesort_1-" + MainRange.cant_numeros + "_sorted.txt";
		String sorted_ubication = "sorted/" + file_name_sorted;
		// burbble sort
		long time_start, time_end, time;
		time_start = System.currentTimeMillis();
		Files.readfile_by_line_array(file_name, array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray(sorted_ubication , array);
		time_end = System.currentTimeMillis();
		time = time_end - time_start;
		System.out.println("Burbble Sort 1-" + MainRange.cant_numeros +  " - Time : " + time);
	}
}

class InsertionSort_1_n extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[MainRange.cant_numeros];
		String file_name = "1_" + MainRange.cant_numeros + ".txt";
		String file_name_sorted = "InsertionSort_1-" + MainRange.cant_numeros + "_sorted.txt";
		String sorted_ubication = "sorted/" + file_name_sorted;
		// burbble sort
		long time_start, time_end, time;
		time_start = System.currentTimeMillis();
		Files.readfile_by_line_array(file_name, array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray(sorted_ubication , array);
		time_end = System.currentTimeMillis();
		time = time_end - time_start;
		System.out.println("Insertion Sort 1-" + MainRange.cant_numeros +  " - Time : " + time);
	}
}

class QuickSort_1_n extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[MainRange.cant_numeros];
		String file_name = "1_" + MainRange.cant_numeros + ".txt";
		String file_name_sorted = "QuickSort_1-" + MainRange.cant_numeros + "_sorted.txt";
		String sorted_ubication = "sorted/" + file_name_sorted;
		// burbble sort
		long time_start, time_end, time;
		time_start = System.currentTimeMillis();
		Files.readfile_by_line_array(file_name, array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray(sorted_ubication , array);
		time_end = System.currentTimeMillis();
		time = time_end - time_start;
		System.out.println("Quick Sort 1-" + MainRange.cant_numeros +  " - Time : " + time);
	}
}

class HeapSort_1_n extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[MainRange.cant_numeros];
		String file_name = "1_" + MainRange.cant_numeros + ".txt";
		String file_name_sorted = "HeapSort_1-" + MainRange.cant_numeros + "_sorted.txt";
		String sorted_ubication = "sorted/" + file_name_sorted;
		// burbble sort
		long time_start, time_end, time;
		time_start = System.currentTimeMillis();
		Files.readfile_by_line_array(file_name, array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray(sorted_ubication , array);
		time_end = System.currentTimeMillis();
		time = time_end - time_start;
		System.out.println("HeapSort 1-" + MainRange.cant_numeros +  " - Time : " + time);
	}
}

public class MainRange
{
	public static int cant_numeros;

	public static void main(String [] args)
	{
		// generating numbers
		MainRange.cant_numeros = 100;
		System.out.println("\nGenerando.......");
		// creating random fiedls
		//Rand.random_1_to_n(MainRange.cant_numeros);

		// object stuffs
		BurbbleSort_1_n burbblesort_1_n = new BurbbleSort_1_n();
		InsertionSort_1_n insertionsort_1_n = new InsertionSort_1_n();
		QuickSort_1_n quicksort_1_n = new QuickSort_1_n();
		HeapSort_1_n heapsort_1_n = new HeapSort_1_n();

		// running!
		//burbblesort_1_n.run();
		//insertionsort_1_n.run();
		//quicksort_1_n.run();
		heapsort_1_n.run();
	}
}