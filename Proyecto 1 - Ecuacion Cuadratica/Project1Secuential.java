class Data
{
	public static double a;
	public static double b ;
	public static double c;
	public static double x1;
	public static double x2;


	public static void setValues(double _a, double _b, double _c)
	{
		Data.a = _a;
		Data.b = _b;
		Data.c = _c;
	}
}


public class Project1Secuential
{
	/* CONVENSION 
		
		1 nanosecond = 1e-6 milisecond; 
		1 nanosecond = 1e-9 second;
		
		- nanoseconds to seconds

			seconds = nanoseconds / 1000000000.0

		- nanoseconds miliseconds 
			miliseconds = nanoseconds / 1000000.0;

		- miliseconds to second
			seconds = miliseconds / 1000.0

	**/

	public static void calculate_secuencial(double a, double b , double c)
	{
		
		// time_start = System.currentTimeMillis();
		Data.x1 = ((-1 * b) + Math.sqrt(Math.pow(b,2) - (4 * (a * c)))) / ((2 * (a)));
		Data.x2 = ((-1 * b) - Math.sqrt(Math.pow(b,2) - (4 * (a * c)))) / ((2 * (a)));
		// time_end = System.currentTimeMillis();
			
	}
	public static void main(String [] args)
	{
		Data.a = 1d;
		Data.b = -2d;
		Data.c =  -24d;
		long time_start, time_end, time;
		time_start = System.nanoTime();
		for(int x = 0; x < 100; x++)
			calculate_secuencial(Data.a,Data.b,Data.c);
		time_end = System.nanoTime();
		time = time_end - time_start;
		System.out.println("X1 : " + Data.x1);
		System.out.println("X2 : " + Data.x2);
		System.out.println("\n*************** Secuential *****************");
		System.out.println("\nSeconds Time : " + time / 1000000000.0);
		System.out.println("Miliseconds Time : " + time / 1000000.0);
		System.out.println("Nanoseconds Time: " + time);
	}
}