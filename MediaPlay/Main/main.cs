using Global;
using UIDesign;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace MediaPlay
{
    class Program
    {
        protected static void GraphicsCall()
        {
            StartScreen scrStart = new StartScreen(800, 600);
            scrStart.Initialization();
            scrStart.Icon = new Icon(_Environment.g_SolutionDir + "/MediaPlay/Icon.ico");
            scrStart.Title = "Media Play";
            scrStart.Run();
        }

        protected static void ProgramCall()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //No comment
            Application.Run(new formMainFrame());
            
        }

        [STAThread]
        static void Main()
        {
            //Console setting
            Log.SetConsoleValue(75, 30, ConsoleColor.Black, 100, 9999, Encoding.UTF8, "Media Play");

            //Log.VERBOSE("[Thread] Run GRAPHICS");
            //ThreadStart graphic = new ThreadStart(GraphicsCall);
            //Thread mother = new Thread(graphic);
            //mother.Start();

            Log.VERBOSE("[Thread] Run PROGRAM");
            ThreadStart program = new ThreadStart(ProgramCall);
            Thread father = new Thread(program);
            father.Start();
        }
    }
}
