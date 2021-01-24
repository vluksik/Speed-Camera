using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Speed_Camera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Int32.MaxValue; i++)
            {
                Console.WriteLine("Speed of The vehicle: ");
                var speedVehicle = Convert.ToInt32(Console.ReadLine());
                var kokot = (speedVehicle - speedLimit) / 5;
                if (speedLimit + 4 >= (speedVehicle))

                {
                    Console.WriteLine("ok");
                }
                else if (kokot <= 11)
                {
                    Console.WriteLine("Points: " + kokot);
                }
                else
                {
                    Console.WriteLine("License suspended");
                }
            }
        }
    }
}
