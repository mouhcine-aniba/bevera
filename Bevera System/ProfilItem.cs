using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bevera_System
{
	public partial class ProfilItem : UserControl
	{
		public ProfilItem()
		{
			InitializeComponent();
		}
		#region Proprietes
		private String UserName;
		private String fullName;
		private int telephone;
		private Image Profil;

		[Category("Infos")]
		public String Id
		{
			get { return UserName; }
			set { UserName = value; _username_.Text = value; }
		}

		[Category("Infos")]
		public String name
		{
			get { return fullName; }
			set { fullName = value; _fullname_.Text = value; }
		}

		[Category("Infos")]
		public int Tel
		{
			get { return telephone; }
			set { telephone = value; _telephone_.Text = value.ToString(); }
		}

		[Category("Infos")]
		public Image imgProfil
		{
			get { return Profil; }
			set { Profil = value; _pic_.Image = value; }
		}

		#endregion

		private void ProfilItem_Load(object sender, EventArgs e)
		{

		}
	}
}
