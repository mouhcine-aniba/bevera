using Bevera_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevera_System
{
	public partial class ProductsForm : MetroFramework.Forms.MetroForm
	{
		public ProductsForm()
		{
			InitializeComponent();
		}

		Product_Card[] rows;
		public void getProduct()
		{
			try
			{
				// Data 
				_pnl.Controls.Clear();
				MyTools t = new MyTools();
				DataTable dt = t.GetDataTable($"Select * from Products");
				rows= new Product_Card[dt.Rows.Count];
				for (int i = 0; i < rows.Length; i++)
				{
					rows[i] = new Product_Card();
					rows[i].Id = dt.Rows[i]["id_prod"].ToString();
					rows[i].Prodname = dt.Rows[i]["name_prod"].ToString();
					rows[i].Desc = dt.Rows[i]["description"].ToString();
					rows[i].Price = dt.Rows[i]["price_vente"].ToString() + " Dhs";
					
					if (!Convert.IsDBNull(dt.Rows[i]["picture"]))
					{
					byte[] blob =(byte[]) dt.Rows[i]["picture"];
					
					rows[i].Img = MyTools.convertBinToImg(blob);
					}
					else
					{
						rows[i].Img = Resources.benim_4_01;
					}
					
					_pnl.Controls.Add(rows[i]);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

	
		byte[] ObjectToByteArray(object obj)
		{
			if (obj == null)
				return null;
			BinaryFormatter bf = new BinaryFormatter();
			using (MemoryStream ms = new MemoryStream())
			{
				bf.Serialize(ms, obj);
				return ms.ToArray();
			}
		}
		String id_dele;
		private void ProductsForm_Load(object sender, EventArgs e)
		{
			try
			{
				getProduct();
				Sear_txt.ButtonClick += delegate
				{
					foreach (Product_Card item in rows)
					{
						if (item.Id == Sear_txt.Text)
						{
							id_dele = item.Id;
							_pic.Image = item.Img;
							_name_lbl.Text = item.Prodname;
							del_btn.Visible = true;
							return;
						}
					}
					del_btn.Visible = false;
				};
			}
			catch (Exception ex)
			{

				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
				MessageBox.Show(ex.Message);
			}
		}

		private void del_btn_Click(object sender, EventArgs e)
		{
			try
			{
				MyTools t = new MyTools();
				int i = t.NonQuery($"DELETE FROM public.products WHERE id_prod = '{id_dele}' ");
				if (i > 0)
				{
					MyTools.Alert("Deleted", Form_Alert.enmType.Success);
					getProduct();
				}
				else
					throw new Exception("this product is entre in one or more Command & delivery ..." +
						"You can't delete it ...");
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}
	}
}
