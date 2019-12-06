using System;
using System.Reflection.Metadata;





namespace NASATrajectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double h = 0;
            double x = 0;
            double a = 0;
            double v0 = 0;
            double t = 0;
            double g = 9.8;

            Console.WriteLine("enter height: ");
            str = Console.ReadLine();
            h = double.Parse(str);


            Console.WriteLine("enter angle: ");
            str = Console.ReadLine();
            a = double.Parse(str);

            Console.WriteLine("enter v0: ");
            str = Console.ReadLine();
            v0 = double.Parse(str);

            a = (a * (Math.PI)) / 180;

            double initialXvelocity = Math.Cos(a) * v0;
            double initialYvelocity = Math.Sin(a) * v0;

            t = (v0 * Math.Sin(a) + Math.Sqrt(Math.Pow(v0 * Math.Sin(a), 2) + 2 * g * h)) / g;
            x = initialXvelocity * t;



            Console.WriteLine("Initial velocity: " + v0);
            Console.WriteLine("Initial Xvelocity: " + initialXvelocity);
            Console.WriteLine("Initial Yvelocity: " + initialYvelocity);
            Console.WriteLine("Angle of launch: " + (a / (Math.PI) * 180));
            Console.WriteLine("Initial height: " + h);
            Console.WriteLine("time is: " + t);
            Console.WriteLine("distance is: " + x);



        }
    }
}
