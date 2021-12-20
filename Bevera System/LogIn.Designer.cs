namespace Bevera_System
{
    partial class LogIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
			this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this._usrnm_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this._passw_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this._signin_btn = new Bunifu.Framework.UI.BunifuImageButton();
			this._log_in_btn = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this._signin_btn)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuSeparator1
			// 
			this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.bunifuSeparator1.LineThickness = 14;
			this.bunifuSeparator1.Location = new System.Drawing.Point(117, 86);
			this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(17, 14, 17, 14);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Size = new System.Drawing.Size(462, 10);
			this.bunifuSeparator1.TabIndex = 3;
			this.bunifuSeparator1.Transparency = 255;
			this.bunifuSeparator1.Vertical = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(47, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 60);
			this.label1.TabIndex = 2;
			this.label1.Text = "Log In";
			// 
			// bunifuCustomLabel10
			// 
			this.bunifuCustomLabel10.AutoSize = true;
			this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bunifuCustomLabel10.Location = new System.Drawing.Point(329, 210);
			this.bunifuCustomLabel10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
			this.bunifuCustomLabel10.Size = new System.Drawing.Size(87, 18);
			this.bunifuCustomLabel10.TabIndex = 5;
			this.bunifuCustomLabel10.Text = "Password : ";
			// 
			// bunifuCustomLabel11
			// 
			this.bunifuCustomLabel11.AutoSize = true;
			this.bunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bunifuCustomLabel11.Location = new System.Drawing.Point(329, 124);
			this.bunifuCustomLabel11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
			this.bunifuCustomLabel11.Size = new System.Drawing.Size(96, 18);
			this.bunifuCustomLabel11.TabIndex = 4;
			this.bunifuCustomLabel11.Text = "UserName : ";
			// 
			// _usrnm_txt
			// 
			this._usrnm_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this._usrnm_txt.BorderColor = System.Drawing.Color.SeaGreen;
			this._usrnm_txt.Location = new System.Drawing.Point(333, 159);
			this._usrnm_txt.Name = "_usrnm_txt";
			this._usrnm_txt.Size = new System.Drawing.Size(235, 31);
			this._usrnm_txt.TabIndex = 10;
			// 
			// _passw_txt
			// 
			this._passw_txt.BorderColor = System.Drawing.Color.SeaGreen;
			this._passw_txt.Location = new System.Drawing.Point(332, 243);
			this._passw_txt.Name = "_passw_txt";
			this._passw_txt.Size = new System.Drawing.Size(235, 31);
			this._passw_txt.TabIndex = 10;
			this._passw_txt.UseSystemPasswordChar = true;
			// 
			// _signin_btn
			// 
			this._signin_btn.BackColor = System.Drawing.Color.Transparent;
			this._signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._signin_btn.Image = ((System.Drawing.Image)(resources.GetObject("_signin_btn.Image")));
			this._signin_btn.ImageActive = null;
			this._signin_btn.Location = new System.Drawing.Point(617, 6);
			this._signin_btn.Name = "_signin_btn";
			this._signin_btn.Size = new System.Drawing.Size(50, 56);
			this._signin_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._signin_btn.TabIndex = 12;
			this._signin_btn.TabStop = false;
			this._signin_btn.Zoom = 10;
			this._signin_btn.Click += new System.EventHandler(this._signin_btn_Click);
			// 
			// _log_in_btn
			// 
			this._log_in_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._log_in_btn.DisplayFocus = true;
			this._log_in_btn.Highlight = true;
			this._log_in_btn.Location = new System.Drawing.Point(455, 280);
			this._log_in_btn.Name = "_log_in_btn";
			this._log_in_btn.Size = new System.Drawing.Size(112, 52);
			this._log_in_btn.Style = MetroFramework.MetroColorStyle.Blue;
			this._log_in_btn.TabIndex = 13;
			this._log_in_btn.Text = "Connecter";
			this._log_in_btn.UseCustomBackColor = true;
			this._log_in_btn.UseCustomForeColor = true;
			this._log_in_btn.UseSelectable = true;
			this._log_in_btn.UseStyleColors = true;
			this._log_in_btn.Click += new System.EventHandler(this._log_in_btn_Click);
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Bevera_System.Properties.Resources.benim_6_01;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this._log_in_btn);
			this.Controls.Add(this._signin_btn);
			this.Controls.Add(this._passw_txt);
			this.Controls.Add(this._usrnm_txt);
			this.Controls.Add(this.bunifuCustomLabel11);
			this.Controls.Add(this.bunifuCustomLabel10);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "LogIn";
			this.Size = new System.Drawing.Size(689, 443);
			this.Load += new System.EventHandler(this.LogIn_Load);
			((System.ComponentModel.ISupportInitialize)(this._signin_btn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
		private WindowsFormsControlLibrary1.BunifuCustomTextbox _usrnm_txt;
		private WindowsFormsControlLibrary1.BunifuCustomTextbox _passw_txt;
		private Bunifu.Framework.UI.BunifuImageButton _signin_btn;
		private MetroFramework.Controls.MetroButton _log_in_btn;
	}
}
