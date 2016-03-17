using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryMath
{
    class Or
    {
        public List<bool> OrInclusive(List<bool> numberA, List<bool> numberB)
        {
            List<bool> sentlist = new List<bool>();
            for (int index = 0; index < numberA.Count; index++)
            {


                if (numberA[index] || numberB[index])
                {
                    sentlist.Add(true);

                }
                else
                {
                    sentlist.Add(false);
                }

            }
            return sentlist;

        }
        public List<bool> Xor(List<bool> numberA, List<bool> numberB)
        {
            List<bool> sentlist = new List<bool>();
            for (int index = 0; index < numberA.Count; index++)
            {


                if ((!numberA[index] && numberB[index]) || ((numberA[index] && !numberB[index])))
                {
                    sentlist.Add(true);

                }
                else
                {
                    sentlist.Add(false);
                }

            }
            return sentlist;
        }
        public List<bool> Nor(List<bool> numberA, List<bool> numberB)
        {
            List<bool> sentlist = new List<bool>();
            for (int index = 0; index < numberA.Count; index++)
            {


                if (!(numberA[index] ||  numberB[index]))
                {
                    sentlist.Add(true);

                }
                else
                {
                    sentlist.Add(false);
                }

            }
            return sentlist;
        }

    }
}
