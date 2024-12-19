namespace Assignment7_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car types are (1) Big, (2) Medium, and (3) Small");
            Console.WriteLine();
            ParkingSystem park = new ParkingSystem(4, 5, 2);
            park.AddCar(2);
            park.AddCar(1);
            park.AddCar(2);
            park.AddCar(1);
            park.AddCar(1);
            park.AddCar(1);
            park.RemoveCar(1);
            park.AddCar(3);
            park.AddCar(1);
            park.AddCar(2);
            park.AddCar(3);
            park.AddCar(2);
            park.RemoveCar(3);
            park.AddCar(3);
            park.AddCar(2);
            park.AddCar(2);
            park.RemoveCar(2);
            park.AddCar(2);
            park.AddCar(3);
            park.AddCar(1);

        }
    }
}
