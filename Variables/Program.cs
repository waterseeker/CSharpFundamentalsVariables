using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            */

            //string myFirstName;
            //myFirstName = "Bob";

            //string myFirstName = "Bob";

            //var myFirstName = "Testy McTestFace";

            //Console.WriteLine(myFirstName);



            //implicit data-type conversion
            //int x = 7;
            //string y = "Testy McTestFace";
            //string myFirstTry = x + y;

            //Console.WriteLine(myFirstTry);

            //explicit data-type conversion
            int x = 7;
            string y = "5";
            int mySecondTry = x + int.Parse(y);
            Console.WriteLine(mySecondTry);

            Console.ReadLine();
        }
    }
}