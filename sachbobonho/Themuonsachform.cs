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
    public partial class Themuonsachform : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;
        public Themuonsachform()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Tensachmuon as [Tên sách mà khách mượn], Soluongsachmuon as [Số lượng sách mượn], Manhanvien as [Nhân viên ký thẻ], Makhachhang as [Mã khách hàng], Thoigianlapthe as [Thời gian lập phiếu], Thoigianmuonsach as [Thời gian mượn sách], Thoigiantrasach as [Thời gian trả sách] from Themuonsach", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ammountofbookbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertinfobtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("XIN HÃY KIỂM TRA VÀ ĐIỀN TÊN NHÂN VIÊN CHÍNH XÁC VÀ KỸ CÀNG BỞI VÌ NHỮNG THÔNG TIN CẦN ĐƯỢC BIẾT KỸ NHÂN VIÊN PHỤ TRÁCH", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("insert into Themuonsach(Tensachmuon, Soluongsachmuon, Manhanvien, Makhachhang, Thoigianlapthe, Thoigianmuonsach, Thoigiantrasach) values (@nameofbook, @ammountofbook, @empid, @clientid, @foundeddate, @borrowedbookdate, @paybookdate)", conn);
                cmd.Parameters.AddWithValue("@nameofbook", comboBox3.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ammountofbook", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@empid", empcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@clientid", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@foundeddate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@borrowedbookdate", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@paybookdate", dateTimePicker3.Text);
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
                cmd = new SqlCommand("update Themuonsach set Tensachmuon = @Nameofborrowedbook, Soluongsachmuon = @ammountofbook, Manhanvien = @empid, Makhachhang = @clientid, Thoigianlapthe = @foundeddate, Thoigianmuonsach = @datetoborrowbook, Thoigiantrasach = @datetopaybook where Stt = @orderid", conn);
                cmd.Parameters.AddWithValue("@Nameofborrowedbook", comboBox3.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ammountofbook", int.Parse(comboBox2.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@empid", empcombobox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@clientid", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@foundeddate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@datetoborrowbook", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@datetopaybook", dateTimePicker3.Text);
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
                cmd = new SqlCommand("delete from Themuonsach where Stt=@id", conn);
                cmd.Parameters.AddWithValue("@id", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
                comboBox3.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                dateTimePicker3.Text = "";
                orderidlbl.Text = "";
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Themuonsachform_Load(object sender, EventArgs e)
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

            comboBox2.Items.Insert(0, "1");
            comboBox2.Items.Insert(1, "2");
            comboBox2.Items.Insert(2, "3");

            DataTable dt4 = new DataTable();
            cmd = new SqlCommand("select Tensach from BangSach", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt4);
            comboBox3.DataSource = dt4;
            comboBox3.DisplayMember = "Tensach";
            comboBox3.ValueMember = "Tensach";
        }


        private void empcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nameofborrbook_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Stt as [Số thứ tự], Mathe as [Mã thẻ], Tensachmuon as [Tên sách], Soluongsachmuon as [Số lượng sách], Manhanvien as [Mã nhân viên], Makhachhang as [Mã khách], Thoigianlapthe as [Thời gian lập phiếu], Thoigianmuonsach as [Thời gian mượn sách], Thoigiantrasach as [Thời gian trả sách] from Themuonsach where Tensachmuon like '%' + @generalid + '%' or Makhachhang like '%' + @generalid + '%' or Manhanvien like '%' + @generalid + '%' or Mathe like '%' + @generalid + '%' or Thoigianlapthe like '%' + @generalid + '%' or Thoigianmuonsach like '%' + @generalid + '%' or Thoigiantrasach like '%' + @generalid + '%'", conn);
            cmd.Parameters.AddWithValue("@generalid", Searchbox.Text.ToString());
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            adapter1.SelectCommand = cmd;
            DataTable dt3 = new DataTable();
            dt.Clear();
            adapter1.Fill(dt3);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt3;
        }

        private void dataGridView1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            orderidlbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox3.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            empcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
