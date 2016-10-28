import java.util.ArrayList;

/*
	======= Burbble Sort Stuffs =========
*/
class BurbbleSort_1_99 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[100];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1_99.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_1_99_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 1-99 - Time : " + time);
		
	
	}
}

class BurbbleSort_100_499 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100_499.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_100_499_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 100-499 - Time : " + time);
	}
}

class BurbbleSort_500_999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[500];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("500_999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_500_999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 500-999 - Time : " + time);
	}
}

class BurbbleSort_1000_4999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[4000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1000_4999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_1000_4999_sorted.txt", array);	
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 1000-4999 - Time : " + time);
	}	
}

class BurbbleSort_5000_9999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[5000];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("5000_9999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_5000_9999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 5000-9999 - Time : " + time);
	}
}

class BurbbleSort_10000_24999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[15000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("10000_24999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_10000_24999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 10000-24999 - Time : " + time);
	}
}

class BurbbleSort_25000_49999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[25000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("25000_49999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
			
		}
		*/
		Files.appendArray("sorted/BurbbleSort_25000_49999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 25000-49999 - Time : " + time);
	}
}

class BurbbleSort_50000_99999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[50000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("50000_99999.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_50000_99999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 50000-99999 - Time : " + time);

	}
}

class BurbbleSort_100000_500000 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400001];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100000_500000.txt", array);
		BurbbleSort.ordenamiento_burbuja(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/BurbbleSort_100000_500000_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Burbble Sort 100000_500000 - Time : " + time);
	}
}

/*
	======= HeapSort Stuffs =========
*/

class HeapSort_1_99 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[100];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1_99.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_1_99_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 1-99 - Time : " + time);
		
	
	}
}

class HeapSort_100_499 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100_499.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_100_499_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 100-499 - Time : " + time);
	}
}

class HeapSort_500_999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[500];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("500_999.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_500_999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 500-999 - Time : " + time);
	}
}

class HeapSort_1000_4999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[4000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1000_4999.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_1000_4999_sorted.txt", array);	
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 1000-4999 - Time : " + time);
	}	
}

class HeapSort_5000_9999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[5000];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("5000_9999.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_5000_9999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 5000-9999 - Time : " + time);
	}
}

class HeapSort_10000_24999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[15000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("10000_24999.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_10000_24999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 10000-24999 - Time : " + time);
	}
}

class HeapSort_25000_49999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[25000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("25000_49999.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
			
		}
		*/
		Files.appendArray("sorted/HeapSort_25000_49999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 25000-49999 - Time : " + time);
	}
}

class HeapSort_50000_99999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[50000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("50000_99999.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_50000_99999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 50000-99999 - Time : " + time);

	}
}

class HeapSort_100000_500000 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400001];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100000_500000.txt", array);
		HeapSort.heapsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/HeapSort_100000_500000_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Heap Sort 100000_500000 - Time : " + time);
	}
}

/*
	======= HeapSort Stuffs =========
*/

class InsertionSort_1_99 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[100];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1_99.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_1_99_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 1-99 - Time : " + time);
		
	
	}
}

class InsertionSort_100_499 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100_499.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_100_499_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 100-499 - Time : " + time);
	}
}

class InsertionSort_500_999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[500];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("500_999.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_500_999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 500-999 - Time : " + time);
	}
}

class InsertionSort_1000_4999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[4000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1000_4999.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_1000_4999_sorted.txt", array);	
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 1000-4999 - Time : " + time);
	}	
}

class InsertionSort_5000_9999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[5000];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("5000_9999.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_5000_9999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 5000-9999 - Time : " + time);
	}
}

class InsertionSort_10000_24999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[15000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("10000_24999.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_10000_24999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 10000-24999 - Time : " + time);
	}
}

class InsertionSort_25000_49999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[25000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("25000_49999.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
			
		}
		*/
		Files.appendArray("sorted/InsertionSort_25000_49999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 25000-49999 - Time : " + time);
	}
}

class InsertionSort_50000_99999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[50000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("50000_99999.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_50000_99999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 50000-99999 - Time : " + time);

	}
}

class InsertionSort_100000_500000 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400001];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100000_500000.txt", array);
		InsertionSort.insertionsort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/InsertionSort_100000_500000_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Insertion Sort 100000_500000 - Time : " + time);
	}
}

class QuickSort_1_99 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[100];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1_99.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length - 1; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_1_99_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 1-99 - Time : " + time);
		
	
	}
}

class QuickSort_100_499 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100_499.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_100_499_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 100-499 - Time : " + time);
	}
}

class QuickSort_500_999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[500];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("500_999.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_500_999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 500-999 - Time : " + time);
	}
}

class QuickSort_1000_4999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[4000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("1000_4999.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_1000_4999_sorted.txt", array);	
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 1000-4999 - Time : " + time);
	}	
}

class QuickSort_5000_9999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[5000];
		// burbble sort
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("5000_9999.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_5000_9999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 5000-9999 - Time : " + time);
	}
}

class QuickSort_10000_24999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[15000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("10000_24999.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_10000_24999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 10000-24999 - Time : " + time);
	}
}

class QuickSort_25000_49999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[25000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("25000_49999.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
			
		}
		*/
		Files.appendArray("sorted/QuickSort_25000_49999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 25000-49999 - Time : " + time);
	}
}

class QuickSort_50000_99999 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[50000];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("50000_99999.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_50000_99999_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 50000-99999 - Time : " + time);

	}
}

class QuickSort_100000_500000 extends Thread
{
	@Override
	public void run()
	{
		int [] array = new int[400001];
		long time_start, time_end, time;
		time_start = System.nanoTime();
		Files.readfile_by_line_array("100000_500000.txt", array);
		QuickSort.quicksort(array);
		/*
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		*/
		Files.appendArray("sorted/QuickSort_100000_500000_sorted.txt", array);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("Quick Sort 100000_500000 - Time : " + time);
	}
}


public class Main
{
	public static void main(String [] args)
	{
		// burbble objects
		BurbbleSort_1_99 burbble_1_99 = new BurbbleSort_1_99();
		BurbbleSort_100_499 burbble_100_499 = new BurbbleSort_100_499();
		BurbbleSort_500_999 burbble_500_999 = new BurbbleSort_500_999();
		BurbbleSort_1000_4999 burbble_1000_4999 = new BurbbleSort_1000_4999();
		BurbbleSort_5000_9999 burbble_5000_9999 = new BurbbleSort_5000_9999();
		BurbbleSort_10000_24999 burbble_10000_24999 = new BurbbleSort_10000_24999();
		BurbbleSort_25000_49999 burbble_25000_49999 = new BurbbleSort_25000_49999();
		BurbbleSort_50000_99999 burbble_50000_99999 = new BurbbleSort_50000_99999();
		// // imposible to run
		BurbbleSort_100000_500000 burbble_100000_500000 = new BurbbleSort_100000_500000();

		// // heap objects
		HeapSort_1_99 heapsort_1_99 = new HeapSort_1_99();
		HeapSort_100_499 heapsort_100_499 = new HeapSort_100_499();
		HeapSort_500_999 heapsort_500_999 = new HeapSort_500_999();
		HeapSort_1000_4999 heapsort_1000_4999 = new HeapSort_1000_4999();
		HeapSort_5000_9999 heapsort_5000_9999 = new HeapSort_5000_9999();
		HeapSort_10000_24999 heapsort_10000_24999 = new HeapSort_10000_24999();
		HeapSort_25000_49999 heapsort_25000_49999 = new HeapSort_25000_49999();
		HeapSort_50000_99999 heapsort_50000_99999 = new HeapSort_50000_99999();
		HeapSort_100000_500000 heapsort_100000_500000 = new HeapSort_100000_500000();

		// insertion objects
		InsertionSort_1_99 insertionsort_1_99 = new InsertionSort_1_99();
		InsertionSort_100_499 insertionsort_100_499 = new InsertionSort_100_499();
		InsertionSort_500_999 insertionsort_500_999 = new InsertionSort_500_999();
		InsertionSort_1000_4999 insertionsort_1000_4999 = new InsertionSort_1000_4999();
		InsertionSort_5000_9999 insertionsort_5000_9999 = new InsertionSort_5000_9999();
		InsertionSort_10000_24999 insertionsort_10000_24999 = new InsertionSort_10000_24999();
		InsertionSort_25000_49999 insertionsort_25000_49999 = new InsertionSort_25000_49999();
		InsertionSort_50000_99999 insertionsort_50000_99999 = new InsertionSort_50000_99999();
		InsertionSort_100000_500000 insertionsort_100000_500000 = new InsertionSort_100000_500000();
		
		// quicksort objects
		QuickSort_1_99 quicksort_1_99 = new QuickSort_1_99();
		QuickSort_100_499 quicksort_100_499 = new QuickSort_100_499();
		QuickSort_500_999 quicksort_500_999 = new QuickSort_500_999();
		QuickSort_1000_4999 quicksort_1000_4999 = new QuickSort_1000_4999();
		QuickSort_5000_9999 quicksort_5000_9999 = new QuickSort_5000_9999();
		QuickSort_10000_24999 quicksort_10000_24999 = new QuickSort_10000_24999();
		QuickSort_25000_49999 quicksort_25000_49999 = new QuickSort_25000_49999();
		QuickSort_50000_99999 quicksort_50000_99999 = new QuickSort_50000_99999();
		QuickSort_100000_500000 quicksort_100000_500000 = new QuickSort_100000_500000();

		/*
			======= Burbble Sort Stuffs =========
		*/

		// burbble_1_99.start();
		// burbble_100_499.start();
		// burbble_500_999.start();
		// burbble_1000_4999.start();
		//burbble_5000_9999.start();
		// burbble_10000_24999.start();
		// burbble_25000_49999.start();
		// burbble_50000_99999.start();
		//burbble_100000_500000.start();

		/*

			======= insertion sort =========
		*/
		// insertionsort_1_99.start();
		// insertionsort_100_499.start();
		// insertionsort_500_999.start();
		// insertionsort_1000_4999.start();
		// insertionsort_5000_9999.start();
		// insertionsort_10000_24999.start();
		// insertionsort_25000_49999.start();
		// insertionsort_50000_99999.start();
		// insertionsort_100000_500000.start();

		/*

		======= Heapsort =========
		*/
		/// heapsort_1_99.start();
		// heapsort_100_499.start();
		// heapsort_500_999.start();
		// heapsort_1000_4999.start();
		// heapsort_5000_9999.start();
		// heapsort_10000_24999.start();
		// heapsort_25000_49999.start();
		// heapsort_50000_99999.start();
		// heapsort_100000_500000.start();

		/*
		
		======= Quicksort =========
		*/
		// quicksort_1_99.start();
		// quicksort_100_499.start();
		// quicksort_500_999.start();
		// quicksort_1000_4999.start();
		// quicksort_5000_9999.start();
		// quicksort_10000_24999.start();
		// quicksort_25000_49999.start();
		// quicksort_50000_99999.start();
		// quicksort_100000_500000.start();

		/*
			=========== Calls =============
		*/

		// // 1 -99
		// burbble_1_99.start();
		// insertionsort_1_99.start();
		// heapsort_1_99.start();
		// quicksort_1_99.start();

		// // 100 - 499
		// insertionsort_100_499.start();
		// burbble_100_499.start();
		// heapsort_100_499.start();
		// quicksort_100_499.start();

		// // 500-999
		// burbble_500_999.start();
		// insertionsort_500_999.start();
		// heapsort_500_999.start();
		// quicksort_500_999.start();

		// // 1000-4999
		// burbble_1000_4999.start();
		// insertionsort_1000_4999.start();
		// heapsort_1000_4999.start();
		// quicksort_1000_4999.start();


		burbble_5000_9999.start();
		insertionsort_5000_9999.start();
		heapsort_5000_9999.start();
		quicksort_5000_9999.start();


	}	
}

