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
    public partial class PhieuphatForm : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;

        public PhieuphatForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Makhachhang as [Mã khách hàng], Manhanvien as [Mã nhân viên], Noidung as [Lý do], Phiphat as [Phí đền bù], Thoigianlapphieu as [Thời gian] from Phieuphat", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            orderidlbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            empcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            reasonrtbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            finefeetxtbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void insertinfobtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("XIN HÃY KIỂM TRA VÀ ĐIỀN TÊN NHÂN VIÊN CHÍNH XÁC VÀ KỸ CÀNG BỞI VÌ NHỮNG THÔNG TIN CẦN ĐƯỢC BIẾT KỸ NHÂN VIÊN PHỤ TRÁCH", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("insert into Phieuphat(Manhanvien, Makhachhang, Noidung, Phiphat, Thoigianlapphieu) values (@idemp, @clientname, @reason, @finefee, @foundeddate)", conn);
                cmd.Parameters.AddWithValue("@clientname", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@idemp", empcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@reason", reasonrtbx.Text);
                cmd.Parameters.AddWithValue("finefee", int.Parse(finefeetxtbx.Text));
                cmd.Parameters.AddWithValue("@foundeddate", dateTimePicker1.Text);

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
                cmd = new SqlCommand("update Phieuphat set Manhanvien = @idemp, Makhachhang = @clientname, Noidung = @reason, Phiphat = @finefee, Thoigianlapphieu = @foundeddate where Stt = @orderid", conn);
                cmd.Parameters.AddWithValue("@clientname", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@idemp", empcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@reason", reasonrtbx.Text);
                cmd.Parameters.AddWithValue("@foundeddate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@finefee", finefeetxtbx.Text);
                cmd.Parameters.AddWithValue("@orderid", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thông tin thành công!");
                loaddata();
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("BỞI VÌ DỮ LIỆU LIÊN KẾT VỚI CƠ SỞ DỮ LIỆU NÊN NẾU CÓ THIẾU DỮ LIỆU THÌ PHẦN MỀM SẼ BỊ LỖI. BẠN CÓ CHẮC CHẮN MUỐN XÓA DÒNG DỮ LIỆU NÀY KHÔNG? Nếu có lỗi xảy ra trong cơ sở dữ liệu thì bạn chịu trách nhiệm!", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Phieuphat where Stt=@id", conn);
                cmd.Parameters.AddWithValue("@id", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
                comboBox1.Text = "";
                orderidlbl.Text = "";
                reasonrtbx.Text = "";
                dateTimePicker1.Text = "";
            }
            else
            {
                return;
            }
            
        }

        private void PhieuphatForm_Load(object sender, EventArgs e)
        {
            loaddata();
            cmd = new SqlCommand("select Manhanvien, Hovatennhanvien from Bangnhanvien", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            empcombobox.DataSource = dt;
            empcombobox.DisplayMember = "Hovatennhanvien";
            empcombobox.ValueMember = "Manhanvien";

            DataTable dt3 = new DataTable();
            cmd = new SqlCommand("select Makhachhang, Tenkhachhang from Bangkhachhang", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt3);
            comboBox1.DataSource = dt3;
            comboBox1.DisplayMember = "Tenkhachhang";
            comboBox1.ValueMember = "Makhachhang";



        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Makhachhang as [Mã khách hàng], Manhanvien as [Mã nhân viên], Noidung as [Lý do], Phiphat as [Phí đền bù], Thoigianlapphieu as [Thời gian] from Phieuphat where Makhachhang like '%' + @generalid + '%' or Manhanvien like '%' + @generalid + '%' or Noidung like '%' + @generalid + '%' or Phiphat like '%' + @generalid + '%' or Thoigianlapphieu like '%' +  @generalid + '%'", conn);
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
