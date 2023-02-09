using FINAL_EXAM.ex_1;
using FINAL_EXAM.ex_2;

public class Program
{
    public static void Main(string[] args)
    {
        Cylinder c = new Cylinder();
        Console.WriteLine("Enter the dimenstions of the cylinder");
        Console.Write("Radius: ");
        c.Radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height: ");
        c.Height = Convert.ToDouble(Console.ReadLine());

        c.Process();
        c.Result();
    }

    public static void Main1(string[] args)
    {
        Lion l = new Lion();
        l.SetMe(50, "Lion");
        Tiger t = new Tiger();
        t.SetMe(40, "Tiger");
    }

}

