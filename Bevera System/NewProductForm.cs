using System;
using System.Collections.Generic;
using NpgsqlTypes;
using System.Data;
using System.Drawing;
using System.Threading;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevera_System
{
	public partial class NewProductForm : MetroFramework.Forms.MetroForm
	{
		private Image mypic;

		public NewProductForm()
		{
			InitializeComponent();
		}
		void AddProduct()
		{
			
			NpgsqlConnection connection = new NpgsqlConnection(MyTools.StaticConnection);
			NpgsqlCommand cmd = new NpgsqlCommand();
			try
			{

				if (mypic == null)
					throw new Exception("Image field is empty");

				if (!new MyTools().IsNotNull(_id_txt.Text, _name_txt.Text, _buy_txt.Text, _sale_txt.Text))
					throw new Exception("a field or more is empty");

				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = $"Insert into products(id_prod, name_prod, code_barre, picture,  price_vente, type_prod, description) VALUES" +
					$" (@id,@name,@code,@pic,{double.Parse(_sale_txt.Text)},@family,@disc)";
				cmd.Parameters.AddWithValue("@id", NpgsqlDbType.Varchar, _id_txt.Text);
				cmd.Parameters.AddWithValue("@name", NpgsqlDbType.Varchar, _name_txt.Text.Trim());
				cmd.Parameters.AddWithValue("@code", NpgsqlDbType.Varchar, _cdBarre_txt.Text);
				cmd.Parameters.AddWithValue("@family", NpgsqlDbType.Varchar, _typ_txt.Text);
				cmd.Parameters.AddWithValue("@pic", NpgsqlDbType.Bytea, MyTools.convertImgToBin(mypic));
				cmd.Parameters.AddWithValue("@disc", NpgsqlDbType.Text, _desc_txt.Text);

				if (cmd.ExecuteNonQuery() > 0)
					MyTools.Alert($"the Product {_name_txt.Text } was added with successfully ! ", Form_Alert.enmType.Success);
	
				else
					throw new Exception("Error !! try again ");
				this.Close();

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


		private void NewProductForm_Load(object sender, EventArgs e)
		{
			_desc_txt.WaterMark = "Other information ...\n Poid , Calories , Ingredients ...";


			//Animation.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation., 2000);
		}

		private void _ok_btn_Click(object sender, EventArgs e)
		{
			AddProduct();
			
		}

		private void _upload_btn_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";

			if (op.ShowDialog() == DialogResult.OK)
			{
				mypic = Image.FromFile(op.FileName);
				_pic_.Image = mypic;
			}
		}

		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Parent.BringToFront();
		}
	}
}
