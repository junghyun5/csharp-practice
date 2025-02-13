namespace TextRPG02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modify file name by pressing f2 button
           Game game = new Game();

            while(true)
            {
                game.Process();
            }

        }
    }
}
