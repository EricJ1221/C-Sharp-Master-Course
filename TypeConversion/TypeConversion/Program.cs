using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("tHE NUMBER COULD NOT BE CONVERTED INTO A BYTE.");
               
            }
            
            
            
            /*byte b = 1; //a byte is only one byte
            int i = b;//an integer is 4 bytes so we can copy without data loss
            Console.WriteLine(i);
        */
        }
    }
}
