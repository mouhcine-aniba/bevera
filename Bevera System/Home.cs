using System;
using System.Drawing;
using FormAnimation;
using System.Windows.Forms;
using Bevera_System.Properties;
using System.Data;
using System.IO;
using Npgsql;

namespace Bevera_System
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home(String id= "@Mouhcine_Aniba")
        {
            InitializeComponent();
			id_user = id;
        }
		public String id_user;
		bool _cmd_bl = false, _reserv_bl = false, _menu_bl = false;
        private void _close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
		void getUser ()
		{
			try
			{

				NpgsqlConnection cnx = new NpgsqlConnection(MyTools.StaticConnection);
				NpgsqlCommand cmd = new NpgsqlCommand($"Select * from Manger where username_mg = '{id_user}' limit 1",cnx);
				cnx.Open();
				NpgsqlDataReader reader = cmd.ExecuteReader();
				if(reader.Read())
				{
					_lbl_username.Text = reader["username_mg"].ToString();
					_lbl_fullname.Text = reader["first_name"] + " " + reader["last_name"];
					if (!Convert.IsDBNull(reader["pic"]))
					{
						byte[] blob = (byte[])reader["pic"];

						_pic_prof.Image = MyTools.convertBinToImg(blob);
					}
					else
					{
						_pic_prof.Image = Resources.icons8_administrator_male_64;
					}
				}
				cnx.Close();
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

        private void Home_Load(object sender, EventArgs e)
        {

			getUser();
			HomeControl new_ = new HomeControl();
			new_.Location = new Point(271, 54);
			new_.Parent = Form.ActiveForm;
			new_.Show();
			new_.BringToFront();
		}

      
      
        private void _pnl_userinfo_MouseHover(object sender, EventArgs e)
        {
			_pnl_userinfo.BackColor = Color.Maroon;
        }

        private void _pnl_userinfo_MouseLeave(object sender, EventArgs e)
        {
            _pnl_userinfo.BackColor = Color.Brown;

        }

        private void _btn_commander_Click(object sender, EventArgs e)
        {
			_cmd_tr.Start();
        }

      

        private void _new_deliv_btn_Click(object sender, EventArgs e)
        {
			New_Dilvery new_ = new New_Dilvery(id_user);
			new_.Location = new Point(271, 54);
			new_.Parent = Form.ActiveForm;
			new_.Show();
			new_.BringToFront();
		}

        private void _nw_cmd_btn_Click(object sender, EventArgs e)
        {
			NewCommande ncmd = new NewCommande(id_user);
			ncmd.Location = new Point(271, 54);
			ncmd.Parent = Form.ActiveForm;
			ncmd.Show();
			ncmd.BringToFront();

        }

        private void _mng_btn_Click(object sender, EventArgs e)
        {
			MangementCmd ncmd = new MangementCmd();
			ncmd.Location = new Point(271, 54);
			ncmd.Parent = Form.ActiveForm;
			ncmd.Show();
			ncmd.BringToFront();
		}

        private void _new_Prod_btn_Click(object sender, EventArgs e)
        {
			NewProductForm npf = new NewProductForm();
			npf.Show();
        }

        private void _prods_btn_Click(object sender, EventArgs e)
        {
			ProductsForm prod = new ProductsForm();
			prod.Show();
		}

        private void _Ingredient_btn_Click(object sender, EventArgs e)
        {

        }

        private void _new_reserv_btn_Click(object sender, EventArgs e)
        {
			NewReservation new_ = new NewReservation();
			new_.Location = new Point(271, 54);
			new_.Parent = Form.ActiveForm;
			new_.Show();
			new_.BringToFront();
		}

        private void _mng_reserv_btn_Click(object sender, EventArgs e)
        {
			ManagementReservation new_ = new ManagementReservation();
			new_.Location = new Point(271, 54);
			new_.Parent = Form.ActiveForm;
			new_.Show();
			new_.BringToFront();
		}

		private void _menu_tr_Tick(object sender, EventArgs e)
		{
			if(!_menu_bl)
			{
			_menu_pnl.Height += 20;
				if (_menu_pnl.Size.Height == _menu_pnl.MaximumSize.Height)
				{
					_menu_bl = true;
					_menu_tr.Stop();

				}
			}
			else
			{
				_menu_pnl.Height -= 20;
				if (_menu_pnl.Size.Height == _menu_pnl.MinimumSize.Height)
				{
					_menu_bl = false;
					_menu_tr.Stop();

				}
			}
		}

		private void _btn_menu_Click(object sender, EventArgs e)
		{
			_menu_tr.Start();
		}

		private void _reserv_tr_Tick(object sender, EventArgs e)
		{
			if (!_reserv_bl)
			{
				_reserv_pnl.Height += 20;
				if (_reserv_pnl.Size.Height == _reserv_pnl.MaximumSize.Height)
				{
					_reserv_bl = true;
					_reserv_tr.Stop();

				}
			}
			else
			{
				_reserv_pnl.Height -= 20;
				if (_reserv_pnl.Size.Height == _reserv_pnl.MinimumSize.Height)
				{
					_reserv_bl = false;
					_reserv_tr.Stop();

				}
			}
		}

		private void _btn_reserv_Click(object sender, EventArgs e)
		{
			_reserv_tr.Start();
		}

		private void _cmd_tr_Tick(object sender, EventArgs e)
		{
			if (!_cmd_bl)
			{
				_cmd_pnl.Height += 20;
				if (_cmd_pnl.Size.Height == _cmd_pnl.MaximumSize.Height)
				{
					_cmd_bl = true;
					_cmd_tr.Stop();

				}
			}
			else
			{
				_cmd_pnl.Height -= 20;
				if (_cmd_pnl.Size.Height == _cmd_pnl.MinimumSize.Height)
				{
					_cmd_bl = false;
					_cmd_tr.Stop();

				}
			}
		}

		private void _pnl_userinfo_Paint(object sender, PaintEventArgs e)
		{
		
		}

		private void _pnl_userinfo_Click(object sender, EventArgs e)
		{

			AccountControl new_ = new AccountControl(id_user);
			new_.Location = new Point(271, 54);
			new_.Parent = Form.ActiveForm;
			new_.Show();
			new_.BringToFront();
		}

		private void Home_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3, MessageBoxOptions.ServiceNotification) == DialogResult.OK)
			{
				Program.lf.Dispose();
				Program.lf.Close();
			}
			else
			{
				e.Cancel = true;
				this.BringToFront();
			}

		}

		private void _home_btn_Click(object sender, EventArgs e)
		{
			HomeControl new_ = new HomeControl();
			new_.Location = new Point(271, 54);
			new_.Parent = Form.ActiveForm;
			new_.Show();
			new_.BringToFront();
		}

	
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
			LogsForm log = new LogsForm();
			log.Show();
        }

	
      
    }
}
