/*
	2x / 5

	1 hilo
	2x
	2 hilo
	proc1 / 5

	funcionamiento : esperar que el primero termina para ejecutar el segundo

*/

class General
{
	public static int x = 50;
	public static String valor;
}

class Proc1 extends Thread
{
	public void run()
	{
		General.x = 50;
	}
}

class Proc2 extends Thread
{
	public void run()
	{
		General.x = General.x / 5;
	}
}

public class ThreadAfter
{
	public static int x;
	public static void main(String [] args)
	{
		Proc1 t1 = new Proc1();
		Proc2 t2 = new Proc2();
		General obj = new General();
		t1.start();
		try
		{
			t1.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}

		t2.start();
		try
		{
			t2.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}
		System.out.println(General.x);
	}
}