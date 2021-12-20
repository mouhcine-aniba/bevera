namespace Bevera_System
{
    partial class NewCommande
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCommande));
			this._row_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.qtte = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DelBtn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._serv_cmb = new MetroFramework.Controls.MetroComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this._csiner_cmb = new MetroFramework.Controls.MetroComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this._add_link = new MetroFramework.Controls.MetroLink();
			this._cancel_btn = new Bunifu.Framework.UI.BunifuThinButton2();
			this._ok_btn = new Bunifu.Framework.UI.BunifuThinButton2();
			this._red_lbl = new System.Windows.Forms.Label();
			this.totFinal_lbl = new System.Windows.Forms.Label();
			this._Total_lbl = new System.Windows.Forms.Label();
			this._id_generate_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.label9 = new System.Windows.Forms.Label();
			this._table_cmb = new MetroFramework.Controls.MetroComboBox();
			this._prod_cmb = new MetroFramework.Controls.MetroComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this._valid_reduc_btn = new MetroFramework.Controls.MetroButton();
			this._reduc_txt = new System.Windows.Forms.TextBox();
			this._coupon_rd = new System.Windows.Forms.RadioButton();
			this._value_rd = new System.Windows.Forms.RadioButton();
			this._per_rd = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this._add_btn = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this._row_gv)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _row_gv
			// 
			this._row_gv.AllowUserToAddRows = false;
			this._row_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this._row_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this._row_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._row_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._row_gv.BackgroundColor = System.Drawing.Color.White;
			this._row_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._row_gv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
			this._row_gv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this._row_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Chocolate;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._row_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this._row_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._row_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameprod,
            this.qtte,
            this.price,
            this.DelBtn,
            this.total});
			this._row_gv.DoubleBuffered = true;
			this._row_gv.EnableHeadersVisualStyles = false;
			this._row_gv.GridColor = System.Drawing.Color.White;
			this._row_gv.HeaderBgColor = System.Drawing.Color.Chocolate;
			this._row_gv.HeaderForeColor = System.Drawing.Color.White;
			this._row_gv.Location = new System.Drawing.Point(19, 227);
			this._row_gv.Name = "_row_gv";
			this._row_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._row_gv.RowHeadersWidth = 20;
			this._row_gv.Size = new System.Drawing.Size(437, 158);
			this._row_gv.TabIndex = 35;
			this._row_gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._row_gv_CellContentClick);
			this._row_gv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._row_gv_CellValueChanged);
			this._row_gv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this._row_gv_RowsRemoved);
			// 
			// id
			// 
			this.id.DataPropertyName = "id_prod";
			this.id.HeaderText = "Id Product";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// nameprod
			// 
			this.nameprod.DataPropertyName = "name_prod";
			this.nameprod.HeaderText = "name";
			this.nameprod.Name = "nameprod";
			this.nameprod.ReadOnly = true;
			// 
			// qtte
			// 
			this.qtte.DataPropertyName = "qt";
			dataGridViewCellStyle13.Format = "N0";
			dataGridViewCellStyle13.NullValue = "1";
			this.qtte.DefaultCellStyle = dataGridViewCellStyle13;
			this.qtte.HeaderText = "Qtte";
			this.qtte.Name = "qtte";
			this.qtte.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.qtte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.qtte.ThousandsSeparator = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "price_vente";
			this.price.HeaderText = "price";
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// DelBtn
			// 
			this.DelBtn.DataPropertyName = "del";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
			this.DelBtn.DefaultCellStyle = dataGridViewCellStyle14;
			this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DelBtn.HeaderText = "Delete";
			this.DelBtn.Name = "DelBtn";
			this.DelBtn.Text = "Delete";
			// 
			// total
			// 
			this.total.DataPropertyName = "TotL";
			dataGridViewCellStyle15.Format = "N2";
			dataGridViewCellStyle15.NullValue = null;
			this.total.DefaultCellStyle = dataGridViewCellStyle15;
			this.total.HeaderText = "Total";
			this.total.Name = "total";
			this.total.ReadOnly = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Location = new System.Drawing.Point(69, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 16);
			this.label4.TabIndex = 28;
			this.label4.Text = "Product :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Chocolate;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(49, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 24);
			this.label1.TabIndex = 29;
			this.label1.Text = "Product Infos :";
			// 
			// _serv_cmb
			// 
			this._serv_cmb.BackColor = System.Drawing.Color.White;
			this._serv_cmb.ForeColor = System.Drawing.Color.Black;
			this._serv_cmb.FormattingEnabled = true;
			this._serv_cmb.ItemHeight = 23;
			this._serv_cmb.Location = new System.Drawing.Point(632, 146);
			this._serv_cmb.Name = "_serv_cmb";
			this._serv_cmb.PromptText = "Serveur Name";
			this._serv_cmb.Size = new System.Drawing.Size(221, 29);
			this._serv_cmb.TabIndex = 46;
			this._serv_cmb.UseCustomBackColor = true;
			this._serv_cmb.UseCustomForeColor = true;
			this._serv_cmb.UseSelectable = true;
			this._serv_cmb.UseStyleColors = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(542, 149);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(68, 16);
			this.label11.TabIndex = 45;
			this.label11.Text = " Serveur :";
			// 
			// _csiner_cmb
			// 
			this._csiner_cmb.BackColor = System.Drawing.Color.White;
			this._csiner_cmb.ForeColor = System.Drawing.Color.Black;
			this._csiner_cmb.FormattingEnabled = true;
			this._csiner_cmb.ItemHeight = 23;
			this._csiner_cmb.Location = new System.Drawing.Point(632, 98);
			this._csiner_cmb.Name = "_csiner_cmb";
			this._csiner_cmb.PromptText = "Cuisinier Name";
			this._csiner_cmb.Size = new System.Drawing.Size(221, 29);
			this._csiner_cmb.TabIndex = 48;
			this._csiner_cmb.UseCustomBackColor = true;
			this._csiner_cmb.UseCustomForeColor = true;
			this._csiner_cmb.UseSelectable = true;
			this._csiner_cmb.UseStyleColors = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(542, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 16);
			this.label7.TabIndex = 47;
			this.label7.Text = "Cuisinier:";
			// 
			// _add_link
			// 
			this._add_link.DisplayFocus = true;
			this._add_link.FontSize = MetroFramework.MetroLinkSize.Medium;
			this._add_link.ForeColor = System.Drawing.Color.Chocolate;
			this._add_link.Location = new System.Drawing.Point(106, 166);
			this._add_link.Name = "_add_link";
			this._add_link.Size = new System.Drawing.Size(322, 23);
			this._add_link.Style = MetroFramework.MetroColorStyle.Teal;
			this._add_link.TabIndex = 58;
			this._add_link.Text = "Add Product";
			this._add_link.UseCustomForeColor = true;
			this._add_link.UseSelectable = true;
			this._add_link.UseStyleColors = true;
			this._add_link.Click += new System.EventHandler(this._add_link_Click);
			// 
			// _cancel_btn
			// 
			this._cancel_btn.ActiveBorderThickness = 3;
			this._cancel_btn.ActiveCornerRadius = 4;
			this._cancel_btn.ActiveFillColor = System.Drawing.Color.White;
			this._cancel_btn.ActiveForecolor = System.Drawing.Color.Red;
			this._cancel_btn.ActiveLineColor = System.Drawing.Color.Red;
			this._cancel_btn.BackColor = System.Drawing.SystemColors.WindowText;
			this._cancel_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_cancel_btn.BackgroundImage")));
			this._cancel_btn.ButtonText = "Cancel";
			this._cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._cancel_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._cancel_btn.ForeColor = System.Drawing.Color.SeaGreen;
			this._cancel_btn.IdleBorderThickness = 1;
			this._cancel_btn.IdleCornerRadius = 30;
			this._cancel_btn.IdleFillColor = System.Drawing.Color.Red;
			this._cancel_btn.IdleForecolor = System.Drawing.Color.White;
			this._cancel_btn.IdleLineColor = System.Drawing.Color.White;
			this._cancel_btn.Location = new System.Drawing.Point(647, 591);
			this._cancel_btn.Margin = new System.Windows.Forms.Padding(7);
			this._cancel_btn.Name = "_cancel_btn";
			this._cancel_btn.Size = new System.Drawing.Size(227, 63);
			this._cancel_btn.TabIndex = 25;
			this._cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _ok_btn
			// 
			this._ok_btn.ActiveBorderThickness = 1;
			this._ok_btn.ActiveCornerRadius = 4;
			this._ok_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this._ok_btn.ActiveForecolor = System.Drawing.Color.White;
			this._ok_btn.ActiveLineColor = System.Drawing.Color.Gold;
			this._ok_btn.BackColor = System.Drawing.SystemColors.WindowText;
			this._ok_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_ok_btn.BackgroundImage")));
			this._ok_btn.ButtonText = "Ok !";
			this._ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._ok_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._ok_btn.ForeColor = System.Drawing.Color.SeaGreen;
			this._ok_btn.IdleBorderThickness = 1;
			this._ok_btn.IdleCornerRadius = 30;
			this._ok_btn.IdleFillColor = System.Drawing.Color.White;
			this._ok_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
			this._ok_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
			this._ok_btn.Location = new System.Drawing.Point(887, 579);
			this._ok_btn.Margin = new System.Windows.Forms.Padding(7);
			this._ok_btn.Name = "_ok_btn";
			this._ok_btn.Size = new System.Drawing.Size(263, 80);
			this._ok_btn.TabIndex = 26;
			this._ok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _red_lbl
			// 
			this._red_lbl.AutoSize = true;
			this._red_lbl.BackColor = System.Drawing.Color.Transparent;
			this._red_lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._red_lbl.ForeColor = System.Drawing.Color.SeaGreen;
			this._red_lbl.Location = new System.Drawing.Point(163, 61);
			this._red_lbl.Name = "_red_lbl";
			this._red_lbl.Size = new System.Drawing.Size(102, 16);
			this._red_lbl.TabIndex = 60;
			this._red_lbl.Text = "Reduction Price";
			// 
			// totFinal_lbl
			// 
			this.totFinal_lbl.AutoSize = true;
			this.totFinal_lbl.BackColor = System.Drawing.Color.Transparent;
			this.totFinal_lbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totFinal_lbl.ForeColor = System.Drawing.Color.Black;
			this.totFinal_lbl.Location = new System.Drawing.Point(11, 99);
			this.totFinal_lbl.Name = "totFinal_lbl";
			this.totFinal_lbl.Size = new System.Drawing.Size(133, 28);
			this.totFinal_lbl.TabIndex = 61;
			this.totFinal_lbl.Text = "Total price";
			// 
			// _Total_lbl
			// 
			this._Total_lbl.AutoSize = true;
			this._Total_lbl.BackColor = System.Drawing.Color.Transparent;
			this._Total_lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._Total_lbl.ForeColor = System.Drawing.Color.Black;
			this._Total_lbl.Location = new System.Drawing.Point(14, 58);
			this._Total_lbl.Name = "_Total_lbl";
			this._Total_lbl.Size = new System.Drawing.Size(104, 22);
			this._Total_lbl.TabIndex = 62;
			this._Total_lbl.Text = "Total price";
			// 
			// _id_generate_lbl
			// 
			this._id_generate_lbl.AutoSize = true;
			this._id_generate_lbl.BackColor = System.Drawing.Color.Transparent;
			this._id_generate_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
			this._id_generate_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._id_generate_lbl.ForeColor = System.Drawing.Color.Black;
			this._id_generate_lbl.Location = new System.Drawing.Point(12, 11);
			this._id_generate_lbl.Name = "_id_generate_lbl";
			this._id_generate_lbl.Size = new System.Drawing.Size(225, 24);
			this._id_generate_lbl.TabIndex = 59;
			this._id_generate_lbl.Text = "Generate ID Delivery";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label9.Location = new System.Drawing.Point(101, 421);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 16);
			this.label9.TabIndex = 65;
			this.label9.Text = "Table :";
			// 
			// _table_cmb
			// 
			this._table_cmb.BackColor = System.Drawing.Color.White;
			this._table_cmb.ForeColor = System.Drawing.Color.Black;
			this._table_cmb.FormattingEnabled = true;
			this._table_cmb.ItemHeight = 23;
			this._table_cmb.Location = new System.Drawing.Point(181, 413);
			this._table_cmb.Name = "_table_cmb";
			this._table_cmb.PromptText = "Table";
			this._table_cmb.Size = new System.Drawing.Size(223, 29);
			this._table_cmb.TabIndex = 64;
			this._table_cmb.UseCustomBackColor = true;
			this._table_cmb.UseCustomForeColor = true;
			this._table_cmb.UseSelectable = true;
			this._table_cmb.UseStyleColors = true;
			// 
			// _prod_cmb
			// 
			this._prod_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this._prod_cmb.FormattingEnabled = true;
			this._prod_cmb.ItemHeight = 23;
			this._prod_cmb.Location = new System.Drawing.Point(155, 104);
			this._prod_cmb.Name = "_prod_cmb";
			this._prod_cmb.PromptText = "Products";
			this._prod_cmb.Size = new System.Drawing.Size(239, 29);
			this._prod_cmb.TabIndex = 68;
			this._prod_cmb.UseSelectable = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this._Total_lbl);
			this.panel1.Controls.Add(this._id_generate_lbl);
			this.panel1.Controls.Add(this.totFinal_lbl);
			this.panel1.Controls.Add(this._red_lbl);
			this.panel1.Location = new System.Drawing.Point(545, 310);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(323, 150);
			this.panel1.TabIndex = 69;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this._valid_reduc_btn);
			this.panel2.Controls.Add(this._reduc_txt);
			this.panel2.Controls.Add(this._coupon_rd);
			this.panel2.Controls.Add(this._value_rd);
			this.panel2.Controls.Add(this._per_rd);
			this.panel2.Location = new System.Drawing.Point(548, 193);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(320, 108);
			this.panel2.TabIndex = 70;
			// 
			// _valid_reduc_btn
			// 
			this._valid_reduc_btn.Location = new System.Drawing.Point(213, 69);
			this._valid_reduc_btn.Name = "_valid_reduc_btn";
			this._valid_reduc_btn.Size = new System.Drawing.Size(86, 23);
			this._valid_reduc_btn.Style = MetroFramework.MetroColorStyle.Green;
			this._valid_reduc_btn.TabIndex = 78;
			this._valid_reduc_btn.Text = "Valider";
			this._valid_reduc_btn.Theme = MetroFramework.MetroThemeStyle.Light;
			this._valid_reduc_btn.UseSelectable = true;
			this._valid_reduc_btn.Click += new System.EventHandler(this._valid_reduc_btn_Click);
			// 
			// _reduc_txt
			// 
			this._reduc_txt.Location = new System.Drawing.Point(23, 69);
			this._reduc_txt.Name = "_reduc_txt";
			this._reduc_txt.Size = new System.Drawing.Size(184, 23);
			this._reduc_txt.TabIndex = 77;
			// 
			// _coupon_rd
			// 
			this._coupon_rd.AutoSize = true;
			this._coupon_rd.Checked = true;
			this._coupon_rd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._coupon_rd.ForeColor = System.Drawing.Color.Black;
			this._coupon_rd.Location = new System.Drawing.Point(213, 22);
			this._coupon_rd.Name = "_coupon_rd";
			this._coupon_rd.Size = new System.Drawing.Size(86, 22);
			this._coupon_rd.TabIndex = 76;
			this._coupon_rd.TabStop = true;
			this._coupon_rd.Text = "Coupon";
			this._coupon_rd.UseVisualStyleBackColor = true;
			// 
			// _value_rd
			// 
			this._value_rd.AutoSize = true;
			this._value_rd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._value_rd.ForeColor = System.Drawing.Color.Black;
			this._value_rd.Location = new System.Drawing.Point(137, 22);
			this._value_rd.Name = "_value_rd";
			this._value_rd.Size = new System.Drawing.Size(70, 22);
			this._value_rd.TabIndex = 76;
			this._value_rd.Text = "Value";
			this._value_rd.UseVisualStyleBackColor = true;
			// 
			// _per_rd
			// 
			this._per_rd.AutoSize = true;
			this._per_rd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._per_rd.ForeColor = System.Drawing.Color.Black;
			this._per_rd.Location = new System.Drawing.Point(23, 22);
			this._per_rd.Name = "_per_rd";
			this._per_rd.Size = new System.Drawing.Size(108, 22);
			this._per_rd.TabIndex = 75;
			this._per_rd.Text = "Persentage";
			this._per_rd.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(704, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 44);
			this.label2.TabIndex = 73;
			this.label2.Text = "New Command";
			// 
			// _add_btn
			// 
			this._add_btn.BackColor = System.Drawing.Color.Teal;
			this._add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._add_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
			this._add_btn.ForeColor = System.Drawing.Color.White;
			this._add_btn.Highlight = true;
			this._add_btn.Location = new System.Drawing.Point(669, 490);
			this._add_btn.Name = "_add_btn";
			this._add_btn.Size = new System.Drawing.Size(199, 48);
			this._add_btn.Style = MetroFramework.MetroColorStyle.Teal;
			this._add_btn.TabIndex = 74;
			this._add_btn.Text = "Verify";
			this._add_btn.UseCustomBackColor = true;
			this._add_btn.UseCustomForeColor = true;
			this._add_btn.UseSelectable = true;
			this._add_btn.UseStyleColors = true;
			this._add_btn.Click += new System.EventHandler(this._add_btn_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.BackColor = System.Drawing.Color.White;
			this.metroButton2.ForeColor = System.Drawing.Color.Red;
			this.metroButton2.Highlight = true;
			this.metroButton2.Location = new System.Drawing.Point(548, 490);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(115, 48);
			this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
			this.metroButton2.TabIndex = 75;
			this.metroButton2.Text = "Cancel";
			this.metroButton2.UseCustomBackColor = true;
			this.metroButton2.UseCustomForeColor = true;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.UseStyleColors = true;
			// 
			// NewCommande
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this._add_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this._prod_cmb);
			this.Controls.Add(this.label9);
			this.Controls.Add(this._table_cmb);
			this.Controls.Add(this._add_link);
			this.Controls.Add(this._csiner_cmb);
			this.Controls.Add(this.label7);
			this.Controls.Add(this._serv_cmb);
			this.Controls.Add(this.label11);
			this.Controls.Add(this._row_gv);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._cancel_btn);
			this.Controls.Add(this._ok_btn);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NewCommande";
			this.Size = new System.Drawing.Size(941, 579);
			this.Load += new System.EventHandler(this.NewCommande_Load);
			((System.ComponentModel.ISupportInitialize)(this._row_gv)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 _cancel_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 _ok_btn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid _row_gv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox _serv_cmb;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroComboBox _csiner_cmb;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroLink _add_link;
		private System.Windows.Forms.Label _red_lbl;
		private System.Windows.Forms.Label totFinal_lbl;
		private System.Windows.Forms.Label _Total_lbl;
		private Bunifu.Framework.UI.BunifuCustomLabel _id_generate_lbl;
		private System.Windows.Forms.Label label9;
		private MetroFramework.Controls.MetroComboBox _table_cmb;
		private MetroFramework.Controls.MetroComboBox _prod_cmb;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton _value_rd;
		private System.Windows.Forms.RadioButton _per_rd;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameprod;
		private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn qtte;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewButtonColumn DelBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
		private System.Windows.Forms.RadioButton _coupon_rd;
		private System.Windows.Forms.TextBox _reduc_txt;
		private MetroFramework.Controls.MetroButton _valid_reduc_btn;
		private System.Windows.Forms.Label label2;
		private MetroFramework.Controls.MetroButton _add_btn;
		private MetroFramework.Controls.MetroButton metroButton2;
	}
}
