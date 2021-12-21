using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sachbobonho
{
    public partial class FormDangnhap : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        static SqlCommand sqlcmd;
        public static string empname;
        public static string empid;
        public static string empjob;
        public static PictureBox emppicture;
        public static MemoryStream stream = new MemoryStream();

        public FormDangnhap()
        {
            InitializeComponent();
        }

        public bool authenticate()
        {
            if (string.IsNullOrWhiteSpace(emailtxtbx.Text) || string.IsNullOrWhiteSpace(passwordtxtbx.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void registerlink_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangky regform = new FormDangky();
            regform.ShowDialog();
            Application.Exit();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            conn.Close();
            bool chckemail = false;
            bool chckpassword = false;
            string sqlquery = "select * from Bangnhanvien where tkemail=@emailacc";
            conn.Open();
            sqlcmd = new SqlCommand(sqlquery, conn);

            sqlcmd.Parameters.AddWithValue("@emailacc", emailtxtbx.Text);

           
            SqlDataReader sda = sqlcmd.ExecuteReader();
            if(sda.HasRows)
            {
                chckemail = true;
            }
            conn.Close();


            conn.Open();
            sqlquery = "select * from Bangnhanvien where tkemail=@emailacc and matkhau=@emppassword";
            sqlcmd = new SqlCommand(sqlquery, conn);

            sqlcmd.Parameters.AddWithValue("@emailacc", emailtxtbx.Text);
            sqlcmd.Parameters.AddWithValue("@emppassword", passwordtxtbx.Text);
            sda = sqlcmd.ExecuteReader();

            if(sda.HasRows)
            {
                chckpassword = true;
            }

            if(chckemail == false)
            {
                MessageBox.Show("Email chưa được đăng ký! Mời bạn đăng ký ở link ở dưới");
            }

            else if (chckemail == false && chckpassword == false)
            {
                MessageBox.Show("Sai thông tin mật khẩu và email!");
            }

            else if(chckemail == false && chckpassword == true)
            {
                MessageBox.Show("Sai tài khoản email!");
            }

            else if(chckpassword == false && chckemail == true)
            {
                MessageBox.Show("Sai mật khẩu!");
            }

            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                MainForm form1 = new MainForm();
                while(sda.Read())
                {
                    empid = sda.GetValue(1).ToString();
                    empname = sda.GetValue(2).ToString();
                    stream = new MemoryStream((byte[])sda.GetValue(8));
                    empjob = sda.GetValue(7).ToString();
                }
                form1.ShowDialog();
                conn.Close();
                Application.Exit();
            }
           
        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Optionform optionform = new Optionform();
            optionform.ShowDialog();
            this.Close();
        }
    }
}
