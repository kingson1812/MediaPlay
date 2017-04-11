using Bunifu.Framework.UI;
using System.Drawing;
using Global;

public enum RepeatStatus
{
    ONE,
    ALL,
    NONE
};

public enum PlayStatus
{
    PLAY,
    PAUSE
}

namespace UIDesign
{
    public static class Configuration
    {
        /// <summary>
        /// NONE -> ALL -> ONE -> NONE ...
        /// </summary>
        public static void SetRepeatStatus(ref RepeatStatus currentStatus, BunifuImageButton button)
        {
            if(currentStatus==RepeatStatus.NONE)//next will be ALL
            {
                currentStatus = RepeatStatus.ALL;
                button.Image = Image.FromFile(_Environment.g_SolutionDir + "/UIDesign/Asset/button_repeatall_background.png");
            }
            else if (currentStatus == RepeatStatus.ALL)//next will be ONE
            {
                currentStatus = RepeatStatus.ONE;
                button.Image = Image.FromFile(_Environment.g_SolutionDir + "/UIDesign/Asset/button_repeatone_background.png");
            }
            else if (currentStatus == RepeatStatus.ONE)//next will be NONE
            {
                currentStatus = RepeatStatus.NONE;
                button.Image = Image.FromFile(_Environment.g_SolutionDir + "/UIDesign/Asset/button_repeatnone_background.png");
            }
        }

        public static void SetPlayStatus(ref PlayStatus currentStatus, BunifuImageButton button)
        {
            if (currentStatus == PlayStatus.PLAY)//next will be PAUSE
            {
                currentStatus = PlayStatus.PAUSE;
                button.Image = Image.FromFile(_Environment.g_SolutionDir + "/UIDesign/Asset/button_play_background.png");//need display play icon when paused
            }
            else if (currentStatus == PlayStatus.PAUSE)//next will be PLAY
            {
                currentStatus = PlayStatus.PLAY;
                button.Image = Image.FromFile(_Environment.g_SolutionDir + "/UIDesign/Asset/button_pause_background.png");//and pause the other
            }
        }
    }
}
