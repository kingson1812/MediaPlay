using System;

namespace Global
{
    public static class Log
    {
        public static void LOG_DEBUG(string message)
        {
            if(Config.PLATFORM == Config.CONFIG.WIN32)
                Console.WriteLine(message);
            //else if (Config.PLATFORM == Config.CONFIG.ANDROID)

        }
    }
}
