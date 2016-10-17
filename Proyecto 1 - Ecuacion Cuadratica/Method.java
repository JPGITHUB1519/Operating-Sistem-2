public class Method
{
	/*  ===================================
   		First Level
   		===================================
	*/

	// return (-1) * (b)
	public float process1(float b)
	{
		return (-1) * (b);
	}

	// return (b) * (b)
	public float process2(float b)
	{
		return (b) * (b);
	}

	// return (-1) * (4)
	public float process3()
	{
		return (-1) * (4);
	}

	// return a * c
	public float process4(float a, float c)
	{
		return (a) * (c);
	}

	// return (2)(a)
	public float process5(float a)
	{
		return 2 * (a);
	}

	/*  ===================================
   		Second Level
   		===================================
	*/

   	// proc3 * proc4
   	// -4ac
   	public float process6(float res_proc3, float res_proc4)
   	{
   		return res_proc3 * res_proc4;
   	}

   	/*  ===================================
   		Third Level
   		===================================
	*/

   	// proc2 + proc6
   	// (b ^ 2 - 4ac)
   	public float process7(float res_proc2, float res_proc6)
   	{
   		return res_proc2 + res_proc6;
   	}

   	/*  ===================================
   		Fourth Level
   		===================================
	*/

   	// sqrt(proc7)
   	// sqrt(b ^ 2 - 4ac)
   	public float process8(float res_proc7)
   	{
   		return (float)(Math.pow(res_proc7, 0.5f));
   	}

   	/*  ===================================
   		Fifth Level
   		===================================
	*/

   	// (proc1 + proc8) / 5 
   	// (-b + sqrt(b ^ 2 - 4ac) / 2a
   	public float process9(float res_proc1, float res_proc8, float res_proc5)
   	{
   		return (res_proc1 + res_proc8) / res_proc5;
   	}

   	// (proc1 - proc8) / 5 
   	// (-b - sqrt(b ^ 2 - 4ac) / 2a
   	public float process10(float res_proc1, float res_proc8, float res_proc5)
   	{
   		return (res_proc1 - res_proc8) / res_proc5;
   	}

	public static void main(String [] args)
	{
		Method obj = new Method();
		int a = 1, b = - 2, c = -24;
		float proc1 = obj.process1(b);
		float proc2 = obj.process2(b);
		float proc5 = obj.process5(a);
		float proc6 = obj.process6(obj.process3(), obj.process4(a,c));
		float proc7 = obj.process7(proc2, proc6);
		float proc8 = obj.process8(proc7);
		float proc9 = obj.process9(proc1, proc8, proc5);
		float proc10 = obj.process10(proc1, proc8, proc5);
		System.out.println("x1 = " + proc9 + "\t x2 : " + proc10);
	}
}