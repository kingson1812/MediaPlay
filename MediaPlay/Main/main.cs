using System;

namespace MediaPlay
{
    class Program
    {
        static void Main()
        {
           StartScreen scrStart = new StartScreen(800,600);
           scrStart.Initialization();
           scrStart.Run();
        }
    }
}
