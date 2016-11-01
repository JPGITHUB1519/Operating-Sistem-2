import java.io.*;
import java.util.ArrayList;
public class Files
{
	// read a file line by line
	public static ArrayList<Integer> readfile_by_line_arraylist(String filename)
	{
		ArrayList<Integer> array = new ArrayList<>();
		File archivo = null;
		FileReader fr = null;
		BufferedReader br = null;
		try
		{
			archivo = new File(filename);
			fr = new FileReader(archivo);
			br = new BufferedReader(fr);

			// reading file by line
			String line;
			while((line = br.readLine()) != null)
			{
				if (line != "")
				{
					array.add(Integer.parseInt(line));
				}	
			}	
		}
		catch(Exception e)
		{
			e.printStackTrace();
		}
		return array;
	}

	public static void readfile_by_line_array(String filename, int [] array)
	{
		File archivo = null;
		FileReader fr = null;
		BufferedReader br = null;
		try
		{
			archivo = new File(filename);
			fr = new FileReader(archivo);
			br = new BufferedReader(fr);

			// reading file by line
			String line;
			int cont = 0;
			while((line = br.readLine()) != null)
			{
				if (line != "")
				{
					array[cont] = Integer.parseInt(line);
					cont++;
				}	
			}	
		}
		catch(Exception e)
		{
			e.printStackTrace();
		}
	}

	// writefile
	public static void write_file(String file, String data)
	{
		PrintWriter pw = null;
		try
		{
			pw = new PrintWriter(file);
			pw.println(data);
		}
		catch(Exception e)
		{
			e.printStackTrace();
		}
		finally
		{
			pw.close();
		}
	}

	// write at final
	public static void append_file(String archivo, String data)
	{
		try{
          File file = new File(archivo);
    	  if(!file.exists()){
    	 	file.createNewFile();
    	  }
    	  // True for append
    	  FileWriter fw = new FileWriter(file, true);
    	  BufferedWriter bw = new BufferedWriter(fw);
    	  PrintWriter pw = new PrintWriter(bw);
    	  pw.println(data);
    	  pw.close();

       }catch(IOException ioe){
    	   System.out.println("Exception occurred:");
    	   ioe.printStackTrace();
      }
	}

	public static void appendArray(String archivo, int [] data)
	{
		try
		{
			File file = new File(archivo);
			String line;
			if(!file.exists())
			{
			 	file.createNewFile();
			}
			// True for append
			FileWriter fw = new FileWriter(file, true);
			BufferedWriter bw = new BufferedWriter(fw);
			PrintWriter pw = new PrintWriter(bw);
			for(int i = 0; i < data.length; i++)
			{
				
				line = String.valueOf(data[i]);
				pw.println(line);
			}
	    	pw.close();
      	}
       catch(IOException ioe)
       {
    	   System.out.println("Exception occurred:");
    	   ioe.printStackTrace();
      }
	}

	public static void createFilebyArray(String archivo, int [] data)
	{
		try
		{
			File file = new File(archivo);
			String line;
			if(!file.exists())
			{
			 	file.createNewFile();
			}
			// True for append
			FileWriter fw = new FileWriter(file);
			BufferedWriter bw = new BufferedWriter(fw);
			PrintWriter pw = new PrintWriter(bw);
			for(int i = 0; i < data.length; i++)
			{
				
				line = String.valueOf(data[i]);
				pw.println(line);
			}
	    	pw.close();
      	}
       catch(IOException ioe)
       {
    	   System.out.println("Exception occurred:");
    	   ioe.printStackTrace();
      }
	}

	public static void main(String [] args)
	{
		String archivo = "text_file.txt";
		append_file(archivo, "hola");	
	}

}