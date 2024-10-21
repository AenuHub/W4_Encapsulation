using W4_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.Make = "Toyota";
        car.Model = "Corolla";
        car.Color = "Red";
        car.NumberOfDoors = 3;

        car.PrintCarInfo();
        Console.ReadKey();
    }
}