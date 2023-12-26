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
    public partial class loadProject : Form
    {
        public loadProject()
        {
            InitializeComponent();
        }
        int start = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 2;
            pgbar.Value = start;
            if (pgbar.Value == 100)
            {
                pgbar.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();
            }
            
        }

        private void pgbar_Click(object sender, EventArgs e)
        {
          //  this.timer1.Start();

        }

        private void panel_guest_Paint(object sender, PaintEventArgs e)
        {
            this.timer1.Start();
        }
    }
}
