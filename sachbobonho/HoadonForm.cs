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
    public partial class HoadonForm : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public HoadonForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Makhachhang as [Mã của khách], Manhanvien as [Nhân viên thu ngân], Masach as [Tên sách], Soluongsach as [Số lượng sách], Ngaylaphoadon as [Thời gian khách mua], Tongtien as [Tổng số tiền], Giasach as [Giá của cuốn sách] from Hoadon", conn);
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
            var res = MessageBox.Show("XIN HÃY KIỂM TRA VÀ ĐIỀN TÊN NHÂN VIÊN CHÍNH XÁC VÀ KỸ CÀNG BỞI VÌ NHỮNG THÔNG TIN CẦN ĐƯỢC BIẾT KỸ NHÂN VIÊN PHỤ TRÁCH", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("insert into Hoadon(Manhanvien, Soluongsach, Giasach, Ngaylaphoadon, Makhachhang, Masach) values (@idemp, @ammountofbook, @priceofbook, @foundeddate, @clienttextbx, @nameofbook)", conn);
                cmd.Parameters.AddWithValue("@idemp", empcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ammountofbook", int.Parse(comboBox4.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@priceofbook", int.Parse(comboBox1.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@foundeddate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@nameofbook", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@clienttextbx", comboBox3.SelectedValue.ToString());

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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("BỞI VÌ DỮ LIỆU LIÊN KẾT VỚI CƠ SỞ DỮ LIỆU NÊN NẾU CÓ THIẾU DỮ LIỆU THÌ PHẦN MỀM SẼ BỊ LỖI. BẠN CÓ CHẮC CHẮN MUỐN XÓA DÒNG DỮ LIỆU NÀY KHÔNG? Nếu có lỗi xảy ra trong cơ sở dữ liệu thì bạn chịu trách nhiệm!", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Hoadon where Stt=@id", conn);
                cmd.Parameters.AddWithValue("@id", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
                comboBox3.SelectedValue = "";
                comboBox2.SelectedValue = "";
                comboBox1.SelectedValue = 0;
                comboBox4.SelectedValue = "";
            }
            else
            {
                return;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                cmd = new SqlCommand("update Hoadon set Manhanvien = @idemp, Soluongsach = @numbersofbook, Giasach = @priceofbook, Ngaylaphoadon = @foundeddate, Makhachhang = @clientnamebx, Masach = @nameofbook where Stt = @orderid", conn);
                cmd.Parameters.AddWithValue("@numbersofbook", int.Parse(comboBox4.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@nameofbook", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@priceofbook", int.Parse(comboBox1.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@foundeddate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@idemp", empcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@orderid", orderidlbl.Text);
                cmd.Parameters.AddWithValue("@clientnamebx", comboBox3.SelectedValue.ToString());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thông tin thành công!");
                loaddata();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            orderidlbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox3.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            empcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox2.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void HoadonForm_Load(object sender, EventArgs e)
        {
            loaddata();
            cmd = new SqlCommand("select Manhanvien, Hovatennhanvien from Bangnhanvien", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            empcombobox.DataSource = dt;
            empcombobox.DisplayMember = "Hovatennhanvien";
            empcombobox.ValueMember = "Manhanvien";

            DataTable dt1 = new DataTable();
            cmd = new SqlCommand("select Tensach, gia from BangSach", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Tensach";
            comboBox1.ValueMember = "gia";

            DataTable dt2 = new DataTable();
            cmd = new SqlCommand("select Tensach, Masach from BangSach", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt2);
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Tensach";
            comboBox2.ValueMember = "Masach";

            DataTable dt3 = new DataTable();
            cmd = new SqlCommand("select Makhachhang, Tenkhachhang from Bangkhachhang", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt3);
            comboBox3.DataSource = dt3;
            comboBox3.DisplayMember = "Tenkhachhang";
            comboBox3.ValueMember = "Makhachhang";

            comboBox4.Items.Insert(0, "1");
            comboBox4.Items.Insert(1, "2");
            comboBox4.Items.Insert(2, "3");
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Makhachhang as [Mã của khách], Manhanvien as [Mã nhân viên], Masach as [Mã sách], Soluongsach as [Số lượng sách], Ngaylaphoadon as [Thời gian khách mua], Tongtien as [Tổng số tiền], Giasach as [Giá của cuốn sách] from Hoadon where Makhachhang like '%' + @generalid + '%' or Manhanvien like '%' + @generalid + '%' or Masach like '%' + @generalid + '%' or Ngaylaphoadon like '%' + @generalid + '%' or Giasach like '%' + @generalid + '%'", conn);
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
