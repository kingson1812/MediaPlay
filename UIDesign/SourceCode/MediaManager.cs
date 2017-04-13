using System.Collections.Generic;
using System.Net;
using WMPLib;

namespace UIDesign
{
    public struct Media
    {
        public int index;
        public string filePath;
    }

    public class MediaManager
    {
        WindowsMediaPlayer wmp;
        private List<Media> m_mediaArray;

        public MediaManager()
        {
            wmp = new WindowsMediaPlayer();
        }

        public void SetMediaList(List<Media> mediaList)
        {
            this.m_mediaArray = mediaList;
            for (int i = 0; i < m_mediaArray.Count; i++)
            {
                wmp.currentPlaylist.appendItem(wmp.newMedia(m_mediaArray[i].filePath));
            }
        }

        public void Play(RepeatStatus repeat,ShuffleStatus shuffle,PlayStatus play)
        {
            if (play == PlayStatus.PLAY)
                wmp.controls.play();
            else if (play == PlayStatus.PAUSE)
                wmp.controls.pause();
        }
    }
}
