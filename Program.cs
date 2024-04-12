using System;

namespace COD
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = Generator.CallOfDuty();

            Console.WriteLine($"{response.Content}");
        }
    }
}
