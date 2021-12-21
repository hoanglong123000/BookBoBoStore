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
    public partial class Bangkhosachform : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;

        public Bangkhosachform()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Matacgia as [Mã tác giả], Masach as [Sách], Manhanvien as [Nhân viên nhập liệu], Soluongsach as [Số lượng sách] from Bangkhosach", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("BỞI VÌ DỮ LIỆU LIÊN KẾT VỚI CƠ SỞ DỮ LIỆU NÊN NẾU CÓ THIẾU DỮ LIỆU THÌ PHẦN MỀM SẼ BỊ LỖI. BẠN CÓ CHẮC CHẮN MUỐN XÓA DÒNG DỮ LIỆU NÀY KHÔNG? Nếu có lỗi xảy ra trong cơ sở dữ liệu thì bạn chịu trách nhiệm!", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Bangkhosach where Sott=@id", conn);
                cmd.Parameters.AddWithValue("@id", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
                orderidlbl.Text = "";
                ammountofbookbox.Text = "";
            }
            else
            {
                return;
            }
        }

        private void authorcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            orderidlbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            authorcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bookcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            empcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ammountofbookbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void insertinfobtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("XIN HÃY KIỂM TRA VÀ ĐIỀN TÊN NHÂN VIÊN CHÍNH XÁC VÀ KỸ CÀNG BỞI VÌ NHỮNG THÔNG TIN CẦN ĐƯỢC BIẾT KỸ NHÂN VIÊN PHỤ TRÁCH", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("insert into Bangkhosach(Matacgia, Masach, Manhanvien, Soluongsach) values (@authorid, @bookid, @empid, @ammountofbook)", conn);
                cmd.Parameters.AddWithValue("@authorid", authorcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@bookid", bookcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ammountofbook", int.Parse(ammountofbookbox.Text));
                cmd.Parameters.AddWithValue("@empid", empcombobox.SelectedValue.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Nhập thông tin vào cơ sở dữ liệu thành công");
                loaddata();
            }
            else
            {
                return;
            }    
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (ammountofbookbox.Text != "")
            {
                cmd = new SqlCommand("update Bangkhosach set Matacgia = @authorid, Masach = @bookid, Manhanvien = @empid, Soluongsach = @ammountofbook where Sott = @orderid", conn);
                cmd.Parameters.AddWithValue("@authorid", authorcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@bookid", bookcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ammountofbook", int.Parse(ammountofbookbox.Text));
                cmd.Parameters.AddWithValue("@empid", empcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@orderid", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thông tin thành công!");
                loaddata();
            }
        }

        private void Bangkhosachform_Load(object sender, EventArgs e)
        {
            loaddata();
            cmd = new SqlCommand("select Manhanvien, Hovatennhanvien from Bangnhanvien", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            empcombobox.DataSource = dt;
            empcombobox.DisplayMember = "Hovatennhanvien";
            empcombobox.ValueMember = "Manhanvien";

            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("select Matacgia, Tentacgia from Bangtacgia", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            authorcombobox.DataSource = dt1;
            authorcombobox.DisplayMember = "Tentacgia";
            authorcombobox.ValueMember = "Matacgia";

            DataTable dt2 = new DataTable();
            cmd = new SqlCommand("select Masach, Tensach from BangSach", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt2);
            bookcombobox.DataSource = dt2;
            bookcombobox.DisplayMember = "Tensach";
            bookcombobox.ValueMember = "Masach";

            

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Matacgia as [Mã tác giả], Masach as [Sách], Manhanvien as [Nhân viên nhập liệu], Soluongsach as [Số lượng sách] from Bangkhosach where Masach like '%' + @generalid + '%' or Matacgia like '%' + @generalid + '%' or Manhanvien like '%' + @generalid + '%'", conn);
            cmd.Parameters.AddWithValue("@generalid", Searchbox.Text.ToString());
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            adapter1.SelectCommand = cmd;
            DataTable dt3 = new DataTable();
            dt.Clear();
            adapter1.Fill(dt3);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt3;
        }
    }
}
