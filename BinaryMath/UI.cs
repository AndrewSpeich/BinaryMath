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
        AndBinary matchnumbers = new AndBinary();
        Or comparenumbers = new Or();
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
        public void andNumbers()
        {

            output = matchnumbers.And(convert.returnFirst(), convert.returnSecond());
        }
        public void nandNumbers()
        {

            output = matchnumbers.NAnd(convert.returnFirst(), convert.returnSecond());
        }
        public void orNumbers()
        {

            output = comparenumbers.OrInclusive(convert.returnFirst(), convert.returnSecond());
        }
        public void xorNumbers()
        {

            output = comparenumbers.Xor(convert.returnFirst(), convert.returnSecond());
        }
        public void norNumbers()
        {

            output = comparenumbers.Nor(convert.returnFirst(), convert.returnSecond());
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
        public void getMath()
        {
            Console.WriteLine("What would you like to do with these numbers? Add, And, Or, Nand, Nor, Xor");
            switch (Console.ReadLine())
            {
                case "Add":
                    addNumbers();
                    printOutput();
                    break;
                case "And":
                    addNumbers();
                    printOutput();
                    break;
                case "Or":
                    orNumbers();
                    printOutput();
                    break;
                case "Nand":
                   nandNumbers();
                    printOutput();
                    break;
                case "Nor":
                    norNumbers();
                    printOutput();
                    break;
                case "Xor":
                    xorNumbers();
                    printOutput();
                    break;
                default:
                    getMath();

            }

        }
    }

}
