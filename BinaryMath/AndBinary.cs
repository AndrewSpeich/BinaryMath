using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryMath
{
    class AndBinary
    {
        public List<bool> And(List<bool> numberA, List<bool> numberB)
        {
            List<bool> sentlist = new List<bool>();
            for (int index = 0; index < numberA.Count; index++)
            {


                if (numberA[index] && numberB[index])
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
        public List<bool> NAnd(List<bool> numberA, List<bool> numberB)
        {
            List<bool> sentlist = new List<bool>();
            for (int index = 0; index < numberA.Count; index++)
            {


                if (!(numberA[index] && numberB[index]))
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
