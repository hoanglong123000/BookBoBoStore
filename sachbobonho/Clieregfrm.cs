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
    public partial class Clieregfrm : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        static SqlCommand sqlcmd;
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public Clieregfrm()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string sqlquery = "insert into Bangkhachhang(Tenkhachhang, Sodienthoai, Matkhau, Gioitinh, Trangthai) values(@clientname, @phonenumber, @clientpass, @clientgender, @clientstate)";
            sqlcmd = new SqlCommand(sqlquery, conn);

            sqlcmd.Parameters.Add("@clientname", SqlDbType.NVarChar);
            sqlcmd.Parameters["@clientname"].Value = clientname.Text;
           

            sqlcmd.Parameters.Add("@phonenumber", SqlDbType.VarChar);
            sqlcmd.Parameters["@phonenumber"].Value = cliephnumbx.Text;

            sqlcmd.Parameters.Add("@clientgender", SqlDbType.Bit);
            sqlcmd.Parameters["@clientgender"].Value = maleradiobutton.Checked ? true : false;

            sqlcmd.Parameters.Add("@clientpass", SqlDbType.VarChar);
            sqlcmd.Parameters["@clientpass"].Value = cliepasbx.Text;

            sqlcmd.Parameters.AddWithValue("@clientstate", false);

          
            conn.Open();
            sqlcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bạn đã đăng ký thành công!");
            this.Hide();
            Dangnhapkhachangform clientsigninfrm = new Dangnhapkhachangform();
            clientsigninfrm.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhapkhachangform clientsigninfrm = new Dangnhapkhachangform();
            clientsigninfrm.ShowDialog();
            this.Close();
        }

        private void Clieregfrm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
