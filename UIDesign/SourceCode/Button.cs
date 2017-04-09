using System.Windows.Forms;
using System.Drawing;
using Global;
using System.Collections.Generic;
using System;

namespace UIDesign
{
    public class _Button : PictureBox
    {
        private List<Image> m_imageList = new List<Image>();
        public enum Status
        {
            PLAY,
            PAUSE
        }
        public Status m_status;

        public _Button()
        {
        }

        public _Button(string backgroundImage)
        {
            this.SuspendLayout();
            this.BackgroundImage = Image.FromFile(backgroundImage);
            this.ResumeLayout(false);
        }

        public _Button(Image image)
        {
            this.SuspendLayout();
            this.BackgroundImage = image;
            this.ResumeLayout(false);
        }

        public void SetBackgroundImage(string filePath)
        {
            this.SuspendLayout();
            this.BackgroundImage = Image.FromFile(filePath);
            this.ResumeLayout(false);
        }

        public void SetBackgroundImage(Image image)
        {
            this.SuspendLayout();
            this.BackgroundImage = image;
            this.ResumeLayout(false);
        }

        public void _Button_MouseHover(object sender, EventArgs e)
        {
            
        }

        public void _Button_MouseClick(object sender, EventArgs e)
        {
            if (m_status == Status.PLAY)
            {
                SetBackgroundImage(m_imageList[0]);
                m_status = Status.PAUSE;
                Log.VERBOSE("Change status to PAUSE");
            }
            else if (m_status == Status.PAUSE)
            {
                SetBackgroundImage(m_imageList[1]);
                m_status = Status.PLAY;
                Log.VERBOSE("Change status to PLAY");
            }
        }

        public void AddImage(string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                m_imageList.Add(Image.FromFile(list[i]));
            }
        }
    }
}
