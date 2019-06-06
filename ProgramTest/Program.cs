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
            string input = Console.ReadLine();

            //Using TryParse to filter non-numeric strings
            Int32.TryParse(input, out int num);

            pgC.NewPage(num);

             
        }
    }
}
