using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRoomBookingSystem
{
    public partial class Guest_tbl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=U_S_H_A\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");

        public void populate()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Guest", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridGuest.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Guest_tbl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Guest_tbl_Load(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Maximized;
            lbl_date.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_addGuest_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text != string.Empty || txt_lname.Text != string.Empty || txt_phone.Text != string.Empty || txt_address.Text != string.Empty ||
                txt_dob.Text != string.Empty || txt_email.Text != string.Empty)
            {
                string fname = txt_fname.Text;
                string lname = txt_lname.Text;
                string address = txt_address.Text;
                string dob = txt_dob.Text;
                string phone = txt_phone.Text;
                string email = txt_email.Text;
                con.Open();
                // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand("insert into Guest(FirstName,LastName,DateOfBirth,Address,Phone,Email) values('" + txt_fname.Text + "', '" + txt_lname.Text + "', '" + txt_dob.Text.ToString() + "','" + txt_address.Text + "', '" + txt_phone.Text + "', '" + txt_email.Text + "')", con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                    MessageBox.Show("Data saved.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              

                txt_id.Clear();
                txt_fname.Clear();
                txt_lname.Clear();
                txt_dob.Clear();
                txt_address.Clear();
                txt_phone.Clear();
                txt_email.Clear();
                populate();
            }
            else
            {
                MessageBox.Show("Empty field not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void DataGridGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // = Convert.ToInt32(DataGridGuest.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_fname.Text = DataGridGuest.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txt_lname.Text = DataGridGuest.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridGuest.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_fname.Text = row.Cells[1].Value.ToString();
                txt_lname.Text = row.Cells[2].Value.ToString();
                txt_dob.Text = row.Cells[3].Value.ToString();
                txt_address.Text = row.Cells[4].Value.ToString();
                txt_phone.Text = row.Cells[5].Value.ToString();
                txt_email.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            con.Open();
            // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("UPDATE Guest SET FirstName='" + txt_fname.Text + "', LastName='" + txt_lname.Text + "'," +
                " DateOfBirth='" + txt_dob.Text.ToString() + "',Address='" + txt_address.Text + "', " +
                "Phone='" + txt_phone.Text + "', Email='" + txt_email.Text + "' where GuestID='" + txt_id.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully.");
            con.Close();
            populate();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Guest where GuestID='" + txt_id.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully.");
            con.Close();
            populate();

        }

        private void pc_reset_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_searchname_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               // txt_fname.Text = txt_fname.Text + " " + txt_lname.Text;
                SqlCommand cmd = new SqlCommand("Select * from  Guest where FirstName LIKE '" + txt_searchname.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridGuest.DataSource = dt;
                con.Close();
               // populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pic_datareset_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text != string.Empty || txt_lname.Text != string.Empty || txt_phone.Text != string.Empty || txt_address.Text != string.Empty ||
                txt_dob.Text != string.Empty || txt_email.Text != string.Empty)
            {
                txt_id.Clear();
                txt_fname.Text = "";
                txt_lname.Text = "";
                txt_dob.Text = "";
                txt_address.Text = "";
                txt_phone.Text = "";
                txt_email.Text = "";
                
                
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
