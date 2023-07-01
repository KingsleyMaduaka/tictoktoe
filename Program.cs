namespace GameCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            TikTocToe t = new TikTocToe();

            t.StartGame();
            t.ComputerRandom();
            
            Console.WriteLine("Click any key to continue ");
            Console.ReadKey();
        }
    }
}