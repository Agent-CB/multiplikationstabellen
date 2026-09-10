namespace multiplikationstabellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplikationstabellen");

            Console.WriteLine("Ange ett tal:");
            int tal = int.Parse(Console.ReadLine());

            for (int i = 1; i<= 100; i++)
            {
                Console.WriteLine(i);

                for (int j = 1; j <= 100; j++)
                {

                    Console.WriteLine($"{tal} * {j} = {tal * j}");
                }

            }
        }
    }
}
