using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bevera_System
{
	public partial class Product_Card : UserControl
	{
		public Product_Card()
		{
			InitializeComponent();
		}

		public Product_Card(String id,String name,String desc,Image img)
		{
			InitializeComponent();
			this.Id = id;
			this.Prodname = name;
			this.Desc = desc;
			this.Img = img;
		}

		#region Propp
		private String id;
		private String prodname;
		private String desc;
		private String price;
		
		private Image img;


		[Category("customProp")]
		public string Id { get => id; set => id = _id.Text = value;  }

		[Category("customProp")]
		public string Prodname { get => prodname; set => prodname = _prod_name.Text = value; }

		[Category("customProp")]
		public string Desc { get => desc; set => desc = _desc.Text = value; }

		[Category("customProp")]
		public string Price { get => price; set => price = _price.Text = value; }

		[Category("customProp")]
		public Image Img { get => img; set => img = _pic.Image = value; }
	

		#endregion

		

		private void Product_Card_Load(object sender, EventArgs e)
		{

		}

		//private void _del_btn_Click(object sender, EventArgs e)
		//{
		//	DeleteProdForm del = new DeleteProdForm(this.Id);
		//	del.ShowDialog();
		//}
	}
}
