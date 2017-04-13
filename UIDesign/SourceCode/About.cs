using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIDesign
{
    class frmAbout : Form
    {
        private Bunifu.Framework.UI.BunifuElipse elipseBorder;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientpanelUpperBar;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private Bunifu.Framework.UI.BunifuDragControl dragcontrolUpperPanel;
        private Panel panelInfor;
        private Panel panelImage;
        private PictureBox pictureboxImage;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textboxDescription;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textboxAuthor;
        private Bunifu.Framework.UI.BunifuCustomLabel labelDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel labelContact;
        private Bunifu.Framework.UI.BunifuCustomLabel labelAuthor;
        private Bunifu.Framework.UI.BunifuSeparator separator1;
        private Bunifu.Framework.UI.BunifuSeparator separator2;
        private System.ComponentModel.IContainer components;

        public frmAbout():base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.elipseBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientpanelUpperBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.dragcontrolUpperPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelInfor = new System.Windows.Forms.Panel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureboxImage = new System.Windows.Forms.PictureBox();
            this.labelAuthor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelContact = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textboxAuthor = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.textboxDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.gradientpanelUpperBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.panelInfor.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseBorder
            // 
            this.elipseBorder.ElipseRadius = 3;
            this.elipseBorder.TargetControl = this.gradientpanelUpperBar;
            // 
            // gradientpanelUpperBar
            // 
            this.gradientpanelUpperBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientpanelUpperBar.BackgroundImage")));
            this.gradientpanelUpperBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientpanelUpperBar.Controls.Add(this.buttonClose);
            this.gradientpanelUpperBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientpanelUpperBar.GradientBottomLeft = System.Drawing.Color.DeepSkyBlue;
            this.gradientpanelUpperBar.GradientBottomRight = System.Drawing.Color.LightSeaGreen;
            this.gradientpanelUpperBar.GradientTopLeft = System.Drawing.Color.DeepSkyBlue;
            this.gradientpanelUpperBar.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.gradientpanelUpperBar.Location = new System.Drawing.Point(0, 0);
            this.gradientpanelUpperBar.Name = "gradientpanelUpperBar";
            this.gradientpanelUpperBar.Quality = 10;
            this.gradientpanelUpperBar.Size = new System.Drawing.Size(384, 32);
            this.gradientpanelUpperBar.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = global::UIDesign.Properties.Resources.button_close_background;
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(352, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 0;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // dragcontrolUpperPanel
            // 
            this.dragcontrolUpperPanel.Fixed = true;
            this.dragcontrolUpperPanel.Horizontal = true;
            this.dragcontrolUpperPanel.TargetControl = this.gradientpanelUpperBar;
            this.dragcontrolUpperPanel.Vertical = true;
            // 
            // panelInfor
            // 
            this.panelInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfor.BackColor = System.Drawing.Color.White;
            this.panelInfor.Controls.Add(this.separator1);
            this.panelInfor.Controls.Add(this.separator2);
            this.panelInfor.Controls.Add(this.textboxDescription);
            this.panelInfor.Controls.Add(this.bunifuCustomTextbox2);
            this.panelInfor.Controls.Add(this.textboxAuthor);
            this.panelInfor.Controls.Add(this.labelDescription);
            this.panelInfor.Controls.Add(this.labelContact);
            this.panelInfor.Controls.Add(this.labelAuthor);
            this.panelInfor.Location = new System.Drawing.Point(144, 31);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Size = new System.Drawing.Size(239, 225);
            this.panelInfor.TabIndex = 5;
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.Transparent;
            this.panelImage.Controls.Add(this.pictureboxImage);
            this.panelImage.Location = new System.Drawing.Point(0, 32);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(142, 224);
            this.panelImage.TabIndex = 6;
            // 
            // pictureboxImage
            // 
            this.pictureboxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxImage.Image = global::UIDesign.Properties.Resources.form_about_background;
            this.pictureboxImage.Location = new System.Drawing.Point(1, 12);
            this.pictureboxImage.Name = "pictureboxImage";
            this.pictureboxImage.Size = new System.Drawing.Size(133, 212);
            this.pictureboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxImage.TabIndex = 0;
            this.pictureboxImage.TabStop = false;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.ForeColor = System.Drawing.Color.Red;
            this.labelAuthor.Location = new System.Drawing.Point(11, 25);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(43, 14);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Author";
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelContact.AutoSize = true;
            this.labelContact.ForeColor = System.Drawing.Color.Red;
            this.labelContact.Location = new System.Drawing.Point(11, 59);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(47, 14);
            this.labelContact.TabIndex = 1;
            this.labelContact.Text = "Contact";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.Color.Red;
            this.labelDescription.Location = new System.Drawing.Point(11, 102);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(69, 14);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // textboxAuthor
            // 
            this.textboxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxAuthor.BackColor = System.Drawing.Color.White;
            this.textboxAuthor.BorderColor = System.Drawing.Color.Transparent;
            this.textboxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxAuthor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(84)))), ((int)(((byte)(90)))));
            this.textboxAuthor.Location = new System.Drawing.Point(83, 24);
            this.textboxAuthor.Name = "textboxAuthor";
            this.textboxAuthor.ReadOnly = true;
            this.textboxAuthor.Size = new System.Drawing.Size(145, 16);
            this.textboxAuthor.TabIndex = 3;
            this.textboxAuthor.TabStop = false;
            this.textboxAuthor.Text = "Trần   Văn   Sơn";
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomTextbox2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuCustomTextbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(84)))), ((int)(((byte)(90)))));
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(83, 54);
            this.bunifuCustomTextbox2.Multiline = true;
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.ReadOnly = true;
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(145, 48);
            this.bunifuCustomTextbox2.TabIndex = 4;
            this.bunifuCustomTextbox2.TabStop = false;
            this.bunifuCustomTextbox2.Text = "kingson.a12@gmail.com\r\nfb:transon1812\r\nskype:kingson1812";
            // 
            // textboxDescription
            // 
            this.textboxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxDescription.BackColor = System.Drawing.Color.White;
            this.textboxDescription.BorderColor = System.Drawing.Color.Transparent;
            this.textboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(84)))), ((int)(((byte)(90)))));
            this.textboxDescription.Location = new System.Drawing.Point(14, 124);
            this.textboxDescription.Multiline = true;
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.ReadOnly = true;
            this.textboxDescription.Size = new System.Drawing.Size(214, 89);
            this.textboxDescription.TabIndex = 5;
            this.textboxDescription.TabStop = false;
            this.textboxDescription.Text = "Media Play     is      a      product     of    entertainment. Hope  you  loved  " +
    "it.\r\n\r\n\r\n\r\n>_< Copyright © 2017 -_- Tran V. Son ._.";
            // 
            // separator2
            // 
            this.separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.separator2.BackColor = System.Drawing.Color.Transparent;
            this.separator2.LineColor = System.Drawing.Color.BurlyWood;
            this.separator2.LineThickness = 1;
            this.separator2.Location = new System.Drawing.Point(1, 101);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(236, 1);
            this.separator2.TabIndex = 1;
            this.separator2.TabStop = false;
            this.separator2.Transparency = 255;
            this.separator2.Vertical = false;
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.BackColor = System.Drawing.Color.Transparent;
            this.separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(184)))), ((int)(((byte)(135)))));
            this.separator1.LineThickness = 1;
            this.separator1.Location = new System.Drawing.Point(1, 44);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(236, 1);
            this.separator1.TabIndex = 6;
            this.separator1.TabStop = false;
            this.separator1.Transparency = 255;
            this.separator1.Vertical = false;
            // 
            // frmAbout
            // 
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelInfor);
            this.Controls.Add(this.gradientpanelUpperBar);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(384, 256);
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.gradientpanelUpperBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.panelInfor.ResumeLayout(false);
            this.panelInfor.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            Effect.button_MouseLeave(sender, e);
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            Effect.button_MouseMove(sender, e);
        }
    }
}
