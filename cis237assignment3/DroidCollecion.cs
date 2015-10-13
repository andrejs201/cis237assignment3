using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollecion
    {
        private static IDroid[] droidArray;
        private static int arrayLength;

        public DroidCollecion()
        {
            droidArray = new IDroid[100];
            arrayLength = 0;
        }

        public IDroid[] this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }

        public void AddDroid(IDroid droid)
        {
            bool droidAdded = false;
            for (int i = 0; i < droidArray.Length; i++)
            {
                if (droidArray[i] == null && !droidAdded)
                {
                    droidArray[i] = droid;
                    arrayLength++;
                }
            }
        }


    }
}
