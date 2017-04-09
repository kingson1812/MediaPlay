using System.IO;

namespace Global
{
    public static class _Environment
    {
        public static string g_SolutionDir = Directory.GetCurrentDirectory()+"/../";
        public static int g_ScreenWidth = 0;
        public static int g_ScreenHeight = 0;

        public static int g_WindowWidth = 800;
        public static int g_WindowHeight = 600;
    }
}
