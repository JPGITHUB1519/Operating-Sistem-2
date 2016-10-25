public class BurbbleSort
{
	public static void ordenamiento_burbuja(int [] array)
	{
		for(int i = 0; i < array.length; i++)
		{
			for(int j = 0; j < array.length - 1; j++)
			{
				if(array[j] > array[j + 1])
				{
					int temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;
				}
			}
		}
		
	}
	public static void main(String [] args)
	{
		int [] arreglo = { 5,4,3,2,1 };
		ordenamiento_burbuja(arreglo);
		for(int i = 0; i < arreglo.length; i++)
		{
			System.out.println(" "  + arreglo[i]);
		}
		System.out.println("Prueba");
	}
}