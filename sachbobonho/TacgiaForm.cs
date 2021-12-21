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
    public partial class TacgiaForm : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;


        public void loaddata()
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Tentacgia as [Tên của tác giả], Diachi as [Nơi ở], Sodienthoai as [Số điện thoại], Manhanvien as [Nhân viên nhập liệu], Anhcanhan as [Ảnh đại diện] from Bangtacgia", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
        }

        public TacgiaForm()
        {
            InitializeComponent();
        }

        private void insertinfobtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("XIN HÃY KIỂM TRA VÀ ĐIỀN TÊN NHÂN VIÊN CHÍNH XÁC VÀ KỸ CÀNG BỞI VÌ NHỮNG THÔNG TIN CẦN ĐƯỢC BIẾT KỸ NHÂN VIÊN PHỤ TRÁCH", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("insert into Bangtacgia(Tentacgia, Diachi, Sodienthoai, Manhanvien, Anhcanhan) values (@authorname, @address, @authorphonenumber, @idemp, @profilepic)", conn);
                cmd.Parameters.AddWithValue("@authorname", nameofauthortxtbx.Text);
                cmd.Parameters.AddWithValue("@address", addresstxtbx.Text);
                cmd.Parameters.AddWithValue("@authorphonenumber", phonenumbertxtbx.Text);
                cmd.Parameters.AddWithValue("@idemp", idempbox.SelectedValue.ToString());
                MemoryStream stream = new MemoryStream();
                profilepicbox.Image.Save(stream, profilepicbox.Image.RawFormat);
                cmd.Parameters.AddWithValue("@profilepic", stream.ToArray());


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

        private void TacgiaForm_Load(object sender, EventArgs e)
        {
            loaddata();
            cmd = new SqlCommand("select Manhanvien, Hovatennhanvien from Bangnhanvien", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            idempbox.DataSource = dt;
            idempbox.DisplayMember = "Hovatennhanvien";
            idempbox.ValueMember = "Manhanvien";


           
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (nameofauthortxtbx.Text != "")
            {
                cmd = new SqlCommand("update Bangtacgia set Tentacgia = @authorname, Diachi = @address, Sodienthoai = @phonenumber, Manhanvien = @idemp, Anhcanhan = @profilepic where Sott = @orderid", conn);
                cmd.Parameters.AddWithValue("@authorname", nameofauthortxtbx.Text);
                cmd.Parameters.AddWithValue("@address", addresstxtbx.Text);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumbertxtbx.Text);
                cmd.Parameters.AddWithValue("@idemp", idempbox.SelectedValue.ToString());
                MemoryStream stream = new MemoryStream();
                profilepicbox.Image.Save(stream, profilepicbox.Image.RawFormat);
                cmd.Parameters.AddWithValue("@profilepic", stream.ToArray());
                cmd.Parameters.AddWithValue("@orderid", orderidlbl.Text);
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("BỞI VÌ THÔNG TIN CỦA TÁC GIẢ SẼ LIÊN KẾT VỚI THÔNG TIN KHO SÁCH NÊN TRƯỚC KHI XÓA THÔNG TIN TÁC GIẢ THÌ NÊN XÓA THÔNG TIN TÁC GIẢ Ở MỤC KHO SÁCH TRƯỚC", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Bangtacgia where Sott=@id", conn);
                cmd.Parameters.AddWithValue("@id", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
                profilepicbox.Image = null;
                nameofauthortxtbx.Text = "";
                orderidlbl.Text = "";
                addresstxtbx.Text = "";
                phonenumbertxtbx.Text = "";

            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            orderidlbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nameofauthortxtbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            addresstxtbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            phonenumbertxtbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            idempbox.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[5].Value);
            profilepicbox.Image = Image.FromStream(ms);
        }

        private void uploadimagebtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Chọn đuôi của hình ảnh(*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *png; *gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                profilepicbox.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Tentacgia as [Tên của tác giả], Diachi as [Nơi ở], Sodienthoai as [Số điện thoại], Manhanvien as [Nhân viên nhập liệu], Anhcanhan as [Ảnh đại diện] from Bangtacgia where Tentacgia like '%' + @generalid + '%' or Diachi like '%' + @generalid + '%' or Sodienthoai like '%' + @generalid + '%' or Manhanvien like '%' + @generalid + '%'", conn);
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
