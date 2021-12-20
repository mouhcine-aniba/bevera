namespace Bevera_System
{
    partial class ManagementReservation
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementReservation));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this._Tab_Main = new MetroFramework.Controls.MetroTabControl();
			this._Delivery_Tab = new MetroFramework.Controls.MetroTabPage();
			this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
			this._p_search = new Bunifu.Framework.UI.BunifuThinButton2();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._p_max = new MetroFramework.Controls.MetroDateTime();
			this._p_min = new MetroFramework.Controls.MetroDateTime();
			this._passed_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this._cmd_Tab = new MetroFramework.Controls.MetroTabPage();
			this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
			this._n_search = new Bunifu.Framework.UI.BunifuThinButton2();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._n_max = new MetroFramework.Controls.MetroDateTime();
			this._n_min = new MetroFramework.Controls.MetroDateTime();
			this._not_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
			this._t_search = new Bunifu.Framework.UI.BunifuThinButton2();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._t_max = new MetroFramework.Controls.MetroDateTime();
			this._t_min = new MetroFramework.Controls.MetroDateTime();
			this._today_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._Tab_Main.SuspendLayout();
			this._Delivery_Tab.SuspendLayout();
			this.xuiCustomGroupbox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._passed_gv)).BeginInit();
			this._cmd_Tab.SuspendLayout();
			this.xuiCustomGroupbox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._not_gv)).BeginInit();
			this.metroTabPage1.SuspendLayout();
			this.xuiCustomGroupbox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._today_gv)).BeginInit();
			this.metroContextMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _Tab_Main
			// 
			this._Tab_Main.Controls.Add(this._Delivery_Tab);
			this._Tab_Main.Controls.Add(this._cmd_Tab);
			this._Tab_Main.Controls.Add(this.metroTabPage1);
			this._Tab_Main.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this._Tab_Main.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
			this._Tab_Main.Location = new System.Drawing.Point(14, 6);
			this._Tab_Main.Name = "_Tab_Main";
			this._Tab_Main.SelectedIndex = 0;
			this._Tab_Main.Size = new System.Drawing.Size(906, 527);
			this._Tab_Main.Style = MetroFramework.MetroColorStyle.Blue;
			this._Tab_Main.TabIndex = 2;
			this._Tab_Main.UseSelectable = true;
			// 
			// _Delivery_Tab
			// 
			this._Delivery_Tab.ContextMenuStrip = this.metroContextMenu1;
			this._Delivery_Tab.Controls.Add(this.xuiCustomGroupbox2);
			this._Delivery_Tab.Controls.Add(this._passed_gv);
			this._Delivery_Tab.HorizontalScrollbarBarColor = true;
			this._Delivery_Tab.HorizontalScrollbarHighlightOnWheel = false;
			this._Delivery_Tab.HorizontalScrollbarSize = 2;
			this._Delivery_Tab.Location = new System.Drawing.Point(4, 44);
			this._Delivery_Tab.Name = "_Delivery_Tab";
			this._Delivery_Tab.Size = new System.Drawing.Size(898, 479);
			this._Delivery_Tab.TabIndex = 1;
			this._Delivery_Tab.Text = "Passed";
			this._Delivery_Tab.VerticalScrollbarBarColor = true;
			this._Delivery_Tab.VerticalScrollbarHighlightOnWheel = false;
			this._Delivery_Tab.VerticalScrollbarSize = 2;
			// 
			// xuiCustomGroupbox2
			// 
			this.xuiCustomGroupbox2.BackColor = System.Drawing.Color.White;
			this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.Indigo;
			this.xuiCustomGroupbox2.BorderWidth = 2;
			this.xuiCustomGroupbox2.Controls.Add(this._p_search);
			this.xuiCustomGroupbox2.Controls.Add(this.label3);
			this.xuiCustomGroupbox2.Controls.Add(this.label4);
			this.xuiCustomGroupbox2.Controls.Add(this._p_max);
			this.xuiCustomGroupbox2.Controls.Add(this._p_min);
			this.xuiCustomGroupbox2.Location = new System.Drawing.Point(20, 13);
			this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
			this.xuiCustomGroupbox2.ShowText = true;
			this.xuiCustomGroupbox2.Size = new System.Drawing.Size(561, 95);
			this.xuiCustomGroupbox2.TabIndex = 12;
			this.xuiCustomGroupbox2.TabStop = false;
			this.xuiCustomGroupbox2.Text = "Filter";
			this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.Indigo;
			// 
			// _p_search
			// 
			this._p_search.ActiveBorderThickness = 1;
			this._p_search.ActiveCornerRadius = 20;
			this._p_search.ActiveFillColor = System.Drawing.Color.Indigo;
			this._p_search.ActiveForecolor = System.Drawing.Color.White;
			this._p_search.ActiveLineColor = System.Drawing.Color.Indigo;
			this._p_search.BackColor = System.Drawing.Color.White;
			this._p_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_p_search.BackgroundImage")));
			this._p_search.ButtonText = "Search";
			this._p_search.Cursor = System.Windows.Forms.Cursors.Hand;
			this._p_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._p_search.ForeColor = System.Drawing.Color.SeaGreen;
			this._p_search.IdleBorderThickness = 1;
			this._p_search.IdleCornerRadius = 20;
			this._p_search.IdleFillColor = System.Drawing.Color.White;
			this._p_search.IdleForecolor = System.Drawing.Color.Indigo;
			this._p_search.IdleLineColor = System.Drawing.Color.Indigo;
			this._p_search.Location = new System.Drawing.Point(371, 35);
			this._p_search.Margin = new System.Windows.Forms.Padding(5);
			this._p_search.Name = "_p_search";
			this._p_search.Size = new System.Drawing.Size(167, 42);
			this._p_search.TabIndex = 14;
			this._p_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._p_search.Click += new System.EventHandler(this._p_search_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(263, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Max.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(55, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "Min.";
			// 
			// _p_max
			// 
			this._p_max.CustomFormat = "";
			this._p_max.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._p_max.Location = new System.Drawing.Point(223, 48);
			this._p_max.MinimumSize = new System.Drawing.Size(0, 29);
			this._p_max.Name = "_p_max";
			this._p_max.Size = new System.Drawing.Size(123, 29);
			this._p_max.Style = MetroFramework.MetroColorStyle.Purple;
			this._p_max.TabIndex = 2;
			this._p_max.UseCustomForeColor = true;
			this._p_max.UseStyleColors = true;
			this._p_max.Value = new System.DateTime(2020, 6, 7, 21, 54, 37, 0);
			// 
			// _p_min
			// 
			this._p_min.Checked = false;
			this._p_min.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._p_min.Location = new System.Drawing.Point(31, 48);
			this._p_min.MinimumSize = new System.Drawing.Size(0, 29);
			this._p_min.Name = "_p_min";
			this._p_min.Size = new System.Drawing.Size(123, 29);
			this._p_min.Style = MetroFramework.MetroColorStyle.Purple;
			this._p_min.TabIndex = 1;
			this._p_min.UseCustomForeColor = true;
			this._p_min.UseStyleColors = true;
			// 
			// _passed_gv
			// 
			this._passed_gv.AllowUserToAddRows = false;
			this._passed_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this._passed_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this._passed_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._passed_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._passed_gv.BackgroundColor = System.Drawing.Color.White;
			this._passed_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._passed_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._passed_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this._passed_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._passed_gv.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this._passed_gv.DefaultCellStyle = dataGridViewCellStyle3;
			this._passed_gv.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._passed_gv.DoubleBuffered = true;
			this._passed_gv.EnableHeadersVisualStyles = false;
			this._passed_gv.GridColor = System.Drawing.Color.White;
			this._passed_gv.HeaderBgColor = System.Drawing.Color.Indigo;
			this._passed_gv.HeaderForeColor = System.Drawing.Color.White;
			this._passed_gv.Location = new System.Drawing.Point(0, 126);
			this._passed_gv.Name = "_passed_gv";
			this._passed_gv.ReadOnly = true;
			this._passed_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._passed_gv.Size = new System.Drawing.Size(898, 353);
			this._passed_gv.TabIndex = 2;
			// 
			// _cmd_Tab
			// 
			this._cmd_Tab.ContextMenuStrip = this.metroContextMenu1;
			this._cmd_Tab.Controls.Add(this.xuiCustomGroupbox1);
			this._cmd_Tab.Controls.Add(this._not_gv);
			this._cmd_Tab.HorizontalScrollbarBarColor = true;
			this._cmd_Tab.HorizontalScrollbarHighlightOnWheel = false;
			this._cmd_Tab.HorizontalScrollbarSize = 2;
			this._cmd_Tab.Location = new System.Drawing.Point(4, 44);
			this._cmd_Tab.Name = "_cmd_Tab";
			this._cmd_Tab.Size = new System.Drawing.Size(898, 479);
			this._cmd_Tab.TabIndex = 0;
			this._cmd_Tab.Text = "Not passed";
			this._cmd_Tab.ToolTipText = "Command Tap";
			this._cmd_Tab.VerticalScrollbarBarColor = true;
			this._cmd_Tab.VerticalScrollbarHighlightOnWheel = false;
			this._cmd_Tab.VerticalScrollbarSize = 2;
			// 
			// xuiCustomGroupbox1
			// 
			this.xuiCustomGroupbox1.BackColor = System.Drawing.Color.White;
			this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.Indigo;
			this.xuiCustomGroupbox1.BorderWidth = 2;
			this.xuiCustomGroupbox1.Controls.Add(this._n_search);
			this.xuiCustomGroupbox1.Controls.Add(this.label2);
			this.xuiCustomGroupbox1.Controls.Add(this.label1);
			this.xuiCustomGroupbox1.Controls.Add(this._n_max);
			this.xuiCustomGroupbox1.Controls.Add(this._n_min);
			this.xuiCustomGroupbox1.Location = new System.Drawing.Point(27, 14);
			this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
			this.xuiCustomGroupbox1.ShowText = true;
			this.xuiCustomGroupbox1.Size = new System.Drawing.Size(561, 95);
			this.xuiCustomGroupbox1.TabIndex = 11;
			this.xuiCustomGroupbox1.TabStop = false;
			this.xuiCustomGroupbox1.Text = "Filter";
			this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.Indigo;
			// 
			// _n_search
			// 
			this._n_search.ActiveBorderThickness = 1;
			this._n_search.ActiveCornerRadius = 20;
			this._n_search.ActiveFillColor = System.Drawing.Color.Indigo;
			this._n_search.ActiveForecolor = System.Drawing.Color.White;
			this._n_search.ActiveLineColor = System.Drawing.Color.Indigo;
			this._n_search.BackColor = System.Drawing.Color.White;
			this._n_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_n_search.BackgroundImage")));
			this._n_search.ButtonText = "Search";
			this._n_search.Cursor = System.Windows.Forms.Cursors.Hand;
			this._n_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._n_search.ForeColor = System.Drawing.Color.SeaGreen;
			this._n_search.IdleBorderThickness = 1;
			this._n_search.IdleCornerRadius = 20;
			this._n_search.IdleFillColor = System.Drawing.Color.White;
			this._n_search.IdleForecolor = System.Drawing.Color.Indigo;
			this._n_search.IdleLineColor = System.Drawing.Color.Indigo;
			this._n_search.Location = new System.Drawing.Point(368, 36);
			this._n_search.Margin = new System.Windows.Forms.Padding(5);
			this._n_search.Name = "_n_search";
			this._n_search.Size = new System.Drawing.Size(173, 41);
			this._n_search.TabIndex = 14;
			this._n_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._n_search.Click += new System.EventHandler(this._n_search_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(263, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 15);
			this.label2.TabIndex = 13;
			this.label2.Text = "Max.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(55, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "Min.";
			// 
			// _n_max
			// 
			this._n_max.CustomFormat = "";
			this._n_max.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._n_max.Location = new System.Drawing.Point(223, 48);
			this._n_max.MinimumSize = new System.Drawing.Size(0, 29);
			this._n_max.Name = "_n_max";
			this._n_max.Size = new System.Drawing.Size(123, 29);
			this._n_max.Style = MetroFramework.MetroColorStyle.Purple;
			this._n_max.TabIndex = 2;
			this._n_max.UseCustomForeColor = true;
			this._n_max.UseStyleColors = true;
			this._n_max.Value = new System.DateTime(2020, 6, 7, 21, 54, 37, 0);
			// 
			// _n_min
			// 
			this._n_min.Checked = false;
			this._n_min.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._n_min.Location = new System.Drawing.Point(31, 48);
			this._n_min.MinimumSize = new System.Drawing.Size(0, 29);
			this._n_min.Name = "_n_min";
			this._n_min.Size = new System.Drawing.Size(123, 29);
			this._n_min.Style = MetroFramework.MetroColorStyle.Purple;
			this._n_min.TabIndex = 1;
			this._n_min.UseCustomForeColor = true;
			this._n_min.UseStyleColors = true;
			// 
			// _not_gv
			// 
			this._not_gv.AllowUserToAddRows = false;
			this._not_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this._not_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this._not_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._not_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._not_gv.BackgroundColor = System.Drawing.Color.White;
			this._not_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._not_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._not_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this._not_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._not_gv.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this._not_gv.DefaultCellStyle = dataGridViewCellStyle6;
			this._not_gv.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._not_gv.DoubleBuffered = true;
			this._not_gv.EnableHeadersVisualStyles = false;
			this._not_gv.GridColor = System.Drawing.Color.White;
			this._not_gv.HeaderBgColor = System.Drawing.Color.Indigo;
			this._not_gv.HeaderForeColor = System.Drawing.Color.White;
			this._not_gv.Location = new System.Drawing.Point(0, 145);
			this._not_gv.Name = "_not_gv";
			this._not_gv.ReadOnly = true;
			this._not_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._not_gv.Size = new System.Drawing.Size(898, 334);
			this._not_gv.TabIndex = 10;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.ContextMenuStrip = this.metroContextMenu1;
			this.metroTabPage1.Controls.Add(this.xuiCustomGroupbox3);
			this.metroTabPage1.Controls.Add(this._today_gv);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 5;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(898, 479);
			this.metroTabPage1.TabIndex = 2;
			this.metroTabPage1.Text = "For Today";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 4;
			// 
			// xuiCustomGroupbox3
			// 
			this.xuiCustomGroupbox3.BackColor = System.Drawing.Color.White;
			this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.Indigo;
			this.xuiCustomGroupbox3.BorderWidth = 2;
			this.xuiCustomGroupbox3.Controls.Add(this._t_search);
			this.xuiCustomGroupbox3.Controls.Add(this.label5);
			this.xuiCustomGroupbox3.Controls.Add(this.label6);
			this.xuiCustomGroupbox3.Controls.Add(this._t_max);
			this.xuiCustomGroupbox3.Controls.Add(this._t_min);
			this.xuiCustomGroupbox3.Location = new System.Drawing.Point(42, 27);
			this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
			this.xuiCustomGroupbox3.ShowText = true;
			this.xuiCustomGroupbox3.Size = new System.Drawing.Size(561, 95);
			this.xuiCustomGroupbox3.TabIndex = 13;
			this.xuiCustomGroupbox3.TabStop = false;
			this.xuiCustomGroupbox3.Text = "Filter";
			this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.Indigo;
			// 
			// _t_search
			// 
			this._t_search.ActiveBorderThickness = 1;
			this._t_search.ActiveCornerRadius = 20;
			this._t_search.ActiveFillColor = System.Drawing.Color.Indigo;
			this._t_search.ActiveForecolor = System.Drawing.Color.White;
			this._t_search.ActiveLineColor = System.Drawing.Color.Indigo;
			this._t_search.BackColor = System.Drawing.Color.White;
			this._t_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_t_search.BackgroundImage")));
			this._t_search.ButtonText = "Search";
			this._t_search.Cursor = System.Windows.Forms.Cursors.Hand;
			this._t_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._t_search.ForeColor = System.Drawing.Color.SeaGreen;
			this._t_search.IdleBorderThickness = 1;
			this._t_search.IdleCornerRadius = 20;
			this._t_search.IdleFillColor = System.Drawing.Color.White;
			this._t_search.IdleForecolor = System.Drawing.Color.Indigo;
			this._t_search.IdleLineColor = System.Drawing.Color.Indigo;
			this._t_search.Location = new System.Drawing.Point(368, 38);
			this._t_search.Margin = new System.Windows.Forms.Padding(5);
			this._t_search.Name = "_t_search";
			this._t_search.Size = new System.Drawing.Size(169, 39);
			this._t_search.TabIndex = 14;
			this._t_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._t_search.Click += new System.EventHandler(this._t_search_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(263, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 15);
			this.label5.TabIndex = 13;
			this.label5.Text = "Max.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(55, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "Min.";
			// 
			// _t_max
			// 
			this._t_max.CustomFormat = "";
			this._t_max.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._t_max.Location = new System.Drawing.Point(223, 48);
			this._t_max.MinimumSize = new System.Drawing.Size(0, 29);
			this._t_max.Name = "_t_max";
			this._t_max.Size = new System.Drawing.Size(123, 29);
			this._t_max.Style = MetroFramework.MetroColorStyle.Purple;
			this._t_max.TabIndex = 2;
			this._t_max.UseCustomForeColor = true;
			this._t_max.UseStyleColors = true;
			this._t_max.Value = new System.DateTime(2020, 6, 7, 21, 54, 37, 0);
			// 
			// _t_min
			// 
			this._t_min.Checked = false;
			this._t_min.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._t_min.Location = new System.Drawing.Point(31, 48);
			this._t_min.MinimumSize = new System.Drawing.Size(0, 29);
			this._t_min.Name = "_t_min";
			this._t_min.Size = new System.Drawing.Size(123, 29);
			this._t_min.Style = MetroFramework.MetroColorStyle.Purple;
			this._t_min.TabIndex = 1;
			this._t_min.UseCustomForeColor = true;
			this._t_min.UseStyleColors = true;
			// 
			// _today_gv
			// 
			this._today_gv.AllowUserToAddRows = false;
			this._today_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this._today_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this._today_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._today_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._today_gv.BackgroundColor = System.Drawing.Color.White;
			this._today_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._today_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._today_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this._today_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._today_gv.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Indigo;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this._today_gv.DefaultCellStyle = dataGridViewCellStyle9;
			this._today_gv.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._today_gv.DoubleBuffered = true;
			this._today_gv.EnableHeadersVisualStyles = false;
			this._today_gv.GridColor = System.Drawing.Color.White;
			this._today_gv.HeaderBgColor = System.Drawing.Color.Indigo;
			this._today_gv.HeaderForeColor = System.Drawing.Color.White;
			this._today_gv.Location = new System.Drawing.Point(0, 142);
			this._today_gv.Name = "_today_gv";
			this._today_gv.ReadOnly = true;
			this._today_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._today_gv.Size = new System.Drawing.Size(898, 337);
			this._today_gv.TabIndex = 3;
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(151, 48);
			this.metroContextMenu1.Text = "Close ";
			this.metroContextMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu1_Opening);
			// 
			// filterToolStripMenuItem
			// 
			this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
			this.filterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.filterToolStripMenuItem.Text = "Cancel filtrage";
			this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.closeToolStripMenuItem.Text = "Close";
			// 
			// ManagementReservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this._Tab_Main);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ManagementReservation";
			this.Size = new System.Drawing.Size(941, 579);
			this.Load += new System.EventHandler(this.MangementCmd_Load);
			this._Tab_Main.ResumeLayout(false);
			this._Delivery_Tab.ResumeLayout(false);
			this.xuiCustomGroupbox2.ResumeLayout(false);
			this.xuiCustomGroupbox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._passed_gv)).EndInit();
			this._cmd_Tab.ResumeLayout(false);
			this.xuiCustomGroupbox1.ResumeLayout(false);
			this.xuiCustomGroupbox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._not_gv)).EndInit();
			this.metroTabPage1.ResumeLayout(false);
			this.xuiCustomGroupbox3.ResumeLayout(false);
			this.xuiCustomGroupbox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._today_gv)).EndInit();
			this.metroContextMenu1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl _Tab_Main;
        private MetroFramework.Controls.MetroTabPage _cmd_Tab;
        private MetroFramework.Controls.MetroTabPage _Delivery_Tab;
		private Bunifu.Framework.UI.BunifuCustomDataGrid _passed_gv;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid _not_gv;
		private Bunifu.Framework.UI.BunifuCustomDataGrid _today_gv;
		private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
		private MetroFramework.Controls.MetroDateTime _n_max;
		private MetroFramework.Controls.MetroDateTime _n_min;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuThinButton2 _n_search;
		private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
		private Bunifu.Framework.UI.BunifuThinButton2 _p_search;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private MetroFramework.Controls.MetroDateTime _p_max;
		private MetroFramework.Controls.MetroDateTime _p_min;
		private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
		private Bunifu.Framework.UI.BunifuThinButton2 _t_search;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private MetroFramework.Controls.MetroDateTime _t_max;
		private MetroFramework.Controls.MetroDateTime _t_min;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
	}
}
