namespace Bevera_System
{
    partial class Home
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this._dg_ = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this._pnl_Left = new XanderUI.XUISlidingPanel();
			this._about_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._reserv_pnl = new System.Windows.Forms.Panel();
			this._mng_reserv_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._new_reserv_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._btn_reserv = new Bunifu.Framework.UI.BunifuFlatButton();
			this._pnl_userinfo = new System.Windows.Forms.Panel();
			this._lbl_fullname = new System.Windows.Forms.Label();
			this._lbl_username = new System.Windows.Forms.Label();
			this._pic_prof = new XanderUI.XUICustomPictureBox();
			this._logs_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._cmd_pnl = new System.Windows.Forms.Panel();
			this._mng_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._nw_cmd_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._new_deliv_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._btn_commander = new Bunifu.Framework.UI.BunifuFlatButton();
			this._btn_settings = new Bunifu.Framework.UI.BunifuFlatButton();
			this._menu_pnl = new System.Windows.Forms.Panel();
			this._prods_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._new_Prod_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._btn_menu = new Bunifu.Framework.UI.BunifuFlatButton();
			this._home_btn = new Bunifu.Framework.UI.BunifuFlatButton();
			this._menu_tr = new System.Windows.Forms.Timer(this.components);
			this._cmd_tr = new System.Windows.Forms.Timer(this.components);
			this._reserv_tr = new System.Windows.Forms.Timer(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.homeControl1 = new Bevera_System.HomeControl();
			this._pnl_Left.SuspendLayout();
			this._reserv_pnl.SuspendLayout();
			this._pnl_userinfo.SuspendLayout();
			this._cmd_pnl.SuspendLayout();
			this._menu_pnl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _dg_
			// 
			this._dg_.Fixed = true;
			this._dg_.Horizontal = true;
			this._dg_.TargetControl = this;
			this._dg_.Vertical = true;
			// 
			// _pnl_Left
			// 
			this._pnl_Left.AutoScroll = true;
			this._pnl_Left.AutoScrollMargin = new System.Drawing.Size(5, 0);
			this._pnl_Left.BottomLeft = System.Drawing.Color.Maroon;
			this._pnl_Left.BottomRight = System.Drawing.Color.Firebrick;
			this._pnl_Left.CollapseControl = null;
			this._pnl_Left.Collapsed = false;
			this._pnl_Left.Controls.Add(this._about_btn);
			this._pnl_Left.Controls.Add(this._reserv_pnl);
			this._pnl_Left.Controls.Add(this._pnl_userinfo);
			this._pnl_Left.Controls.Add(this._logs_btn);
			this._pnl_Left.Controls.Add(this._cmd_pnl);
			this._pnl_Left.Controls.Add(this._btn_settings);
			this._pnl_Left.Controls.Add(this._menu_pnl);
			this._pnl_Left.Controls.Add(this._home_btn);
			this._pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
			this._pnl_Left.HideControls = true;
			this._pnl_Left.Location = new System.Drawing.Point(10, 30);
			this._pnl_Left.Name = "_pnl_Left";
			this._pnl_Left.PanelWidthCollapsed = 1;
			this._pnl_Left.PanelWidthExpanded = 237;
			this._pnl_Left.PrimerColor = System.Drawing.Color.Maroon;
			this._pnl_Left.Size = new System.Drawing.Size(252, 584);
			this._pnl_Left.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
			this._pnl_Left.TabIndex = 5;
			this._pnl_Left.TopLeft = System.Drawing.Color.Maroon;
			this._pnl_Left.TopRight = System.Drawing.Color.Maroon;
			// 
			// _about_btn
			// 
			this._about_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._about_btn.BackColor = System.Drawing.Color.Firebrick;
			this._about_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._about_btn.BorderRadius = 0;
			this._about_btn.ButtonText = "About";
			this._about_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._about_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._about_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._about_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._about_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._about_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("_about_btn.Iconimage")));
			this._about_btn.Iconimage_right = null;
			this._about_btn.Iconimage_right_Selected = null;
			this._about_btn.Iconimage_Selected = null;
			this._about_btn.IconMarginLeft = 0;
			this._about_btn.IconMarginRight = 0;
			this._about_btn.IconRightVisible = true;
			this._about_btn.IconRightZoom = 40D;
			this._about_btn.IconVisible = true;
			this._about_btn.IconZoom = 35D;
			this._about_btn.IsTab = false;
			this._about_btn.Location = new System.Drawing.Point(0, 333);
			this._about_btn.Margin = new System.Windows.Forms.Padding(5);
			this._about_btn.Name = "_about_btn";
			this._about_btn.Normalcolor = System.Drawing.Color.Firebrick;
			this._about_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._about_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._about_btn.selected = false;
			this._about_btn.Size = new System.Drawing.Size(252, 59);
			this._about_btn.TabIndex = 40;
			this._about_btn.Text = "About";
			this._about_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._about_btn.Textcolor = System.Drawing.Color.White;
			this._about_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// _reserv_pnl
			// 
			this._reserv_pnl.BackColor = System.Drawing.Color.Maroon;
			this._reserv_pnl.Controls.Add(this._mng_reserv_btn);
			this._reserv_pnl.Controls.Add(this._new_reserv_btn);
			this._reserv_pnl.Controls.Add(this._btn_reserv);
			this._reserv_pnl.Dock = System.Windows.Forms.DockStyle.Top;
			this._reserv_pnl.Location = new System.Drawing.Point(0, 279);
			this._reserv_pnl.MaximumSize = new System.Drawing.Size(252, 137);
			this._reserv_pnl.MinimumSize = new System.Drawing.Size(252, 52);
			this._reserv_pnl.Name = "_reserv_pnl";
			this._reserv_pnl.Size = new System.Drawing.Size(252, 54);
			this._reserv_pnl.TabIndex = 36;
			// 
			// _mng_reserv_btn
			// 
			this._mng_reserv_btn.Activecolor = System.Drawing.Color.Maroon;
			this._mng_reserv_btn.BackColor = System.Drawing.Color.Maroon;
			this._mng_reserv_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._mng_reserv_btn.BorderRadius = 0;
			this._mng_reserv_btn.ButtonText = "Mangement";
			this._mng_reserv_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._mng_reserv_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._mng_reserv_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._mng_reserv_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._mng_reserv_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._mng_reserv_btn.Iconimage = null;
			this._mng_reserv_btn.Iconimage_right = null;
			this._mng_reserv_btn.Iconimage_right_Selected = null;
			this._mng_reserv_btn.Iconimage_Selected = null;
			this._mng_reserv_btn.IconMarginLeft = 0;
			this._mng_reserv_btn.IconMarginRight = 0;
			this._mng_reserv_btn.IconRightVisible = true;
			this._mng_reserv_btn.IconRightZoom = 40D;
			this._mng_reserv_btn.IconVisible = true;
			this._mng_reserv_btn.IconZoom = 35D;
			this._mng_reserv_btn.IsTab = false;
			this._mng_reserv_btn.Location = new System.Drawing.Point(0, 96);
			this._mng_reserv_btn.Margin = new System.Windows.Forms.Padding(5);
			this._mng_reserv_btn.Name = "_mng_reserv_btn";
			this._mng_reserv_btn.Normalcolor = System.Drawing.Color.Maroon;
			this._mng_reserv_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._mng_reserv_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._mng_reserv_btn.selected = false;
			this._mng_reserv_btn.Size = new System.Drawing.Size(252, 37);
			this._mng_reserv_btn.TabIndex = 33;
			this._mng_reserv_btn.Text = "Mangement";
			this._mng_reserv_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._mng_reserv_btn.Textcolor = System.Drawing.Color.White;
			this._mng_reserv_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._mng_reserv_btn.Click += new System.EventHandler(this._mng_reserv_btn_Click);
			// 
			// _new_reserv_btn
			// 
			this._new_reserv_btn.Activecolor = System.Drawing.Color.Maroon;
			this._new_reserv_btn.BackColor = System.Drawing.Color.Maroon;
			this._new_reserv_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._new_reserv_btn.BorderRadius = 0;
			this._new_reserv_btn.ButtonText = "New Reservation";
			this._new_reserv_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._new_reserv_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._new_reserv_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._new_reserv_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._new_reserv_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._new_reserv_btn.Iconimage = null;
			this._new_reserv_btn.Iconimage_right = null;
			this._new_reserv_btn.Iconimage_right_Selected = null;
			this._new_reserv_btn.Iconimage_Selected = null;
			this._new_reserv_btn.IconMarginLeft = 0;
			this._new_reserv_btn.IconMarginRight = 0;
			this._new_reserv_btn.IconRightVisible = true;
			this._new_reserv_btn.IconRightZoom = 40D;
			this._new_reserv_btn.IconVisible = true;
			this._new_reserv_btn.IconZoom = 35D;
			this._new_reserv_btn.IsTab = false;
			this._new_reserv_btn.Location = new System.Drawing.Point(0, 59);
			this._new_reserv_btn.Margin = new System.Windows.Forms.Padding(5);
			this._new_reserv_btn.Name = "_new_reserv_btn";
			this._new_reserv_btn.Normalcolor = System.Drawing.Color.Maroon;
			this._new_reserv_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._new_reserv_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._new_reserv_btn.selected = false;
			this._new_reserv_btn.Size = new System.Drawing.Size(252, 37);
			this._new_reserv_btn.TabIndex = 32;
			this._new_reserv_btn.Text = "New Reservation";
			this._new_reserv_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._new_reserv_btn.Textcolor = System.Drawing.Color.White;
			this._new_reserv_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._new_reserv_btn.Click += new System.EventHandler(this._new_reserv_btn_Click);
			// 
			// _btn_reserv
			// 
			this._btn_reserv.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._btn_reserv.BackColor = System.Drawing.Color.Firebrick;
			this._btn_reserv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._btn_reserv.BorderRadius = 0;
			this._btn_reserv.ButtonText = "Reservation";
			this._btn_reserv.Cursor = System.Windows.Forms.Cursors.Hand;
			this._btn_reserv.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._btn_reserv.Dock = System.Windows.Forms.DockStyle.Top;
			this._btn_reserv.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btn_reserv.Iconcolor = System.Drawing.Color.Transparent;
			this._btn_reserv.Iconimage = ((System.Drawing.Image)(resources.GetObject("_btn_reserv.Iconimage")));
			this._btn_reserv.Iconimage_right = global::Bevera_System.Properties.Resources.icons8_down_squared_64;
			this._btn_reserv.Iconimage_right_Selected = null;
			this._btn_reserv.Iconimage_Selected = null;
			this._btn_reserv.IconMarginLeft = 0;
			this._btn_reserv.IconMarginRight = 0;
			this._btn_reserv.IconRightVisible = true;
			this._btn_reserv.IconRightZoom = 40D;
			this._btn_reserv.IconVisible = true;
			this._btn_reserv.IconZoom = 35D;
			this._btn_reserv.IsTab = false;
			this._btn_reserv.Location = new System.Drawing.Point(0, 0);
			this._btn_reserv.Margin = new System.Windows.Forms.Padding(5);
			this._btn_reserv.Name = "_btn_reserv";
			this._btn_reserv.Normalcolor = System.Drawing.Color.Firebrick;
			this._btn_reserv.OnHovercolor = System.Drawing.Color.Maroon;
			this._btn_reserv.OnHoverTextColor = System.Drawing.Color.White;
			this._btn_reserv.selected = false;
			this._btn_reserv.Size = new System.Drawing.Size(252, 59);
			this._btn_reserv.TabIndex = 31;
			this._btn_reserv.Text = "Reservation";
			this._btn_reserv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._btn_reserv.Textcolor = System.Drawing.Color.White;
			this._btn_reserv.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btn_reserv.Click += new System.EventHandler(this._btn_reserv_Click);
			// 
			// _pnl_userinfo
			// 
			this._pnl_userinfo.BackColor = System.Drawing.Color.Brown;
			this._pnl_userinfo.Controls.Add(this._lbl_fullname);
			this._pnl_userinfo.Controls.Add(this._lbl_username);
			this._pnl_userinfo.Controls.Add(this._pic_prof);
			this._pnl_userinfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this._pnl_userinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._pnl_userinfo.Location = new System.Drawing.Point(0, 492);
			this._pnl_userinfo.Name = "_pnl_userinfo";
			this._pnl_userinfo.Size = new System.Drawing.Size(252, 92);
			this._pnl_userinfo.TabIndex = 16;
			this._pnl_userinfo.Click += new System.EventHandler(this._pnl_userinfo_Click);
			this._pnl_userinfo.Paint += new System.Windows.Forms.PaintEventHandler(this._pnl_userinfo_Paint);
			this._pnl_userinfo.MouseLeave += new System.EventHandler(this._pnl_userinfo_MouseLeave);
			this._pnl_userinfo.MouseHover += new System.EventHandler(this._pnl_userinfo_MouseHover);
			// 
			// _lbl_fullname
			// 
			this._lbl_fullname.AutoSize = true;
			this._lbl_fullname.Cursor = System.Windows.Forms.Cursors.Hand;
			this._lbl_fullname.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbl_fullname.ForeColor = System.Drawing.Color.White;
			this._lbl_fullname.Location = new System.Drawing.Point(76, 36);
			this._lbl_fullname.Name = "_lbl_fullname";
			this._lbl_fullname.Size = new System.Drawing.Size(95, 43);
			this._lbl_fullname.TabIndex = 1;
			this._lbl_fullname.Text = "full name";
			this._lbl_fullname.MouseLeave += new System.EventHandler(this._pnl_userinfo_MouseLeave);
			this._lbl_fullname.MouseHover += new System.EventHandler(this._pnl_userinfo_MouseHover);
			// 
			// _lbl_username
			// 
			this._lbl_username.AutoSize = true;
			this._lbl_username.Cursor = System.Windows.Forms.Cursors.Hand;
			this._lbl_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbl_username.ForeColor = System.Drawing.Color.White;
			this._lbl_username.Location = new System.Drawing.Point(78, 11);
			this._lbl_username.Name = "_lbl_username";
			this._lbl_username.Size = new System.Drawing.Size(117, 22);
			this._lbl_username.TabIndex = 1;
			this._lbl_username.Text = "@Username";
			this._lbl_username.MouseLeave += new System.EventHandler(this._pnl_userinfo_MouseLeave);
			this._lbl_username.MouseHover += new System.EventHandler(this._pnl_userinfo_MouseHover);
			// 
			// _pic_prof
			// 
			this._pic_prof.BackColor = System.Drawing.Color.Transparent;
			this._pic_prof.Color1 = System.Drawing.Color.White;
			this._pic_prof.Color2 = System.Drawing.Color.White;
			this._pic_prof.Cursor = System.Windows.Forms.Cursors.Hand;
			this._pic_prof.FilterAlpha = 200;
			this._pic_prof.FilterEnabled = false;
			this._pic_prof.Image = global::Bevera_System.Properties.Resources.icons8_administrator_64;
			this._pic_prof.IsElipse = true;
			this._pic_prof.IsParallax = false;
			this._pic_prof.Location = new System.Drawing.Point(7, 11);
			this._pic_prof.Name = "_pic_prof";
			this._pic_prof.Size = new System.Drawing.Size(68, 72);
			this._pic_prof.TabIndex = 0;
			this._pic_prof.MouseLeave += new System.EventHandler(this._pnl_userinfo_MouseLeave);
			this._pic_prof.MouseHover += new System.EventHandler(this._pnl_userinfo_MouseHover);
			// 
			// _logs_btn
			// 
			this._logs_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._logs_btn.BackColor = System.Drawing.Color.Firebrick;
			this._logs_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._logs_btn.BorderRadius = 0;
			this._logs_btn.ButtonText = "Logs";
			this._logs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._logs_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._logs_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._logs_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._logs_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._logs_btn.Iconimage = global::Bevera_System.Properties.Resources.icons8_bulleted_list_64;
			this._logs_btn.Iconimage_right = null;
			this._logs_btn.Iconimage_right_Selected = null;
			this._logs_btn.Iconimage_Selected = null;
			this._logs_btn.IconMarginLeft = 0;
			this._logs_btn.IconMarginRight = 0;
			this._logs_btn.IconRightVisible = true;
			this._logs_btn.IconRightZoom = 40D;
			this._logs_btn.IconVisible = true;
			this._logs_btn.IconZoom = 35D;
			this._logs_btn.IsTab = false;
			this._logs_btn.Location = new System.Drawing.Point(0, 220);
			this._logs_btn.Margin = new System.Windows.Forms.Padding(5);
			this._logs_btn.Name = "_logs_btn";
			this._logs_btn.Normalcolor = System.Drawing.Color.Firebrick;
			this._logs_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._logs_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._logs_btn.selected = false;
			this._logs_btn.Size = new System.Drawing.Size(252, 59);
			this._logs_btn.TabIndex = 38;
			this._logs_btn.Text = "Logs";
			this._logs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._logs_btn.Textcolor = System.Drawing.Color.White;
			this._logs_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._logs_btn.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
			// 
			// _cmd_pnl
			// 
			this._cmd_pnl.BackColor = System.Drawing.Color.Maroon;
			this._cmd_pnl.Controls.Add(this._mng_btn);
			this._cmd_pnl.Controls.Add(this._nw_cmd_btn);
			this._cmd_pnl.Controls.Add(this._new_deliv_btn);
			this._cmd_pnl.Controls.Add(this._btn_commander);
			this._cmd_pnl.Dock = System.Windows.Forms.DockStyle.Top;
			this._cmd_pnl.Location = new System.Drawing.Point(0, 170);
			this._cmd_pnl.MaximumSize = new System.Drawing.Size(252, 170);
			this._cmd_pnl.MinimumSize = new System.Drawing.Size(252, 50);
			this._cmd_pnl.Name = "_cmd_pnl";
			this._cmd_pnl.Size = new System.Drawing.Size(252, 50);
			this._cmd_pnl.TabIndex = 39;
			// 
			// _mng_btn
			// 
			this._mng_btn.Activecolor = System.Drawing.Color.Maroon;
			this._mng_btn.BackColor = System.Drawing.Color.Maroon;
			this._mng_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._mng_btn.BorderRadius = 0;
			this._mng_btn.ButtonText = "Mangement";
			this._mng_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._mng_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._mng_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._mng_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._mng_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._mng_btn.Iconimage = null;
			this._mng_btn.Iconimage_right = null;
			this._mng_btn.Iconimage_right_Selected = null;
			this._mng_btn.Iconimage_Selected = null;
			this._mng_btn.IconMarginLeft = 0;
			this._mng_btn.IconMarginRight = 0;
			this._mng_btn.IconRightVisible = true;
			this._mng_btn.IconRightZoom = 40D;
			this._mng_btn.IconVisible = true;
			this._mng_btn.IconZoom = 35D;
			this._mng_btn.IsTab = false;
			this._mng_btn.Location = new System.Drawing.Point(0, 126);
			this._mng_btn.Margin = new System.Windows.Forms.Padding(5);
			this._mng_btn.Name = "_mng_btn";
			this._mng_btn.Normalcolor = System.Drawing.Color.Maroon;
			this._mng_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._mng_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._mng_btn.selected = false;
			this._mng_btn.Size = new System.Drawing.Size(252, 37);
			this._mng_btn.TabIndex = 30;
			this._mng_btn.Text = "Mangement";
			this._mng_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._mng_btn.Textcolor = System.Drawing.Color.White;
			this._mng_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._mng_btn.Click += new System.EventHandler(this._mng_btn_Click);
			// 
			// _nw_cmd_btn
			// 
			this._nw_cmd_btn.Activecolor = System.Drawing.Color.Maroon;
			this._nw_cmd_btn.BackColor = System.Drawing.Color.Maroon;
			this._nw_cmd_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._nw_cmd_btn.BorderRadius = 0;
			this._nw_cmd_btn.ButtonText = "New Command";
			this._nw_cmd_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._nw_cmd_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._nw_cmd_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._nw_cmd_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nw_cmd_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._nw_cmd_btn.Iconimage = null;
			this._nw_cmd_btn.Iconimage_right = null;
			this._nw_cmd_btn.Iconimage_right_Selected = null;
			this._nw_cmd_btn.Iconimage_Selected = null;
			this._nw_cmd_btn.IconMarginLeft = 0;
			this._nw_cmd_btn.IconMarginRight = 0;
			this._nw_cmd_btn.IconRightVisible = true;
			this._nw_cmd_btn.IconRightZoom = 40D;
			this._nw_cmd_btn.IconVisible = true;
			this._nw_cmd_btn.IconZoom = 35D;
			this._nw_cmd_btn.IsTab = false;
			this._nw_cmd_btn.Location = new System.Drawing.Point(0, 89);
			this._nw_cmd_btn.Margin = new System.Windows.Forms.Padding(5);
			this._nw_cmd_btn.Name = "_nw_cmd_btn";
			this._nw_cmd_btn.Normalcolor = System.Drawing.Color.Maroon;
			this._nw_cmd_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._nw_cmd_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._nw_cmd_btn.selected = false;
			this._nw_cmd_btn.Size = new System.Drawing.Size(252, 37);
			this._nw_cmd_btn.TabIndex = 29;
			this._nw_cmd_btn.Text = "New Command";
			this._nw_cmd_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._nw_cmd_btn.Textcolor = System.Drawing.Color.White;
			this._nw_cmd_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nw_cmd_btn.Click += new System.EventHandler(this._nw_cmd_btn_Click);
			// 
			// _new_deliv_btn
			// 
			this._new_deliv_btn.Activecolor = System.Drawing.Color.Maroon;
			this._new_deliv_btn.BackColor = System.Drawing.Color.Maroon;
			this._new_deliv_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._new_deliv_btn.BorderRadius = 0;
			this._new_deliv_btn.ButtonText = "New Delivery";
			this._new_deliv_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._new_deliv_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._new_deliv_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._new_deliv_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._new_deliv_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._new_deliv_btn.Iconimage = null;
			this._new_deliv_btn.Iconimage_right = null;
			this._new_deliv_btn.Iconimage_right_Selected = null;
			this._new_deliv_btn.Iconimage_Selected = null;
			this._new_deliv_btn.IconMarginLeft = 0;
			this._new_deliv_btn.IconMarginRight = 0;
			this._new_deliv_btn.IconRightVisible = true;
			this._new_deliv_btn.IconRightZoom = 40D;
			this._new_deliv_btn.IconVisible = true;
			this._new_deliv_btn.IconZoom = 35D;
			this._new_deliv_btn.IsTab = false;
			this._new_deliv_btn.Location = new System.Drawing.Point(0, 52);
			this._new_deliv_btn.Margin = new System.Windows.Forms.Padding(5);
			this._new_deliv_btn.Name = "_new_deliv_btn";
			this._new_deliv_btn.Normalcolor = System.Drawing.Color.Maroon;
			this._new_deliv_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._new_deliv_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._new_deliv_btn.selected = false;
			this._new_deliv_btn.Size = new System.Drawing.Size(252, 37);
			this._new_deliv_btn.TabIndex = 27;
			this._new_deliv_btn.Text = "New Delivery";
			this._new_deliv_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._new_deliv_btn.Textcolor = System.Drawing.Color.White;
			this._new_deliv_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._new_deliv_btn.Click += new System.EventHandler(this._new_deliv_btn_Click);
			// 
			// _btn_commander
			// 
			this._btn_commander.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._btn_commander.BackColor = System.Drawing.Color.Firebrick;
			this._btn_commander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._btn_commander.BorderRadius = 0;
			this._btn_commander.ButtonText = "Commander";
			this._btn_commander.Cursor = System.Windows.Forms.Cursors.Hand;
			this._btn_commander.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._btn_commander.Dock = System.Windows.Forms.DockStyle.Top;
			this._btn_commander.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btn_commander.Iconcolor = System.Drawing.Color.Transparent;
			this._btn_commander.Iconimage = ((System.Drawing.Image)(resources.GetObject("_btn_commander.Iconimage")));
			this._btn_commander.Iconimage_right = global::Bevera_System.Properties.Resources.icons8_down_squared_64;
			this._btn_commander.Iconimage_right_Selected = null;
			this._btn_commander.Iconimage_Selected = null;
			this._btn_commander.IconMarginLeft = 0;
			this._btn_commander.IconMarginRight = 0;
			this._btn_commander.IconRightVisible = true;
			this._btn_commander.IconRightZoom = 40D;
			this._btn_commander.IconVisible = true;
			this._btn_commander.IconZoom = 35D;
			this._btn_commander.IsTab = false;
			this._btn_commander.Location = new System.Drawing.Point(0, 0);
			this._btn_commander.Margin = new System.Windows.Forms.Padding(5);
			this._btn_commander.Name = "_btn_commander";
			this._btn_commander.Normalcolor = System.Drawing.Color.Firebrick;
			this._btn_commander.OnHovercolor = System.Drawing.Color.Maroon;
			this._btn_commander.OnHoverTextColor = System.Drawing.Color.White;
			this._btn_commander.selected = false;
			this._btn_commander.Size = new System.Drawing.Size(252, 52);
			this._btn_commander.TabIndex = 25;
			this._btn_commander.Text = "Commander";
			this._btn_commander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._btn_commander.Textcolor = System.Drawing.Color.White;
			this._btn_commander.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btn_commander.Click += new System.EventHandler(this._btn_commander_Click);
			// 
			// _btn_settings
			// 
			this._btn_settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._btn_settings.BackColor = System.Drawing.Color.Firebrick;
			this._btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._btn_settings.BorderRadius = 0;
			this._btn_settings.ButtonText = "Settings";
			this._btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
			this._btn_settings.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
			this._btn_settings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btn_settings.Iconcolor = System.Drawing.Color.Transparent;
			this._btn_settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("_btn_settings.Iconimage")));
			this._btn_settings.Iconimage_right = null;
			this._btn_settings.Iconimage_right_Selected = null;
			this._btn_settings.Iconimage_Selected = null;
			this._btn_settings.IconMarginLeft = 0;
			this._btn_settings.IconMarginRight = 0;
			this._btn_settings.IconRightVisible = true;
			this._btn_settings.IconRightZoom = 40D;
			this._btn_settings.IconVisible = true;
			this._btn_settings.IconZoom = 35D;
			this._btn_settings.IsTab = false;
			this._btn_settings.Location = new System.Drawing.Point(0, 114);
			this._btn_settings.Margin = new System.Windows.Forms.Padding(5);
			this._btn_settings.Name = "_btn_settings";
			this._btn_settings.Normalcolor = System.Drawing.Color.Firebrick;
			this._btn_settings.OnHovercolor = System.Drawing.Color.Maroon;
			this._btn_settings.OnHoverTextColor = System.Drawing.Color.White;
			this._btn_settings.selected = false;
			this._btn_settings.Size = new System.Drawing.Size(252, 56);
			this._btn_settings.TabIndex = 36;
			this._btn_settings.Text = "Settings";
			this._btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._btn_settings.Textcolor = System.Drawing.Color.White;
			this._btn_settings.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// _menu_pnl
			// 
			this._menu_pnl.BackColor = System.Drawing.Color.Maroon;
			this._menu_pnl.Controls.Add(this._prods_btn);
			this._menu_pnl.Controls.Add(this._new_Prod_btn);
			this._menu_pnl.Controls.Add(this._btn_menu);
			this._menu_pnl.Dock = System.Windows.Forms.DockStyle.Top;
			this._menu_pnl.Location = new System.Drawing.Point(0, 59);
			this._menu_pnl.MaximumSize = new System.Drawing.Size(252, 130);
			this._menu_pnl.MinimumSize = new System.Drawing.Size(252, 52);
			this._menu_pnl.Name = "_menu_pnl";
			this._menu_pnl.Size = new System.Drawing.Size(252, 55);
			this._menu_pnl.TabIndex = 37;
			// 
			// _prods_btn
			// 
			this._prods_btn.Activecolor = System.Drawing.Color.Maroon;
			this._prods_btn.BackColor = System.Drawing.Color.Maroon;
			this._prods_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._prods_btn.BorderRadius = 0;
			this._prods_btn.ButtonText = "Products";
			this._prods_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._prods_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._prods_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._prods_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._prods_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._prods_btn.Iconimage = null;
			this._prods_btn.Iconimage_right = null;
			this._prods_btn.Iconimage_right_Selected = null;
			this._prods_btn.Iconimage_Selected = null;
			this._prods_btn.IconMarginLeft = 0;
			this._prods_btn.IconMarginRight = 0;
			this._prods_btn.IconRightVisible = true;
			this._prods_btn.IconRightZoom = 40D;
			this._prods_btn.IconVisible = true;
			this._prods_btn.IconZoom = 35D;
			this._prods_btn.IsTab = false;
			this._prods_btn.Location = new System.Drawing.Point(0, 94);
			this._prods_btn.Margin = new System.Windows.Forms.Padding(5);
			this._prods_btn.Name = "_prods_btn";
			this._prods_btn.Normalcolor = System.Drawing.Color.Maroon;
			this._prods_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._prods_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._prods_btn.selected = false;
			this._prods_btn.Size = new System.Drawing.Size(252, 34);
			this._prods_btn.TabIndex = 44;
			this._prods_btn.Text = "Products";
			this._prods_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._prods_btn.Textcolor = System.Drawing.Color.White;
			this._prods_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._prods_btn.Click += new System.EventHandler(this._prods_btn_Click);
			// 
			// _new_Prod_btn
			// 
			this._new_Prod_btn.Activecolor = System.Drawing.Color.Maroon;
			this._new_Prod_btn.BackColor = System.Drawing.Color.Maroon;
			this._new_Prod_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._new_Prod_btn.BorderRadius = 0;
			this._new_Prod_btn.ButtonText = "New Product";
			this._new_Prod_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._new_Prod_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._new_Prod_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._new_Prod_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._new_Prod_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._new_Prod_btn.Iconimage = null;
			this._new_Prod_btn.Iconimage_right = null;
			this._new_Prod_btn.Iconimage_right_Selected = null;
			this._new_Prod_btn.Iconimage_Selected = null;
			this._new_Prod_btn.IconMarginLeft = 0;
			this._new_Prod_btn.IconMarginRight = 0;
			this._new_Prod_btn.IconRightVisible = true;
			this._new_Prod_btn.IconRightZoom = 40D;
			this._new_Prod_btn.IconVisible = true;
			this._new_Prod_btn.IconZoom = 35D;
			this._new_Prod_btn.IsTab = false;
			this._new_Prod_btn.Location = new System.Drawing.Point(0, 57);
			this._new_Prod_btn.Margin = new System.Windows.Forms.Padding(5);
			this._new_Prod_btn.Name = "_new_Prod_btn";
			this._new_Prod_btn.Normalcolor = System.Drawing.Color.Maroon;
			this._new_Prod_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._new_Prod_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._new_Prod_btn.selected = false;
			this._new_Prod_btn.Size = new System.Drawing.Size(252, 37);
			this._new_Prod_btn.TabIndex = 42;
			this._new_Prod_btn.Text = "New Product";
			this._new_Prod_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._new_Prod_btn.Textcolor = System.Drawing.Color.White;
			this._new_Prod_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._new_Prod_btn.Click += new System.EventHandler(this._new_Prod_btn_Click);
			// 
			// _btn_menu
			// 
			this._btn_menu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._btn_menu.BackColor = System.Drawing.Color.Firebrick;
			this._btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._btn_menu.BorderRadius = 0;
			this._btn_menu.ButtonText = "Menu";
			this._btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
			this._btn_menu.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
			this._btn_menu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btn_menu.Iconcolor = System.Drawing.Color.Transparent;
			this._btn_menu.Iconimage = ((System.Drawing.Image)(resources.GetObject("_btn_menu.Iconimage")));
			this._btn_menu.Iconimage_right = global::Bevera_System.Properties.Resources.icons8_down_squared_64;
			this._btn_menu.Iconimage_right_Selected = null;
			this._btn_menu.Iconimage_Selected = null;
			this._btn_menu.IconMarginLeft = 0;
			this._btn_menu.IconMarginRight = 0;
			this._btn_menu.IconRightVisible = true;
			this._btn_menu.IconRightZoom = 40D;
			this._btn_menu.IconVisible = true;
			this._btn_menu.IconZoom = 35D;
			this._btn_menu.IsTab = false;
			this._btn_menu.Location = new System.Drawing.Point(0, 0);
			this._btn_menu.Margin = new System.Windows.Forms.Padding(5);
			this._btn_menu.Name = "_btn_menu";
			this._btn_menu.Normalcolor = System.Drawing.Color.Firebrick;
			this._btn_menu.OnHovercolor = System.Drawing.Color.Maroon;
			this._btn_menu.OnHoverTextColor = System.Drawing.Color.White;
			this._btn_menu.selected = false;
			this._btn_menu.Size = new System.Drawing.Size(252, 57);
			this._btn_menu.TabIndex = 31;
			this._btn_menu.Text = "Menu";
			this._btn_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._btn_menu.Textcolor = System.Drawing.Color.White;
			this._btn_menu.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btn_menu.Click += new System.EventHandler(this._btn_menu_Click);
			// 
			// _home_btn
			// 
			this._home_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this._home_btn.BackColor = System.Drawing.Color.Firebrick;
			this._home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this._home_btn.BorderRadius = 0;
			this._home_btn.ButtonText = "Home";
			this._home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._home_btn.DisabledColor = System.Drawing.SystemColors.GrayText;
			this._home_btn.Dock = System.Windows.Forms.DockStyle.Top;
			this._home_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._home_btn.Iconcolor = System.Drawing.Color.Transparent;
			this._home_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("_home_btn.Iconimage")));
			this._home_btn.Iconimage_right = null;
			this._home_btn.Iconimage_right_Selected = null;
			this._home_btn.Iconimage_Selected = null;
			this._home_btn.IconMarginLeft = 0;
			this._home_btn.IconMarginRight = 0;
			this._home_btn.IconRightVisible = true;
			this._home_btn.IconRightZoom = 40D;
			this._home_btn.IconVisible = true;
			this._home_btn.IconZoom = 35D;
			this._home_btn.IsTab = false;
			this._home_btn.Location = new System.Drawing.Point(0, 0);
			this._home_btn.Margin = new System.Windows.Forms.Padding(5);
			this._home_btn.Name = "_home_btn";
			this._home_btn.Normalcolor = System.Drawing.Color.Firebrick;
			this._home_btn.OnHovercolor = System.Drawing.Color.Maroon;
			this._home_btn.OnHoverTextColor = System.Drawing.Color.White;
			this._home_btn.selected = false;
			this._home_btn.Size = new System.Drawing.Size(252, 59);
			this._home_btn.TabIndex = 37;
			this._home_btn.Text = "Home";
			this._home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._home_btn.Textcolor = System.Drawing.Color.White;
			this._home_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._home_btn.Click += new System.EventHandler(this._home_btn_Click);
			// 
			// _menu_tr
			// 
			this._menu_tr.Interval = 40;
			this._menu_tr.Tick += new System.EventHandler(this._menu_tr_Tick);
			// 
			// _cmd_tr
			// 
			this._cmd_tr.Interval = 40;
			this._cmd_tr.Tick += new System.EventHandler(this._cmd_tr_Tick);
			// 
			// _reserv_tr
			// 
			this._reserv_tr.Interval = 40;
			this._reserv_tr.Tick += new System.EventHandler(this._reserv_tr_Tick);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this._pnl_Left;
			// 
			// homeControl1
			// 
			this.homeControl1.BackColor = System.Drawing.Color.White;
			this.homeControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.homeControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.homeControl1.Location = new System.Drawing.Point(271, 52);
			this.homeControl1.Margin = new System.Windows.Forms.Padding(4);
			this.homeControl1.Name = "homeControl1";
			this.homeControl1.Size = new System.Drawing.Size(941, 579);
			this.homeControl1.TabIndex = 6;
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(1240, 624);
			this.Controls.Add(this.homeControl1);
			this.Controls.Add(this._pnl_Left);
			this.DisplayHeader = false;
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "Home";
			this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Teal;
			this.Text = "Home";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
			this.Load += new System.EventHandler(this.Home_Load);
			this._pnl_Left.ResumeLayout(false);
			this._reserv_pnl.ResumeLayout(false);
			this._pnl_userinfo.ResumeLayout(false);
			this._pnl_userinfo.PerformLayout();
			this._cmd_pnl.ResumeLayout(false);
			this._menu_pnl.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl _dg_;
        private XanderUI.XUISlidingPanel _pnl_Left;
        private System.Windows.Forms.Panel _pnl_userinfo;
        private System.Windows.Forms.Label _lbl_fullname;
        private System.Windows.Forms.Label _lbl_username;
        private XanderUI.XUICustomPictureBox _pic_prof;
        private System.Windows.Forms.Panel _reserv_pnl;
        private Bunifu.Framework.UI.BunifuFlatButton _mng_reserv_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _new_reserv_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _btn_reserv;
        private System.Windows.Forms.Panel _cmd_pnl;
        private Bunifu.Framework.UI.BunifuFlatButton _mng_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _nw_cmd_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _new_deliv_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _btn_commander;
        private System.Windows.Forms.Panel _menu_pnl;
        private Bunifu.Framework.UI.BunifuFlatButton _prods_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _new_Prod_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _btn_menu;
        private Bunifu.Framework.UI.BunifuFlatButton _btn_settings;
        private Bunifu.Framework.UI.BunifuFlatButton _logs_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _home_btn;
        private Bunifu.Framework.UI.BunifuFlatButton _about_btn;
		private System.Windows.Forms.Timer _menu_tr;
		private System.Windows.Forms.Timer _cmd_tr;
		private System.Windows.Forms.Timer _reserv_tr;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private HomeControl homeControl1;
	}
}