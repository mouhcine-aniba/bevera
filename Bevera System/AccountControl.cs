using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bevera_System.Properties;

namespace Bevera_System
{
	public partial class AccountControl : UserControl
	{
		public AccountControl(String user="Admin")
		{
			InitializeComponent();
			username = user;
		}

		String username;

		void getCaAndCountCmd ()
		{
			MyTools t = new MyTools();
			int countCmd = Int32.Parse(t.Scalar($"Select count(*) from Command where ID_manger='{username}'").ToString());
			int Count = Int32.Parse(t.Scalar($"Select count(*) from Command").ToString());
			Decimal chiffreA = Decimal.Parse(t.Scalar($"Select Sum(Net_payer) from Command where ID_manger='{username}'").ToString());
			Decimal Chiffre = Decimal.Parse(t.Scalar($"Select Sum(Net_payer) from Command").ToString());

			_cmdCount_prog.Value = countCmd / Count * 100;
			_cmd_lbl.Text = Chiffre + "Command(s)";
			_ca_prog.Value = int.Parse((chiffreA / Chiffre * 100).ToString());


		}


		void GetUser ()
		{
			MyTools t = new MyTools();
			DataTable dt = t.GetDataTable($"Select  * from Manger where username_mg='{username}' limit 1");
			if (dt != null)
			{
				_name_lbl.Text = dt.Rows[0]["First_name"] + " " + dt.Rows[0]["last_name"];
				_username_lbl.Text = dt.Rows[0]["username_mg"].ToString();
				_tel_lbl.Text = dt.Rows[0]["tel"].ToString();
				if (!Convert.IsDBNull(dt.Rows[0]["pic"]))
				{
					byte[] blob = (byte[])dt.Rows[0]["pic"];

					_pic.Image = MyTools.convertBinToImg(blob);
				}
				else
				{
					_pic.Image = Resources.icons8_administrator_64;
				}

			}
			else
			{
				throw new Exception("User not Founded !!");
			}

		}

		void GetCuisiners ( )
		{
			// Data 
			MyTools t = new MyTools();
			DataTable dt = t.GetDataTable("Select * from cuisiner");
			ProfilItem[] rows = new ProfilItem[dt.Rows.Count];
			for (int i = 0; i < rows.Length; i++)
			{
				rows[i] = new ProfilItem();
				rows[i].Id = dt.Rows[i]["username_cs"].ToString();
				rows[i].Tel = int.Parse(dt.Rows[i]["tel"].ToString());
				rows[i].Name = dt.Rows[i]["First_name"].ToString() + " " + dt.Rows[i]["Last_name"].ToString();
			
					rows[i].imgProfil = Resources.icons8_administrator_male_64;
				
				cuis_pnl.Controls.Add(rows[i]);
			}
		}

		void GetManger()
		{
			try
			{

		
			// Data 
			MyTools t = new MyTools();
			DataTable dt = t.GetDataTable($"Select * from Manger where username_mg != '{username}'");
			ProfilItem[] rows = new ProfilItem[dt.Rows.Count];
			for (int i = 0; i < rows.Length; i++)
			{
				rows[i] = new ProfilItem();
				rows[i].Id = dt.Rows[i]["username_mg"].ToString();
				rows[i].Tel = int.Parse(dt.Rows[i]["tel"].ToString());
				rows[i].Name = dt.Rows[i]["First_name"].ToString() + " " + dt.Rows[i]["Last_name"].ToString();
					if (!Convert.IsDBNull(dt.Rows[0]["pic"]))
					{
						byte[] blob = (byte[])dt.Rows[0]["pic"];

						rows[i].imgProfil = MyTools.convertBinToImg(blob);
					}
					else
					{
						rows[i].imgProfil = Resources.icons8_administrator_male_64;
					}
					mngr_pnl.Controls.Add(rows[i]);
			}
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		void GetServeurs()
		{

			// Data 
			MyTools t = new MyTools();
			DataTable dt = t.GetDataTable("Select * from Serveurs");
			ProfilItem[] rows = new ProfilItem[dt.Rows.Count];
			for (int i = 0; i < rows.Length; i++)
			{
				rows[i] = new ProfilItem();
				rows[i].Id = dt.Rows[i]["username_sv"].ToString();
				rows[i].Tel = int.Parse(dt.Rows[i]["tel"].ToString());
				rows[i].Name = dt.Rows[i]["First_name"].ToString() + " " + dt.Rows[i]["Last_name"].ToString();
				if (!Convert.IsDBNull(dt.Rows[0]["pic"]))
				{
					byte[] blob = (byte[])dt.Rows[0]["pic"];

					rows[i].imgProfil = MyTools.convertBinToImg(blob);
				}
				else
				{
					rows[i].imgProfil = Resources.icons8_administrator_male_64;
				}
				serv_pnl.Controls.Add(rows[i]);
			}
		}

		private void cuis_pnl_Paint(object sender, PaintEventArgs e)
		{

		}

		private void AccountControl_Load(object sender, EventArgs e)
		{
			try
			{
				GetUser();
				getCaAndCountCmd();
				//GetCuisiners();
				//GetManger();
				//GetServeurs();
				
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			UpdateUserForm frm = new UpdateUserForm(username);
			frm.ShowDialog();
		}

		private void xuiCustomGroupbox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
