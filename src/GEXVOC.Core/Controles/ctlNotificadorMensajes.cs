using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GEXVOC.Core.Controles
{
	/// <summary>
	/// An Google Like Info Showing control
	/// </summary>
	public class ctlNotificadorMensajes : System.Windows.Forms.Form
	{
	
		#region DesignTimeMembers
		private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Timer tmrMove;
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
        private Panel panel1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlNotificadorMensajes));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.ntfyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tmrEnd = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(10, 8);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(48, 48);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.OcultarClick_Click);
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 1000;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // ntfyIcon
            // 
            this.ntfyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyIcon.Icon")));
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Click += new System.EventHandler(this.OcultarClick_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "kwrite.png");
            this.imgList.Images.SetKeyName(1, "kwalletmanager.png");
            // 
            // tmrEnd
            // 
            this.tmrEnd.Interval = 1000;
            this.tmrEnd.Tick += new System.EventHandler(this.tmrEnd_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(64, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 48);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.OcultarClick_Click);
            // 
            // ctlNotificadorMensajes
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 60);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(1280, 1024);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ctlNotificadorMensajes";
            this.Opacity = 0.85;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Click += new System.EventHandler(this.OcultarClick_Click);
          //  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ctlNotificadorMensajes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		#region Methods
		private void HideMyInfo()
		{
			bHide = true;
			bFinished = false;
            ShowInfo(_icono);			
		}

		public void ShowInfo() // method to show the info in the GmailNotifierControl
		{
            ShowInfo(_icono);
		}
        int _icono=-1;
        public void ShowInfo(int icono) // method to show the info in the GmailNotifierControl
        {
            _icono = icono;
            if (!bHide) //the GmailNotifierControl is about to be shown we initialize its location
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Size.Width - 20,
                    Screen.PrimaryScreen.Bounds.Bottom);
            lblInfo.Text = strInfo;
            if (_icono!=-1)            
                pctLogo.Image = imgList.Images[_icono];



            this.Visible = true;
            this.Invalidate();
            tmrMove.Start();
        }

		#endregion

		#region EventHandlers
		private void tmrEnd_Tick(object sender, System.EventArgs e)
		{
			tmrEnd.Stop();
			HideMyInfo();
		}
	
		private void tmrMove_Tick(object sender, System.EventArgs e)
		{
			int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;
			if(!bHide) // Show the Info Box
			{
				this.Show();
				if ( this.Top > Screen.PrimaryScreen.Bounds.Bottom-30 - (this.Height + nTaskBarHeight)) //screen limit - TaskBarSize
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
                    this.Close();
				}
			}
			if (bFinished)
				tmrMove.Stop();
			if (bHide && bFinished)
				tmrEnd.Start();
		}
		
		private void mnTell_Click(object sender, System.EventArgs e)
		{
            ShowInfo(_icono);
		}
		#endregion

		public ctlNotificadorMensajes()
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

        bool _OcultarAlClick = true;

        public bool OcultarAlClick
        {
            get { return _OcultarAlClick; }
            set { _OcultarAlClick = value; }
        }


        private void OcultarClick_Click(object sender, EventArgs e)
        {
            if (OcultarAlClick) this.HideMyInfo();
        }

     

  

	}
}
