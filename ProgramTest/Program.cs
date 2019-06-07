using System;
using Business;
using Entity.Factory;
using Repository;

namespace ProgramTest
{
    class Program
    {
        static PageControls pgC = new PageControls();
        static void Main(string[] args)
        {
            while (true)
            {
                #region CreatePages
                //Input string
                Console.WriteLine("Choose Page: [1] LocalBusiness, [2] Artist, [3] Entertainment");
                Console.Write(">>  ");
                string input = Console.ReadLine();

                //Using TryParse to filter non-numeric strings
                Int32.TryParse(input, out int num);

                //Using if else to filter out-of-range values
                if (num >= 1 && num <= 3)
                {
                    //Console.WriteLine("Success.");
                    pgC.NewPage(num);
                    pgC.ViewPages();
                }
                else
                {
                    //Console.WriteLine("Out of range.");
                }
                #endregion
                #region Again?
                Console.Write("\nEnter 0 to exit, any key to go again: ");
                string response = Console.ReadLine();
                if (response == "0")
                {
                    break;
                } 
                #endregion
            }
        }
    }
}
