namespace Bevera_System
{
    partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this._head_pnl = new Bunifu.Framework.UI.BunifuGradientPanel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this._mini_btn = new Bunifu.Framework.UI.BunifuImageButton();
			this._close_btn = new Bunifu.Framework.UI.BunifuImageButton();
			this.logIn1 = new Bevera_System.LogIn();
			this._head_pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._mini_btn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._close_btn)).BeginInit();
			this.SuspendLayout();
			// 
			// _head_pnl
			// 
			this._head_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_head_pnl.BackgroundImage")));
			this._head_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._head_pnl.Controls.Add(this.bunifuCustomLabel2);
			this._head_pnl.Controls.Add(this.bunifuCustomLabel1);
			this._head_pnl.Controls.Add(this._mini_btn);
			this._head_pnl.Controls.Add(this._close_btn);
			this._head_pnl.Dock = System.Windows.Forms.DockStyle.Top;
			this._head_pnl.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._head_pnl.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
			this._head_pnl.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._head_pnl.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
			this._head_pnl.Location = new System.Drawing.Point(0, 0);
			this._head_pnl.Name = "_head_pnl";
			this._head_pnl.Quality = 10;
			this._head_pnl.Size = new System.Drawing.Size(710, 53);
			this._head_pnl.TabIndex = 0;
			this._head_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this._head_pnl_Paint);
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(336, 3);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 38);
			this.bunifuCustomLabel2.TabIndex = 1;
			this.bunifuCustomLabel2.Text = "coffee";
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Peru;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(243, 6);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Benim";
			// 
			// _mini_btn
			// 
			this._mini_btn.BackColor = System.Drawing.Color.Transparent;
			this._mini_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._mini_btn.Image = ((System.Drawing.Image)(resources.GetObject("_mini_btn.Image")));
			this._mini_btn.ImageActive = null;
			this._mini_btn.Location = new System.Drawing.Point(588, 9);
			this._mini_btn.Name = "_mini_btn";
			this._mini_btn.Size = new System.Drawing.Size(41, 36);
			this._mini_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._mini_btn.TabIndex = 0;
			this._mini_btn.TabStop = false;
			this._mini_btn.Zoom = 10;
			this._mini_btn.Click += new System.EventHandler(this._mini_btn_Click);
			// 
			// _close_btn
			// 
			this._close_btn.BackColor = System.Drawing.Color.Transparent;
			this._close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._close_btn.Image = ((System.Drawing.Image)(resources.GetObject("_close_btn.Image")));
			this._close_btn.ImageActive = null;
			this._close_btn.Location = new System.Drawing.Point(633, 9);
			this._close_btn.Name = "_close_btn";
			this._close_btn.Size = new System.Drawing.Size(41, 36);
			this._close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this._close_btn.TabIndex = 0;
			this._close_btn.TabStop = false;
			this._close_btn.Zoom = 10;
			this._close_btn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			this._close_btn.MouseEnter += new System.EventHandler(this.bunifuImageButton1_MouseEnter);
			this._close_btn.MouseLeave += new System.EventHandler(this.bunifuImageButton1_MouseLeave);
			// 
			// logIn1
			// 
			this.logIn1.BackColor = System.Drawing.Color.White;
			this.logIn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logIn1.BackgroundImage")));
			this.logIn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logIn1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logIn1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logIn1.Location = new System.Drawing.Point(0, 53);
			this.logIn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.logIn1.Name = "logIn1";
			this.logIn1.Size = new System.Drawing.Size(710, 480);
			this.logIn1.TabIndex = 1;
			this.logIn1.Load += new System.EventHandler(this.logIn1_Load_1);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(710, 533);
			this.Controls.Add(this.logIn1);
			this.Controls.Add(this._head_pnl);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "LoginForm";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.Home_Load);
			this._head_pnl.ResumeLayout(false);
			this._head_pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._mini_btn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._close_btn)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel _head_pnl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton _mini_btn;
        private Bunifu.Framework.UI.BunifuImageButton _close_btn;
		private LogIn logIn1;
	}
}

