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
    public partial class Giaodienchinhcuakhach : Form
    {
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        SqlCommand cmd;

        public Giaodienchinhcuakhach()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dangnhapkhachangform optionform = new Dangnhapkhachangform();
            optionform.ShowDialog();

            this.Close();
        }

        public void loaddata()
        {
            cmd = new SqlCommand("select Tensach as [Tên sách], biasach as [Bìa sách], gia as [Giá của cuốn sách] from BangSach", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[1];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Giaodienchinhcuakhach_Load(object sender, EventArgs e)
        {
            label1.Text = Dangnhapkhachangform.clientname;
            label2.Text = Dangnhapkhachangform.clientphonenum;
            label6.Text = Dangnhapkhachangform.clientsta;
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[1].Value);
            pictureBox2.Image = Image.FromStream(ms);
            label5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() + " Đồng";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
