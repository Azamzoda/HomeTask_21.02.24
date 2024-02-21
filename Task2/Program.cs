var rac=new Ractangle();
rac.Width=Convert.ToInt32(Console.ReadLine());
rac.Height=Convert.ToInt32(Console.ReadLine());

rac.GetArea();





public class Ractangle
{
    public double Width;
    public double Height;
    
    public void GetArea ()
    {
        System.Console.WriteLine($"Area = {Width*Height}");
    }
}