using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int nLargest;
            int nSmallest;
            int nCurrent;
            string strEntry;
            //first integer
            strEntry = Utils.GetInput("Enter an integer ");
            nLargest = nSmallest = Convert.ToInt32(strEntry);
            //loop
            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                //check to see if input should replace largest or smallest
                if (nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if (nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }
                strEntry = Utils.GetInput("Enter another integer or Q to Quit ");
            }
            Console.WriteLine("The largest value you entered was " + nLargest + ".");
            Console.WriteLine("The smallest value you entered was " + nSmallest + ".");
        }
    }
}
