var per=new Person();
System.Console.WriteLine("Enter your firstname: ");
per.FirstName = Console.ReadLine();
System.Console.WriteLine($"Enter your Lastname: ");
per.LastName =Console.ReadLine();
System.Console.WriteLine($"Enter your Age: ");
per.Age = Convert.ToInt32(Console.ReadLine());
 per.GetFullName();
 per.GetBirthYear();

public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;
    public string Address;

    public void GetFullName()
    {
        System.Console.WriteLine($"My name is {FirstName} {LastName}");

    }
    public void GetBirthYear()
    {
        System.Console.WriteLine($"My birth year is {Age}");
    } 

}