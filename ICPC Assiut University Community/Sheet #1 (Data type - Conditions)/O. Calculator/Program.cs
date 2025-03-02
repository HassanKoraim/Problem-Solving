namespace O._Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            string[] inputs2 = inputs.Split('*', '+', '-', '/');
            int a = int.Parse(inputs2[0]);
            int b = int.Parse(inputs2[1]);

            if (inputs.Contains('+')){
                Console.WriteLine(a + b);
            }else if (inputs.Contains("-"))
            {
                Console.WriteLine(a - b);
            }else if (inputs.Contains("/"))
            {
                Console.WriteLine(a / b);
            }else if (inputs.Contains('*'))
            {
                Console.WriteLine(a * b);
            }

        }
    }
}
