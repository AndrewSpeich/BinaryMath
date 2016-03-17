using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryMath
{
    class Program
    {
        static void Main(string[] args)
        {
            UI input = new UI();
            input.getNumber();
            input.getMath();
            Console.Read();
        }
    }
}
