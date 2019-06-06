using System;
using Business;
using Entity.Factory;
using Repository;

namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PageControls pgC = new PageControls();

            //Input string
            string input = null;

            //Using TryParse to filter non-numeric strings
            Int32.TryParse(input, out int num);

            //Using if else to filter out-of-range values
            if (num >= 1 && num <= 3)
            {
                Console.WriteLine("Success.");
                pgC.NewPage(num);
            }
            else
            {
                Console.WriteLine("Out of range.");
            }
        }
    }
}
