public class Benchmark
{
	public static void numbers()
	{
		int result = 5;
		for(int x = 1; x < 10000; x++)
		{
			result = ((result * x) / x) + x; 
		}
	}
	public static void main(String [] args)
	{
		// time = time_start - time_end
		long time_start, time_end, time;
		// start time
		time_start = System.currentTimeMillis();
		numbers();
		time_end = System.currentTimeMillis();
		time = time_end - time_start;
		System.out.println("Time : " + time);
	}
}