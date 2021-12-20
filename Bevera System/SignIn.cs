using System;
using System.Drawing;
using Npgsql;
using System.Windows.Forms;
using Bevera_System.Properties;

namespace Bevera_System
{
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }
		String prov = "Server=127.0.0.1;Port=5432;Database=beveradatabase;User Id=postgres;Password=197922;";
		private Image mypic = Resources.icons8_administrator_64;

		private void _cancel_btn_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Location = new Point(15, 62);
            l.Parent = Form.ActiveForm;
            this.Hide();
            l.Show();
        }

		private void _sign_in_btn_Click(object sender, EventArgs e)
		{
			NpgsqlConnection connection = new NpgsqlConnection();
			try
			{

				connection.ConnectionString = prov;
				connection.Open();
				String Query = $"INSERT INTO manger(username_mg, pin, first_name, last_name,pic , tel) VALUES('{_usrname_txt.Text}', '{MyTools.SHA1_Hashing(_passw_txt.Text)}', '{_fname_txt.Text}', '{_lname_txt.Text}',@pic,{int.Parse(_tel_txt.Text)}); ";
				NpgsqlCommand ncmd = new NpgsqlCommand(Query, connection);
				ncmd.Parameters.AddWithValue("@pic", NpgsqlTypes.NpgsqlDbType.Bytea, MyTools.convertImgToBin(mypic));
				int i = ncmd.ExecuteNonQuery();

				if (i >= 0)
				{
					LogIn l = new LogIn(_usrname_txt.Text);
					l.Location = new Point(15, 62);
					l.Parent = Form.ActiveForm;
					l.Dock = DockStyle.Fill;
					this.Hide();
					l.Show();
				}
				else
				{
					throw new Exception("Error !!!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

				connection.Close();
			}

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
	}
}
