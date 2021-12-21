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

namespace sachbobonho
{
    public partial class Dangnhapkhachangform : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        static SqlCommand sqlcmd;
        public static string clientname;
        public static string clientsta;
        public static string clientphonenum;
        

        public Dangnhapkhachangform()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Optionform optionform = new Optionform();
            optionform.ShowDialog();
            
            this.Close();
        }

        public bool authenticate()
        {
            if (string.IsNullOrWhiteSpace(cliephnumbx.Text) || string.IsNullOrWhiteSpace(cliepasbx.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            conn.Close();
            bool chckphonenum = false;
            bool chckpassword = false;
            string sqlquery = "select * from Bangkhachhang where Sodienthoai=@phonenum";
            conn.Open();
            sqlcmd = new SqlCommand(sqlquery, conn);

            sqlcmd.Parameters.AddWithValue("@phonenum", cliephnumbx.Text);


            SqlDataReader sda = sqlcmd.ExecuteReader();
            if (sda.HasRows)
            {
                chckphonenum = true;
            }
            conn.Close();


            conn.Open();
            sqlquery = "select * from Bangkhachhang where Sodienthoai=@phonenum and Matkhau=@clientpass";
            sqlcmd = new SqlCommand(sqlquery, conn);

            sqlcmd.Parameters.AddWithValue("@phonenum", cliephnumbx.Text);
            sqlcmd.Parameters.AddWithValue("@clientpass", cliepasbx.Text);
            sda = sqlcmd.ExecuteReader();

            if (sda.HasRows)
            {
                chckpassword = true;
            }

            if (chckphonenum == false)
            {
                MessageBox.Show("Số điện thoại chưa được đăng ký! Mời bạn đăng ký ở link ở dưới");
            }

            else if (chckphonenum == false && chckpassword == false)
            {
                MessageBox.Show("Sai thông tin mật khẩu và số điện thoại!");
            }

            else if (chckphonenum == false && chckpassword == true)
            {
                MessageBox.Show("Sai số điện thoại!");
            }

            else if (chckpassword == false && chckphonenum == true)
            {
                MessageBox.Show("Sai mật khẩu!");
            }

            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                Giaodienchinhcuakhach form1 = new Giaodienchinhcuakhach();
                while (sda.Read())
                {
                    clientname = sda.GetValue(2).ToString();
                    clientphonenum = sda.GetValue(4).ToString();
                    clientsta = (bool)sda.GetValue(3) == true?"PHẠT ĐỀN BÙ":"TỐT";
                }
                form1.ShowDialog();
                conn.Close();
                this.Close();
            }
        }

        private void cliepasbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerlink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clieregfrm regform = new Clieregfrm();
            regform.ShowDialog();
            this.Close();
        }

        private void Dangnhapkhachangform_Load(object sender, EventArgs e)
        {

        }
    }
}
