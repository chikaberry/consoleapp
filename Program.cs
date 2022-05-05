using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Chika Wonodi";
            string location = "Afghanaistan";


            Console.WriteLine("Enter your  name: ");
            string name = Console.ReadLine();


            Console.Write("please enter your location");
            location = Console.ReadLine();

            Console.WriteLine("your name is:" + name);
            Console.WriteLine("you are from:" + location);

            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("d"));


//CALCULATE CHRSTMAS
            DateTime xmas = new DateTime(2022, 12, 25);
            TimeSpan difference = xmas - today;
            Console.WriteLine("We have " + difference.Days +" untill christmas");


//6
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Please eneter the width in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("please enter the height in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * ( width + height ) * 3.25 ;
            glassArea = 2 * ( width * height ) ;
            Console.WriteLine ( "The length of the wood is " +
            woodLength + " feet" ) ;
            Console.WriteLine( "The area of the glass is " +
            glassArea + " square metres" ) ;


            
            



            Console.WriteLine("press any key to end");
            Console.ReadKey();






            
        }
    }
}
