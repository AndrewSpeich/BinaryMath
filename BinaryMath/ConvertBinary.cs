using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryMath
{
    class ConvertBinary
    {
        List<bool> number1;
        List<bool> number2;
        public List<bool> returnFirst()
        {
            changeLengths();
            return number1;
        }
        public List<bool> returnSecond()
        {
            changeLengths();
            return number2;
        }

        public List<bool> convertIntegerToBinary(int input)
        {
            double index = 0;
            List<bool> templist = new List<bool>();
            while (input > Math.Pow(2, index))
            {
                index++;
            }
            for(int count = 0; count <= index; count++)
            {
                if(Math.Pow(2, (index - count))<=input)
                {
                    templist.Add(true);
                    input -= (int)Math.Pow(2, (index - count));
                }
                else
                {
                    templist.Add(false);
                }
               
            }
            return templist;
        }
        public void setBinaryA(int input)
        {
            number1 = convertIntegerToBinary(input);
        }
        public void setBinaryB(int input)
        {
            number2 = convertIntegerToBinary(input);
        }
        public void changeLengths()
        {
            while (number1.Count < number2.Count)
            {
                number1.Insert(0, false);
            }
            while (number1.Count > number2.Count)
            {
                number2.Insert(0, false);
            }
        }


    }
}
