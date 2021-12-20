using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Bevera_System
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
			
		}

		public LogIn(string text)
		{
            InitializeComponent();
			_usrnm_txt.Text = text;
			
		}
		void getUsernames()
		{

			AutoCompleteStringCollection myList = new AutoCompleteStringCollection();
			MyTools t = new MyTools();
			DataTable dt = t.GetDataTable("Select username_mg from Manger");
			
			
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				
				myList.Add(dt.Rows[i][0].ToString());
			}
			_usrnm_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
			_usrnm_txt.AutoCompleteCustomSource = (AutoCompleteStringCollection)myList;
		}

		String prov = "Server=127.0.0.1;Port=5432;Database=beveradatabase;User Id=postgres;Password=197922;";


        private void _signin_btn_Click(object sender, EventArgs e)
        {
            SignIn s = new SignIn();
            s.Location = new Point(15, 62);
            s.Parent = Form.ActiveForm;
            this.Hide();
            s.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
			try
			{

			getUsernames();
			

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void _log_in_btn_Click(object sender, EventArgs e)
		{
			NpgsqlConnection connection = new NpgsqlConnection();
			try
			{

				connection.ConnectionString = prov;
				connection.Open();
				String Query = $"Select username_mg,pin from manger where username_mg='{_usrnm_txt.Text}' and pin = '{MyTools.SHA1_Hashing(_passw_txt.Text)}'";
				NpgsqlCommand ncmd = new NpgsqlCommand(Query, connection);
				NpgsqlDataReader ndr = ncmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(ndr);
				
				if (dt.Rows[0][0].ToString() == _usrnm_txt.Text && dt.Rows[0][1].ToString() == MyTools.SHA1_Hashing(_passw_txt.Text))
				{
					MyTools.Alert("Connected to System ... ", Form_Alert.enmType.Success);
					Home h = new Home(_usrnm_txt.Text);
					h.Show();
					Program.lf.Hide();
				}
				else
					throw new Exception("Account is invalid");
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
			finally
			{

				connection.Close();
			}
			
		}
	}
}
