using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.DateTime;
using Image = iTextSharp.text.Image;

namespace Bevera_System
{
    public partial class New_Dilvery : UserControl
    {
        public New_Dilvery(String userr)
        {
            InitializeComponent();
			products = new DataTable();
			user = userr;
		}

		String user;
		DataTable products;

		double totalNormal, total_reduc, totalFinal;
		private string id_deliv;

		void generatePDF()
		{
			SaveFileDialog ss = new SaveFileDialog();
			ss.Filter = "Pdf Files|*.pdf";

			DialogResult result = ss.ShowDialog();
			if (result == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(ss.FileName, FileMode.Create))
				{
					Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
					PdfWriter.GetInstance(pdfDoc, stream);
					pdfDoc.Open();
					pdfDoc.Add(new Phrase("                                     Delivery Facture"));
					Image image = Image.GetInstance(@"\bevera-logo.png");

					image.ScalePercent(24f);
					
					image.SetAbsolutePosition(pdfDoc.PageSize.Width - 36f - 72f,
						  pdfDoc.PageSize.Height - 86.6f);
					pdfDoc.Add(image);
					pdfDoc.Add(new Paragraph(DateTime.Now.ToString()));
					pdfDoc.Add(new Paragraph("Delivery ID :" + id_deliv));
					pdfDoc.Add(new Paragraph("Manger ID :" + user));
					pdfDoc.Add(new Paragraph("Deliverer :" + _deliv_cmb.SelectedValue + Environment.NewLine));
					pdfDoc.Add(new Paragraph(Environment.NewLine));
					pdfDoc.Add(MyTools.ToPdfTable(_row_gv, "-- Delivery Panier --"));
					pdfDoc.Add(new Phrase("                                   Total : " + totalNormal + " DHS" + Environment.NewLine));
					pdfDoc.Add(new Phrase("                                   Reduction : " + total_reduc + " DHS" + Environment.NewLine));
					pdfDoc.Add(new Phrase("                                   ------------------------------------" + Environment.NewLine));
					pdfDoc.Add(new Phrase("                                   NET PAYER : " + totalFinal + " DHS"));
					for(int i=0;i< 8;i++)
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase("    Signature : "));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					Image qr = Image.GetInstance(@"\qrcode.png");
					pdfDoc.Add(qr);
					pdfDoc.Close();
					stream.Close();
					Process.Start(ss.FileName);
				}
			}


		}


		void generateID()
		{
			id_deliv = "0" + new MyTools().Scalar("Select COUNT(*) from Delivery").ToString();
			id_deliv += "-" + DateTime.Now.ToShortDateString().Replace("/", "");
			id_deliv += "-" + new Random().Next(99, 999);
			_id_generate_lbl.Text = id_deliv;
		}

		void getCuisiners()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"select username_cs from Cuisiner";
				DataTable dt = new DataTable();

				dt = tool.GetDataTable(Query);
				if (dt != null)
				{
					_cuisiner_cmb.DataSource = dt;
					_cuisiner_cmb.DisplayMember = "username_cs";
					_cuisiner_cmb.ValueMember = "username_cs";

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		void getDeliverer()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"select * from Deliverer";
				DataTable dt = new DataTable();

				dt = tool.GetDataTable(Query);
				if (dt != null)
				{
					_deliv_cmb.DataSource = dt;
					_deliv_cmb.DisplayMember = "username_dv";
					_deliv_cmb.ValueMember = "username_dv";

				}

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message + " " + ex.InnerException.Message, Form_Alert.enmType.Error);
			}
		}

		void getProd()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"SELECT id_prod, name_prod, 1 as qt,  price_vente ,  'Delete' as del FROM products";
				String msg;
				products = tool.GetDataTable(Query, out msg);
				if (products != null)
				{

					products.Columns.Add(new DataColumn("total", typeof(double)));
					foreach (DataRow item in products.Rows)
					{
						item["total"] = double.Parse(item["qt"].ToString()) * double.Parse(item["price_vente"].ToString());
					}
					prod_cmb.DataSource = products;
					prod_cmb.DisplayMember = "Name_prod";
					prod_cmb.ValueMember = "ID_prod";

				}

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}

		}

		public void CalculerPrix()
		{
			try
			{

				totalNormal = RowsCalc();
				totalFinal = totalNormal - total_reduc;
				_red_lbl.Text = total_reduc.ToString() + "  DHs";
				totFinal_lbl.Text = totalFinal.ToString() + " Dhs";
				_Total_lbl.Text = totalNormal.ToString() + " Dhs";
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
			finally
			{

			}

		}

		void AddDelivey()
		{
			MyTools t = new MyTools();
			String Query = String.Format("INSERT INTO Delivery VALUES ('{0}','{1}','{2}',{3},{4},{5},'{6}','{7}','{8}')",
									id_deliv, Now.ToShortDateString(), Now.ToShortTimeString(),
									totalNormal, total_reduc, totalFinal, user,
									 _cuisiner_cmb.SelectedValue, _deliv_cmb.SelectedValue);

			if (t.NonQuery(Query) > 0)
			{
				AddRow();
				generatePDF();
			}
			else
				throw new Exception("Try Again ... Something wrong");
		}

		void AddRow()
		{
			int rowAdd = 0;
			int qtte = 0;
			double tot = 0;
			String prod = "";
			MyTools tt = new MyTools();
			for (int i = 0; i < _row_gv.Rows.Count; i++)
			{
				qtte = int.Parse(_row_gv.Rows[i].Cells[2].Value.ToString());
				tot = double.Parse(_row_gv.Rows[i].Cells[5].Value.ToString());
				prod = _row_gv.Rows[i].Cells[0].Value.ToString();
				String query = String.Format("INSERT INTO lineDeliv(qtte, id_product, id_delivery, total)" +
					"VALUES({0}, {1}, '{2}', {3})", qtte, prod, id_deliv, tot);
				if (tt.NonQuery(query) > 0)
				{
					rowAdd++;
				}
			}
			//if (rowAdd == _row_gv.Rows.Count)
			//	MyTools.Alert("End Rows", Form_Alert.enmType.Success);
			//else
			//	throw new Exception("Something wrong ... please check the Command informations");
		}


		double RowsCalc()
		{
			double resultat = 0;

			foreach (DataGridViewRow item in _row_gv.Rows)
			{
				resultat += double.Parse(item.Cells["total"].Value.ToString());
			}
			return resultat;
		}

		private void prod_cmb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			String id = prod_cmb.SelectedValue.ToString();
			foreach (DataRow item in products.Rows)
			{
				if (item["id_prod"].ToString() == id)
				{
					_row_gv.Rows.Add(item.ItemArray);
					products.Rows.Remove(item);
					CalculerPrix();
					return;
				}
			}
		}

		private void _row_gv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				if (e.ColumnIndex == 2 && e.RowIndex >= 0)
				{
					double qtte = double.Parse(_row_gv.Rows[e.RowIndex].Cells[2].Value.ToString());
					double prix = double.Parse(_row_gv.Rows[e.RowIndex].Cells[3].Value.ToString());
					if (qtte > 0)
						_row_gv.Rows[e.RowIndex].Cells["total"].Value = qtte * prix;
					CalculerPrix();
				}
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void _valid_reduc_btn_Click(object sender, EventArgs e)
		{
			if (_valid_reduc_btn.Text == "Valider")
			{
				try
				{

					if (_coupon_rd.Checked)
					{
						MyTools t = new MyTools();
						double vl = double.Parse(t.Scalar(String.Format("select value_coupon from coupon where code ='{0}'", _reduc_txt.Text)).ToString());

						if (vl != 0)
						{
							total_reduc = vl;
						}
						else
							throw new Exception("Coupon invalid");
					}
					else if (_per_rd.Checked)
					{
						total_reduc = totalNormal - (totalNormal - totalNormal * double.Parse(_reduc_txt.Text) / 100);

					}
					else if (_value_rd.Checked)
					{
						total_reduc = double.Parse(_reduc_txt.Text);
					}
					else
					{
						throw new Exception("Not Select");
					}
					CalculerPrix();
					_valid_reduc_btn.Text = "Cancel";
				}
				catch (Exception ex)
				{
					MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
				}
			}
			else
			{
				total_reduc = 0;
				CalculerPrix();
				_reduc_txt.Text = "";
				_valid_reduc_btn.Text = "Valider";

			}
		}

		private void _add_btn_Click(object sender, EventArgs e)
		{

			try
			{

				if (_add_btn.Text == "Verify")
				{
					if (_deliv_cmb.SelectedIndex < 0 || _cuisiner_cmb.SelectedIndex < 0)
						throw new Exception("Some field is empty ... please try again");
					if (_row_gv.Rows.Count == 0)
						throw new Exception("Please add a product ... the Command is empty");
					_add_btn.Text = "Add Delivery";
					_add_btn.BackColor = Color.Green;
				}
				else
				{

					AddDelivey();
					this.Hide();

				}
			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
			}

		}

		

		private void _row_gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				DataRow row = products.NewRow();
				row[0] = _row_gv.Rows[e.RowIndex].Cells[0].Value;
				row[1] = _row_gv.Rows[e.RowIndex].Cells[1].Value;
				row[2] = _row_gv.Rows[e.RowIndex].Cells[2].Value;
				row[3] = _row_gv.Rows[e.RowIndex].Cells[3].Value;
				row[4] = _row_gv.Rows[e.RowIndex].Cells[4].Value;
				row[5] = _row_gv.Rows[e.RowIndex].Cells[5].Value;
				products.Rows.Add(row);
				_row_gv.Rows.RemoveAt(e.RowIndex);

				CalculerPrix();
			}
		}

		

		private void New_Dilvery_Load(object sender, EventArgs e)
        {
			getCuisiners();
			getDeliverer();
			getProd();
			generateID();
        }

     
    }
}
