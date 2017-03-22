using System.Windows.Forms;
using System.Drawing;
using Global;

namespace UIDesign
{
    public class _Button : PictureBox
    {
        public Color ForeColor { get; set; }
        private Image BackGround() => Image.FromFile(Environment.g_SolutionDir+ "Asset/button_background.png");
        public _Button()
        {
            this.ForeColor = Color.WhiteSmoke;
            
            this.Size = new Size(BackGround().Width,BackGround().Height);
        }
    }
}
