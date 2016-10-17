/* EJERCICIOS Testing
	
	x2 + -2x − 24 = 0  ---->  X1 = 6    X2  -> -4

	7x2 + 21x − 28 = 0  ---->  X1 = 1    X2  -> 4

	−x2 + 4x − 7 = 0 	---- X1 = -1.31662      X2 = 5.3166246
*/

class Data
{
	public static float a = 12;
	public static float b = -3;
	public static float c = 0;
	public static float res_proc1;
	public static float res_proc2;
	public static float res_proc3;
	public static float res_proc4;
	public static float res_proc5;
	public static float res_proc6;
	public static float res_proc7;
	public static float res_proc8;
	public static float res_proc9;
	public static float res_proc10;

	public static void setValues(float _a, float _b, float _c)
	{
		a = _a;
		b = _b;
		c = _c;
	}
}

/*  ===============
	First Level
	===============
*/

// return (-1) * (b)
class Process1 extends Thread
{
	public void run()
	{
		
		Data.res_proc1 =  (-1) * (Data.b);
	}
}

// return (b) * (b)
class Process2 extends Thread
{
	public void run()
	{
		Data.res_proc2 =  (Data.b) * (Data.b);
	}
}

// return (-1) * (4)
class Process3 extends Thread
{
	public void run()
	{
		Data.res_proc3 = (-1) * (4);
	}
}

// return a * c
class Process4 extends Thread
{
	public void run()
	{
		Data.res_proc4 = Data.a * Data.c;
	}
}

// return (2)(a)
class Process5 extends Thread
{
	public void run()
	{
		Data.res_proc5 = 2 * Data.a;
	}
}

/*  ===============
	Second Level
	===============
*/

// proc3 * proc4
// -4ac
class Process6 extends Thread
{
	public void run()
	{
		Data.res_proc6 = Data.res_proc3 * Data.res_proc4;
	}
}


/*  ===============
	Third Level
	===============
*/

// proc2 + proc6
// (b ^ 2 - 4ac)
class Process7 extends Thread
{
	public void run()
	{
		Data.res_proc7 = Data.res_proc2 + Data.res_proc6;
	}
}

/*  ===============
	Fourth Level
	===============
*/

// sqrt(proc7)
// sqrt(b ^ 2 - 4ac)
class Process8 extends Thread
{
	public void run()
	{
		Data.res_proc8 = (float) (Math.pow(Data.res_proc7, 0.5));
	}
}


/*  ===============
	Fifth Level
	===============
*/

// (proc1 + proc8) / 5 
// (-b + sqrt(b ^ 2 - 4ac) / 2a
class Process9 extends Thread
{
	public void run()
	{
		Data.res_proc9 = (Data.res_proc1 + Data.res_proc8) / Data.res_proc5;
	}
}


// (proc1 - proc8) / 5 
// (-b - sqrt(b ^ 2 - 4ac) / 2a
class Process10 extends Thread
{
	public void run()
	{
		Data.res_proc10 = (Data.res_proc1 - Data.res_proc8) / Data.res_proc5;
	}
}

public class Project1
{
	public static void main(String [] args)
	{
		Data.setValues(1, -2, - 24);
		// Creating Threads
		Process1 t1 = new Process1();
		Process2 t2 = new Process2();
		Process3 t3 = new Process3();
		Process4 t4 = new Process4();
		Process5 t5 = new Process5();
		Process6 t6 = new Process6();
		Process7 t7 = new Process7();
		Process8 t8 = new Process8();
		Process9 t9 = new Process9();
		Process10 t10 = new Process10();

		/* ===============
			First Level
		   ===============
		*/

		// run first 5 process
		t1.start();
		t2.start();
		t3.start();
		t4.start();
		t5.start();

		try
		{
			t1.join();
			t2.join();
			t3.join();
			t4.join();
			t5.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}

		/* ===============
			Second Level
		   ===============
		*/

		t6.start();

		try
		{
			t6.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}

		/* ===============
			Third Level
		   ===============
		*/

		t7.start();

		try
		{
			t7.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}
		
		/* ===============
			Fourth Level
		   ===============
		*/

		t8.start();

		try
		{
			t8.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}

		/* ===============
			Fifth Level
		   ===============
		*/

		t9.start();
		t10.start();
		try
		{
			t9.join();
			t10.join();
		}
		catch(InterruptedException e)
		{
			e.printStackTrace();
		}

		System.out.println("Proc 1 = " + Data.res_proc1);
		System.out.println("Proc 2 = " + Data.res_proc2);
		System.out.println("Proc 3 = " + Data.res_proc3);
		System.out.println("Proc 4 = " + Data.res_proc4);
		System.out.println("Proc 5 = " + Data.res_proc5);
		System.out.println("Proc 6 = " + Data.res_proc6);
		System.out.println("Proc 7 = " + Data.res_proc7);
		System.out.println("Proc 8 = " + Data.res_proc8);
		System.out.println("Proc 9 = " + Data.res_proc9);
		System.out.println("Proc 10 = " + Data.res_proc10);

		System.out.println("\n********* RESULTADOS ******** \n x1 = " + Data.res_proc9 + "\t x2 = " + + Data.res_proc10);
	}
}

