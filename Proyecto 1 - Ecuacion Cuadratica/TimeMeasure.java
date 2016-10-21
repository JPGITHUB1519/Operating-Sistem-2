public class TimeMeasure
{
	public static void method()
	{
		int result = 5;
		for(int x = 1; x < 10000; x++)
		{
			result = ((result * x) / x) + x; 
		}
	}
	public static double measure_time()
	{
		long time_start, time_end, time;
		time_start = System.nanoTime();
		method();
		time_end = System.nanoTime();
		time = time_end - time_start;
		return time;
	}
	public static void main(String [] args)
	{
		System.out.println(measure_time());
	}
	
}