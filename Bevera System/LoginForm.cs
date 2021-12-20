using System;

using System.Drawing;

using System.Windows.Forms;

namespace Bevera_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ////this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //////private const int cGrip = 16;
        //////private const int cCaption = 32;
        ////protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17;
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            
        }
       
        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void _mini_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

		private void logIn1_Load(object sender, EventArgs e)
		{

		}

        private void _head_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

		private void logIn1_Load_1(object sender, EventArgs e)
		{

		}
	}
}
