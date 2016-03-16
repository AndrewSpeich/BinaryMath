using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryMath
{
    class UI
    {
        ConvertBinary convert = new ConvertBinary();
        AddBinary addnumbers = new AddBinary();
        List<bool> output;
        public void getNumber()
        {
            Console.WriteLine("type in your number you want to add");
            convert.setBinaryA(int.Parse(Console.ReadLine()));
            Console.WriteLine("And your other number to add.");
            convert.setBinaryB(int.Parse(Console.ReadLine()));
        }
        public void addNumbers()
        {

            output = addnumbers.addNumbers(convert.returnFirst(), convert.returnSecond());                            
        }
        public void printOutput()
        {
            Console.WriteLine("The answer is...");

            for(int count = 0; output.Count > count; count++)
            {
                if (output[count])
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                
            }
        }
    }

}
