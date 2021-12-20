namespace Bevera_System
{
    partial class New_Dilvery
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this._cuisiner_cmb = new MetroFramework.Controls.MetroComboBox();
			this._row_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.IDprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.n_prd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qtte = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
			this.priceUt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._deliv_cmb = new MetroFramework.Controls.MetroComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this._valid_reduc_btn = new MetroFramework.Controls.MetroButton();
			this._reduc_txt = new System.Windows.Forms.TextBox();
			this._coupon_rd = new System.Windows.Forms.RadioButton();
			this._value_rd = new System.Windows.Forms.RadioButton();
			this._per_rd = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this._Total_lbl = new System.Windows.Forms.Label();
			this._id_generate_lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.totFinal_lbl = new System.Windows.Forms.Label();
			this._red_lbl = new System.Windows.Forms.Label();
			this.prod_cmb = new MetroFramework.Controls.MetroComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this._add_btn = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this._row_gv)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(42, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Product Infos :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(71, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Product :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(73, 410);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 18);
			this.label7.TabIndex = 13;
			this.label7.Text = "Cuisinier:";
			// 
			// _cuisiner_cmb
			// 
			this._cuisiner_cmb.BackColor = System.Drawing.Color.White;
			this._cuisiner_cmb.ForeColor = System.Drawing.Color.Black;
			this._cuisiner_cmb.FormattingEnabled = true;
			this._cuisiner_cmb.ItemHeight = 23;
			this._cuisiner_cmb.Location = new System.Drawing.Point(76, 447);
			this._cuisiner_cmb.Name = "_cuisiner_cmb";
			this._cuisiner_cmb.PromptText = "Cuisinier Name";
			this._cuisiner_cmb.Size = new System.Drawing.Size(273, 29);
			this._cuisiner_cmb.TabIndex = 20;
			this._cuisiner_cmb.UseCustomBackColor = true;
			this._cuisiner_cmb.UseCustomForeColor = true;
			this._cuisiner_cmb.UseSelectable = true;
			this._cuisiner_cmb.UseStyleColors = true;
			// 
			// _row_gv
			// 
			this._row_gv.AllowUserToAddRows = false;
			this._row_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this._row_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this._row_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._row_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._row_gv.BackgroundColor = System.Drawing.Color.White;
			this._row_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._row_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._row_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this._row_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._row_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDprod,
            this.n_prd,
            this.Qtte,
            this.priceUt,
            this.Delete,
            this.total});
			this._row_gv.DoubleBuffered = true;
			this._row_gv.EnableHeadersVisualStyles = false;
			this._row_gv.GridColor = System.Drawing.Color.White;
			this._row_gv.HeaderBgColor = System.Drawing.Color.CadetBlue;
			this._row_gv.HeaderForeColor = System.Drawing.Color.White;
			this._row_gv.Location = new System.Drawing.Point(13, 203);
			this._row_gv.Name = "_row_gv";
			this._row_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this._row_gv.Size = new System.Drawing.Size(409, 182);
			this._row_gv.TabIndex = 25;
			this._row_gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._row_gv_CellContentClick);
			this._row_gv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._row_gv_CellValueChanged);
			// 
			// IDprod
			// 
			this.IDprod.HeaderText = "ID Product";
			this.IDprod.Name = "IDprod";
			this.IDprod.ReadOnly = true;
			// 
			// n_prd
			// 
			this.n_prd.HeaderText = "Product name";
			this.n_prd.Name = "n_prd";
			this.n_prd.ReadOnly = true;
			// 
			// Qtte
			// 
			this.Qtte.HeaderText = "Qtte";
			this.Qtte.Name = "Qtte";
			this.Qtte.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Qtte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Qtte.ThousandsSeparator = true;
			// 
			// priceUt
			// 
			this.priceUt.HeaderText = "Price";
			this.priceUt.Name = "priceUt";
			this.priceUt.ReadOnly = true;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			this.Delete.Text = "Delete";
			// 
			// total
			// 
			this.total.DataPropertyName = "total";
			this.total.HeaderText = "Total";
			this.total.Name = "total";
			// 
			// _deliv_cmb
			// 
			this._deliv_cmb.BackColor = System.Drawing.Color.White;
			this._deliv_cmb.ForeColor = System.Drawing.Color.Black;
			this._deliv_cmb.FormattingEnabled = true;
			this._deliv_cmb.ItemHeight = 23;
			this._deliv_cmb.Location = new System.Drawing.Point(546, 105);
			this._deliv_cmb.Name = "_deliv_cmb";
			this._deliv_cmb.PromptText = "Deliverer Name";
			this._deliv_cmb.Size = new System.Drawing.Size(281, 29);
			this._deliv_cmb.TabIndex = 46;
			this._deliv_cmb.UseCustomBackColor = true;
			this._deliv_cmb.UseCustomForeColor = true;
			this._deliv_cmb.UseSelectable = true;
			this._deliv_cmb.UseStyleColors = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label11.Location = new System.Drawing.Point(544, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 18);
			this.label11.TabIndex = 45;
			this.label11.Text = "Deliverer :";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this._valid_reduc_btn);
			this.panel2.Controls.Add(this._reduc_txt);
			this.panel2.Controls.Add(this._coupon_rd);
			this.panel2.Controls.Add(this._value_rd);
			this.panel2.Controls.Add(this._per_rd);
			this.panel2.Location = new System.Drawing.Point(546, 157);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(320, 108);
			this.panel2.TabIndex = 71;
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this._Total_lbl);
			this.panel1.Controls.Add(this._id_generate_lbl);
			this.panel1.Controls.Add(this.totFinal_lbl);
			this.panel1.Controls.Add(this._red_lbl);
			this.panel1.Location = new System.Drawing.Point(546, 271);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(323, 150);
			this.panel1.TabIndex = 72;
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
			// prod_cmb
			// 
			this.prod_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.prod_cmb.FormattingEnabled = true;
			this.prod_cmb.ItemHeight = 23;
			this.prod_cmb.Location = new System.Drawing.Point(74, 135);
			this.prod_cmb.Name = "prod_cmb";
			this.prod_cmb.PromptText = "Product name";
			this.prod_cmb.Size = new System.Drawing.Size(275, 29);
			this.prod_cmb.TabIndex = 73;
			this.prod_cmb.UseSelectable = true;
			this.prod_cmb.SelectionChangeCommitted += new System.EventHandler(this.prod_cmb_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(675, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 44);
			this.label2.TabIndex = 3;
			this.label2.Text = "New dilivery";
			// 
			// metroButton2
			// 
			this.metroButton2.BackColor = System.Drawing.Color.White;
			this.metroButton2.ForeColor = System.Drawing.Color.Red;
			this.metroButton2.Highlight = true;
			this.metroButton2.Location = new System.Drawing.Point(534, 470);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(115, 48);
			this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
			this.metroButton2.TabIndex = 77;
			this.metroButton2.Text = "Cancel";
			this.metroButton2.UseCustomBackColor = true;
			this.metroButton2.UseCustomForeColor = true;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.UseStyleColors = true;
			// 
			// _add_btn
			// 
			this._add_btn.BackColor = System.Drawing.Color.Teal;
			this._add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this._add_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
			this._add_btn.ForeColor = System.Drawing.Color.White;
			this._add_btn.Highlight = true;
			this._add_btn.Location = new System.Drawing.Point(655, 470);
			this._add_btn.Name = "_add_btn";
			this._add_btn.Size = new System.Drawing.Size(199, 48);
			this._add_btn.Style = MetroFramework.MetroColorStyle.Teal;
			this._add_btn.TabIndex = 76;
			this._add_btn.Text = "Verify";
			this._add_btn.UseCustomBackColor = true;
			this._add_btn.UseCustomForeColor = true;
			this._add_btn.UseSelectable = true;
			this._add_btn.UseStyleColors = true;
			this._add_btn.Click += new System.EventHandler(this._add_btn_Click);
			// 
			// New_Dilvery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Bevera_System.Properties.Resources.benim_1_01;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this._add_btn);
			this.Controls.Add(this.prod_cmb);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this._deliv_cmb);
			this.Controls.Add(this.label11);
			this.Controls.Add(this._row_gv);
			this.Controls.Add(this._cuisiner_cmb);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Location = new System.Drawing.Point(245, 59);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "New_Dilvery";
			this.Size = new System.Drawing.Size(941, 579);
			this.Load += new System.EventHandler(this.New_Dilvery_Load);
			((System.ComponentModel.ISupportInitialize)(this._row_gv)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox _cuisiner_cmb;
        private Bunifu.Framework.UI.BunifuCustomDataGrid _row_gv;
        private MetroFramework.Controls.MetroComboBox _deliv_cmb;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel2;
		private MetroFramework.Controls.MetroButton _valid_reduc_btn;
		private System.Windows.Forms.TextBox _reduc_txt;
		private System.Windows.Forms.RadioButton _coupon_rd;
		private System.Windows.Forms.RadioButton _value_rd;
		private System.Windows.Forms.RadioButton _per_rd;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label _Total_lbl;
		private Bunifu.Framework.UI.BunifuCustomLabel _id_generate_lbl;
		private System.Windows.Forms.Label totFinal_lbl;
		private System.Windows.Forms.Label _red_lbl;
		private MetroFramework.Controls.MetroComboBox prod_cmb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDprod;
		private System.Windows.Forms.DataGridViewTextBoxColumn n_prd;
		private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Qtte;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceUt;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton _add_btn;
	}
}
