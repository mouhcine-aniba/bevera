namespace Bevera_System
{
	partial class LogsForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this._histo_gv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.heure_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			((System.ComponentModel.ISupportInitialize)(this._histo_gv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// _histo_gv
			// 
			this._histo_gv.AllowUserToAddRows = false;
			this._histo_gv.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
			this._histo_gv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this._histo_gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._histo_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._histo_gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this._histo_gv.BackgroundColor = System.Drawing.Color.Gainsboro;
			this._histo_gv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._histo_gv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(7);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._histo_gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this._histo_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._histo_gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.msg,
            this.date,
            this.heure_log});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this._histo_gv.DefaultCellStyle = dataGridViewCellStyle7;
			this._histo_gv.DoubleBuffered = true;
			this._histo_gv.EnableHeadersVisualStyles = false;
			this._histo_gv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(181)))));
			this._histo_gv.HeaderForeColor = System.Drawing.Color.White;
			this._histo_gv.Location = new System.Drawing.Point(23, 89);
			this._histo_gv.Name = "_histo_gv";
			this._histo_gv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(9);
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._histo_gv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this._histo_gv.RowHeadersWidth = 60;
			this._histo_gv.Size = new System.Drawing.Size(742, 313);
			this._histo_gv.TabIndex = 1;
			// 
			// id
			// 
			this.id.DataPropertyName = "code_log";
			this.id.HeaderText = "id";
			this.id.Name = "id";
			// 
			// msg
			// 
			this.msg.DataPropertyName = "message_log";
			this.msg.HeaderText = "Message";
			this.msg.Name = "msg";
			// 
			// date
			// 
			this.date.DataPropertyName = "date_event";
			this.date.HeaderText = "date";
			this.date.Name = "date";
			// 
			// heure_log
			// 
			this.heure_log.DataPropertyName = "heure_event";
			this.heure_log.HeaderText = "heure";
			this.heure_log.Name = "heure_log";
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
			this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton1.Image = global::Bevera_System.Properties.Resources.icons8_refresh_64;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(727, 46);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(38, 37);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 2;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			// 
			// LogsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bunifuImageButton1);
			this.Controls.Add(this._histo_gv);
			this.HelpButton = true;
			this.Name = "LogsForm";
			this.Text = "Logs Form";
			this.Load += new System.EventHandler(this.LogsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this._histo_gv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid _histo_gv;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn msg;
		private System.Windows.Forms.DataGridViewTextBoxColumn date;
		private System.Windows.Forms.DataGridViewTextBoxColumn heure_log;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
	}
}