using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using Global;
using System;

namespace UIDesign
{

    public partial class formMainFrame : Form
    {
        private Bunifu.Framework.UI.BunifuElipse elipseBorder;
        private Bunifu.Framework.UI.BunifuDragControl dragcontrolMainFrame;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientpanelUpperBar;
        private Panel panelControl;
        private Panel panelView;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private Bunifu.Framework.UI.BunifuImageButton buttonMinimize;
        private Bunifu.Framework.UI.BunifuProgressBar processbarPlayTime;
        private Bunifu.Framework.UI.BunifuImageButton buttonPlay;
        private Bunifu.Framework.UI.BunifuImageButton buttonVolumeMax;
        private Bunifu.Framework.UI.BunifuImageButton buttonVolumeMin;
        private Bunifu.Framework.UI.BunifuImageButton buttonPre;
        private Bunifu.Framework.UI.BunifuImageButton buttonNext;
        private Bunifu.Framework.UI.BunifuTrackbar trackbarVolume;
        private Bunifu.Framework.UI.BunifuImageButton buttonShuffle;
        private Bunifu.Framework.UI.BunifuImageButton buttonRepeat;
        private System.ComponentModel.IContainer components;

        public RepeatStatus m_buttonRepeat;
        public PlayStatus m_buttonPlay;

        public formMainFrame()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainFrame));
            this.panelControl = new System.Windows.Forms.Panel();
            this.trackbarVolume = new Bunifu.Framework.UI.BunifuTrackbar();
            this.processbarPlayTime = new Bunifu.Framework.UI.BunifuProgressBar();
            this.elipseBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragcontrolMainFrame = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.buttonShuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonVolumeMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonVolumeMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonPre = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.gradientpanelUpperBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVolumeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVolumeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).BeginInit();
            this.gradientpanelUpperBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.buttonShuffle);
            this.panelControl.Controls.Add(this.buttonRepeat);
            this.panelControl.Controls.Add(this.trackbarVolume);
            this.panelControl.Controls.Add(this.buttonVolumeMax);
            this.panelControl.Controls.Add(this.buttonVolumeMin);
            this.panelControl.Controls.Add(this.buttonPre);
            this.panelControl.Controls.Add(this.buttonNext);
            this.panelControl.Controls.Add(this.buttonPlay);
            this.panelControl.Controls.Add(this.processbarPlayTime);
            this.panelControl.Location = new System.Drawing.Point(0, 416);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(768, 96);
            this.panelControl.TabIndex = 2;
            // 
            // trackbarVolume
            // 
            this.trackbarVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackbarVolume.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.trackbarVolume.BackColor = System.Drawing.Color.Transparent;
            this.trackbarVolume.BackgroudColor = System.Drawing.Color.MediumSeaGreen;
            this.trackbarVolume.BorderRadius = 2;
            this.trackbarVolume.IndicatorColor = System.Drawing.Color.DarkSlateGray;
            this.trackbarVolume.Location = new System.Drawing.Point(559, 41);
            this.trackbarVolume.MaximumValue = 100;
            this.trackbarVolume.Name = "trackbarVolume";
            this.trackbarVolume.Size = new System.Drawing.Size(148, 30);
            this.trackbarVolume.SliderRadius = 1;
            this.trackbarVolume.TabIndex = 8;
            this.trackbarVolume.TabStop = false;
            this.trackbarVolume.Value = 0;
            // 
            // processbarPlayTime
            // 
            this.processbarPlayTime.BackColor = System.Drawing.Color.MediumTurquoise;
            this.processbarPlayTime.BorderRadius = 5;
            this.processbarPlayTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.processbarPlayTime.Location = new System.Drawing.Point(0, 0);
            this.processbarPlayTime.MaximumValue = 100;
            this.processbarPlayTime.Name = "processbarPlayTime";
            this.processbarPlayTime.ProgressColor = System.Drawing.Color.Teal;
            this.processbarPlayTime.Size = new System.Drawing.Size(768, 16);
            this.processbarPlayTime.TabIndex = 1;
            this.processbarPlayTime.Value = 0;
            // 
            // elipseBorder
            // 
            this.elipseBorder.ElipseRadius = 3;
            this.elipseBorder.TargetControl = this;
            // 
            // dragcontrolMainFrame
            // 
            this.dragcontrolMainFrame.Fixed = true;
            this.dragcontrolMainFrame.Horizontal = true;
            this.dragcontrolMainFrame.TargetControl = this.gradientpanelUpperBar;
            this.dragcontrolMainFrame.Vertical = true;
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonShuffle.BackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.Image = global::UIDesign.Properties.Resources.button_shuffle_background;
            this.buttonShuffle.ImageActive = null;
            this.buttonShuffle.Location = new System.Drawing.Point(100, 35);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(40, 40);
            this.buttonShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonShuffle.TabIndex = 10;
            this.buttonShuffle.TabStop = false;
            this.buttonShuffle.Zoom = 10;
            this.buttonShuffle.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonShuffle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRepeat.BackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.Image = global::UIDesign.Properties.Resources.button_repeatnone_background;
            this.buttonRepeat.ImageActive = null;
            this.buttonRepeat.Location = new System.Drawing.Point(20, 35);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(40, 40);
            this.buttonRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonRepeat.TabIndex = 9;
            this.buttonRepeat.TabStop = false;
            this.buttonRepeat.Zoom = 10;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            this.buttonRepeat.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonRepeat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonVolumeMax
            // 
            this.buttonVolumeMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonVolumeMax.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolumeMax.Image = global::UIDesign.Properties.Resources.button_sound_background;
            this.buttonVolumeMax.ImageActive = null;
            this.buttonVolumeMax.Location = new System.Drawing.Point(713, 35);
            this.buttonVolumeMax.Name = "buttonVolumeMax";
            this.buttonVolumeMax.Size = new System.Drawing.Size(40, 40);
            this.buttonVolumeMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonVolumeMax.TabIndex = 6;
            this.buttonVolumeMax.TabStop = false;
            this.buttonVolumeMax.Zoom = 10;
            this.buttonVolumeMax.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonVolumeMax.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonVolumeMin
            // 
            this.buttonVolumeMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonVolumeMin.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolumeMin.Image = global::UIDesign.Properties.Resources.button_mute_background;
            this.buttonVolumeMin.ImageActive = null;
            this.buttonVolumeMin.Location = new System.Drawing.Point(513, 35);
            this.buttonVolumeMin.Name = "buttonVolumeMin";
            this.buttonVolumeMin.Size = new System.Drawing.Size(40, 40);
            this.buttonVolumeMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonVolumeMin.TabIndex = 5;
            this.buttonVolumeMin.TabStop = false;
            this.buttonVolumeMin.Zoom = 10;
            this.buttonVolumeMin.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonVolumeMin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonPre
            // 
            this.buttonPre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPre.BackColor = System.Drawing.Color.Transparent;
            this.buttonPre.Image = global::UIDesign.Properties.Resources.button_previous_background;
            this.buttonPre.ImageActive = null;
            this.buttonPre.Location = new System.Drawing.Point(298, 32);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(48, 48);
            this.buttonPre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonPre.TabIndex = 4;
            this.buttonPre.TabStop = false;
            this.buttonPre.Zoom = 10;
            this.buttonPre.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonPre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.Image = global::UIDesign.Properties.Resources.button_forward_background;
            this.buttonNext.ImageActive = null;
            this.buttonNext.Location = new System.Drawing.Point(406, 32);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(48, 48);
            this.buttonNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonNext.TabIndex = 3;
            this.buttonNext.TabStop = false;
            this.buttonNext.Zoom = 10;
            this.buttonNext.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonNext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.Image = global::UIDesign.Properties.Resources.button_play_background;
            this.buttonPlay.ImageActive = null;
            this.buttonPlay.Location = new System.Drawing.Point(352, 32);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(48, 48);
            this.buttonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Zoom = 10;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // panelView
            // 
            this.panelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelView.BackgroundImage = global::UIDesign.Properties.Resources.form_image_background;
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelView.Location = new System.Drawing.Point(0, 32);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(768, 384);
            this.panelView.TabIndex = 1;
            // 
            // gradientpanelUpperBar
            // 
            this.gradientpanelUpperBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientpanelUpperBar.BackgroundImage")));
            this.gradientpanelUpperBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientpanelUpperBar.Controls.Add(this.buttonMinimize);
            this.gradientpanelUpperBar.Controls.Add(this.buttonClose);
            this.gradientpanelUpperBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientpanelUpperBar.GradientBottomLeft = System.Drawing.Color.DeepSkyBlue;
            this.gradientpanelUpperBar.GradientBottomRight = System.Drawing.Color.LightSeaGreen;
            this.gradientpanelUpperBar.GradientTopLeft = System.Drawing.Color.DeepSkyBlue;
            this.gradientpanelUpperBar.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.gradientpanelUpperBar.Location = new System.Drawing.Point(0, 0);
            this.gradientpanelUpperBar.Name = "gradientpanelUpperBar";
            this.gradientpanelUpperBar.Quality = 10;
            this.gradientpanelUpperBar.Size = new System.Drawing.Size(768, 32);
            this.gradientpanelUpperBar.TabIndex = 0;
            this.gradientpanelUpperBar.DoubleClick += new System.EventHandler(this.gradientpanelUpperBar_DoubleClick);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Image = global::UIDesign.Properties.Resources.button_minus_background;
            this.buttonMinimize.ImageActive = null;
            this.buttonMinimize.Location = new System.Drawing.Point(703, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(32, 32);
            this.buttonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Zoom = 0;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = global::UIDesign.Properties.Resources.button_close_background;
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(735, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 0;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // formMainFrame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.gradientpanelUpperBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "formMainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Play";
            this.Load += new System.EventHandler(this.formMainFrame_Load);
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVolumeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonVolumeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlay)).EndInit();
            this.gradientpanelUpperBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);

        }

        private void gradientpanelUpperBar_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
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
                    b.BackColor = Color.FromArgb(255, 237, 237);
                    break;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton b = (Bunifu.Framework.UI.BunifuImageButton)sender;
            b.BackColor = Color.Transparent;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Configuration.SetPlayStatus(ref m_buttonPlay,buttonPlay);
        }

        private void formMainFrame_Load(object sender, EventArgs e)
        {
            m_buttonRepeat = RepeatStatus.NONE;
            m_buttonPlay = PlayStatus.PAUSE;
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            Configuration.SetRepeatStatus(ref m_buttonRepeat,buttonRepeat);
        }
    }
}
