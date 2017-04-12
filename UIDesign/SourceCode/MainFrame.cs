using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System;

namespace UIDesign
{

    public partial class formMainFrame : Form
    {
        public PlayStatus m_buttonPlay;
        public RepeatStatus m_buttonRepeat;
        public ShuffleStatus m_buttonShuffle;

        private Bunifu.Framework.UI.BunifuElipse elipseBorder;
        private Bunifu.Framework.UI.BunifuDragControl dragcontrolMainFrame;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientpanelUpperBar;
        private Panel panelControl;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private Bunifu.Framework.UI.BunifuImageButton buttonMinimize;
        private Bunifu.Framework.UI.BunifuProgressBar processbarPlayTime;
        private Bunifu.Framework.UI.BunifuImageButton buttonPlay;
        private Bunifu.Framework.UI.BunifuImageButton buttonVolumeMax;
        private Bunifu.Framework.UI.BunifuImageButton buttonVolumeMin;
        private Bunifu.Framework.UI.BunifuImageButton buttonPre;
        private Bunifu.Framework.UI.BunifuImageButton buttonNext;
        private Bunifu.Framework.UI.BunifuImageButton buttonShuffle;
        private Bunifu.Framework.UI.BunifuImageButton buttonRepeat;
        private System.ComponentModel.IContainer components;
        private Panel panelLeft;
        private Panel panelTitle;
        private PictureBox pictureboxTitle;
        private Panel panelTrackList;
        private Bunifu.Framework.UI.BunifuImageButton buttonSlider;
        private Bunifu.Framework.UI.BunifuSeparator separatorLeftMid;
        private Panel panelBlankTop;
        private Panel panelMid;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonClearList;
        private Bunifu.Framework.UI.BunifuSlider sliderVolume;

        public formMainFrame()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainFrame));
            this.panelControl = new System.Windows.Forms.Panel();
            this.sliderVolume = new Bunifu.Framework.UI.BunifuSlider();
            this.buttonShuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonVolumeMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonVolumeMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonPre = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.processbarPlayTime = new Bunifu.Framework.UI.BunifuProgressBar();
            this.elipseBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragcontrolMainFrame = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.gradientpanelUpperBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTrackList = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonSlider = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureboxTitle = new System.Windows.Forms.PictureBox();
            this.separatorLeftMid = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panelBlankTop = new System.Windows.Forms.Panel();
            this.buttonClearList = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.panelLeft.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTitle)).BeginInit();
            this.panelBlankTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.sliderVolume);
            this.panelControl.Controls.Add(this.buttonShuffle);
            this.panelControl.Controls.Add(this.buttonRepeat);
            this.panelControl.Controls.Add(this.buttonVolumeMax);
            this.panelControl.Controls.Add(this.buttonVolumeMin);
            this.panelControl.Controls.Add(this.buttonPre);
            this.panelControl.Controls.Add(this.buttonNext);
            this.panelControl.Controls.Add(this.buttonPlay);
            this.panelControl.Controls.Add(this.processbarPlayTime);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 416);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(768, 96);
            this.panelControl.TabIndex = 2;
            // 
            // sliderVolume
            // 
            this.sliderVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.sliderVolume.BackgroudColor = System.Drawing.Color.SlateGray;
            this.sliderVolume.BorderRadius = 2;
            this.sliderVolume.IndicatorColor = System.Drawing.Color.DarkSlateGray;
            this.sliderVolume.Location = new System.Drawing.Point(559, 41);
            this.sliderVolume.MaximumValue = 100;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(148, 30);
            this.sliderVolume.TabIndex = 13;
            this.sliderVolume.Value = 0;
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonShuffle.BackColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.Image = global::UIDesign.Properties.Resources.button_noneshuffle_background;
            this.buttonShuffle.ImageActive = null;
            this.buttonShuffle.Location = new System.Drawing.Point(191, 35);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(40, 40);
            this.buttonShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonShuffle.TabIndex = 10;
            this.buttonShuffle.TabStop = false;
            this.buttonShuffle.Zoom = 10;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            this.buttonShuffle.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonShuffle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRepeat.BackColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.Image = global::UIDesign.Properties.Resources.button_repeatnone_background;
            this.buttonRepeat.ImageActive = null;
            this.buttonRepeat.Location = new System.Drawing.Point(111, 35);
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
            this.buttonVolumeMax.Click += new System.EventHandler(this.buttonVolumeMax_Click);
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
            this.buttonVolumeMin.Click += new System.EventHandler(this.buttonVolumeMin_Click);
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
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
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
            // processbarPlayTime
            // 
            this.processbarPlayTime.BackColor = System.Drawing.Color.LightSlateGray;
            this.processbarPlayTime.BorderRadius = 2;
            this.processbarPlayTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processbarPlayTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.processbarPlayTime.Location = new System.Drawing.Point(0, 0);
            this.processbarPlayTime.MaximumValue = 100;
            this.processbarPlayTime.Name = "processbarPlayTime";
            this.processbarPlayTime.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.processbarPlayTime.Size = new System.Drawing.Size(768, 12);
            this.processbarPlayTime.TabIndex = 1;
            this.processbarPlayTime.TabStop = false;
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
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.separatorLeftMid);
            this.panelLeft.Controls.Add(this.panelTrackList);
            this.panelLeft.Controls.Add(this.panelTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft.ForeColor = System.Drawing.Color.Black;
            this.panelLeft.Location = new System.Drawing.Point(0, 32);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(240, 384);
            this.panelLeft.TabIndex = 3;
            // 
            // panelTrackList
            // 
            this.panelTrackList.AllowDrop = true;
            this.panelTrackList.AutoScroll = true;
            this.panelTrackList.BackColor = System.Drawing.Color.Transparent;
            this.panelTrackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrackList.Location = new System.Drawing.Point(0, 32);
            this.panelTrackList.Name = "panelTrackList";
            this.panelTrackList.Size = new System.Drawing.Size(240, 352);
            this.panelTrackList.TabIndex = 1;
            this.panelTrackList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTrackList_DragDrop);
            this.panelTrackList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTrackList_DragEnter);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.buttonSlider);
            this.panelTitle.Controls.Add(this.pictureboxTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(240, 32);
            this.panelTitle.TabIndex = 0;
            // 
            // buttonSlider
            // 
            this.buttonSlider.BackColor = System.Drawing.Color.Transparent;
            this.buttonSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSlider.Image = global::UIDesign.Properties.Resources.button_menu_background;
            this.buttonSlider.ImageActive = null;
            this.buttonSlider.Location = new System.Drawing.Point(0, 0);
            this.buttonSlider.Name = "buttonSlider";
            this.buttonSlider.Size = new System.Drawing.Size(48, 32);
            this.buttonSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonSlider.TabIndex = 6;
            this.buttonSlider.TabStop = false;
            this.buttonSlider.Zoom = 10;
            this.buttonSlider.Click += new System.EventHandler(this.buttonSlider_Click);
            this.buttonSlider.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // pictureboxTitle
            // 
            this.pictureboxTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureboxTitle.Image = global::UIDesign.Properties.Resources.picture_title_background;
            this.pictureboxTitle.Location = new System.Drawing.Point(48, 0);
            this.pictureboxTitle.Name = "pictureboxTitle";
            this.pictureboxTitle.Size = new System.Drawing.Size(192, 32);
            this.pictureboxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxTitle.TabIndex = 0;
            this.pictureboxTitle.TabStop = false;
            // 
            // separatorLeftMid
            // 
            this.separatorLeftMid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.separatorLeftMid.BackColor = System.Drawing.Color.Transparent;
            this.separatorLeftMid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.separatorLeftMid.LineThickness = 1;
            this.separatorLeftMid.Location = new System.Drawing.Point(238, 0);
            this.separatorLeftMid.Name = "separatorLeftMid";
            this.separatorLeftMid.Size = new System.Drawing.Size(2, 384);
            this.separatorLeftMid.TabIndex = 2;
            this.separatorLeftMid.Transparency = 255;
            this.separatorLeftMid.Vertical = true;
            // 
            // panelMid
            // 
            this.panelMid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMid.BackColor = System.Drawing.Color.Transparent;
            this.panelMid.Location = new System.Drawing.Point(240, 64);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(528, 352);
            this.panelMid.TabIndex = 4;
            // 
            // panelBlankTop
            // 
            this.panelBlankTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBlankTop.BackColor = System.Drawing.Color.Transparent;
            this.panelBlankTop.Controls.Add(this.buttonClearList);
            this.panelBlankTop.Location = new System.Drawing.Point(240, 32);
            this.panelBlankTop.Name = "panelBlankTop";
            this.panelBlankTop.Size = new System.Drawing.Size(528, 32);
            this.panelBlankTop.TabIndex = 5;
            // 
            // buttonClearList
            // 
            this.buttonClearList.ActiveBorderThickness = 1;
            this.buttonClearList.ActiveCornerRadius = 2;
            this.buttonClearList.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.buttonClearList.ActiveForecolor = System.Drawing.Color.White;
            this.buttonClearList.ActiveLineColor = System.Drawing.Color.DarkCyan;
            this.buttonClearList.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearList.BackgroundImage")));
            this.buttonClearList.ButtonText = "Clear list";
            this.buttonClearList.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonClearList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonClearList.IdleBorderThickness = 1;
            this.buttonClearList.IdleCornerRadius = 2;
            this.buttonClearList.IdleFillColor = System.Drawing.Color.LightCyan;
            this.buttonClearList.IdleForecolor = System.Drawing.Color.DarkCyan;
            this.buttonClearList.IdleLineColor = System.Drawing.Color.DarkCyan;
            this.buttonClearList.Location = new System.Drawing.Point(8, 0);
            this.buttonClearList.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(64, 32);
            this.buttonClearList.TabIndex = 0;
            this.buttonClearList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // formMainFrame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.panelBlankTop);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelControl);
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
            this.panelLeft.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxTitle)).EndInit();
            this.panelBlankTop.ResumeLayout(false);
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
            this.Dispose();
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
                    b.BackColor = Color.FromArgb(175, 255, 197);
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
            Configuration.SetPlayStatus(ref m_buttonPlay, buttonPlay);
        }

        private void formMainFrame_Load(object sender, EventArgs e)
        {
            m_buttonRepeat = RepeatStatus.NONE;
            m_buttonPlay = PlayStatus.PAUSE;
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            Configuration.SetRepeatStatus(ref m_buttonRepeat, buttonRepeat);
        }

        private void buttonVolumeMin_Click(object sender, EventArgs e)
        {
            sliderVolume.Value = 0;
        }

        private void buttonVolumeMax_Click(object sender, EventArgs e)
        {
            sliderVolume.Value = sliderVolume.MaximumValue;

        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            Configuration.SetShuffleStatus(ref m_buttonShuffle, buttonShuffle);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Label b;
            for (int i = 0; i < 50; i++)
            {
                b = new Label();
                b.Text = i + "";
                b.Size = new Size(30, 20);
                b.Location = new Point(b.Location.X, b.Location.Y + i * b.Height);
                panelLeft.Controls["panelTrackList"].Controls.Add(b);
            }
        }

        private void buttonSlider_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {

        }

        private void panelTrackList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panelTrackList_DragDrop(object sender, DragEventArgs e)
        {
            string[] dataArray=(string[])e.Data.GetData(DataFormats.FileDrop, false);
        }
    }
}
