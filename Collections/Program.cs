using Collections;
class Program
{
    public static void Main()
    {
        Garage garage = new Garage("Thomas Garage");
        garage.CreateCar(1, "Lamborghini", "Purple");
        garage.CreateCar(2, "Audi", "Blue");
        garage.CreateCar(3, "BMW", "Black");
        Console.WriteLine(garage.GetCarById(1));
        Console.WriteLine(garage.GetAllCar());
        garage.RemoveCarById(3);
        Console.WriteLine(garage.GetAllCar());
    }
}