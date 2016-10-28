public class InsertionSort
{
	public static void insertionsort(int [] array)
	{
		for (int i=1; i < array.length; i++) 
		{
		int temp = array[i];
		int j;
		for (j = i - 1; j >= 0 && temp < array[j] ; j--)
		array[j + 1] = array[j];
		array[j + 1] = temp;
		}
	}
	public static void main(String [] args)
	{
		int [] array = {5,4,3,2,1};

		insertionsort(array);

		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);			
		}
	}
}

