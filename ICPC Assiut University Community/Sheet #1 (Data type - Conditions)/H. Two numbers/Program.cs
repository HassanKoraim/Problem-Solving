namespace H._Two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] vals = s.Split(" ");
            double a = double.Parse(vals[0]);
            double b = double.Parse(vals[1]);
            double c = a / b;
            // Console.WriteLine(c);
            double floor = Math.Floor(c);
            double ceil = Math.Ceiling(c);
            double round = Math.Round(c, MidpointRounding.AwayFromZero);
            Console.WriteLine(
                $"floor {a} / {b} = {floor}" +
                $"\r\nceil {a} / {b} = {ceil}" +
                $"\r\nround {a} / {b} = {round}");

        }
    }
}
