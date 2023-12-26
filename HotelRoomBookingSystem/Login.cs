using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelRoomBookingSystem
{
    public partial class LoginForm : Form
    {
        //SqlConnection Con = new SqlConnection(@"Data Source=U_S_H_A\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True");
        string cs = @"Data Source=U_S_H_A\SQLEXPRESS;Initial Catalog=HotelManagementSystem;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void log_in_Click(object sender, EventArgs e)
        {

            //    Con.Open();
            //    SqlDataAdapter sda = new SqlDataAdapter("select * from Staff where StaffName='" + txtboxusername.Text + "' and +StaffPass='" + txtpassword.Text + "'", Con);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    try
            //    {
            //        if (dt.Rows[0][0].ToString() != "1")
            //        {
            //            MessageBox.Show("Wrong User Name or Password ");
            //            MessageBox.Show("Try it Again......... ");

            //        }
            //        else
            //        {
            //            MainForm mf = new MainForm();
            //            mf.Show();
            //            this.Hide();

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message + "\n\nWrong User Name or Password ");
            //        //MessageBox.Show();
            //        //MessageBox.Show("Try it Again......... ");
            //    }

            //    Con.Close();


            //}
            if (txtboxusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select * from Staff where StaffName='" + txtboxusername.Text + "' and +StaffPass='" + txtpassword.Text + "'", con);
                cmd.Parameters.AddWithValue("@StaffName", txtboxusername.Text);
                cmd.Parameters.AddWithValue("@StaffPass", txtpassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    MainForm fm = new MainForm();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!"+"\n\n Provide Valid Username and Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
