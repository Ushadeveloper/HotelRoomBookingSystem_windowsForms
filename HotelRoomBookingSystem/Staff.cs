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
    public partial class Staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=U_S_H_A\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");

        public Staff()
        {
            InitializeComponent();
        }
        public void populate()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Staff", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridStaff.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void gpbox_staff_Enter(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongTimeString();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != string.Empty || txt_pass.Text != string.Empty || txt_phone.Text != string.Empty || comboBox_gender.Text != string.Empty)
            {
               
                con.Open();
                // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand("insert into Staff(StaffName,StaffPass,StaffPhone,Gender) values('" + txt_name.Text + "', '" + txt_pass.Text + "', '" + txt_phone.Text + "', '" + comboBox_gender.SelectedItem.ToString() + "')", con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                    MessageBox.Show("Data saved.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txt_id.Clear();
                txt_name.Clear();
                txt_pass.Clear();
                txt_phone.Clear();
                
                comboBox_gender.Text= " Gender";
                populate();
            }
            else
            {
                MessageBox.Show("Empty field not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != string.Empty || txt_pass.Text != string.Empty || txt_phone.Text != string.Empty || comboBox_gender.Text != string.Empty)
            {
                con.Open();
                // string theDate = txt_dob.Value.ToString("yyyy-MM-dd");
                SqlCommand cmd = new SqlCommand("UPDATE Staff SET StaffName='" + txt_name.Text + "', StaffPass='" + txt_pass.Text + "',StaffPhone='" + txt_phone.Text + "', " +
                    "Gender='" + comboBox_gender.Text + "' where StaffId='" + txt_id.Text + "'", con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Data Updated Successfully.");
                //con.Close();
               // populate();

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                    MessageBox.Show("Data Edit.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Not Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txt_id.Clear();
                txt_name.Clear();
                txt_pass.Clear();
                txt_phone.Clear();

                comboBox_gender.Text = " Gender";
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
            SqlCommand cmd = new SqlCommand("delete from Staff where StaffId='" + txt_id.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully.");
            con.Close();
            populate();
        }

        private void DataGridGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridStaff.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_name.Text = row.Cells[1].Value.ToString();
                txt_pass.Text = row.Cells[2].Value.ToString();
                comboBox_gender.Text = row.Cells[3].Value.ToString();
            }
            }

        private void btn_searchname_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // txt_fname.Text = txt_fname.Text + " " + txt_lname.Text;
                SqlCommand cmd = new SqlCommand("Select * from  Staff where StaffName LIKE '" + txt_searchname.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridStaff.DataSource = dt;
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

        private void pic_datareset_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != string.Empty || txt_name.Text != string.Empty || 
                txt_phone.Text != string.Empty || comboBox_gender.Text != string.Empty )
            {
                txt_id.Clear();
                txt_name.Text = "";
                txt_pass.Text = "";
                txt_phone.Text = "";
                comboBox_gender.Text = " Gender";
                


            }
        }

        private void DataGridStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridStaff.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_name.Text = row.Cells[1].Value.ToString();
                txt_pass.Text = row.Cells[2].Value.ToString();
                txt_phone.Text = row.Cells[3].Value.ToString();
                comboBox_gender.Text = row.Cells[4].Value.ToString();
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
