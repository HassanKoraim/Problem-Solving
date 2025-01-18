namespace F._Digits_Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long N = long.Parse(inputs[0]);
            long M = long.Parse(inputs[1]);
            long sum = (N % 10 ) + (M % 10);  
            Console.WriteLine(sum);
        }
    }
}
