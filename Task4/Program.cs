
// var  mycar = new Car()
// {
//     Make = Console.ReadLine(),
//     Model = Console.ReadLine(),
//     Year = Convert.ToInt32(Console.ReadLine()),
//     Mileage = Convert.ToDouble(Console.ReadLine()),
//     fuel = Convert.ToDouble(Console.ReadLine())
// };

// if(mycar.Mileage/5*mycar.fuel<mycar.Mileage)
// {
//     System.Console.WriteLine($"Need to refuel");
// }
// else{
//     System.Console.WriteLine($"You can drive");
// }
// Creating a Car object
var myCar = new Car("Toyota", "Camry", 2022);

// Printing initial information
Console.WriteLine($"Make: {myCar.Make}");
Console.WriteLine($"Model: {myCar.Model}");
Console.WriteLine($"Year: {myCar.Year}");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");

// Driving the car
myCar.Drive(100);

// Adding fuel
myCar.AddFuel(10);

// Printing updated information
Console.WriteLine($"\nAfter the trip and refueling:");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");


public class Car
{
    public string Make;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;


public Car(string mark,string model,int year)
{
    Make = mark;
    Model = model;
    Year = year;
}
    public void Drive (double miles)
    {
        Mileage = miles;
    }
    public void AddFuel(double gallons)
    {
        Fuel=gallons;
    }
}