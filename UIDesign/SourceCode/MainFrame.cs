using System.Drawing;
using System.Windows.Forms;
using Global;
using System;

namespace UIDesign
{

    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //Get screen dimension
            //_Environment.g_ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            //_Environment.g_ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            //Log.DEBUG("Current display resolution: {0} x {1}", _Environment.g_ScreenWidth, _Environment.g_ScreenHeight);
            //    //Component
            //    GroupBox groupboxControl = new GroupBox();
            //    GroupBox groupboxInfor = new GroupBox();
            //    _Button buttonPlay = new _Button();
            //    _Button buttonNext = new _Button();

            //    //Setup UI
            //    this.SuspendLayout();

            //    //__________
            //    //groupboxControl
            //    //__________
            //    groupboxControl.Name = "groupboxControl";
            //    groupboxControl.ClientSize = new Size(_Environment.g_WindowWidth - 10, 80);
            //    groupboxControl.Location =new Point((_Environment.g_WindowWidth - groupboxControl.Width)/2
            //        , _Environment.g_WindowHeight - groupboxControl.Height-5);
            //    groupboxControl.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            //    groupboxControl.BackColor = Color.White;

            //    //__________
            //    //groupboxInfor
            //    //__________
            //    groupboxInfor.Name = "groupboxInfor";
            //    groupboxInfor.TabIndex = 0;
            //    groupboxInfor.ClientSize = new Size(_Environment.g_WindowWidth - 10, _Environment.g_WindowHeight- groupboxControl.Height-10);
            //    groupboxInfor.Location = new Point((_Environment.g_WindowWidth - groupboxInfor.Width) / 2
            //        , 5);
            //    groupboxInfor.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right| AnchorStyles.Top;
            //    groupboxInfor.BackColor = Color.White;

            //    //__________
            //    //buttonPlay
            //    //__________
            //    buttonPlay.Name ="buttonPlay";
            //    buttonPlay.TabStop = false;
            //    buttonPlay.BackgroundImageLayout = ImageLayout.Zoom;
            //    buttonPlay.Size = new Size((groupboxControl.Height>>1)+5, groupboxControl.Height >> 1);
            //    buttonPlay.Location = new Point(10,(groupboxControl.Height - buttonPlay.Height) >> 1);
            //    buttonPlay.SetBackgroundImage(_Environment.g_SolutionDir + "/UIDesign/Asset/button_play_background.png");
            //    buttonPlay.AddImage(new string[]
            //    {
            //        _Environment.g_SolutionDir + "/UIDesign/Asset/button_play_background.png",
            //        _Environment.g_SolutionDir + "/UIDesign/Asset/button_pause_background.png"
            //    });
            //    buttonPlay.m_status = _Button.Status.PAUSE;
            //    buttonPlay.MouseHover += Button_MouseHover;
            //    buttonPlay.Click += _Button_Play_Click;

            //    //__________
            //    //buttonNext
            //    //__________
            //    buttonNext.Name = "buttonNext";
            //    buttonNext.TabIndex = 0;
            //    buttonNext.BackgroundImageLayout = ImageLayout.Stretch;
            //    buttonNext.ClientSize = new Size(groupboxControl.Height >> 1, groupboxControl.Height >> 1);
            //    buttonNext.Location = new Point(10, (groupboxControl.Height - buttonPlay.Height) >> 1);
            //    buttonNext.SetBackgroundImage(_Environment.g_SolutionDir + "/UIDesign/Asset/button_play_background.png");

            //   // buttonNext.MouseHover += MainFrame_MouseHover;
            //   // buttonNext.Click += MainFrame_Click;

            //    //__________
            //    //formMainFrame
            //    //__________
            //    this.AutoScaleDimensions = new SizeF(6F, 13F);
            //    this.AutoScaleMode = AutoScaleMode.Font;
            //    this.ClientSize = new Size(_Environment.g_WindowWidth, _Environment.g_WindowHeight);
            //    this.Name = "formMainFrame";
            //    this.Text = "MediaPlay";
            //    this.Resize += MainFrame_Resize;
            //    this.Icon = new Icon(_Environment.g_SolutionDir + "/MediaPlay/Icon.ico");
            //    this.MinimizeBox = false;
            //    this.MaximizeBox = false;
            //    this.StartPosition = FormStartPosition.CenterScreen;
            //    this.BackColor = Color.White;

            //    //Add controls
            //    groupboxControl.Controls.Add(buttonPlay);
            //    this.Controls.Add(groupboxControl);
            //    this.Controls.Add(groupboxInfor);

            //    this.ResumeLayout(false);

            //}

            //private void _Button_Play_Click(object sender, EventArgs e)
            //{
            //    try
            //    {
            //        _Button b = (_Button)sender;
            //        b._Button_MouseClick(sender, e);
            //    }
            //    catch (Exception ex)
            //    {
            //        Log.ERROR("Error: {0}", ex.Message);
            //    }
            //}

            //private void Button_MouseHover(object sender, EventArgs e)
            //{
            //    try
            //    {
            //        _Button b = (_Button)sender;
            //        b._Button_MouseHover(sender, e);
            //    }
            //    catch (Exception ex)
            //    {
            //        Log.ERROR("Error: {0}", ex.Message);
            //    }
            //}

            //private void MainFrame_Resize(object sender, System.EventArgs e)
            //{
            //    try
            //    {
            //        Form form = (Form)sender;
            //        form.MinimumSize = new Size((3*_Environment.g_WindowWidth)>>2,(3*_Environment.g_WindowHeight)>>2);
            //    }
            //    catch(Exception ex)
            //    {
            //        Log.ERROR("Error: {0}", ex.Message);
            //    }
        }
    }
}
