using System; 
namespace ProgramLabPogashev
{
    class Program{

    static void Main(string[] args)
    {
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());
        double answer = Math.Sin(x)+Math.Cos(x);
        Console.WriteLine(answer);
        Console.ReadLine();
    }


    }
}