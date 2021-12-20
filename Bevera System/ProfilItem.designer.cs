namespace Bevera_System
{
	partial class ProfilItem
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
			this._pic_ = new System.Windows.Forms.PictureBox();
			this._fullname_ = new System.Windows.Forms.Label();
			this._username_ = new System.Windows.Forms.Label();
			this._telephone_ = new System.Windows.Forms.Label();
			this._countcmd_ = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this._pic_)).BeginInit();
			this.SuspendLayout();
			// 
			// _pic_
			// 
			this._pic_.BackColor = System.Drawing.Color.White;
			this._pic_.Image = global::Bevera_System.Properties.Resources.icons8_administrator_64;
			this._pic_.Location = new System.Drawing.Point(10, 8);
			this._pic_.Name = "_pic_";
			this._pic_.Size = new System.Drawing.Size(79, 67);
			this._pic_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this._pic_.TabIndex = 0;
			this._pic_.TabStop = false;
			// 
			// _fullname_
			// 
			this._fullname_.AutoSize = true;
			this._fullname_.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._fullname_.ForeColor = System.Drawing.Color.White;
			this._fullname_.Location = new System.Drawing.Point(120, 8);
			this._fullname_.Name = "_fullname_";
			this._fullname_.Size = new System.Drawing.Size(111, 24);
			this._fullname_.TabIndex = 1;
			this._fullname_.Text = "Full name";
			// 
			// _username_
			// 
			this._username_.AutoSize = true;
			this._username_.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._username_.ForeColor = System.Drawing.Color.White;
			this._username_.Location = new System.Drawing.Point(109, 48);
			this._username_.Name = "_username_";
			this._username_.Size = new System.Drawing.Size(82, 16);
			this._username_.TabIndex = 1;
			this._username_.Text = "@username";
			// 
			// _telephone_
			// 
			this._telephone_.AutoSize = true;
			this._telephone_.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._telephone_.ForeColor = System.Drawing.Color.White;
			this._telephone_.Location = new System.Drawing.Point(242, 48);
			this._telephone_.Name = "_telephone_";
			this._telephone_.Size = new System.Drawing.Size(75, 16);
			this._telephone_.TabIndex = 1;
			this._telephone_.Text = "Telephone";
			// 
			// _countcmd_
			// 
			this._countcmd_.AutoSize = true;
			this._countcmd_.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._countcmd_.ForeColor = System.Drawing.Color.White;
			this._countcmd_.Location = new System.Drawing.Point(292, 15);
			this._countcmd_.Name = "_countcmd_";
			this._countcmd_.Size = new System.Drawing.Size(89, 16);
			this._countcmd_.TabIndex = 1;
			this._countcmd_.Text = "| count cmd";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gold;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 79);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 2);
			this.panel1.TabIndex = 2;
			// 
			// ProfilItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Teal;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this._countcmd_);
			this.Controls.Add(this._telephone_);
			this.Controls.Add(this._username_);
			this.Controls.Add(this._fullname_);
			this.Controls.Add(this._pic_);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(400, 81);
			this.Name = "ProfilItem";
			this.Size = new System.Drawing.Size(400, 81);
			this.Load += new System.EventHandler(this.ProfilItem_Load);
			((System.ComponentModel.ISupportInitialize)(this._pic_)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox _pic_;
		private System.Windows.Forms.Label _fullname_;
		private System.Windows.Forms.Label _username_;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label _countcmd_;
		private System.Windows.Forms.Label _telephone_;
	}
}
