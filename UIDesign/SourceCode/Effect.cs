using System;
using System.Drawing;
using System.Windows.Forms;

namespace UIDesign
{
    public static class Effect
    {
        public static void button_MouseLeave(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton b = (Bunifu.Framework.UI.BunifuImageButton)sender;
            b.BackColor = Color.Transparent;
        }

        public static void button_MouseMove(object sender, MouseEventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton b = (Bunifu.Framework.UI.BunifuImageButton)sender;
            switch (b.Name)
            {
                case "buttonMinimize":
                    b.BackColor = Color.White;
                    break;
                case "buttonClose":
                    b.BackColor = Color.Red;
                    break;
                default:
                    b.BackColor = Color.FromArgb(175, 255, 197);
                    break;
            }
        }
    }
}
