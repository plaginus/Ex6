namespace Ex6;

class Program
{
    static void Main(string[] args)
    {
        Test1();
    }

    static void Test1()
    {
        Gamer g1 = new Gamer("Niko");

        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Value of dice {g1.SeanseGame()} for {g1.ToString()}");
        }
    }
}
