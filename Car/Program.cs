using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Car
{
    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }

    class Car : IVehiculo
    {
        private int gasoline;

        public Car(int initialGasoline)
        {
            gasoline = initialGasoline;
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("The car has no gasoline. Refuel to drive.");
            }
        }
        public bool Refuel(int amount)
        {
            if (amount > 0)
            {
                gasoline += amount;
                Console.WriteLine($"Refueled {amount} units of gasoline. Total gasoline: {gasoline}");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid refuel amount. Please enter a positive value.");
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(0);

            Console.Write("Enter the amount of gasoline to refuel: ");
            Console.ReadLine();
            var refuelAmount = 90;
            bool refueled = myCar.Refuel(refuelAmount);

            if (refueled)
            {
                myCar.Drive();
            }
        }
    }
}
