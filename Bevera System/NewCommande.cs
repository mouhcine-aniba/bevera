using System;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using Bevera_System.Properties;
using System.Collections.Generic;
using static System.String;
using static System.DateTime;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Bevera_System
{
	
	public partial class NewCommande : UserControl
	{
		public NewCommande(String user="Admin")
		{
			InitializeComponent();
			products= new DataTable();
			this.user = user;
		}
		
		
		DataTable products;
		String id_cmd;
		double totalNormal, total_reduc, totalFinal;
		private String user;

		void generateID ( )
		{
			id_cmd =  new MyTools().Scalar("Select COUNT(*) from command").ToString();
			id_cmd += "-" + DateTime.Now.ToShortDateString().Replace("/","");
			id_cmd +="-" + new Random().Next(99, 999);
			_id_generate_lbl.Text = id_cmd;
		}
		public void Alert(string msg, Form_Alert.enmType type)
		{
			Form_Alert frm = new Form_Alert();
			frm.showAlert(msg, type);
		}

		void getProd ()
		{
			try
			{
			
			MyTools tool = new MyTools();
			String Query = $"SELECT id_prod, name_prod, 1 as qt,  price_vente ,  'Delete' as del FROM products";
				String msg;
				products = tool.GetDataTable(Query, out msg);
			if (products != null) {
					
					products.Columns.Add(new DataColumn("TotL",typeof(double)));
					foreach (DataRow item in products.Rows)
					{
						item["TotL"] = double.Parse(item["qt"].ToString()) * double.Parse(item["price_vente"].ToString());
					}
					_prod_cmb.DataSource = products;
					_prod_cmb.DisplayMember = "Name_prod";
					_prod_cmb.ValueMember = "ID_prod";
					
				}
	
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}

		void getServeurs ()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"select username_sv from Serveur";
				DataTable dt = new DataTable();
				String msg;
				dt = tool.GetDataTable(Query, out msg);
				if (dt != null)
				{
					_serv_cmb.DataSource = dt;
					_serv_cmb.DisplayMember = "username_sv";
					_serv_cmb.ValueMember = "username_sv";
					_Total_lbl.Text = msg;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		void getCuisiners ()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"select username_cs from Cuisiner";
				DataTable dt = new DataTable();
				
				dt = tool.GetDataTable(Query);
				if (dt != null)
				{
					_csiner_cmb.DataSource = dt;
					_csiner_cmb.DisplayMember = "username_cs";
					_csiner_cmb.ValueMember = "username_cs";
					
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		void getTables ()
		{
			try
			{

				MyTools tool = new MyTools();
				String Query = $"select * from Bv_Table";
				DataTable dt = new DataTable();
				
				dt = tool.GetDataTable(Query);
				if (dt != null)
				{
					_table_cmb.DataSource = dt;
					_table_cmb.DisplayMember = "id_table";
					_table_cmb.ValueMember = "id_table";
					
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void CalculerPrix ()
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
				Alert(ex.Message, Form_Alert.enmType.Error);
			}
			finally
			{

			}

		}
	
		double RowsCalc ( )
		{
			double resultat = 0;

			foreach (DataGridViewRow item in _row_gv.Rows)
			{
				resultat += double.Parse(item.Cells["total"].Value.ToString());
			}
			return resultat;
		}

		void AddCommand ()
		{
			MyTools t = new MyTools();
			String Query = Format("INSERT INTO Command VALUES ('{0}','{1}','{2}',{3},{4},{5},'{6}','{7}','{8}',{9})",
									id_cmd, Now.ToShortDateString(), Now.ToShortTimeString(),
									totalNormal, total_reduc, totalFinal,user,
									_serv_cmb.SelectedValue, _csiner_cmb.SelectedValue, _table_cmb.SelectedValue);
				
			if (t.NonQuery(Query) > 0)
			{
				AddRow();
			}
			else
				throw new Exception("Try Again ... Something wrong");
		}

		int rowAdd = 0;
		void AddRow ()
		{
			int qtte = 0;
			double tot = 0;
			String prod = "";
			MyTools tt = new MyTools();
			for (int i = 0; i < _row_gv.Rows.Count; i++)
			{
				qtte = int.Parse(_row_gv.Rows[i].Cells[2].Value.ToString());
				tot = double.Parse(_row_gv.Rows[i].Cells[5].Value.ToString());
				prod = _row_gv.Rows[i].Cells[0].Value.ToString();
				String query = Format("INSERT INTO public.linecmd(qtte, id_product, id_command, total)" +
					"VALUES({0}, {1}, '{2}', {3})",qtte,prod,id_cmd,tot);
				if (tt.NonQuery(query) > 0)
				{
					rowAdd++;
				}
			}
			//if (rowAdd == _row_gv.Rows.Count)
			//	Alert("End Rows", Form_Alert.enmType.Success);
			//else
			//	throw new Exception("Something wrong ... please check the Command informations");
		}

		void generatePDF ()
		{
			SaveFileDialog ss = new SaveFileDialog();
			ss.Filter = "Pdf Files|*.pdf";
			
			DialogResult result = ss.ShowDialog();
			if(result == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(ss.FileName, FileMode.Create))
				{
					Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
					PdfWriter.GetInstance(pdfDoc, stream);
					pdfDoc.Open();
					pdfDoc.Add(new Phrase("\nCommand Facture"));
					Image image = Image.GetInstance(@"\bevera-logo.png");
					
					image.ScalePercent(24f);
					
					image.SetAbsolutePosition(pdfDoc.PageSize.Width - 36f - 72f,
						  pdfDoc.PageSize.Height  - 86.6f);
					pdfDoc.Add(image);
					pdfDoc.Add(new Paragraph(DateTime.Now.ToString()));
					pdfDoc.Add(new Paragraph("Command ID :" + id_cmd));
					pdfDoc.Add(new Paragraph("Manger ID :" + user));
					pdfDoc.Add(new Paragraph("Table :" + _table_cmb.SelectedValue + Environment.NewLine));
					pdfDoc.Add(new Paragraph( Environment.NewLine));
					pdfDoc.Add(MyTools.ToPdfTable(_row_gv, "this is a title"));
					pdfDoc.Add(new Phrase("                                   Total : " + totalNormal + " DHS" + Environment.NewLine));
					pdfDoc.Add(new Phrase("                                   Reduction : " + total_reduc + " DHS" + Environment.NewLine));
					pdfDoc.Add(new Phrase("                                   ------------------------------------" + Environment.NewLine));
					pdfDoc.Add(new Phrase("                                   NET PAYER : " + totalFinal + " DHS" ));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase(Environment.NewLine));
					pdfDoc.Add(new Phrase("    Signature : "));
					pdfDoc.Close();
					stream.Close();
					Process.Start(ss.FileName);
				}
			}
	

		}


		private void NewCommande_Load(object sender, EventArgs e)
		{
			generateID();
			getProd();
			getServeurs();
			getCuisiners();
			getTables();
			
		}

	

		private void _add_link_Click(object sender, EventArgs e)
		{
			try
			{
				if (_prod_cmb.SelectedIndex < 0)
					throw new Exception("Product list is empty ...");
			String id = _prod_cmb.SelectedValue.ToString();
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
			catch (Exception ex)
			{
				Alert(ex.Message, Form_Alert.enmType.Warning);
			}
		}
	

		private void _row_gv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			CalculerPrix();
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

		private void _add_btn_Click(object sender, EventArgs e)
		{
			try
			{
				
				if(_add_btn.Text == "Verify")
				{
					if (_serv_cmb.SelectedIndex < 0 || _table_cmb.SelectedIndex < 0 || _csiner_cmb.SelectedIndex < 0)
						throw new Exception("Some field is empty ... please try again");
					if (_row_gv.Rows.Count == 0)
						throw new Exception("Please add a product ... the Command is empty");
					_add_btn.Text = "Add Command";
					_add_btn.BackColor = Color.Green;
				}
				else
				{
					AddCommand();
					generatePDF();
					this.Hide();
				}


			}
			catch (Exception ex)
			{
				Alert(ex.Message, Form_Alert.enmType.Error);
			}
		}

		private void _row_gv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

			try
			{

			if (e.ColumnIndex == 2 && e.RowIndex  >= 0)
			{
				double qtte = double.Parse(_row_gv.Rows[e.RowIndex].Cells[2].Value.ToString());
				 double prix = double.Parse(_row_gv.Rows[e.RowIndex].Cells[3].Value.ToString());
				if(qtte > 0)
				_row_gv.Rows[e.RowIndex].Cells["total"].Value = qtte * prix;
				CalculerPrix();
			}
			}
			catch (Exception ex)
			{
				Alert(ex.Message, Form_Alert.enmType.Error);
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
						double vl = double.Parse(t.Scalar(Format("select value_coupon from coupon where code ='{0}'", _reduc_txt.Text)).ToString());

						if (vl != 0)
						{
							total_reduc = vl;
						}
						else
							throw new Exception("Coupon invalid");
					}
					else if (_per_rd.Checked)
					{
						total_reduc =totalNormal- ( totalNormal - totalNormal * double.Parse(_reduc_txt.Text) / 100);

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
					Alert(ex.Message, Form_Alert.enmType.Error);
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


	
	
	}
		
}
