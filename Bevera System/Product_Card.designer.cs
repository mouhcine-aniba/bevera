namespace Bevera_System
{
	partial class Product_Card
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Card));
			this.panel1 = new System.Windows.Forms.Panel();
			this._price = new MetroFramework.Controls.MetroLabel();
			this._prod_name = new Bunifu.Framework.UI.BunifuCustomLabel();
			this._desc = new Bunifu.Framework.UI.BunifuCustomLabel();
			this._id = new MetroFramework.Controls.MetroLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this._pic = new XanderUI.XUICustomPictureBox();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 222);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(196, 4);
			this.panel1.TabIndex = 0;
			// 
			// _price
			// 
			this._price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._price.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this._price.ForeColor = System.Drawing.Color.Firebrick;
			this._price.Location = new System.Drawing.Point(103, 177);
			this._price.Name = "_price";
			this._price.Size = new System.Drawing.Size(83, 32);
			this._price.Style = MetroFramework.MetroColorStyle.Blue;
			this._price.TabIndex = 1;
			this._price.Text = "Price";
			this._price.UseCustomForeColor = true;
			this._price.UseStyleColors = true;
			this._price.WrapToLine = true;
			// 
			// _prod_name
			// 
			this._prod_name.AutoSize = true;
			this._prod_name.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._prod_name.Location = new System.Drawing.Point(34, 84);
			this._prod_name.Name = "_prod_name";
			this._prod_name.Size = new System.Drawing.Size(123, 26);
			this._prod_name.TabIndex = 3;
			this._prod_name.Text = "Product Name";
			// 
			// _desc
			// 
			this._desc.AutoSize = true;
			this._desc.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._desc.Location = new System.Drawing.Point(20, 115);
			this._desc.Name = "_desc";
			this._desc.Size = new System.Drawing.Size(80, 16);
			this._desc.TabIndex = 4;
			this._desc.Text = "Description ...";
			// 
			// _id
			// 
			this._id.BackColor = System.Drawing.Color.Firebrick;
			this._id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._id.FontSize = MetroFramework.MetroLabelSize.Tall;
			this._id.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this._id.ForeColor = System.Drawing.Color.White;
			this._id.Location = new System.Drawing.Point(10, 177);
			this._id.Name = "_id";
			this._id.Size = new System.Drawing.Size(87, 32);
			this._id.Style = MetroFramework.MetroColorStyle.Blue;
			this._id.TabIndex = 1;
			this._id.Text = "ID";
			this._id.UseCustomBackColor = true;
			this._id.UseCustomForeColor = true;
			this._id.UseStyleColors = true;
			this._id.WrapToLine = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkCyan;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(192, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(4, 222);
			this.panel2.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkCyan;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(4, 222);
			this.panel3.TabIndex = 6;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkCyan;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(4, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(188, 4);
			this.panel4.TabIndex = 1;
			// 
			// _pic
			// 
			this._pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this._pic.Color1 = System.Drawing.Color.DodgerBlue;
			this._pic.Color2 = System.Drawing.Color.DodgerBlue;
			this._pic.FilterAlpha = 200;
			this._pic.FilterEnabled = false;
			this._pic.Image = ((System.Drawing.Image)(resources.GetObject("_pic.Image")));
			this._pic.IsElipse = false;
			this._pic.IsParallax = false;
			this._pic.Location = new System.Drawing.Point(60, 12);
			this._pic.Name = "_pic";
			this._pic.Size = new System.Drawing.Size(75, 69);
			this._pic.TabIndex = 2;
			this._pic.Text = "xuiCustomPictureBox1";
			// 
			// Product_Card
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this._desc);
			this.Controls.Add(this._prod_name);
			this.Controls.Add(this._pic);
			this.Controls.Add(this._id);
			this.Controls.Add(this._price);
			this.Controls.Add(this.panel1);
			this.Name = "Product_Card";
			this.Size = new System.Drawing.Size(196, 226);
			this.Load += new System.EventHandler(this.Product_Card_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroLabel _price;
		private XanderUI.XUICustomPictureBox _pic;
		private Bunifu.Framework.UI.BunifuCustomLabel _prod_name;
		private Bunifu.Framework.UI.BunifuCustomLabel _desc;
		private MetroFramework.Controls.MetroLabel _id;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
	}
}
