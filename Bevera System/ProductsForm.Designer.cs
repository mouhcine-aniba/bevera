namespace Bevera_System
{
	partial class ProductsForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
			this._pnl = new System.Windows.Forms.FlowLayoutPanel();
			this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
			this.del_btn = new Bunifu.Framework.UI.BunifuThinButton2();
			this._name_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
			this._pic = new XanderUI.XUICustomPictureBox();
			this.Sear_txt = new MetroFramework.Controls.MetroTextBox();
			this.xuiGradientPanel1.SuspendLayout();
			this.xuiCustomGroupbox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _pnl
			// 
			this._pnl.AutoScroll = true;
			this._pnl.Location = new System.Drawing.Point(33, 115);
			this._pnl.Name = "_pnl";
			this._pnl.Size = new System.Drawing.Size(879, 494);
			this._pnl.TabIndex = 0;
			// 
			// xuiGradientPanel1
			// 
			this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.xuiGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
			this.xuiGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
			this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.xuiGradientPanel1.Location = new System.Drawing.Point(30, 30);
			this.xuiGradientPanel1.Name = "xuiGradientPanel1";
			this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
			this.xuiGradientPanel1.Size = new System.Drawing.Size(1140, 64);
			this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
			this.xuiGradientPanel1.TabIndex = 2;
			this.xuiGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(159, 6);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 50);
			this.bunifuCustomLabel1.TabIndex = 0;
			this.bunifuCustomLabel1.Text = "Menu";
			// 
			// xuiCustomGroupbox1
			// 
			this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
			this.xuiCustomGroupbox1.BorderWidth = 1;
			this.xuiCustomGroupbox1.Controls.Add(this.Sear_txt);
			this.xuiCustomGroupbox1.Controls.Add(this.del_btn);
			this.xuiCustomGroupbox1.Controls.Add(this._name_lbl);
			this.xuiCustomGroupbox1.Controls.Add(this._pic);
			this.xuiCustomGroupbox1.Location = new System.Drawing.Point(918, 115);
			this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
			this.xuiCustomGroupbox1.ShowText = true;
			this.xuiCustomGroupbox1.Size = new System.Drawing.Size(252, 494);
			this.xuiCustomGroupbox1.TabIndex = 0;
			this.xuiCustomGroupbox1.TabStop = false;
			this.xuiCustomGroupbox1.Text = "Search";
			this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
			// 
			// del_btn
			// 
			this.del_btn.ActiveBorderThickness = 1;
			this.del_btn.ActiveCornerRadius = 20;
			this.del_btn.ActiveFillColor = System.Drawing.Color.White;
			this.del_btn.ActiveForecolor = System.Drawing.Color.Red;
			this.del_btn.ActiveLineColor = System.Drawing.Color.Red;
			this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.del_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("del_btn.BackgroundImage")));
			this.del_btn.ButtonText = "Delete";
			this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.del_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.del_btn.ForeColor = System.Drawing.Color.SeaGreen;
			this.del_btn.IdleBorderThickness = 3;
			this.del_btn.IdleCornerRadius = 20;
			this.del_btn.IdleFillColor = System.Drawing.Color.Red;
			this.del_btn.IdleForecolor = System.Drawing.Color.White;
			this.del_btn.IdleLineColor = System.Drawing.Color.Red;
			this.del_btn.Location = new System.Drawing.Point(27, 411);
			this.del_btn.Margin = new System.Windows.Forms.Padding(5);
			this.del_btn.Name = "del_btn";
			this.del_btn.Size = new System.Drawing.Size(191, 61);
			this.del_btn.TabIndex = 13;
			this.del_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.del_btn.Visible = false;
			this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
			// 
			// _name_lbl
			// 
			this._name_lbl.AutoSize = true;
			this._name_lbl.Location = new System.Drawing.Point(48, 290);
			this._name_lbl.Name = "_name_lbl";
			this._name_lbl.Size = new System.Drawing.Size(0, 20);
			this._name_lbl.TabIndex = 2;
			// 
			// _pic
			// 
			this._pic.Color1 = System.Drawing.Color.DodgerBlue;
			this._pic.Color2 = System.Drawing.Color.DodgerBlue;
			this._pic.FilterAlpha = 200;
			this._pic.FilterEnabled = false;
			this._pic.Image = null;
			this._pic.IsElipse = true;
			this._pic.IsParallax = false;
			this._pic.Location = new System.Drawing.Point(49, 123);
			this._pic.Name = "_pic";
			this._pic.Size = new System.Drawing.Size(150, 150);
			this._pic.TabIndex = 1;
			this._pic.Text = "xuiCustomPictureBox1";
			// 
			// Sear_txt
			// 
			// 
			// 
			// 
			this.Sear_txt.CustomButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Sear_txt.CustomButton.ForeColor = System.Drawing.Color.White;
			this.Sear_txt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.Sear_txt.CustomButton.Location = new System.Drawing.Point(188, 2);
			this.Sear_txt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
			this.Sear_txt.CustomButton.Name = "";
			this.Sear_txt.CustomButton.Padding = new System.Windows.Forms.Padding(2);
			this.Sear_txt.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.Sear_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Brown;
			this.Sear_txt.CustomButton.TabIndex = 1;
			this.Sear_txt.CustomButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Sear_txt.CustomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Sear_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.Sear_txt.CustomButton.UseCompatibleTextRendering = true;
			this.Sear_txt.CustomButton.UseSelectable = true;
			this.Sear_txt.Lines = new string[0];
			this.Sear_txt.Location = new System.Drawing.Point(20, 58);
			this.Sear_txt.MaxLength = 32767;
			this.Sear_txt.Name = "Sear_txt";
			this.Sear_txt.PasswordChar = '\0';
			this.Sear_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.Sear_txt.SelectedText = "";
			this.Sear_txt.SelectionLength = 0;
			this.Sear_txt.SelectionStart = 0;
			this.Sear_txt.ShortcutsEnabled = true;
			this.Sear_txt.ShowButton = true;
			this.Sear_txt.ShowClearButton = true;
			this.Sear_txt.Size = new System.Drawing.Size(216, 30);
			this.Sear_txt.TabIndex = 15;
			this.Sear_txt.UseSelectable = true;
			this.Sear_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.Sear_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// ProductsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.xuiCustomGroupbox1);
			this.Controls.Add(this.xuiGradientPanel1);
			this.Controls.Add(this._pnl);
			this.DisplayHeader = false;
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ProductsForm";
			this.Padding = new System.Windows.Forms.Padding(30, 30, 30, 31);
			this.Text = "ProductsForm";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.Load += new System.EventHandler(this.ProductsForm_Load);
			this.xuiGradientPanel1.ResumeLayout(false);
			this.xuiGradientPanel1.PerformLayout();
			this.xuiCustomGroupbox1.ResumeLayout(false);
			this.xuiCustomGroupbox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel _pnl;
		private XanderUI.XUIGradientPanel xuiGradientPanel1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
		private XanderUI.XUICustomPictureBox _pic;
		private Bunifu.Framework.UI.BunifuCustomLabel _name_lbl;
		private Bunifu.Framework.UI.BunifuThinButton2 del_btn;
		private MetroFramework.Controls.MetroTextBox Sear_txt;
	}
}