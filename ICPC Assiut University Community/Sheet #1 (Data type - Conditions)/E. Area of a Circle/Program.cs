namespace E._Area_of_a_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double Bye = 3.141592653;
            double area = Bye * (r * r);
            Console.WriteLine(area);
        }
    }
}
