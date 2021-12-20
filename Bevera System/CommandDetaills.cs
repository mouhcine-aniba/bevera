using System;
using System.Data;
using System.Drawing;

namespace Bevera_System
{
	public partial class CommandDetaills : MetroFramework.Forms.MetroForm
	{
		public CommandDetaills(String id,String type)
		{
			InitializeComponent();
			this.id = id;
			this.type = type;
		}
		String id;
		String type;
		void getCommand()
		{
			MyTools t = new MyTools();
			DataTable dt = t.GetDataTable($"Select * from Command where id_cmd ='{id}'");
			_cmd_lbl.Text = " Command ID is : " + dt.Rows[0][0].ToString();
			_time.Text += dt.Rows[0][1].ToString() + " , " + dt.Rows[0][2].ToString();
			_price.Text = "    |Price : " + dt.Rows[0][3].ToString() + " DHs "
				+ "\n|Reduction : " + dt.Rows[0][4] + " DHs " +
				"\n    |TOTAL : " + dt.Rows[0][5] + " DHs ";
			_manger.Text += dt.Rows[0]["id_manger"] + "";
			_srver.Text += dt.Rows[0]["id_serveur"] + "";
			_cuisinier.Text += dt.Rows[0]["id_cuisinir"] + "";
			_tbl.Text += dt.Rows[0]["id_tbl"] + "";





		}

		void getLineCmd()
		{
			_cmd_gv.DataSource = new MyTools().GetDataTable(
				$"Select DISTINCT l.qtte as Quantite,p.name_prod,total from " +
				$"linecmd l , products p  " +
				$"where l.id_Command = '{id}' and p.id_prod = l.id_product");
		}

		private void getDelivey()
		{
			MyTools t = new MyTools();
			DataTable dt = t.GetDataTable($"Select * from Delivery where id_deliv ='{id}'");
			_cmd_lbl.Text = " Delivey ID is : " + dt.Rows[0][0].ToString();
			_time.Text += dt.Rows[0][1].ToString() + " , " + dt.Rows[0][2].ToString();
			_price.Text = "    Price : " + dt.Rows[0][3].ToString() + " DHs "
				+ "\nReduction : " + dt.Rows[0][4] + " DHs " +
				"\n    TOTAL : " + dt.Rows[0][5] + " DHs ";
			_manger.Text += dt.Rows[0]["id_manger"] + "";
			_srver.Text ="Deliverer : " +  dt.Rows[0]["id_deliverer"] + "";
			_cuisinier.Text += dt.Rows[0]["id_cuisiner"] + "";
			_tbl.Visible = false;


		}

		void getLineDeliv ()
		{
			_cmd_gv.DataSource = new MyTools().GetDataTable($"SELECT DISTINCT  qtte,products.name_prod, id_delivery, total FROM public.linedeliv , products " +
				$"where id_product = products.id_prod and  id_delivery = '{id}';");
		}

		void Del_Cmd ( )
		{
			try
			{
				MyTools t = new MyTools();

				if (t.NonQuery($"Delete from linecmd where id_Command = '{id}'") > 0)
				{

					t.NonQuery($"Delete from Command where id_cmd = '{id}'");
					MyTools.Alert("Command Deleted ... Command ID : " + id, Form_Alert.enmType.Success);
					this.Close();
				}

				else
					throw new Exception("Something wrong ... try again");
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}

		}

		void Del_Deliv ()
		{
			try
			{
				MyTools t = new MyTools();

				if (t.NonQuery($"Delete from linedeliv where id_delivery = '{id}'") > 0)
				{

					t.NonQuery($"Delete from Delivery where ID_deliv = '{id}'");
					MyTools.Alert("Delivey Deleted ... Delivery ID : " + id, Form_Alert.enmType.Success);
					this.Close();
				}

				else
					throw new Exception("Something wrong ... try again");
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void CommandDetaills_Load(object sender, EventArgs e)
		{
			try

			{
				if(type == "CMD")
				{
				getCommand();
				getLineCmd();

				}
				else
				{
					xuiGradientPanel1.TopRight = Color.Teal;
					xuiGradientPanel1.PrimerColor = Color.DodgerBlue;
					xuiGradientPanel1.BottomRight = Color.RoyalBlue;
					getDelivey();
					getLineDeliv();

				}

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

	

		private void _cancel_btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void _del_btn_Click(object sender, EventArgs e)
		{
			if (type == "CMD")
				Del_Cmd();
			else
				Del_Deliv();
		}
	} 
}
