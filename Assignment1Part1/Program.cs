namespace Assignment1Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();
            myPet.Start();

            Console.Write("press Enter to start next part!");
            //reads that user pressed a key to continue
            Console.ReadLine();

            Album album =new Album();
            album.Start();
        }
    }
}
