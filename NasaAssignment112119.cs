using System;

namespace Force_if_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int force = 0;
            const int MAX_FORCE = 500;

            if(force > MAX_FORCE)
            {
                Console.WriteLine("Supply pod delivery failed. Pod took too much force.");
            }
            else
            {
                Console.WriteLine("Supply pod delivery successful.");
            }
        }
    }
}
