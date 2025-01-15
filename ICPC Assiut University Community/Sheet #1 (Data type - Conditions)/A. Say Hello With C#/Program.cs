namespace A._Say_Hello_With_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string welcome = $"Hello, {name}";
            Console.WriteLine(welcome);
        }
    }
}
