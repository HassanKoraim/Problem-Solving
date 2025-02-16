namespace L._The_Brothers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstPersonName = Console.ReadLine().Split(' ');
            string[] secondPersonName = Console.ReadLine().Split(' ');
            string fatherNameP1 = firstPersonName[1];
            string fatherNameP2 = secondPersonName[1];
            string IsBrother = fatherNameP1 == fatherNameP2 ? "ARE Brothers": "NOT";
            Console.WriteLine(IsBrother);
        }
    }
}
