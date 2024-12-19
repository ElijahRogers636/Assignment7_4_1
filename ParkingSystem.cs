using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_4_1
{
    public class ParkingSystem
    {
        public int Big { get; set; }
        public int Medium { get; set; }
        public int Small { get; set; }
        //The parking spaces are Big, Medium, and Small. Number representation for car type is 1, 2, 3 respectivly
        private readonly int[] ParkingLot;

        public ParkingSystem(int big, int medium, int small) 
        {
            Big = big;
            Medium = medium;
            Small = small;
            ParkingLot = [Big, Medium, Small];
        }

        // Remove a parking spot based on car type
        public bool AddCar(int carType) 
        {
            Console.WriteLine("<=================== New Car ===================>\n");
            Thread.Sleep(2000);
            Console.WriteLine($"Car type of {carType} enters parking lot.");
            Console.WriteLine();
            if (ParkingLot[carType - 1] > 0)
            {
                ParkingLot[carType - 1]--;
                Console.WriteLine("There is a spot");
                Console.WriteLine();
                Console.WriteLine($"Remaining Big spots {ParkingLot[0]}, Medium spots {ParkingLot[1]}, Small spots {ParkingLot[2]}");
                Console.WriteLine();
                return true;
            }
            Console.WriteLine($"Too Bad. There are no more spots for Car type of {carType}.");
            Console.WriteLine();
            return false;
        }

        // Add a parking spot based on car type (Would be better to add a check to see if the empty spots of the car type are at max before removing a car)
        public void RemoveCar(int carType)
        {
            Console.WriteLine("<=================== Car Leaves ===================>\n");
            Thread.Sleep(2000);
            Console.WriteLine($"Car type of {carType} leaves parking lot.");
            Console.WriteLine();
            ParkingLot[carType - 1]++;
            Console.WriteLine($"Remaining Big spots {ParkingLot[0]}, Medium spots {ParkingLot[1]}, Small spots {ParkingLot[2]}");
            Console.WriteLine();
        }
    }
}
