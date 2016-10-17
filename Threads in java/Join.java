class Process extends Thread
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

public class Join
{
	public static void main(String [] args)
	{
		Process t1 = new Process();
		Process t2 = new Process();
		Process t3 = new Process();

		t1.start();
		// wait the first Thread Finish to start second
		try
		{
			t1.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}
		t2.start();

		// wait the second Thread Finish + 2 seconds to start Three
		try
		{
			t2.join(2000);
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}
		t3.start();

		// whait all threds finish to show message
		try
		{
			t1.join();
			t2.join();
			t3.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}
		System.out.println("All threads are dead, exiting main thread");
	}
}