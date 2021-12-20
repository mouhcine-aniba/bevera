using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevera_System
{
	public partial class LogsForm : MetroFramework.Forms.MetroForm
	{
		public LogsForm()
		{
			dt = new DataTable();
			InitializeComponent();
		}
		DataTable dt;
		void getData ()
		{
			dt = new MyTools().GetDataTable("Select * from logs");
			_histo_gv.DataSource = dt;
		}
		private void LogsForm_Load(object sender, EventArgs e)
		{
			getData();
		}

		
	}
}
