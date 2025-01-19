namespace G._Summation_from_1_to_N
{
    /// <summary>
    /// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/G
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long sum = (input * (input +1)) / 2; // Calculate  the summation of the numbers that is between 1 and input (inclusive)
            Console.WriteLine(sum);
        }
    }
}
