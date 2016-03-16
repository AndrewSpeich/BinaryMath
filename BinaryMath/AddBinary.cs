using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryMath
{
    class AddBinary
    {
        public List<bool> addNumbers(List<bool> numberA, List<bool> numberB)
        {
            List<bool> sentlist = new List<bool>();
            bool carryover = false;
            for(int index = 0;numberA.Count > index; index++)
            {
                int count = index + 1;
                if (numberA[numberA.Count - count] && numberB[numberB.Count - count] &&carryover)
                {
                    carryover = true;
                    sentlist.Add(true);
                }
                else if((numberA[numberA.Count-count] && carryover) || (numberB[numberB.Count - count] && carryover)|| (numberB[numberB.Count - count] && numberA[numberA.Count - count] ))
                {
                    carryover = true;
                    sentlist.Add(false);
                }
                else if (!(numberA[numberA.Count - count] || numberB[numberB.Count - count]))
                {
                    sentlist.Add(false || carryover);
                    carryover = ( false);
                }
                else if (carryover && (numberA[numberA.Count - count] || numberB[numberB.Count - count]))
                    {
                        carryover = true;
                        sentlist.Add(false);
                    }
                else
                {
                    carryover = false;
                    sentlist.Add(true);
                }
              
                    
                }
            sentlist.Add(carryover);
            return invertList(sentlist);
            }
        public List<bool> invertList(List<bool> input)
        {
            List<bool> inverse = new List<bool>();
            int indexer = 1;
            foreach (bool index in input)
            {
               
                inverse.Add(input[input.Count - indexer]);
                indexer++;
            }
            return inverse;
        }
    }
}

