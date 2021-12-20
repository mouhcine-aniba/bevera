namespace Bevera_System
{
    partial class SignIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this._passw_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this._tel_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this._usrname_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this._lname_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this._fname_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this._pic_ = new XanderUI.XUICustomPictureBox();
			this._cancel_btn = new Bunifu.Framework.UI.BunifuThinButton2();
			this._sign_in_btn = new Bunifu.Framework.UI.BunifuThinButton2();
			this._upload_btn = new Bunifu.Framework.UI.BunifuTileButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Chocolate;
			this.label1.Location = new System.Drawing.Point(108, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sign In";
			// 
			// bunifuSeparator1
			// 
			this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
			this.bunifuSeparator1.LineThickness = 6;
			this.bunifuSeparator1.Location = new System.Drawing.Point(87, 58);
			this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Size = new System.Drawing.Size(550, 10);
			this.bunifuSeparator1.TabIndex = 1;
			this.bunifuSeparator1.Transparency = 255;
			this.bunifuSeparator1.Vertical = false;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 93);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 21);
			this.bunifuCustomLabel1.TabIndex = 2;
			this.bunifuCustomLabel1.Text = "First Name : ";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(373, 93);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(105, 21);
			this.bunifuCustomLabel2.TabIndex = 2;
			this.bunifuCustomLabel2.Text = "Last Name : ";
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(35, 155);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(102, 21);
			this.bunifuCustomLabel4.TabIndex = 2;
			this.bunifuCustomLabel4.Text = "UserName : ";
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(41, 281);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(67, 21);
			this.bunifuCustomLabel5.TabIndex = 2;
			this.bunifuCustomLabel5.Text = "Phone :";
			// 
			// bunifuCustomLabel6
			// 
			this.bunifuCustomLabel6.AutoSize = true;
			this.bunifuCustomLabel6.BackColor = System.Drawing.Color.White;
			this.bunifuCustomLabel6.Location = new System.Drawing.Point(41, 219);
			this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
			this.bunifuCustomLabel6.Size = new System.Drawing.Size(94, 21);
			this.bunifuCustomLabel6.TabIndex = 2;
			this.bunifuCustomLabel6.Text = "Password : ";
			// 
			// _passw_txt
			// 
			this._passw_txt.BorderColorFocused = System.Drawing.Color.RoyalBlue;
			this._passw_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._passw_txt.BorderColorMouseHover = System.Drawing.Color.Gold;
			this._passw_txt.BorderThickness = 1;
			this._passw_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._passw_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this._passw_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._passw_txt.isPassword = true;
			this._passw_txt.Location = new System.Drawing.Point(134, 218);
			this._passw_txt.Margin = new System.Windows.Forms.Padding(4);
			this._passw_txt.Name = "_passw_txt";
			this._passw_txt.Size = new System.Drawing.Size(181, 27);
			this._passw_txt.TabIndex = 4;
			this._passw_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// _tel_txt
			// 
			this._tel_txt.BorderColorFocused = System.Drawing.Color.RoyalBlue;
			this._tel_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._tel_txt.BorderColorMouseHover = System.Drawing.Color.Gold;
			this._tel_txt.BorderThickness = 1;
			this._tel_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._tel_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this._tel_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._tel_txt.isPassword = false;
			this._tel_txt.Location = new System.Drawing.Point(134, 277);
			this._tel_txt.Margin = new System.Windows.Forms.Padding(4);
			this._tel_txt.Name = "_tel_txt";
			this._tel_txt.Size = new System.Drawing.Size(181, 27);
			this._tel_txt.TabIndex = 6;
			this._tel_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// _usrname_txt
			// 
			this._usrname_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._usrname_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this._usrname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._usrname_txt.HintForeColor = System.Drawing.Color.Gray;
			this._usrname_txt.HintText = "@Username ...";
			this._usrname_txt.isPassword = false;
			this._usrname_txt.LineFocusedColor = System.Drawing.Color.RoyalBlue;
			this._usrname_txt.LineIdleColor = System.Drawing.Color.Gray;
			this._usrname_txt.LineMouseHoverColor = System.Drawing.Color.Gold;
			this._usrname_txt.LineThickness = 1;
			this._usrname_txt.Location = new System.Drawing.Point(142, 143);
			this._usrname_txt.Margin = new System.Windows.Forms.Padding(4);
			this._usrname_txt.Name = "_usrname_txt";
			this._usrname_txt.Size = new System.Drawing.Size(458, 33);
			this._usrname_txt.TabIndex = 3;
			this._usrname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// _lname_txt
			// 
			this._lname_txt.BorderColorFocused = System.Drawing.Color.RoyalBlue;
			this._lname_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._lname_txt.BorderColorMouseHover = System.Drawing.Color.Gold;
			this._lname_txt.BorderThickness = 1;
			this._lname_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._lname_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this._lname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._lname_txt.isPassword = false;
			this._lname_txt.Location = new System.Drawing.Point(485, 90);
			this._lname_txt.Margin = new System.Windows.Forms.Padding(4);
			this._lname_txt.Name = "_lname_txt";
			this._lname_txt.Size = new System.Drawing.Size(178, 27);
			this._lname_txt.TabIndex = 6;
			this._lname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// _fname_txt
			// 
			this._fname_txt.BorderColorFocused = System.Drawing.Color.RoyalBlue;
			this._fname_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._fname_txt.BorderColorMouseHover = System.Drawing.Color.Gold;
			this._fname_txt.BorderThickness = 1;
			this._fname_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._fname_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this._fname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._fname_txt.isPassword = false;
			this._fname_txt.Location = new System.Drawing.Point(136, 92);
			this._fname_txt.Margin = new System.Windows.Forms.Padding(4);
			this._fname_txt.Name = "_fname_txt";
			this._fname_txt.Size = new System.Drawing.Size(178, 27);
			this._fname_txt.TabIndex = 6;
			this._fname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// _pic_
			// 
			this._pic_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this._pic_.Color1 = System.Drawing.Color.DodgerBlue;
			this._pic_.Color2 = System.Drawing.Color.DodgerBlue;
			this._pic_.Cursor = System.Windows.Forms.Cursors.Hand;
			this._pic_.FilterAlpha = 200;
			this._pic_.FilterEnabled = false;
			this._pic_.Image = global::Bevera_System.Properties.Resources.icons8_administrator_64;
			this._pic_.IsElipse = false;
			this._pic_.IsParallax = false;
			this._pic_.Location = new System.Drawing.Point(412, 206);
			this._pic_.Name = "_pic_";
			this._pic_.Size = new System.Drawing.Size(167, 147);
			this._pic_.TabIndex = 8;
			this._pic_.Click += new System.EventHandler(this._upload_btn_Click);
			// 
			// _cancel_btn
			// 
			this._cancel_btn.ActiveBorderThickness = 1;
			this._cancel_btn.ActiveCornerRadius = 20;
			this._cancel_btn.ActiveFillColor = System.Drawing.Color.Red;
			this._cancel_btn.ActiveForecolor = System.Drawing.Color.White;
			this._cancel_btn.ActiveLineColor = System.Drawing.Color.Gold;
			this._cancel_btn.BackColor = System.Drawing.Color.White;
			this._cancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_cancel_btn.BackgroundImage")));
			this._cancel_btn.ButtonText = "Cancel";
			this._cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._cancel_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._cancel_btn.ForeColor = System.Drawing.Color.Red;
			this._cancel_btn.IdleBorderThickness = 1;
			this._cancel_btn.IdleCornerRadius = 10;
			this._cancel_btn.IdleFillColor = System.Drawing.Color.White;
			this._cancel_btn.IdleForecolor = System.Drawing.Color.Chocolate;
			this._cancel_btn.IdleLineColor = System.Drawing.Color.Chocolate;
			this._cancel_btn.Location = new System.Drawing.Point(525, 10);
			this._cancel_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this._cancel_btn.Name = "_cancel_btn";
			this._cancel_btn.Size = new System.Drawing.Size(112, 38);
			this._cancel_btn.TabIndex = 7;
			this._cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._cancel_btn.Click += new System.EventHandler(this._cancel_btn_Click);
			// 
			// _sign_in_btn
			// 
			this._sign_in_btn.ActiveBorderThickness = 1;
			this._sign_in_btn.ActiveCornerRadius = 20;
			this._sign_in_btn.ActiveFillColor = System.Drawing.Color.RoyalBlue;
			this._sign_in_btn.ActiveForecolor = System.Drawing.Color.Gold;
			this._sign_in_btn.ActiveLineColor = System.Drawing.Color.Gold;
			this._sign_in_btn.BackColor = System.Drawing.Color.White;
			this._sign_in_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_sign_in_btn.BackgroundImage")));
			this._sign_in_btn.ButtonText = "Sign In";
			this._sign_in_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._sign_in_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._sign_in_btn.ForeColor = System.Drawing.Color.RoyalBlue;
			this._sign_in_btn.IdleBorderThickness = 1;
			this._sign_in_btn.IdleCornerRadius = 1;
			this._sign_in_btn.IdleFillColor = System.Drawing.Color.White;
			this._sign_in_btn.IdleForecolor = System.Drawing.Color.Chocolate;
			this._sign_in_btn.IdleLineColor = System.Drawing.Color.Chocolate;
			this._sign_in_btn.Location = new System.Drawing.Point(433, 391);
			this._sign_in_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this._sign_in_btn.Name = "_sign_in_btn";
			this._sign_in_btn.Size = new System.Drawing.Size(224, 58);
			this._sign_in_btn.TabIndex = 7;
			this._sign_in_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._sign_in_btn.Click += new System.EventHandler(this._sign_in_btn_Click);
			// 
			// _upload_btn
			// 
			this._upload_btn.BackColor = System.Drawing.Color.Transparent;
			this._upload_btn.color = System.Drawing.Color.Transparent;
			this._upload_btn.colorActive = System.Drawing.Color.DarkGray;
			this._upload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._upload_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this._upload_btn.ForeColor = System.Drawing.Color.White;
			this._upload_btn.Image = global::Bevera_System.Properties.Resources.icons8_upload_Maroon_64;
			this._upload_btn.ImagePosition = 10;
			this._upload_btn.ImageZoom = 50;
			this._upload_btn.LabelPosition = 0;
			this._upload_btn.LabelText = "";
			this._upload_btn.Location = new System.Drawing.Point(603, 281);
			this._upload_btn.Margin = new System.Windows.Forms.Padding(6);
			this._upload_btn.Name = "_upload_btn";
			this._upload_btn.Size = new System.Drawing.Size(54, 46);
			this._upload_btn.TabIndex = 9;
			this._upload_btn.Click += new System.EventHandler(this._upload_btn_Click);
			// 
			// SignIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this._upload_btn);
			this.Controls.Add(this._pic_);
			this.Controls.Add(this._cancel_btn);
			this.Controls.Add(this._sign_in_btn);
			this.Controls.Add(this._fname_txt);
			this.Controls.Add(this._lname_txt);
			this.Controls.Add(this._tel_txt);
			this.Controls.Add(this._passw_txt);
			this.Controls.Add(this._usrname_txt);
			this.Controls.Add(this.bunifuCustomLabel4);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.bunifuCustomLabel6);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "SignIn";
			this.Size = new System.Drawing.Size(721, 467);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox _passw_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox _tel_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox _usrname_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox _lname_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox _fname_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 _sign_in_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 _cancel_btn;
		private XanderUI.XUICustomPictureBox _pic_;
		private Bunifu.Framework.UI.BunifuTileButton _upload_btn;
	}
}
