using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace sachbobonho
{
    public partial class FormDangky : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        static SqlCommand sqlcmd;
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        

        public FormDangky()
        {
            InitializeComponent();
        }

        public bool authenticate()
        {
            if(string.IsNullOrWhiteSpace(emailtxtbx.Text) || string.IsNullOrWhiteSpace(passwordtxtbx.Text) || string.IsNullOrWhiteSpace(jobcombobox.Text) || string.IsNullOrWhiteSpace(agetxtbox.Text) || string.IsNullOrWhiteSpace(jobcombobox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void userlbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if(!authenticate())
            {
                MessageBox.Show("Xin hãy điền đầy đủ thông tin");
                return;
            }
            string sqlquery = "insert into Bangnhanvien(Hovatennhanvien, tkemail, gioitinh, matkhau, tuoi, Machucvu, anh3x4) values(@empname, @empemail, @empgen, @emppass, @empage, @idjob, @pic)";
            sqlcmd = new SqlCommand(sqlquery, conn);

            sqlcmd.Parameters.Add("@empname", SqlDbType.NVarChar);
            sqlcmd.Parameters["@empname"].Value = employeetxtbox.Text;
            
            sqlcmd.Parameters.Add("@empemail", SqlDbType.VarChar);
            sqlcmd.Parameters["@empemail"].Value = emailtxtbx.Text;

            sqlcmd.Parameters.Add("@empgen", SqlDbType.Bit);
            sqlcmd.Parameters["@empgen"].Value = maleradiobutton.Checked ? true : false;

            sqlcmd.Parameters.Add("@emppass", SqlDbType.VarChar);
            sqlcmd.Parameters["@emppass"].Value = passwordtxtbx.Text;

            sqlcmd.Parameters.Add("@empage", SqlDbType.Int);
            sqlcmd.Parameters["@empage"].Value = agetxtbox.Text;

            sqlcmd.Parameters.Add("@idjob", SqlDbType.VarChar);
            sqlcmd.Parameters["@idjob"].Value = jobcombobox.SelectedValue.ToString();

            MemoryStream stream = new MemoryStream();
            pic3x4.Image.Save(stream, pic3x4.Image.RawFormat);
            sqlcmd.Parameters.AddWithValue("@pic", stream.ToArray());

            conn.Open();
            sqlcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bạn đã đăng ký thành công!");
            this.Hide();
            FormDangnhap formDangnhap = new FormDangnhap();
            formDangnhap.ShowDialog();
            Application.Exit();
        }

        private void FormDangky_Load(object sender, EventArgs e)
        {
            sqlcmd = new SqlCommand("select Machucvu, chucvu from Bangchucvu", conn);
            adapter.SelectCommand = sqlcmd;
            adapter.Fill(dt);
            jobcombobox.DataSource = dt;
            jobcombobox.DisplayMember = "Chucvu";
            jobcombobox.ValueMember = "Machucvu";
        }

        private void malefemalechck_Enter(object sender, EventArgs e)
        {

        }

        private void malechckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maleradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void femaleradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Chọn đuổi hình ảnh(*.jpg, *.jpeg, *.png, *.gif)| *.jpg; *.jpeg; *.png; *.gif";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic3x4.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangnhap loginform = new FormDangnhap();
            loginform.ShowDialog();
            Application.Exit();
        }

        private void jobcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
