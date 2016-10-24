import java.io.*;


public class Files
{
	// read a file line by line
	public static void readfile_by_line(String filename)
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
			while((line = br.readLine()) != null)
			{
				System.out.println(line);
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
    	  pw.println("");
    	  pw.close();

	  	System.out.println("Data successfully appended at the end of file");

       }catch(IOException ioe){
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