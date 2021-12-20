using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using static System.Int32;
namespace Bevera_System
{
	public partial class NewReservation : UserControl
	{
		public NewReservation()
		{
			InitializeComponent();
		}

		String Type = "";
		String id;
		void getTables()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"select * from Bv_Table";

				DataTable dt = tool.GetDataTable(Query);

				if (dt != null)
				{
					_table_cmb.DataSource = dt;
					_table_cmb.DisplayMember = "id_table";
					_table_cmb.ValueMember = "id_table";

				}

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}
		void DeselectAll()
		{
			_morning_.BannerColor = _afternn_.BannerColor = _3chiya_.BannerColor = _diner_.BannerColor = Color.RoyalBlue;
			_morning_.BorderColor = _afternn_.BorderColor = _3chiya_.BorderColor = _diner_.BorderColor = Color.White;
			_morning_.ForeColor = _afternn_.ForeColor = _3chiya_.ForeColor = _diner_.ForeColor = Color.White;

		}
		void GenerateID()
		{
			id = DateTime.Now.ToString("MMMM");
			id += "-" + new Random().Next(999, 9999);
			_id_generate_lbl.Text = id;
		}
		private void NewReservation_Load(object sender, EventArgs e)
		{
			getTables();
			GenerateID();

		}

		private void _people_trck_ValueChanged(object sender, EventArgs e)
		{
			_nb_lbl.Text = _people_trck.Value.ToString();
		}

		private void _morning__Click(object sender, EventArgs e)
		{
			DeselectAll();
			_morning_.BorderColor = Color.RoyalBlue;
			_morning_.BannerColor = Color.White;
			_morning_.ForeColor = Color.RoyalBlue;
			Type = _morning_.Text;
		}

		private void _afternn__Click(object sender, EventArgs e)
		{
			DeselectAll();
			_afternn_.BorderColor = Color.RoyalBlue;
			_afternn_.BannerColor = Color.White;
			_afternn_.ForeColor = Color.RoyalBlue;
			Type = _afternn_.Text;
		}

		private void _diner__Click(object sender, EventArgs e)
		{
			DeselectAll();
			_diner_.BorderColor = Color.RoyalBlue;
			_diner_.BannerColor = Color.White;
			_diner_.ForeColor = Color.RoyalBlue;
			Type = _diner_.Text;
		}

		private void _3chiya__Click(object sender, EventArgs e)
		{
			DeselectAll();
			_3chiya_.BorderColor = Color.RoyalBlue;
			_3chiya_.BannerColor = Color.White;
			_3chiya_.ForeColor = Color.RoyalBlue;
			Type = _3chiya_.Text;
		}



		private void _add_btn_Click(object sender, EventArgs e)
		{
			try
			{

			if (_add_btn.Text == "Verify")
			{
				//int idd = int.Parse(new MyTools().Scalar($"Select id_reserv from reservation " +
				//	$"where date_reserv = '{_dt_.Value}' and period_reserv = '{Type}' and id_table = {_table_cmb.SelectedValue}").ToString());
				//if (idd != 0)
				//	throw new Exception("Reserved already ! ");
				if (!new MyTools().IsNotNull(_clnt_txt.Text, _price_txt.Text))
					throw new Exception(" one or more field is empty");
				_add_btn.Text = "Add Reservation";
			}
			else
			{
					AddReservation();
			}
			}catch(Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		void AddReservation()
		{
			String query = $"INSERT INTO reservation VALUES ('{id}', '{_clnt_txt.Text}', {Parse(_tel_txt.Text)},'{_dt_.Value}', {double.Parse(_price_txt.Text)}, {Parse(_table_cmb.SelectedValue.ToString())}, '{Type}','{_cmnt_txt.Text}', {_people_trck.Value})";
			MyTools t = new MyTools();
			if (t.NonQuery(query) > 0)
				MyTools.Alert("Reservation Added with successfully ...", Form_Alert.enmType.Success);
			else
				throw new Exception("Something wrong .. try again");
		}

		private void _price_txt_Click(object sender, EventArgs e)
		{
			
		}
	}
} 