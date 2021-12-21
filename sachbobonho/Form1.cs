using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sachbobonho
{
    public partial class Form1 : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;

        private void sachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sachboboDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
            cmd = new SqlCommand("select Manhanvien, Hovatennhanvien from Bangnhanvien", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            empcombobox.DataSource = dt;
            empcombobox.DisplayMember = "Hovatennhanvien";
            empcombobox.ValueMember = "Manhanvien";
        }

        private void sottTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void sachDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Chọn đuôi của hình ảnh(*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *png; *gif";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Masach as [Mã sách], Tensach as [Tên sách], Manhanvien as [Nhân viên chịu trách nhiệm], biasach as [Bìa sách], gia as [Giá của cuốn sách], soluocnoidung as [Nội dung sơ lược] from BangSach", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        

        private void insertinfobtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("XIN HÃY KIỂM TRA VÀ ĐIỀN TÊN NHÂN VIÊN CHÍNH XÁC VÀ KỸ CÀNG BỞI VÌ NHỮNG THÔNG TIN CẦN ĐƯỢC BIẾT KỸ NHÂN VIÊN PHỤ TRÁCH", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("insert into BangSach(Tensach, soluocnoidung, biasach, Manhanvien, gia) values (@Tensach, @briefcontent, @coverofbook, @idemp, @price)", conn);
                cmd.Parameters.AddWithValue("@Tensach", nameofbooktxtbx.Text);
                cmd.Parameters.AddWithValue("@briefcontent", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(pricetxtbx.Text));
                cmd.Parameters.AddWithValue("@idemp", empcombobox.SelectedValue.ToString());
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
                cmd.Parameters.AddWithValue("@coverofbook", stream.ToArray());


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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nameofbooktxtbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            empcombobox.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[4].Value);
            pictureBox1.Image = Image.FromStream(ms);
            pricetxtbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if(pricetxtbx.Text != "")
            {
                cmd = new SqlCommand("update BangSach set Tensach = @Tensach, soluocnoidung = @briefcontent, biasach = @coverofbook, Manhanvien = @idemp, gia = @price where Sott = @Sott", conn);
                cmd.Parameters.AddWithValue("@Tensach", nameofbooktxtbx.Text);
                cmd.Parameters.AddWithValue("@briefcontent", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@price", int.Parse(pricetxtbx.Text));
                cmd.Parameters.AddWithValue("@idemp", empcombobox.SelectedValue.ToString());
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
                cmd.Parameters.AddWithValue("@coverofbook", stream.ToArray());
                cmd.Parameters.AddWithValue("@Sott", label2.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thông tin thành công!");
                loaddata();
            }
            
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("BỞI VÌ DỮ LIỆU LIÊN KẾT VỚI CƠ SỞ DỮ LIỆU NÊN NẾU CÓ THIẾU DỮ LIỆU THÌ PHẦN MỀM SẼ BỊ LỖI. BẠN CÓ CHẮC CHẮN MUỐN XÓA DÒNG DỮ LIỆU NÀY KHÔNG? Nếu có lỗi xảy ra trong cơ sở dữ liệu thì bạn chịu trách nhiệm!", "CẢNH BÁO!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from BangSach where Sott=@id", conn);
                cmd.Parameters.AddWithValue("@id", label2.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thông tin thành công!");
                loaddata();
                pictureBox1.Image = null;
                nameofbooktxtbx.Text = "";
                label2.Text = "";
            }
            else
            {
                return;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imagetitletxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void briefcontentbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void empcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Sott as [Số thứ tự], Masach as [Mã sách], Tensach as [Tên sách], Manhanvien as [Nhân viên chịu trách nhiệm], biasach as [Bìa sách], gia as [Giá của cuốn sách], soluocnoidung as [Nội dung sơ lược] from BangSach where Tensach like '%' + @generalvar + '%' or gia like '%' + @generalvar + '%' or Sott like '%' + @generalvar + '%' or Manhanvien like '%' + @generalvar + '%' or soluocnoidung = '%' + generalvar '%'", conn);
            cmd.Parameters.AddWithValue("@generalvar", Searchbox.Text.ToString());
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            adapter1.SelectCommand = cmd;
            DataTable dt1 = new DataTable();
            dt.Clear();
            adapter.Fill(dt1);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt1;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
