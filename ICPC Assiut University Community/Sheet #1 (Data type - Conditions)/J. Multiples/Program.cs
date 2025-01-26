namespace J._Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ");
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            bool IsMultiple = A % B == 0 || B % A == 0;
            if (IsMultiple)
                Console.WriteLine("Multiples");
            else
                Console.WriteLine("No Multiples");
        }
    }
}
