using System;
using System.Data;

using System.Windows.Forms;

namespace Bevera_System
{
    public partial class ManagementReservation : UserControl
    {
        public ManagementReservation()
        {
            InitializeComponent();
			
        }
		DataView __passed, __notPassed, __today;
		DataTable _passed, _notPassed, _today;

		private void _n_search_Click(object sender, EventArgs e)
		{
			__notPassed.RowFilter = String.Format("date_reserv > #{0}# AND date_reserv < #{1}#", _n_min.Value, _n_max.Value);

		}

		private void metroContextMenu1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void filterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			__notPassed.RowFilter = __today.RowFilter = __passed.RowFilter = "";
		}

		private void _t_search_Click(object sender, EventArgs e)
		{
			__today.RowFilter = String.Format("date_reserv > #{0}# AND date_reserv < #{1}#", _t_min.Value, _t_max.Value);

		}

		private void _p_search_Click(object sender, EventArgs e)
		{

			__passed.RowFilter = String.Format("date_reserv > #{0}# AND date_reserv < #{1}#", _p_min.Value,_p_max.Value);
		}

		void getTables()
		{
			_passed = new MyTools().GetDataTable("Select * from Reservation where date_reserv < CURRENT_DATE");
			_notPassed = new MyTools().GetDataTable("Select * from Reservation where date_reserv > CURRENT_DATE");
			_today = new MyTools().GetDataTable("Select * from Reservation where date_reserv = CURRENT_DATE" );
		}
		
		private void MangementCmd_Load(object sender, EventArgs e)
        {
			try
			{
				getTables();
				__passed = new DataView(_passed);
				__notPassed = new DataView(_notPassed);
				__today = new DataView(_today);
				_not_gv.DataSource = __notPassed;
				_passed_gv.DataSource = __passed;
				_today_gv.DataSource = __today;
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
			
		}



		
	}
}
