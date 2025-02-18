namespace N._Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char c = char.Parse(Console.ReadLine());
            if(c >= 65 && c <= 90)
            {
                int a = c + 32;
                Console.WriteLine((char)a);
            }
            else
            {
                int a = c - 32;
                Console.WriteLine((char)a);
            }
        }
    }
}
