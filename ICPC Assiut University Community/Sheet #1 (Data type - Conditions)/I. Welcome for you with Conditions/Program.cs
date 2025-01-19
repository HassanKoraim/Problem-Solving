namespace I._Welcome_for_you_with_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            bool IsGreaterOrEqual(int x, int y) => x >= y;
            if (IsGreaterOrEqual(A, B))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
