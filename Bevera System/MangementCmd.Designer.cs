namespace Bevera_System
{
    partial class MangementCmd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangementCmd));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this._Tab_Main = new MetroFramework.Controls.MetroTabControl();
			this._Delivery_Tab = new MetroFramework.Controls.MetroTabPage();
			this._info_lbl = new System.Windows.Forms.Label();
			this._search_txt = new MetroFramework.Controls.MetroTextBox();
			this._typSearch_cmb = new MetroFramework.Controls.MetroComboBox();
			this._cmd_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this._cmd_Tab = new MetroFramework.Controls.MetroTabPage();
			this._deliv_lbl = new System.Windows.Forms.Label();
			this.Sear_deliv_txt = new MetroFramework.Controls.MetroTextBox();
			this._deliv_typ_cmb = new MetroFramework.Controls.MetroComboBox();
			this._deliv_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.id_deliv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date_deliv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.heure_deliv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price_reduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.net_payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_manger = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_cuisiner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_deliverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._graphics_Tab = new MetroFramework.Controls.MetroTabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._Total_lbl = new System.Windows.Forms.Label();
			this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.xuiBarGraph2 = new XanderUI.XUIBarGraph();
			this.xuiBarGraph1 = new XanderUI.XUIBarGraph();
			this._tables_tab = new MetroFramework.Controls.MetroTabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this._Add_btn = new MetroFramework.Controls.MetroButton();
			this._dropdown_size = new Bunifu.Framework.UI.BunifuDropdown();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this._nb_lbl = new MetroFramework.Controls.MetroLabel();
			this._nb_track = new MetroFramework.Controls.MetroTrackBar();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this._idtbl_txt = new System.Windows.Forms.MaskedTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this._tables_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.id_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberchair = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.size_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.del = new System.Windows.Forms.DataGridViewButtonColumn();
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.resetFiltrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serveurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.couponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuisinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._Tab_Main.SuspendLayout();
			this._Delivery_Tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._cmd_gv)).BeginInit();
			this._cmd_Tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._deliv_gv)).BeginInit();
			this._graphics_Tab.SuspendLayout();
			this._tables_tab.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._tables_gv)).BeginInit();
			this.metroContextMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _Tab_Main
			// 
			this._Tab_Main.Controls.Add(this._Delivery_Tab);
			this._Tab_Main.Controls.Add(this._cmd_Tab);
			this._Tab_Main.Controls.Add(this._graphics_Tab);
			this._Tab_Main.Controls.Add(this._tables_tab);
			this._Tab_Main.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this._Tab_Main.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
			this._Tab_Main.Location = new System.Drawing.Point(14, 6);
			this._Tab_Main.Name = "_Tab_Main";
			this._Tab_Main.SelectedIndex = 1;
			this._Tab_Main.Size = new System.Drawing.Size(906, 527);
			this._Tab_Main.Style = MetroFramework.MetroColorStyle.Blue;
			this._Tab_Main.TabIndex = 2;
			this._Tab_Main.UseSelectable = true;
			// 
			// _Delivery_Tab
			// 
			this._Delivery_Tab.Controls.Add(this._info_lbl);
			this._Delivery_Tab.Controls.Add(this._search_txt);
			this._Delivery_Tab.Controls.Add(this._typSearch_cmb);
			this._Delivery_Tab.Controls.Add(this._cmd_gv);
			this._Delivery_Tab.HorizontalScrollbarBarColor = true;
			this._Delivery_Tab.HorizontalScrollbarHighlightOnWheel = false;
			this._Delivery_Tab.HorizontalScrollbarSize = 2;
			this._Delivery_Tab.Location = new System.Drawing.Point(4, 44);
			this._Delivery_Tab.Name = "_Delivery_Tab";
			this._Delivery_Tab.Size = new System.Drawing.Size(898, 479);
			this._Delivery_Tab.TabIndex = 1;
			this._Delivery_Tab.Text = "Commands";
			this._Delivery_Tab.VerticalScrollbarBarColor = true;
			this._Delivery_Tab.VerticalScrollbarHighlightOnWheel = false;
			this._Delivery_Tab.VerticalScrollbarSize = 2;
			// 
			// _info_lbl
			// 
			this._info_lbl.AutoSize = true;
			this._info_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._info_lbl.ForeColor = System.Drawing.Color.SeaGreen;
			this._info_lbl.Location = new System.Drawing.Point(578, 35);
			this._info_lbl.Name = "_info_lbl";
			this._info_lbl.Size = new System.Drawing.Size(0, 20);
			this._info_lbl.TabIndex = 6;
			// 
			// _search_txt
			// 
			// 
			// 
			// 
			this._search_txt.CustomButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._search_txt.CustomButton.ForeColor = System.Drawing.Color.White;
			this._search_txt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this._search_txt.CustomButton.Location = new System.Drawing.Point(164, 2);
			this._search_txt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
			this._search_txt.CustomButton.Name = "";
			this._search_txt.CustomButton.Padding = new System.Windows.Forms.Padding(2);
			this._search_txt.CustomButton.Size = new System.Drawing.Size(19, 19);
			this._search_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Brown;
			this._search_txt.CustomButton.TabIndex = 1;
			this._search_txt.CustomButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this._search_txt.CustomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._search_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this._search_txt.CustomButton.UseCompatibleTextRendering = true;
			this._search_txt.CustomButton.UseSelectable = true;
			this._search_txt.Lines = new string[0];
			this._search_txt.Location = new System.Drawing.Point(298, 29);
			this._search_txt.MaxLength = 32767;
			this._search_txt.Name = "_search_txt";
			this._search_txt.PasswordChar = '\0';
			this._search_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this._search_txt.SelectedText = "";
			this._search_txt.SelectionLength = 0;
			this._search_txt.SelectionStart = 0;
			this._search_txt.ShortcutsEnabled = true;
			this._search_txt.ShowButton = true;
			this._search_txt.ShowClearButton = true;
			this._search_txt.Size = new System.Drawing.Size(247, 30);
			this._search_txt.TabIndex = 5;
			this._search_txt.UseSelectable = true;
			this._search_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this._search_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// _typSearch_cmb
			// 
			this._typSearch_cmb.FormattingEnabled = true;
			this._typSearch_cmb.ItemHeight = 23;
			this._typSearch_cmb.Items.AddRange(new object[] {
            "Command ID",
            "Date",
            "Manger"});
			this._typSearch_cmb.Location = new System.Drawing.Point(22, 30);
			this._typSearch_cmb.Name = "_typSearch_cmb";
			this._typSearch_cmb.Size = new System.Drawing.Size(220, 29);
			this._typSearch_cmb.TabIndex = 4;
			this._typSearch_cmb.UseSelectable = true;
			// 
			// _cmd_gv
			// 
			this._cmd_gv.AllowUserToAddRows = false;
			this._cmd_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this._cmd_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this._cmd_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._cmd_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._cmd_gv.BackgroundColor = System.Drawing.Color.White;
			this._cmd_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._cmd_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._cmd_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this._cmd_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._cmd_gv.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this._cmd_gv.DefaultCellStyle = dataGridViewCellStyle12;
			this._cmd_gv.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._cmd_gv.DoubleBuffered = true;
			this._cmd_gv.EnableHeadersVisualStyles = false;
			this._cmd_gv.GridColor = System.Drawing.Color.White;
			this._cmd_gv.HeaderBgColor = System.Drawing.Color.Maroon;
			this._cmd_gv.HeaderForeColor = System.Drawing.Color.White;
			this._cmd_gv.Location = new System.Drawing.Point(0, 94);
			this._cmd_gv.Name = "_cmd_gv";
			this._cmd_gv.ReadOnly = true;
			this._cmd_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._cmd_gv.Size = new System.Drawing.Size(898, 385);
			this._cmd_gv.TabIndex = 2;
			this._cmd_gv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._cmd_gv_CellDoubleClick);
			// 
			// _cmd_Tab
			// 
			this._cmd_Tab.Controls.Add(this._deliv_lbl);
			this._cmd_Tab.Controls.Add(this.Sear_deliv_txt);
			this._cmd_Tab.Controls.Add(this._deliv_typ_cmb);
			this._cmd_Tab.Controls.Add(this._deliv_gv);
			this._cmd_Tab.HorizontalScrollbarBarColor = true;
			this._cmd_Tab.HorizontalScrollbarHighlightOnWheel = false;
			this._cmd_Tab.HorizontalScrollbarSize = 2;
			this._cmd_Tab.Location = new System.Drawing.Point(4, 44);
			this._cmd_Tab.Name = "_cmd_Tab";
			this._cmd_Tab.Size = new System.Drawing.Size(898, 479);
			this._cmd_Tab.TabIndex = 0;
			this._cmd_Tab.Text = "delivery";
			this._cmd_Tab.ToolTipText = "Command Tap";
			this._cmd_Tab.VerticalScrollbarBarColor = true;
			this._cmd_Tab.VerticalScrollbarHighlightOnWheel = false;
			this._cmd_Tab.VerticalScrollbarSize = 2;
			// 
			// _deliv_lbl
			// 
			this._deliv_lbl.AutoSize = true;
			this._deliv_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._deliv_lbl.ForeColor = System.Drawing.Color.SeaGreen;
			this._deliv_lbl.Location = new System.Drawing.Point(590, 40);
			this._deliv_lbl.Name = "_deliv_lbl";
			this._deliv_lbl.Size = new System.Drawing.Size(0, 20);
			this._deliv_lbl.TabIndex = 9;
			// 
			// Sear_deliv_txt
			// 
			// 
			// 
			// 
			this.Sear_deliv_txt.CustomButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Sear_deliv_txt.CustomButton.ForeColor = System.Drawing.Color.White;
			this.Sear_deliv_txt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			this.Sear_deliv_txt.CustomButton.Location = new System.Drawing.Point(219, 2);
			this.Sear_deliv_txt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
			this.Sear_deliv_txt.CustomButton.Name = "";
			this.Sear_deliv_txt.CustomButton.Padding = new System.Windows.Forms.Padding(2);
			this.Sear_deliv_txt.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.Sear_deliv_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Brown;
			this.Sear_deliv_txt.CustomButton.TabIndex = 1;
			this.Sear_deliv_txt.CustomButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Sear_deliv_txt.CustomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Sear_deliv_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.Sear_deliv_txt.CustomButton.UseCompatibleTextRendering = true;
			this.Sear_deliv_txt.CustomButton.UseSelectable = true;
			this.Sear_deliv_txt.Lines = new string[0];
			this.Sear_deliv_txt.Location = new System.Drawing.Point(310, 34);
			this.Sear_deliv_txt.MaxLength = 32767;
			this.Sear_deliv_txt.Name = "Sear_deliv_txt";
			this.Sear_deliv_txt.PasswordChar = '\0';
			this.Sear_deliv_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.Sear_deliv_txt.SelectedText = "";
			this.Sear_deliv_txt.SelectionLength = 0;
			this.Sear_deliv_txt.SelectionStart = 0;
			this.Sear_deliv_txt.ShortcutsEnabled = true;
			this.Sear_deliv_txt.ShowButton = true;
			this.Sear_deliv_txt.ShowClearButton = true;
			this.Sear_deliv_txt.Size = new System.Drawing.Size(247, 30);
			this.Sear_deliv_txt.TabIndex = 8;
			this.Sear_deliv_txt.UseSelectable = true;
			this.Sear_deliv_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.Sear_deliv_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// _deliv_typ_cmb
			// 
			this._deliv_typ_cmb.FormattingEnabled = true;
			this._deliv_typ_cmb.ItemHeight = 23;
			this._deliv_typ_cmb.Items.AddRange(new object[] {
            "Delivery ID",
            "Date",
            "Manger",
            "Deliverer"});
			this._deliv_typ_cmb.Location = new System.Drawing.Point(34, 35);
			this._deliv_typ_cmb.Name = "_deliv_typ_cmb";
			this._deliv_typ_cmb.Size = new System.Drawing.Size(220, 29);
			this._deliv_typ_cmb.TabIndex = 7;
			this._deliv_typ_cmb.UseSelectable = true;
			// 
			// _deliv_gv
			// 
			this._deliv_gv.AllowUserToAddRows = false;
			this._deliv_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
			this._deliv_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this._deliv_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._deliv_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._deliv_gv.BackgroundColor = System.Drawing.Color.White;
			this._deliv_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._deliv_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._deliv_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this._deliv_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._deliv_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_deliv,
            this.date_deliv,
            this.heure_deliv,
            this.price_total,
            this.price_reduction,
            this.net_payer,
            this.id_manger,
            this.id_cuisiner,
            this.id_deliverer});
			this._deliv_gv.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this._deliv_gv.DefaultCellStyle = dataGridViewCellStyle15;
			this._deliv_gv.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._deliv_gv.DoubleBuffered = true;
			this._deliv_gv.EnableHeadersVisualStyles = false;
			this._deliv_gv.GridColor = System.Drawing.Color.White;
			this._deliv_gv.HeaderBgColor = System.Drawing.Color.Teal;
			this._deliv_gv.HeaderForeColor = System.Drawing.Color.White;
			this._deliv_gv.Location = new System.Drawing.Point(0, 94);
			this._deliv_gv.MultiSelect = false;
			this._deliv_gv.Name = "_deliv_gv";
			this._deliv_gv.ReadOnly = true;
			this._deliv_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._deliv_gv.Size = new System.Drawing.Size(898, 385);
			this._deliv_gv.TabIndex = 2;
			this._deliv_gv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._deliv_gv_CellDoubleClick);
			// 
			// id_deliv
			// 
			this.id_deliv.DataPropertyName = "id_deliv";
			this.id_deliv.HeaderText = "Delivery ID";
			this.id_deliv.Name = "id_deliv";
			this.id_deliv.ReadOnly = true;
			// 
			// date_deliv
			// 
			this.date_deliv.DataPropertyName = "date_deliv";
			this.date_deliv.HeaderText = "Day";
			this.date_deliv.Name = "date_deliv";
			this.date_deliv.ReadOnly = true;
			// 
			// heure_deliv
			// 
			this.heure_deliv.DataPropertyName = "heure_deliv";
			this.heure_deliv.HeaderText = "Houre";
			this.heure_deliv.Name = "heure_deliv";
			this.heure_deliv.ReadOnly = true;
			// 
			// price_total
			// 
			this.price_total.DataPropertyName = "price_total";
			this.price_total.HeaderText = "Price";
			this.price_total.Name = "price_total";
			this.price_total.ReadOnly = true;
			// 
			// price_reduction
			// 
			this.price_reduction.DataPropertyName = "price_reduction";
			this.price_reduction.HeaderText = "Reduction";
			this.price_reduction.Name = "price_reduction";
			this.price_reduction.ReadOnly = true;
			// 
			// net_payer
			// 
			this.net_payer.DataPropertyName = "net_payer";
			this.net_payer.HeaderText = "TOTAL";
			this.net_payer.Name = "net_payer";
			this.net_payer.ReadOnly = true;
			// 
			// id_manger
			// 
			this.id_manger.DataPropertyName = "id_manger";
			this.id_manger.HeaderText = "Manger";
			this.id_manger.Name = "id_manger";
			this.id_manger.ReadOnly = true;
			// 
			// id_cuisiner
			// 
			this.id_cuisiner.DataPropertyName = "id_cuisiner";
			this.id_cuisiner.HeaderText = "cuisiner";
			this.id_cuisiner.Name = "id_cuisiner";
			this.id_cuisiner.ReadOnly = true;
			// 
			// id_deliverer
			// 
			this.id_deliverer.DataPropertyName = "id_deliverer";
			this.id_deliverer.HeaderText = "Deliverer";
			this.id_deliverer.Name = "id_deliverer";
			this.id_deliverer.ReadOnly = true;
			// 
			// _graphics_Tab
			// 
			this._graphics_Tab.Controls.Add(this.label6);
			this._graphics_Tab.Controls.Add(this.label7);
			this._graphics_Tab.Controls.Add(this.label8);
			this._graphics_Tab.Controls.Add(this.label5);
			this._graphics_Tab.Controls.Add(this.label2);
			this._graphics_Tab.Controls.Add(this._Total_lbl);
			this._graphics_Tab.Controls.Add(this.bunifuSeparator1);
			this._graphics_Tab.Controls.Add(this.label1);
			this._graphics_Tab.Controls.Add(this.label4);
			this._graphics_Tab.Controls.Add(this.xuiBarGraph2);
			this._graphics_Tab.Controls.Add(this.xuiBarGraph1);
			this._graphics_Tab.HorizontalScrollbarBarColor = true;
			this._graphics_Tab.HorizontalScrollbarHighlightOnWheel = false;
			this._graphics_Tab.HorizontalScrollbarSize = 2;
			this._graphics_Tab.Location = new System.Drawing.Point(4, 44);
			this._graphics_Tab.Name = "_graphics_Tab";
			this._graphics_Tab.Size = new System.Drawing.Size(898, 479);
			this._graphics_Tab.TabIndex = 2;
			this._graphics_Tab.Text = "Dashboards";
			this._graphics_Tab.UseVisualStyleBackColor = true;
			this._graphics_Tab.VerticalScrollbarBarColor = true;
			this._graphics_Tab.VerticalScrollbarHighlightOnWheel = false;
			this._graphics_Tab.VerticalScrollbarSize = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(54, 334);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 19);
			this.label6.TabIndex = 24;
			this.label6.Text = "| Total Reduction";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(54, 308);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(184, 21);
			this.label7.TabIndex = 25;
			this.label7.Text = "| Number Delivery";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(54, 284);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(130, 21);
			this.label8.TabIndex = 26;
			this.label8.Text = "| Total Sales";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(450, 334);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 19);
			this.label5.TabIndex = 23;
			this.label5.Text = "| Total Reduction";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(450, 308);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 21);
			this.label2.TabIndex = 23;
			this.label2.Text = "| Number Delivery";
			// 
			// _Total_lbl
			// 
			this._Total_lbl.AutoSize = true;
			this._Total_lbl.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._Total_lbl.Location = new System.Drawing.Point(450, 284);
			this._Total_lbl.Name = "_Total_lbl";
			this._Total_lbl.Size = new System.Drawing.Size(130, 21);
			this._Total_lbl.TabIndex = 23;
			this._Total_lbl.Text = "| Total Sales";
			// 
			// bunifuSeparator1
			// 
			this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.bunifuSeparator1.LineThickness = 873;
			this.bunifuSeparator1.Location = new System.Drawing.Point(405, 26);
			this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Size = new System.Drawing.Size(11, 394);
			this.bunifuSeparator1.TabIndex = 6;
			this.bunifuSeparator1.Transparency = 255;
			this.bunifuSeparator1.Vertical = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(529, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Delivery  :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Command :";
			// 
			// xuiBarGraph2
			// 
			this.xuiBarGraph2.BackColor = System.Drawing.Color.White;
			this.xuiBarGraph2.FilledColor = System.Drawing.Color.RoyalBlue;
			this.xuiBarGraph2.ForeColor = System.Drawing.Color.White;
			this.xuiBarGraph2.GraphOrientation = XanderUI.XUIBarGraph.Orientation.Vertical;
			this.xuiBarGraph2.GraphStyle = XanderUI.XUIBarGraph.Style.Flat;
			this.xuiBarGraph2.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuiBarGraph2.Items")));
			this.xuiBarGraph2.Location = new System.Drawing.Point(-4, 46);
			this.xuiBarGraph2.Name = "xuiBarGraph2";
			this.xuiBarGraph2.ShowGrid = false;
			this.xuiBarGraph2.Size = new System.Drawing.Size(380, 186);
			this.xuiBarGraph2.Sorting = XanderUI.XUIBarGraph.SortStyle.Normal;
			this.xuiBarGraph2.SplitterColor = System.Drawing.Color.Gold;
			this.xuiBarGraph2.TabIndex = 2;
			this.xuiBarGraph2.Text = "_cmd_graph";
			this.xuiBarGraph2.TextAlignment = XanderUI.XUIBarGraph.Aligning.Center;
			this.xuiBarGraph2.TextColor = System.Drawing.Color.Black;
			this.xuiBarGraph2.UnfilledColor = System.Drawing.Color.White;
			// 
			// xuiBarGraph1
			// 
			this.xuiBarGraph1.BackColor = System.Drawing.Color.White;
			this.xuiBarGraph1.FilledColor = System.Drawing.Color.RoyalBlue;
			this.xuiBarGraph1.ForeColor = System.Drawing.Color.White;
			this.xuiBarGraph1.GraphOrientation = XanderUI.XUIBarGraph.Orientation.Vertical;
			this.xuiBarGraph1.GraphStyle = XanderUI.XUIBarGraph.Style.Flat;
			this.xuiBarGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuiBarGraph1.Items")));
			this.xuiBarGraph1.Location = new System.Drawing.Point(454, 46);
			this.xuiBarGraph1.Name = "xuiBarGraph1";
			this.xuiBarGraph1.ShowGrid = false;
			this.xuiBarGraph1.Size = new System.Drawing.Size(380, 186);
			this.xuiBarGraph1.Sorting = XanderUI.XUIBarGraph.SortStyle.Normal;
			this.xuiBarGraph1.SplitterColor = System.Drawing.Color.Gold;
			this.xuiBarGraph1.TabIndex = 2;
			this.xuiBarGraph1.Text = "_deliv_graph";
			this.xuiBarGraph1.TextAlignment = XanderUI.XUIBarGraph.Aligning.Center;
			this.xuiBarGraph1.TextColor = System.Drawing.Color.Black;
			this.xuiBarGraph1.UnfilledColor = System.Drawing.Color.White;
			// 
			// _tables_tab
			// 
			this._tables_tab.Controls.Add(this.panel1);
			this._tables_tab.Controls.Add(this._tables_gv);
			this._tables_tab.HorizontalScrollbarBarColor = true;
			this._tables_tab.HorizontalScrollbarHighlightOnWheel = false;
			this._tables_tab.HorizontalScrollbarSize = 5;
			this._tables_tab.Location = new System.Drawing.Point(4, 44);
			this._tables_tab.Name = "_tables_tab";
			this._tables_tab.Size = new System.Drawing.Size(898, 479);
			this._tables_tab.TabIndex = 3;
			this._tables_tab.Text = "Tables";
			this._tables_tab.VerticalScrollbarBarColor = true;
			this._tables_tab.VerticalScrollbarHighlightOnWheel = false;
			this._tables_tab.VerticalScrollbarSize = 4;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.panel1.Controls.Add(this._Add_btn);
			this.panel1.Controls.Add(this._dropdown_size);
			this.panel1.Controls.Add(this.metroLabel3);
			this.panel1.Controls.Add(this._nb_lbl);
			this.panel1.Controls.Add(this._nb_track);
			this.panel1.Controls.Add(this.metroLabel2);
			this.panel1.Controls.Add(this._idtbl_txt);
			this.panel1.Controls.Add(this.metroLabel1);
			this.panel1.Location = new System.Drawing.Point(27, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(275, 294);
			this.panel1.TabIndex = 4;
			// 
			// _Add_btn
			// 
			this._Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._Add_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
			this._Add_btn.Location = new System.Drawing.Point(34, 231);
			this._Add_btn.Name = "_Add_btn";
			this._Add_btn.Size = new System.Drawing.Size(196, 44);
			this._Add_btn.Style = MetroFramework.MetroColorStyle.Orange;
			this._Add_btn.TabIndex = 7;
			this._Add_btn.Text = "Add";
			this._Add_btn.UseSelectable = true;
			this._Add_btn.UseStyleColors = true;
			this._Add_btn.Click += new System.EventHandler(this._Add_btn_Click);
			// 
			// _dropdown_size
			// 
			this._dropdown_size.BackColor = System.Drawing.Color.Transparent;
			this._dropdown_size.BorderRadius = 3;
			this._dropdown_size.DisabledColor = System.Drawing.Color.Gray;
			this._dropdown_size.ForeColor = System.Drawing.Color.White;
			this._dropdown_size.Items = new string[] {
        "Small",
        "Medium",
        "Large",
        "Room"};
			this._dropdown_size.Location = new System.Drawing.Point(34, 188);
			this._dropdown_size.Margin = new System.Windows.Forms.Padding(4);
			this._dropdown_size.Name = "_dropdown_size";
			this._dropdown_size.NomalColor = System.Drawing.Color.LightSeaGreen;
			this._dropdown_size.onHoverColor = System.Drawing.Color.DarkSlateBlue;
			this._dropdown_size.selectedIndex = -1;
			this._dropdown_size.Size = new System.Drawing.Size(196, 28);
			this._dropdown_size.TabIndex = 6;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.ForeColor = System.Drawing.Color.White;
			this.metroLabel3.Location = new System.Drawing.Point(34, 156);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(44, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Size :";
			this.metroLabel3.UseCustomBackColor = true;
			this.metroLabel3.UseCustomForeColor = true;
			this.metroLabel3.UseStyleColors = true;
			// 
			// _nb_lbl
			// 
			this._nb_lbl.AutoSize = true;
			this._nb_lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this._nb_lbl.ForeColor = System.Drawing.Color.White;
			this._nb_lbl.Location = new System.Drawing.Point(213, 130);
			this._nb_lbl.Name = "_nb_lbl";
			this._nb_lbl.Size = new System.Drawing.Size(17, 19);
			this._nb_lbl.TabIndex = 4;
			this._nb_lbl.Text = "4";
			this._nb_lbl.UseCustomBackColor = true;
			this._nb_lbl.UseCustomForeColor = true;
			this._nb_lbl.UseStyleColors = true;
			// 
			// _nb_track
			// 
			this._nb_track.BackColor = System.Drawing.Color.Transparent;
			this._nb_track.Location = new System.Drawing.Point(34, 130);
			this._nb_track.Maximum = 10;
			this._nb_track.Minimum = 2;
			this._nb_track.Name = "_nb_track";
			this._nb_track.Size = new System.Drawing.Size(167, 23);
			this._nb_track.Style = MetroFramework.MetroColorStyle.Blue;
			this._nb_track.TabIndex = 3;
			this._nb_track.Theme = MetroFramework.MetroThemeStyle.Light;
			this._nb_track.UseCustomBackColor = true;
			this._nb_track.Value = 4;
			this._nb_track.ValueChanged += new System.EventHandler(this._nb_track_ValueChanged);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel2.ForeColor = System.Drawing.Color.White;
			this.metroLabel2.Location = new System.Drawing.Point(34, 104);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(127, 19);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "Number of seats :";
			this.metroLabel2.UseCustomBackColor = true;
			this.metroLabel2.UseCustomForeColor = true;
			this.metroLabel2.UseStyleColors = true;
			// 
			// _idtbl_txt
			// 
			this._idtbl_txt.Location = new System.Drawing.Point(34, 69);
			this._idtbl_txt.Mask = "00000";
			this._idtbl_txt.Name = "_idtbl_txt";
			this._idtbl_txt.Size = new System.Drawing.Size(196, 23);
			this._idtbl_txt.TabIndex = 1;
			this._idtbl_txt.ValidatingType = typeof(int);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.ForeColor = System.Drawing.Color.White;
			this.metroLabel1.Location = new System.Drawing.Point(34, 46);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(71, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Table ID :";
			this.metroLabel1.UseCustomBackColor = true;
			this.metroLabel1.UseCustomForeColor = true;
			this.metroLabel1.UseStyleColors = true;
			// 
			// _tables_gv
			// 
			this._tables_gv.AllowUserToAddRows = false;
			this._tables_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
			this._tables_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this._tables_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._tables_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._tables_gv.BackgroundColor = System.Drawing.Color.White;
			this._tables_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._tables_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkGoldenrod;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._tables_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this._tables_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._tables_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_table,
            this.numberchair,
            this.size_table,
            this.del});
			this._tables_gv.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this._tables_gv.DefaultCellStyle = dataGridViewCellStyle18;
			this._tables_gv.Dock = System.Windows.Forms.DockStyle.Right;
			this._tables_gv.DoubleBuffered = true;
			this._tables_gv.EnableHeadersVisualStyles = false;
			this._tables_gv.GridColor = System.Drawing.Color.White;
			this._tables_gv.HeaderBgColor = System.Drawing.Color.DarkGoldenrod;
			this._tables_gv.HeaderForeColor = System.Drawing.Color.White;
			this._tables_gv.Location = new System.Drawing.Point(319, 0);
			this._tables_gv.MultiSelect = false;
			this._tables_gv.Name = "_tables_gv";
			this._tables_gv.ReadOnly = true;
			this._tables_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._tables_gv.Size = new System.Drawing.Size(579, 479);
			this._tables_gv.TabIndex = 3;
			this._tables_gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._tables_gv_CellContentClick);
			// 
			// id_table
			// 
			this.id_table.DataPropertyName = "id_table";
			this.id_table.HeaderText = "Table ID";
			this.id_table.Name = "id_table";
			this.id_table.ReadOnly = true;
			// 
			// numberchair
			// 
			this.numberchair.DataPropertyName = "numberchair";
			this.numberchair.HeaderText = "Number of seats";
			this.numberchair.Name = "numberchair";
			this.numberchair.ReadOnly = true;
			// 
			// size_table
			// 
			this.size_table.DataPropertyName = "size_table";
			this.size_table.HeaderText = "Size";
			this.size_table.Name = "size_table";
			this.size_table.ReadOnly = true;
			// 
			// del
			// 
			this.del.DataPropertyName = "del";
			this.del.HeaderText = "Delete";
			this.del.Name = "del";
			this.del.ReadOnly = true;
			this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetFiltrageToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(145, 70);
			// 
			// resetFiltrageToolStripMenuItem
			// 
			this.resetFiltrageToolStripMenuItem.Name = "resetFiltrageToolStripMenuItem";
			this.resetFiltrageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.resetFiltrageToolStripMenuItem.Text = "Reset Filtrage";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.closeToolStripMenuItem.Text = "Reflesh";
			// 
			// closeToolStripMenuItem1
			// 
			this.closeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandToolStripMenuItem,
            this.deliveryToolStripMenuItem,
            this.serveurToolStripMenuItem,
            this.couponToolStripMenuItem,
            this.cuisinerToolStripMenuItem});
			this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
			this.closeToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
			this.closeToolStripMenuItem1.Text = "New";
			// 
			// commandToolStripMenuItem
			// 
			this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
			this.commandToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.commandToolStripMenuItem.Text = "Command";
			// 
			// deliveryToolStripMenuItem
			// 
			this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
			this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.deliveryToolStripMenuItem.Text = "Delivery";
			// 
			// serveurToolStripMenuItem
			// 
			this.serveurToolStripMenuItem.Name = "serveurToolStripMenuItem";
			this.serveurToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.serveurToolStripMenuItem.Text = "Serveur";
			// 
			// couponToolStripMenuItem
			// 
			this.couponToolStripMenuItem.Name = "couponToolStripMenuItem";
			this.couponToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.couponToolStripMenuItem.Text = "Coupon";
			// 
			// cuisinerToolStripMenuItem
			// 
			this.cuisinerToolStripMenuItem.Name = "cuisinerToolStripMenuItem";
			this.cuisinerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.cuisinerToolStripMenuItem.Text = "Cuisiner";
			// 
			// MangementCmd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this._Tab_Main);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MangementCmd";
			this.Size = new System.Drawing.Size(941, 579);
			this.Load += new System.EventHandler(this.MangementCmd_Load);
			this._Tab_Main.ResumeLayout(false);
			this._Delivery_Tab.ResumeLayout(false);
			this._Delivery_Tab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._cmd_gv)).EndInit();
			this._cmd_Tab.ResumeLayout(false);
			this._cmd_Tab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._deliv_gv)).EndInit();
			this._graphics_Tab.ResumeLayout(false);
			this._graphics_Tab.PerformLayout();
			this._tables_tab.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._tables_gv)).EndInit();
			this.metroContextMenu1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl _Tab_Main;
        private MetroFramework.Controls.MetroTabPage _cmd_Tab;
        private MetroFramework.Controls.MetroTabPage _Delivery_Tab;
        private MetroFramework.Controls.MetroTabPage _graphics_Tab;
        private XanderUI.XUIBarGraph xuiBarGraph1;
        private XanderUI.XUIBarGraph xuiBarGraph2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _Total_lbl;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem resetFiltrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serveurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couponToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuisinerToolStripMenuItem;
		private Bunifu.Framework.UI.BunifuCustomDataGrid _cmd_gv;
		private Bunifu.Framework.UI.BunifuCustomDataGrid _deliv_gv;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_deliv;
		private System.Windows.Forms.DataGridViewTextBoxColumn date_deliv;
		private System.Windows.Forms.DataGridViewTextBoxColumn heure_deliv;
		private System.Windows.Forms.DataGridViewTextBoxColumn price_total;
		private System.Windows.Forms.DataGridViewTextBoxColumn price_reduction;
		private System.Windows.Forms.DataGridViewTextBoxColumn net_payer;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_manger;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_cuisiner;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_deliverer;
		private MetroFramework.Controls.MetroComboBox _typSearch_cmb;
		private MetroFramework.Controls.MetroTextBox _search_txt;
		private MetroFramework.Controls.MetroTabPage _tables_tab;
		private System.Windows.Forms.Label _info_lbl;
		private System.Windows.Forms.Label _deliv_lbl;
		private MetroFramework.Controls.MetroTextBox Sear_deliv_txt;
		private MetroFramework.Controls.MetroComboBox _deliv_typ_cmb;
		private Bunifu.Framework.UI.BunifuCustomDataGrid _tables_gv;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_table;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberchair;
		private System.Windows.Forms.DataGridViewTextBoxColumn size_table;
		private System.Windows.Forms.DataGridViewButtonColumn del;
		private System.Windows.Forms.Panel panel1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.MaskedTextBox _idtbl_txt;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTrackBar _nb_track;
		private MetroFramework.Controls.MetroLabel _nb_lbl;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private Bunifu.Framework.UI.BunifuDropdown _dropdown_size;
		private MetroFramework.Controls.MetroButton _Add_btn;
	}
}
