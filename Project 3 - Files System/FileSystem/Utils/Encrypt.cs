using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Encrypt
    {
        public static string convertToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        public static int characterToAscii(char character)
        {
            return Convert.ToInt32(character);
        }

        public static byte [] stringToAscii(string str)
        {
            byte[] ascii_values = Encoding.ASCII.GetBytes(str);
            return ascii_values;
        }

        // return 0 and 1 quantities in a byte ascii array
        // [cont0, cont1]
        public static int[] cerosAndOneCounter(string bynarys)
        {
            int cont0 = 0, cont1 = 0;
            int [] data = new int[2];
            foreach(char element in bynarys)
            {
                if (element == '0') cont0++;
                if (element == '1') cont1++;
            }

            data[0] = cont0;
            data[1] = cont1;
            return data;
        }

        public static string encriptar(string text)
        {
            string encrypted = "";
            int ascii_value;
            string bynary_ascii_value;
            int[] data0and1;
            int cont0, cont1;
            char new_character;
            for (int cont = 0; cont < text.Length; cont++)
            {
                ascii_value = characterToAscii(text[cont]);
                //Console.WriteLine(ascii_value);
                // en vez de convertir el caracter actual en binario, se convierte la posicion
                bynary_ascii_value = convertToBinary(cont);
                data0and1 = cerosAndOneCounter(bynary_ascii_value);
                if (cont % 2 == 0)
                {
                    cont0 = data0and1[0];
                    ascii_value = ascii_value + cont0;
                }
                else
                {
                    cont1 = data0and1[1];
                    ascii_value = ascii_value + cont1;
                }
                new_character = Convert.ToChar(ascii_value);
                //Console.WriteLine(new_character);
                encrypted = encrypted + Convert.ToString(new_character);
            }
            return encrypted;
        }

        public static string desencriptar(string text)
        {
            string encrypted = "";
            int ascii_value;
            string bynary_ascii_value;
            int[] data0and1;
            int cont0, cont1;
            char new_character;
            for (int cont = 0; cont < text.Length; cont++)
            {
                ascii_value = characterToAscii(text[cont]);
                //Console.WriteLine(ascii_value);
                // en vez de convertir el caracter actual en binario, se convierte la posicion
                bynary_ascii_value = convertToBinary(cont);
                data0and1 = cerosAndOneCounter(bynary_ascii_value);
                if (cont % 2 == 0)
                {
                    cont0 = data0and1[0];
                    ascii_value = ascii_value - cont0;
                }
                else
                {
                    cont1 = data0and1[1];
                    ascii_value = ascii_value - cont1;
                }
                new_character = Convert.ToChar(ascii_value);
                //Console.WriteLine(new_character);
                encrypted = encrypted + Convert.ToString(new_character);
            }
            return encrypted;
        }

        public static void encriptarArchivo(string filename)
        {
            string content_file = Utilities.fileToString(filename);
            string encrypted_content_file = encriptar(content_file);
            Utilities.writeSingleLineToFile(filename, encrypted_content_file);
        }

        // anterior binario convertido a caracter actual
        // no se puede decriptar
        /*
        public static string encriptar(string text)
        {
            string encrypted = "";
            int ascii_value;
            string bynary_ascii_value;
            int[] data0and1;
            int cont0, cont1;
            char new_character;
            for (int cont = 0; cont < text.Length; cont++)
            {
                ascii_value = characterToAscii(text[cont]);
                //Console.WriteLine(ascii_value);
                bynary_ascii_value = convertToBinary(ascii_value);
                data0and1 = cerosAndOneCounter(bynary_ascii_value);
                if (cont % 2 == 0)
                {
                    cont0 = data0and1[0];
                    ascii_value = ascii_value + cont0;
                }
                else
                {
                    cont1 = data0and1[1];
                    ascii_value = ascii_value + cont1;
                }
                new_character = Convert.ToChar(ascii_value);
                //Console.WriteLine(new_character);
                encrypted = encrypted + Convert.ToString(new_character);
            }
            return encrypted;
        }
        */ 
    }
}
