using Bevera_System.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bevera_System
{
	public partial class UpdateUserForm : Form
	{
		public UpdateUserForm(String username)
		{
			InitializeComponent();
			this.username = username;
			_myForm.TitleText += " " + username;
			_username_txt.Text = username;
		}
		String username;
		String Password;
		Image mypic;
		void getUser ()
		{
			DataTable dt = new MyTools().GetDataTable($"Select  * from Manger where username_mg='{username}' limit 1");
			if (dt != null)
			{
				_frName_txt.Text = dt.Rows[0]["first_name"].ToString();
				_lstName_txt.Text = dt.Rows[0]["last_name"].ToString();
				_tel_txt.Text = dt.Rows[0]["tel"].ToString();
				Password = dt.Rows[0]["pin"].ToString();
				if (!Convert.IsDBNull(dt.Rows[0]["pic"]))
				{
					byte[] blob = (byte[])dt.Rows[0]["pic"];

					mypic = MyTools.convertBinToImg(blob);
					
				}
				else
					mypic = Resources.icons8_administrator_male_64;
				if (mypic != null)
					_pic_.Image = mypic;
			}
		}


		void UpdateUser (String username,String first,String last,byte[] newpic,int newTel)
		{
			try
			{

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}

		}

		private void UpdateUserForm_Load(object sender, EventArgs e)
		{
			try
			{

			trans.ShowAsyc(this);
			getUser();
			

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
		{

		}

		private void _ok_btn_Click(object sender, EventArgs e)
		{
			String query = $"UPDATE Manger set first_name = '{_frName_txt.Text}', last_name = '{_lstName_txt.Text}', pic = {MyTools.convertImgToBin(mypic)}, tel = {int.Parse(_tel_txt.Text)} where username_mg = {username}"; 
			try
			{
				
					if (new MyTools().IsNotNull(_frName_txt.Text, _lstName_txt.Text, _tel_txt.Text))
					{
						Npgsql.NpgsqlConnection cnx = new Npgsql.NpgsqlConnection(MyTools.StaticConnection);
						Npgsql.NpgsqlCommand cmd= new Npgsql.NpgsqlCommand(query, cnx);
						cnx.Open();
						if(cmd.ExecuteNonQuery() > 0 )
					{
						MyTools.Alert("Updated", Form_Alert.enmType.Success);
						this.Close();
					}
					}
					else
						throw new Exception("one or more field is empty .... Please input all this");
				
				
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void _chng_pass_Btn_Click(object sender, EventArgs e)
		{
			
			try
			{
				if (new MyTools().Hashing(_actualPassword_txt.Text) != Password)
					throw new Exception("actual password is invalid");
					
				if (_confirm_txt.Text != _newPass_txt.Text || _newPass_txt.Text == String.Empty || _confirm_txt.Text == String.Empty)
					throw new Exception("your new password is not Identique");
		
			String HashingPIN = new MyTools().Hashing(_newPass_txt.Text);
			String query = $"Update Manger set pin = '{HashingPIN}' where username_mg ='{username}'";
			if (_chng_pass_Btn.Text == "Change Password")
			{
				if (new MyTools().NonQuery(query) > 0)
				{
					_chng_pass_Btn.Text = "Changed";
					_chng_pass_Btn.Enabled = false;
					MyTools.Alert("Password is changed !!!", Form_Alert.enmType.Success);
				}
				else
					throw new Exception("Password invalid ... try again");
			}
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}

		}

		private void _upload_btn_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "";

			if (op.ShowDialog() == DialogResult.OK)
			{
				mypic = Image.FromFile(op.FileName);
				_pic_.Image = mypic;
			}
		}

		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
