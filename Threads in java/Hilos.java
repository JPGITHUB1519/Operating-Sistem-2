// implementing the runnable interface 

class Process0 extends Thread
{
	// method execute by start
	public void run()
	{
		for(int x = 0; x < 100; x++)
		{
			System.out.println(x + " " + Thread.currentThread().getName());
		}

		System.out.println("Termina Thread " + Thread.currentThread().getName());
	}	
}


class Process1 extends Thread
{
	// method execute by start
	public void run()
	{
		System.out.println("bye I am " + this.getName());
	}	
}


public class Hilos
{
	public static void main(String [] args)
	{
		Process0 hilo0 = new Process0();
		Process0 hilo1 = new Process0();
		Process0 hilo2 = new Process0();

		hilo0.start();
		hilo1.start();
		hilo2.start();
		
	}
}
