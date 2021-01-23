using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Speed_Camera
{
    public class maxSpeed
    {
        public int speedLimit;
        public int actualSpeed;

        public void enterSpeed()
        {
            Console.WriteLine("Enter speed: " );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Speed limit: ");
            var SpeedLimit = new maxSpeed();
            SpeedLimit.speedLimit = Convert.ToInt32(Console.ReadLine());
            SpeedLimit.enterSpeed();
            SpeedLimit.actualSpeed = Convert.ToInt32(Console.ReadLine());

            if (SpeedLimit.speedLimit >= SpeedLimit.actualSpeed)
            {
                Console.WriteLine("OK");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 5))
            {
                Console.WriteLine("+ 1 point");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 10))
            {
                Console.WriteLine("+ 2 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 15))
            {
                Console.WriteLine("+ 3 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 20))
            {
                Console.WriteLine("+ 4 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 25))
            {
                Console.WriteLine("+ 5 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 30))
            {
                Console.WriteLine("+ 6 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 35))
            {
                Console.WriteLine("+ 7 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 40))
            {
                Console.WriteLine("+ 8 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 45))
            {
                Console.WriteLine("+ 9 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 50))
            {
                Console.WriteLine("+ 10 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 55))
            {
                Console.WriteLine("+ 11 points");
            }
            else if (SpeedLimit.actualSpeed <= (SpeedLimit.speedLimit + 60))
            {
                Console.WriteLine("+ 12 points");
            }
            else
            {
                Console.WriteLine("license suspended");
            }
        }
    }
}
