using System.Xml.Linq;

namespace B._Basic_Data_Types
{
    /// <summary>
    /// Input
    ///  Only one line containing the following space-separated values:
     ///  int, long long, char, float and double respectively.

    /// Output
   // Print each element on a new line in the same order it was received as input.
    /// </summary>
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
    //space-separated values int, long long, char, float and double respectively.
            int intValue = int.Parse(inputs[0]);
            long longValue = long.Parse(inputs[1]);
            char charValue = char.Parse(inputs[2]);
            float floatValue = float.Parse(inputs[3]);
            double doubleValue = double.Parse(inputs[4]);
           
            Console.WriteLine(intValue);
            Console.WriteLine(longValue);
            Console.WriteLine(charValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
        }
    }
}
