namespace M._Capital_or_Small_or_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c =  Char.Parse(Console.ReadLine());
            if(c >= 48 && c <= 57)
            {
                Console.WriteLine("IS DIGIT");
            }
            else
            {
                Console.WriteLine("ALPHA");
                if(c >= 65 && c <= 90)
                {
                    Console.WriteLine("IS CAPITAL");
                }
                else
                {
                    Console.WriteLine("IS SMALL");
                }
            }
        }
    }
}
