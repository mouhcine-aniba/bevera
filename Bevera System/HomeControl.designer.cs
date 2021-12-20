namespace Bevera_System
{
	partial class HomeControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			this.xuiClock1 = new XanderUI.XUIClock();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
			this.panel1.SuspendLayout();
			this.bunifuCards1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Controls.Add(this.xuiCustomPictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(874, 520);
			this.panel1.TabIndex = 6;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// bunifuCards1
			// 
			this.bunifuCards1.BackColor = System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 20;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = System.Drawing.Color.Maroon;
			this.bunifuCards1.Controls.Add(this.xuiClock1);
			this.bunifuCards1.Controls.Add(this.monthCalendar1);
			this.bunifuCards1.LeftSahddow = true;
			this.bunifuCards1.Location = new System.Drawing.Point(189, 13);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 50;
			this.bunifuCards1.Size = new System.Drawing.Size(557, 186);
			this.bunifuCards1.TabIndex = 7;
			// 
			// xuiClock1
			// 
			this.xuiClock1.CircleThickness = 6;
			this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwentyFourHour;
			this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
			this.xuiClock1.FilledMinuteColor = System.Drawing.Color.White;
			this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
			this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
			this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
			this.xuiClock1.Location = new System.Drawing.Point(362, 17);
			this.xuiClock1.Name = "xuiClock1";
			this.xuiClock1.ShowAmPm = false;
			this.xuiClock1.ShowHexagon = true;
			this.xuiClock1.ShowMinutesCircle = true;
			this.xuiClock1.ShowSecondsCircle = true;
			this.xuiClock1.Size = new System.Drawing.Size(163, 162);
			this.xuiClock1.TabIndex = 4;
			this.xuiClock1.Text = "xuiClock1";
			this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
			this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.White;
			this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(17, 17);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.ShowTodayCircle = false;
			this.monthCalendar1.ShowWeekNumbers = true;
			this.monthCalendar1.TabIndex = 6;
			this.monthCalendar1.TitleBackColor = System.Drawing.Color.Maroon;
			// 
			// xuiCustomPictureBox1
			// 
			this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.DodgerBlue;
			this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.DodgerBlue;
			this.xuiCustomPictureBox1.FilterAlpha = 200;
			this.xuiCustomPictureBox1.FilterEnabled = false;
			this.xuiCustomPictureBox1.Image = global::Bevera_System.Properties.Resources.bevera_logo1;
			this.xuiCustomPictureBox1.IsElipse = false;
			this.xuiCustomPictureBox1.IsParallax = false;
			this.xuiCustomPictureBox1.Location = new System.Drawing.Point(230, 232);
			this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
			this.xuiCustomPictureBox1.Size = new System.Drawing.Size(289, 253);
			this.xuiCustomPictureBox1.TabIndex = 5;
			this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
			// 
			// HomeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "HomeControl";
			this.Size = new System.Drawing.Size(874, 520);
			this.Load += new System.EventHandler(this.HomeControl_Load);
			this.panel1.ResumeLayout(false);
			this.bunifuCards1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private XanderUI.XUIClock xuiClock1;
		private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private Bunifu.Framework.UI.BunifuCards bunifuCards1;
	}
}
