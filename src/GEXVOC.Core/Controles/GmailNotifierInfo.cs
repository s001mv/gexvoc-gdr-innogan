using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GEXVOC.Core.Controles
{
	/// <summary>
	/// An Google Like Info Showing control
	/// </summary>
	public class GmailNotifierInfo : System.Windows.Forms.Form
	{
	
		#region DesignTimeMembers
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Timer tmrMove;
		private System.Windows.Forms.ContextMenu ctxMenu;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem mnTell;
		private System.Windows.Forms.MenuItem mnAbout;
		private System.Windows.Forms.NotifyIcon ntfyIcon;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.ImageList imgList;
		private System.ComponentModel.IContainer components;
		#endregion

		#region private Members
		private string strInfo; // the info to b shown in the GmailNotifierControl
		private int nInterval = 50; // the interval for moving the GmailNotifierControl
		private string strNotifyText; // the text to show in the notify Icon
		private System.Windows.Forms.Timer tmrEnd;
		private Image imgGimage;
		private bool bHide = false;
		private bool bFinished = false;
		private int nPitch = 4;
		private int nTimeOut = 10;
		#endregion

		#region Accessors
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
		}
		public override Image BackgroundImage
		{
			get
			{
				return base.BackgroundImage;
			}
		}

		public override Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
		}

		public override RightToLeft RightToLeft
		{
			get
			{
				return base.RightToLeft;
			}
		}

		public override bool AllowDrop
		{
			get
			{
				return base.AllowDrop;
			}
		}

		public override ContextMenu ContextMenu
		{
			get
			{
				return base.ContextMenu;
			}
		}

		public override AnchorStyles Anchor
		{
			get
			{
				return base.Anchor;
			}
		}

		public override DockStyle Dock
		{
			get
			{
				return base.Dock;
			}
		}

		public override string Text
		{
			get
			{
				return "";
			}
		}
		
		public override Size AutoScaleBaseSize
		{
			get
			{
				return base.AutoScaleBaseSize;
			}
		}


		[Category("Misc..."),Description("The TimeOut in milliseconds of GmailNotifierControl Info")]
		public int TimeOut
		{
			get
			{
				return this.nTimeOut / 1000;
			}
			set
			{
				this.nTimeOut = value * 1000;
				this.tmrEnd.Interval = value * 1000;
			}
		}
	
		[Category("Misc..."),Description("The text to show in the GmailNotifierControl")]
		public string Info
		{
			get
			{
				return this.strInfo;
			}
			set
			{
				this.lblInfo.Text = value;
				this.strInfo = value;
				this.Refresh();
			}
		}


		[Category("Misc..."),Description("The text to show in the GmailNotifier TrayIcon")]
		public string NotifyText
		{
			get
			{
				return this.strNotifyText;
			}
			set
			{
				this.ntfyIcon.Text = value;
				this.strNotifyText = value;
				this.Refresh();
			}
		}

		
		[Category("Misc..."),Description("The Pitch in pixels to move the GmailNotifierControl")]
		public int Pitch
		{
			get
			{
				return this.nPitch;
			}
			set
			{
				this.nPitch= value;
			}
		}

		
		[Category("Misc..."),Description("The speed in milliseconds of GmailNotifierControl movement")]
		public int Interval
		{
			get
			{
				return this.nInterval;
			}
			set
			{
				this.nInterval = value;
				this.tmrMove.Interval = value;
			}
		}

		
		[Category("Misc..."),Description("The Image to be displayed in GmailNotifierControl")]
		public Image GmailImage
		{
			get
			{
				return this.imgList.Images[1];
			}
			set
			{
				this.pctLogo.Image = value;
				this.imgList.Images.Add(value);
				this.imgGimage = value;
			}
		}
		#endregion

		#region Code généré par le Concepteur de composants
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GmailNotifierInfo));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.ntfyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenu = new System.Windows.Forms.ContextMenu();
            this.mnTell = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnAbout = new System.Windows.Forms.MenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tmrEnd = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(16, 5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(40, 40);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 1000;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // ntfyIcon
            // 
            this.ntfyIcon.ContextMenu = this.ctxMenu;
            this.ntfyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyIcon.Icon")));
            // 
            // ctxMenu
            // 
            this.ctxMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnTell,
            this.menuItem4,
            this.mnAbout});
            // 
            // mnTell
            // 
            this.mnTell.Index = 0;
            this.mnTell.Text = "Tell Me!!";
            this.mnTell.Click += new System.EventHandler(this.mnTell_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // mnAbout
            // 
            this.mnAbout.Index = 2;
            this.mnAbout.Text = "About";
            this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(64, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(272, 32);
            this.lblInfo.TabIndex = 1;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "");
            this.imgList.Images.SetKeyName(1, "");
            // 
            // tmrEnd
            // 
            this.tmrEnd.Interval = 1000;
            this.tmrEnd.Tick += new System.EventHandler(this.tmrEnd_Tick);
            // 
            // GmailNotifierInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 50);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1280, 1024);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GmailNotifierInfo";
            this.Opacity = 0.85;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Click += new System.EventHandler(this.GmailNotifierInfo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		
		#region Methods
		private void HideMyInfo()
		{
			bHide = true;
			bFinished = false;
			ShowInfo();			
		}
		public void ShowInfo() // method to show the info in the GmailNotifierControl
		{
			if(!bHide) //the GmailNotifierControl is about to be shown we initialize its location
				this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Size.Width - 50, 
					Screen.PrimaryScreen.Bounds.Bottom);
			lblInfo.Text = strInfo;
			pctLogo.Image = imgList.Images[1];
			this.Show();
			tmrMove.Start();
		}

		#endregion

		#region EventHandlers
		private void tmrEnd_Tick(object sender, System.EventArgs e)
		{
			tmrEnd.Stop();
			HideMyInfo();
		}
		private void mnAbout_Click(object sender, System.EventArgs e)
		{
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Size.Width - 50, Screen.PrimaryScreen.Bounds.Bottom);
			lblInfo.Text = "Done thanks to gmail, by eRRaTuM <m.feriati@gmail.com>";
			pctLogo.Image = imgList.Images[0];
			this.Show();
			tmrMove.Start();
		}
		
		private void tmrMove_Tick(object sender, System.EventArgs e)
		{
			int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;
			if(!bHide) // Show the Info Box
			{
				this.Show();
				if ( this.Top > Screen.PrimaryScreen.Bounds.Bottom - (this.Height + nTaskBarHeight)) //screen limit - TaskBarSize
				{		
					this.TopMost = false;
					this.Top -= nPitch;
					this.Refresh();
					bFinished = false;
				}
				else 
				{
					this.TopMost = true;
					bFinished = true;
					this.Refresh();
					bHide = true;
				}
			}
			else if (!bFinished) // Hide It
			{
				if ( this.Top < Screen.PrimaryScreen.Bounds.Bottom )
				{		
					this.TopMost = false;
					this.Top += nPitch;
					this.Refresh();
					bFinished = false;
				}
				else 
				{
					this.TopMost = true;
					this.Hide();
					bFinished = true;
					bHide = false;
				}
			}
			if (bFinished)
				tmrMove.Stop();
			if (bHide && bFinished)
				tmrEnd.Start();
		}
		
		private void mnTell_Click(object sender, System.EventArgs e)
		{
			ShowInfo();
		}
		#endregion

		public GmailNotifierInfo()
		{
			InitializeComponent();
		}
	
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

        private void GmailNotifierInfo_Click(object sender, EventArgs e)
        {
            this.HideMyInfo();
        }

	}
}
