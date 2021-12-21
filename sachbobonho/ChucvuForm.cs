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
    public partial class ChucvuForm : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;

        public ChucvuForm()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Hovatennhanvien as [Họ và tên đã được chỉnh sửa], tkemail as [Tài khoản email đã được sửa], matkhau as [Mật khẩu đã được sửa], gioitinh as [Giới tính], tuoi as [tuổi], Machucvu as [Mã chức vụ], anh3x4 as [Ảnh cá nhân] from Bangnhanvien", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[7];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }


        private void empcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maleradiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("TRƯỚC KHI CẬP NHẬT THÔNG TIN CỦA NHÂN VIÊN, HÃY ĐẢM BẢO VIỆC CẬP NHẬT HAY THAY ĐỔI THÔNG TIN NHÂN VIÊN PHỤ TRÁCH Ở TỪNG BẢNG DỮ LIỆU KHÁC", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            
            if (agetxtbox.Text != "" && res == DialogResult.Yes)
            {
                cmd = new SqlCommand("update Bangnhanvien set Hovatennhanvien = @empname, tkemail = @emailacc, gioitinh = @gender, matkhau = @emppass, tuoi = @empage, Machucvu = @jobid, anh3x4 = @image3x4  where Sott = @orderid", conn);
                cmd.Parameters.AddWithValue("@empname", empnametxtbx.Text);
                cmd.Parameters.AddWithValue("@emailacc", emailtxtbx.Text);
                cmd.Parameters.AddWithValue("@gender", femaleradiobutton.Checked? false: true);
                cmd.Parameters.AddWithValue("@emppass", emppasstxtbox.Text);
                cmd.Parameters.AddWithValue("@empage", int.Parse(agetxtbox.Text));
                cmd.Parameters.AddWithValue("@jobid", jobcombobox.SelectedValue.ToString());
                MemoryStream stream = new MemoryStream();
                pic3x4.Image.Save(stream, pic3x4.Image.RawFormat);
                cmd.Parameters.AddWithValue("@image3x4", stream.ToArray());
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

        private void agetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empnametxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Chọn đuôi của hình ảnh(*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *png; *gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic3x4.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void ChucvuForm_Load(object sender, EventArgs e)
        {
            loaddata();
            cmd = new SqlCommand("select Machucvu, Chucvu from Bangchucvu", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            jobcombobox.DataSource = dt;
            jobcombobox.DisplayMember = "Chucvu";
            jobcombobox.ValueMember = "Machucvu";


           
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("TRƯỚC KHI XÓA THÔNG TIN CỦA NHÂN VIÊN NÀO ĐÓ, HÃY ĐẢM BẢO VIỆC CẬP NHẬT HAY THAY ĐỔI THÔNG TIN NHÂN VIÊN PHỤ TRÁCH Ở TỪNG BẢNG DỮ LIỆU KHÁC! NẾU KHÔNG THÌ SẼ SINH RA LỖI KHÔNG MONG ĐỢI Ở PHẦN MỀM", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from Bangnhanvien where Sott=@id", conn);
                cmd.Parameters.AddWithValue("@id", orderidlbl.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
                pic3x4.Image = null;
                empnametxtbx.Text = "";
                orderidlbl.Text = "";
                emailtxtbx.Text = "";
                emppasstxtbox.Text = "";
                agetxtbox.Text = "";
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
            empnametxtbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            emailtxtbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if((bool)dataGridView1.CurrentRow.Cells[4].Value == true)
            {
                maleradiobutton.Checked = true;
            }
            else
            {
                maleradiobutton.Checked = false;
                femaleradiobutton.Checked = true;
            }
            emppasstxtbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            agetxtbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            jobcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[7].Value);
            pic3x4.Image = Image.FromStream(ms);
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Hovatennhanvien as [Họ và tên đã được chỉnh sửa], tkemail as [Tài khoản email đã được sửa], matkhau as [Mật khẩu đã được sửa], gioitinh as [Giới tính], tuoi as [tuổi], Machucvu as [Mã chức vụ], anh3x4 as [Ảnh cá nhân] from Bangnhanvien where Hovatennhanvien like '%' +@generalid+ '%' or tkemail like '%' +@generalid+ '%' or matkhau like '%' +@generalid+ '%' or tuoi like '%' +@generalid+ '%'", conn);
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
