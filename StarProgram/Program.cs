
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This program is 1 to 5.");

        OneToFiveStarProgarm();

        Console.WriteLine("This program is 5 to 1.");

        FiveToOneStarProgram();
    }

    private static void OneToFiveStarProgarm()
    {
        Console.Write("Enter the number of rows: ");

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    private static void FiveToOneStarProgram()
    {
        Console.Write("Enter the number of rows: ");

        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 1; i--)
        {
            //for (int j = 1; j <= i; j++)  // like 12345
            for (int j = i; j >= 1; j--)    // like 54321
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}