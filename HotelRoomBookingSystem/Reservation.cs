using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelRoomBookingSystem
{
    public partial class Reservation : Form
    {
        DateTime today;
        SqlConnection con = new SqlConnection(@"Data Source=U_S_H_A\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");

        public Reservation()
        {
            InitializeComponent();
        }
        
        public void populate()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reservation", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridRes.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillguestcb()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select FirstName from Guest", con);
            // SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            //sda.Fill(dt);
            dt.Columns.Add("FirstName", typeof(String));
            //DataGridRes.DataSource = dt;
            dt.Load(rdr);
            cb_guestname.ValueMember = "FirstName";
            cb_guestname.DataSource = dt;
            con.Close();
        }
        public void fillroomcb()
        {
            con.Open();
            string rmstatus = "Free";
            SqlCommand cmd = new SqlCommand("select RoomId from Room where RoomStatus='"+rmstatus+"'", con);
            // SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            //sda.Fill(dt);
            dt.Columns.Add("RoomId", typeof(int));
            //DataGridRes.DataSource = dt;
            dt.Load(rdr);
            cb_roomid.ValueMember = "RoomId";
            cb_roomid.DataSource = dt;
            con.Close();
        }

        public void updateroomstatus()
        {
            con.Open();
            string rmst = "Busy";
            // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("UPDATE Room SET  RoomStatus='"+rmst+"' where RoomId='" + Convert.ToInt32(cb_roomid.SelectedValue.ToString()) +
                "'", con);
            // populate();

            int result = cmd.ExecuteNonQuery();
            con.Close();
            fillroomcb();
        }

        public void updeleteroomstatus()
        {
            con.Open();
            string rmst = "Free";
            int rmid =Convert.ToInt32( DataGridRes.Rows[0].Cells[2].Value.ToString());
           


            // = Convert.ToInt32( DataGridRes.SelectedRows[0].Cells[2].Value.ToString());
            // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("UPDATE Room SET  RoomStatus='" + rmst + "' where RoomId='" + rmid + "'", con);
            // populate();

            int result = cmd.ExecuteNonQuery();
            con.Close();
          //  fillroomcb();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // lbl_date.Text = DateTime.Now.ToLongTimeString();
            //lbl_date.Text = DateTime.Today.Month.ToString();
            lbl_date.Text = DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString();



        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            timer1.Start();
            fillroomcb();
            fillguestcb();
            populate();
        }

        private void dtp_checkin_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dtp_checkin.Value, today);
            if (res < 0)
            {
                MessageBox.Show("Wrong Date for Reservation");

            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dtp_checkout.Value,dtp_checkin.Value);
            if (res < 0)
            {
                MessageBox.Show("Wrong DateOut, Check Once More for Reservation");

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != string.Empty || cb_guestname.Text != string.Empty|| cb_roomid.Text != string.Empty || dtp_checkin.Text != string.Empty|| dtp_checkout.Text != string.Empty)
            {
                



                con.Open();
                // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand("insert into Reservation(ResId,Guest,Room,DateIn,DateOut) values('" + txt_id.Text + "', '" + cb_guestname.SelectedValue.ToString() + "', '" + cb_roomid.SelectedValue.ToString() + "', '" + dtp_checkin.Value + "', '" + dtp_checkout.Value + "')", con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                    MessageBox.Show("Data saved.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txt_id.Clear();
                populate();
                updateroomstatus();
            }
            else
            {
                MessageBox.Show("Empty field not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != string.Empty || cb_guestname.Text != string.Empty|| cb_roomid.Text != string.Empty|| dtp_checkin.Text != string.Empty|| dtp_checkout.Text != string.Empty)

            {
               
                con.Open();
                // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand("UPDATE Reservation SET  Guest='" + cb_guestname.SelectedValue.ToString() + 
                    "',Room='" + cb_roomid.SelectedValue.ToString()
                    + "',DateIn='" + dtp_checkin.Value.ToString() + "',DateOut='" + dtp_checkout.Value.ToString() + "' where ResId='" + txt_id.Text + "'", con);
                // populate();

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                    MessageBox.Show("Data Edit.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Not Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txt_id.Clear();
                

                populate();
            }
            else
            {
                MessageBox.Show("Empty field not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Reservation where ResId='" + txt_id.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully.");
            con.Close();
            updeleteroomstatus();
            populate();
        }

        private void pic_datareset_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != string.Empty || cb_guestname.Text != string.Empty)

            {

                txt_id.Clear();
                //txt_phone.Clear();
                //rb_busy.Checked = false;
                //rb_free.Checked = false;




            }
        }

        private void btn_searchname_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // txt_fname.Text = txt_fname.Text + " " + txt_lname.Text;
                SqlCommand cmd = new SqlCommand("Select * from  Reservation where ResId LIKE '" + txt_searchname.Text+ "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridRes.DataSource = dt;
                con.Close();
                // populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pc_reset_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void DataGridRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridRes.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                cb_guestname.Text = row.Cells[1].Value.ToString();
                cb_roomid.Text = row.Cells[2].Value.ToString();
                dtp_checkin.Text = row.Cells[3].Value.ToString();
                dtp_checkout.Text = row.Cells[4].Value.ToString();

            }
            }

        private void Back_Click(object sender, EventArgs e)
        {
            MainForm mn = new MainForm();
            mn.Show();
            this.Hide();
        }
    }
}
