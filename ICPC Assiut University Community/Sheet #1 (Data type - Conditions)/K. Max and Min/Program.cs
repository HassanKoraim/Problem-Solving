namespace K._Max_and_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
        

            int min = int.Parse(inputs[0]);
            int max = int.Parse(inputs[0]);
            for(int i = 1; i < 3; i++)
            {
                if (int.Parse(inputs[i]) < min) min = int.Parse(inputs[i]);
                if (int.Parse(inputs[i]) > max) max = int.Parse(inputs[i]);
            }
            Console.Write($"{min} "); Console.Write(max);
            
        }
    }
}
