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

public enum ShuffleStatus
{
    NO,
    YES
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

        public static void SetShuffleStatus(ref ShuffleStatus currentStatus, BunifuImageButton button)
        {
            if (currentStatus == ShuffleStatus.NO)//next will be YES
            {
                currentStatus = ShuffleStatus.YES;
                button.Image = Image.FromFile(_Environment.g_SolutionDir + "/UIDesign/Asset/button_shuffle_background.png");//display real status
            }
            else if (currentStatus == ShuffleStatus.YES)//next will be PLAY
            {
                currentStatus = ShuffleStatus.NO;
                button.Image = Image.FromFile(_Environment.g_SolutionDir + "/UIDesign/Asset/button_noneshuffle_background.png");//display real status
            }
        }
    }
}
