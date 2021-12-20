using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Bevera_System
{
    public partial class MangementCmd : UserControl
    {
        public MangementCmd()
        {
            InitializeComponent();
			
        }
		DataView Commands,Deliveries;
		DataTable __Tables__;
		void getTables ()
		{
			DataTable _deliveryData;
			DataTable _CommandData;
			MyTools t = new MyTools();
			_CommandData= t.GetDataTable("SELECT id_cmd as IDCommand, dt_cmd || ' | ' ||  hr_cmd as Timing,  net_payer as TOTAL, id_manger as Manger	FROM command");
			_deliveryData= t.GetDataTable("Select * from delivery");
			Commands = new DataView(_CommandData);
			Deliveries = new DataView(_deliveryData);
			
		}

		void getTabls()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"select * , 'Delete' as del from Bv_Table";
				
				__Tables__ = tool.GetDataTable(Query);
				
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}


		/*
		 * 
		 * Select dt_cmd , sum(net_payer) from Command
group by dt_cmd
		  */
		private void MangementCmd_Load(object sender, EventArgs e)
        {
			try
			{
				Thread th = new Thread(getTabls);
				th.Start();
				getTables();
				_cmd_gv.DataSource = Commands;
				_deliv_gv.DataSource = Deliveries;
				_info_lbl.Text = "Count Command is : " + Commands.Count;

				_search_txt.ButtonClick += delegate
				{
					
					if (_typSearch_cmb.SelectedItem.ToString() == "Command ID")
						Commands.RowFilter = String.Format("IDCommand LIKE '%{0}%'", _search_txt.Text);
					else if(_typSearch_cmb.SelectedItem.ToString() == "Date")
						Commands.RowFilter = String.Format("Timing LIKE '%{0}%'", _search_txt.Text);
					else
						Commands.RowFilter = String.Format("Manger LIKE '%{0}%'", _search_txt.Text);

					_info_lbl.Text = "the list is filtred ... the count is :  " + Commands.Count;
					if(_search_txt.Text == String.Empty)
						_info_lbl.Text = "Count Command is : " + Commands.Count;

				};
				Sear_deliv_txt.ButtonClick += delegate
				{
					try
					{

					if (_deliv_typ_cmb.SelectedItem.ToString() == "Delivery ID")
						Deliveries.RowFilter = String.Format("id_deliv LIKE '%{0}%'", Sear_deliv_txt.Text);
					else if (_deliv_typ_cmb.SelectedItem.ToString() == "Date")
						Deliveries.RowFilter = String.Format("date_deliv = '%{0}%'", Sear_deliv_txt.Text);
					else if (_deliv_typ_cmb.SelectedItem.ToString() == "Deliverer")
						Deliveries.RowFilter = String.Format("id_deliverer LIKE '%{0}%'", Sear_deliv_txt.Text);
					else
						Deliveries.RowFilter = String.Format("id_Manger LIKE '%{0}%'", Sear_deliv_txt.Text);

					_deliv_lbl.Text = "the list is filtred ... the count is :  " + Deliveries.Count;
					if (_search_txt.Text == String.Empty)
						_deliv_lbl.Text = "Count Command is : " + Deliveries.Count;

					}
					catch (Exception ex)
					{
						MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
					}
				};

				_tables_gv.DataSource = __Tables__;

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}


	
		private void _cmd_gv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				CommandDetaills cmdDetaill = new CommandDetaills(_cmd_gv.Rows[e.RowIndex].Cells[0].Value.ToString(),"CMD");
				cmdDetaill.ShowDialog();
				cmdDetaill.BringToFront();
			}
		}

	
		private void _search_txt_KeyUp(object sender, EventArgs e)
		{
			try
			{

			
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

	
		private void _tables_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

			
			if(e.ColumnIndex == 3)
			{
				if (new MyTools().NonQuery($"Delete from bv_table where id_table = {int.Parse(_tables_gv.Rows[e.RowIndex].Cells[0].Value.ToString())}") > 0)
				{
					getTabls();
					_tables_gv.DataSource = __Tables__;
						MyTools.Alert("the table is deleted with succesfully", Form_Alert.enmType.Success);
				}
				else
					throw new Exception("Something wrong ... please try again");
			}
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void _nb_track_ValueChanged(object sender, EventArgs e)
		{
			_nb_lbl.Text = _nb_track.Value.ToString();
		}

		private void _Add_btn_Click(object sender, EventArgs e)
		{
			try
			{

			String size = _dropdown_size.selectedValue != null ? _dropdown_size.selectedValue : "Medium";
			int id = int.Parse(_idtbl_txt.Text);
			int nb = int.Parse(_nb_lbl.Text);
			String query = $"Insert into bv_table VALUES({id},{nb}, '{size}')";
			if (new MyTools().NonQuery(query) > 0)
			{
					getTables();
					_tables_gv.DataSource = __Tables__;
					MyTools.Alert("new Table Added ID : " + id, Form_Alert.enmType.Success);
					_idtbl_txt.Text = "";
					_dropdown_size.selectedIndex = -1;
					_nb_track.Value = 4;
			}
			else
				throw new Exception("Something wrong ... try again");

			}
			catch(Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void _deliv_gv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				CommandDetaills cmdDetaill = new CommandDetaills(_deliv_gv.Rows[e.RowIndex].Cells[0].Value.ToString(), "Deliv");
				cmdDetaill.ShowDialog();
				cmdDetaill.BringToFront();
			}
		}
	}
}
