using Global;
using System;
using System.Drawing;

namespace MediaPlay
{
    class Program
    {
        static void Main()
        {
           StartScreen scrStart = new StartScreen(800,600);
           scrStart.Initialization();
            scrStart.Icon = new Icon(_Environment.g_SolutionDir + "/MediaPlay/Icon.ico");
            scrStart.Title = "Media Play";
            
            scrStart.Run();
        }
    }
}
