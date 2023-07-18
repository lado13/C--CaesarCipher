
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CaesarCipher
{
    internal class Program
    {


        public static string Encrypt(string message, int shift)
        {

            char[] characters = message.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = (char)(characters[i] + shift);
            }

            Console.WriteLine(characters);
            return characters.ToString();
        }


        public static string Decrypt(string message, int shift)
        {

            int decryptShift = -shift;
            return Encrypt(message, decryptShift);
        }





        static void Main(string[] args)
        {


            Encrypt("Hello", 2);
            Decrypt("Jgnnq",2);
        }
    }
}
