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
    public partial class Clientfrm : Form
    {

        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;

        public Clientfrm()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Makhachhang as [Mã khách], Tenkhachhang as [Họ và tên đã được chỉnh sửa], Trangthai as [Bị phạt hay không], Sodienthoai as [Số điện thoại], Matkhau as [Mật khẩu], Gioitinh as [Giới tính] from Bangkhachhang", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
            
        }

        private void insertinfobtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Clientfrm_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("TRƯỚC KHI CẬP NHẬT THÔNG TIN CỦA NHÂN VIÊN, HÃY ĐẢM BẢO VIỆC CẬP NHẬT HAY THAY ĐỔI THÔNG TIN NHÂN VIÊN PHỤ TRÁCH Ở TỪNG BẢNG DỮ LIỆU KHÁC", "CẢNH BÁO!", MessageBoxButtons.YesNo);

            if (clienttxtbx.Text != "" && res == DialogResult.Yes)
            {
                cmd = new SqlCommand("update Bangkhachhang set Tenkhachhang = @clientname, Trangthai = @cliestatus, Sodienthoai = @phonenum, Matkhau = @cliepass, Gioitinh = @cliegens where Stt = @orderid", conn);
                cmd.Parameters.AddWithValue("@orderid", int.Parse(orderidlbl.Text));
                cmd.Parameters.AddWithValue("@clientname", clienttxtbx.Text);
                cmd.Parameters.AddWithValue("@cliestatus", fineradiobutton.Checked? true: false);
                cmd.Parameters.AddWithValue("@cliegens", radioButton2.Checked ? true : false);
                cmd.Parameters.AddWithValue("@cliepass", passbx.Text);
                cmd.Parameters.AddWithValue("@phonenum", phonenumbx.Text);
                
                               
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thông tin thành công!");
                loaddata();
            }
            else
            {
                return;
            }
        }

        private void clienttxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("BỞI VÌ DỮ LIỆU LIÊN KẾT VỚI CƠ SỞ DỮ LIỆU NÊN NẾU CÓ THIẾU DỮ LIỆU THÌ PHẦN MỀM SẼ BỊ LỖI. BẠN CÓ CHẮC CHẮN MUỐN XÓA DÒNG DỮ LIỆU NÀY KHÔNG? Nếu có lỗi xảy ra trong cơ sở dữ liệu thì bạn chịu trách nhiệm!", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Bangkhachhang where Stt=@id", conn);
                cmd.Parameters.AddWithValue("@id", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
            }
            else
            {
                return;
            }
        }

        private void orderidlbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Makhachhang as [Mã khách hàng], Tenkhachhang as [Tên khách hàng], Trangthai as [Bị phạt], Sodienthoai as [Số điện thoại], Matkhau as [Mật khẩu], Gioitinh as [Giới tính] from Bangkhachhang where Makhachhang like '%' + @generalid + '%' or Tenkhachhang like '%' + @generalid + '%' or Sodienthoai like '%' + @generalid + '%'", conn);
            cmd.Parameters.AddWithValue("@generalid", Searchbox.Text.ToString());
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            adapter1.SelectCommand = cmd;
            DataTable dt3 = new DataTable();
            dt.Clear();
            adapter1.Fill(dt3);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt3;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            orderidlbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            clienttxtbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if((bool)dataGridView1.CurrentRow.Cells[3].Value == true)
            {
                fineradiobutton.Checked = true;
                goodrdbtn.Checked = false;
            }
            else if((bool)dataGridView1.CurrentRow.Cells[3].Value == false)
            {
                fineradiobutton.Checked = false;
                goodrdbtn.Checked = true;
            }
            else
            {
                fineradiobutton.Checked = false;
                goodrdbtn.Checked = false;
            }

            phonenumbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            passbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if ((bool)dataGridView1.CurrentRow.Cells[6].Value == true)
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            else if ((bool)dataGridView1.CurrentRow.Cells[6].Value == false)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = false;
                radioButton1.Checked = false;
            }

           


        }

        private void phonenumbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
