using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRoomBookingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pic_admin_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            st.Show();
            this.Hide();
        }
        //private void Exit_pic(object sender, EventArgs e)
        //{

        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void Exit_pic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picimage_Click(object sender, EventArgs e)
        {
            Room rm = new Room();
            rm.Show();
            this.Hide();
        }

        private void pic_guest_Click(object sender, EventArgs e)
        {
            Guest_tbl gt = new Guest_tbl();
            gt.Show();
            this.Hide();
        }

        private void pic_Res_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();
            res.Show();
            this.Hide();
        }
    }
}
