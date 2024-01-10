using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120, "electric");
            Car Volvo = new Car("XC-90");

            Console.WriteLine(Ford.Name);
            Console.WriteLine(Ford.Color);
            Console.WriteLine(Ford.Year);
            Console.WriteLine(Ford.engine_type);
            Ford.fullThrottle();

            Console.WriteLine(Opel.Name);
            Console.WriteLine(Opel.Color);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Volvo.engine_type);
            Opel.fullThrottle();
            Opel.Honk();

            Console.WriteLine("Enter Volvo's age:");
            try
            {
                Volvo.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Volvo age is:" + Volvo.Year);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
