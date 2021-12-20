using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using static System.String;
using System.Drawing;
using System.IO;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using iTextSharp.text;
using Image = System.Drawing.Image;

namespace Bevera_System
{
	public class MyTools : IDisposable
	{
		public  string prov = "Server=127.0.0.1;Port=5432;Database=beveradatabase;User Id=postgres;Password=197922;";
		public static string StaticConnection = "Server=127.0.0.1;Port=5432;Database=beveradatabase;User Id=postgres;Password=197922;";
		public NpgsqlConnection npgsql = new NpgsqlConnection();
		public NpgsqlCommand cmd = new NpgsqlCommand();
		public DataTable GetDataTable(String query, out string msg)
		{
			try
			{
				npgsql.ConnectionString = prov;
				cmd.Connection = npgsql;
				npgsql.Open();
				cmd.CommandText = query;
				NpgsqlDataReader ndr = cmd.ExecuteReader();
				DataTable myTable = new DataTable();
				myTable.Load(ndr);
				msg = "success";
				return myTable;
			}
			catch (Exception ex)
			{
				msg = ex.Message;
				return null;
			}
			finally
			{
				npgsql.Close();

			}
		}
		//public static BaseFont customfont = BaseFont.CreateFont("Century Gothic", BaseFont.CP1252, BaseFont.EMBEDDED);
		//public static iTextSharp.text.Font font = new iTextSharp.text.Font(customfont, 12);
		public byte[] convertImageToBinary(Image img)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				return ms.ToArray();
			}
		}
		public static byte[] convertImgToBin(Image img)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				return ms.ToArray();
			}
		}
		public Image convertBinaryToImage(byte[] data)
		{
			using (MemoryStream ms = new MemoryStream(data))
			{

				return Image.FromStream(ms);
			}
		}

		public static Image convertBinToImg(byte[] data)
		{
			using (var ms = new MemoryStream(data))
			{

				return Image.FromStream(ms);
			}
		}



		public DataTable GetDataTable(String query)
		{
			try
			{
				npgsql.ConnectionString = prov;
				cmd.Connection = npgsql;
				npgsql.Open();
				cmd.CommandText = query;
				NpgsqlDataReader ndr = cmd.ExecuteReader();
				DataTable myTable = new DataTable();
				myTable.Load(ndr);
				return myTable;
			}
			catch (Exception)
			{
				return null;
			}
			finally
			{
				npgsql.Close();

			}
		}

		public object Scalar(String query)
		{
			try
			{
				npgsql.ConnectionString = prov;
				cmd.Connection = npgsql;
				npgsql.Open();
				cmd.CommandText = query;
				object Result = cmd.ExecuteScalar();


				return Result;
			}
			catch (Exception)
			{

				return null;
			}
			finally
			{
				npgsql.Close();

			}
		}
		public int NonQuery(String query)
		{
			try
			{
				npgsql.ConnectionString = prov;
				cmd.Connection = npgsql;
				npgsql.Open();
				cmd.CommandText = query;

				return cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{

				return -1;
			}
			finally
			{
				npgsql.Close();

			}
		}

		public static string SHA1_Hashing(String value)
		{
			byte[] val = UTF8Encoding.UTF8.GetBytes(value);
			using (SHA1Managed sha = new SHA1Managed())
			{
				return Convert.ToBase64String(sha.ComputeHash(val));
			}
		}

		public string Hashing(String value)
		{
			byte[] val = UTF8Encoding.UTF8.GetBytes(value);
			using (SHA1Managed sha = new SHA1Managed())
			{
				return Convert.ToBase64String(sha.ComputeHash(val));
			}
		}
		public string EncreptbyMD5(byte[] val)
		{
			using (MD5 m = MD5.Create())
			{
				return Convert.ToBase64String(m.ComputeHash(val));
			}
		}

		public bool validRange (int val,int min , int max )
		{
			return val > min && val < max ? true : false;
		}

		public bool IsNotNull ( params String[] values)
		{
			foreach (String item in values)
			{
				if (item == Empty)
				{
					return false;
				}
			}
			return true;
		}

		public static void Alert(string msg, Form_Alert.enmType type)
		{
			Form_Alert frm = new Form_Alert();
			frm.showAlert(msg, type);
		}

		public void Dispose()
		{
			this.Dispose();
		}

		public static PdfPTable ToPdfTable(DataGridView _gv, String title)
		{

			try
			{
				PdfPTable table = new PdfPTable(_gv.Columns.Count -1 );
				PdfPCell cell = new PdfPCell(new Phrase(title));
				cell.Colspan = _gv.ColumnCount;
				cell.HorizontalAlignment = Element.ALIGN_CENTER;
				table.AddCell(cell);
				table.DefaultCell.Padding = 3;
				table.WidthPercentage = 90;
				table.HorizontalAlignment = Element.ALIGN_CENTER;
				foreach (DataGridViewColumn column in _gv.Columns)
				{
					if(column.Index != 4)
					{
					PdfPCell cel = new PdfPCell(new Phrase(column.HeaderText));
					table.AddCell(cel);

					}
				}

				foreach (DataGridViewRow row in _gv.Rows)
				{
					if(row.Index != 4)
					{

					foreach (DataGridViewCell cel in row.Cells)
					{
							if(cel.ColumnIndex != 4)
						table.AddCell(cel.Value.ToString());
					}
					}
				}

				return table;

			}
			catch (Exception ex)
			{
				MyTools.Alert(ex.Message, Form_Alert.enmType.Error);
				return null;
			}
		}
	}
}
