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
    public partial class MainForm : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");

        public MainForm()
        {
            InitializeComponent();
        }

        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Themuonsachform());
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var signout = MessageBox.Show("Bạn có muốn đăng xuất không? Bởi vì nếu bạn muốn đăng xuất thì bạn hãy kiểm tra kỹ những thông tin trong từng bảng trước bạn đăng xuất!", "Thông báo", MessageBoxButtons.YesNo);
            if (signout == DialogResult.Yes)
            {
                this.Hide();
                conn.Close();
                FormDangnhap formDangnhap = new FormDangnhap();
                formDangnhap.ShowDialog();
                
                Application.Exit();
            }
            else
            {
                return;
            }
             
            
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = FormDangnhap.empname;
            label3.Text = FormDangnhap.empid;
            pictureBox1.Image = Image.FromStream(FormDangnhap.stream);
            if(FormDangnhap.empjob.ToString() == "ChV00004")
            {
                empbutton.Enabled = true;
                empbutton.Visible = true;
                button7.Enabled = true;
                button7.Visible = true;
                button1.Enabled = false;
                button1.Visible = false;
                button2.Enabled = false;
                button2.Visible = false;
                button3.Enabled = false;
                button3.Visible = false;
                button4.Enabled = false;
                button4.Visible = false;
                button5.Enabled = false;
                button5.Visible = false;
                button6.Enabled = false;
                button6.Visible = false;
                button11.Visible = true;
                button11.Enabled = true;
            }

            if(FormDangnhap.empjob.ToString() == "ChV00001")
            {
                button8.Visible = true;
                button8.Enabled = true;
                button2.Visible = true;
                button2.Enabled = true;
                button1.Visible = true;
                button1.Enabled = true;
                button3.Enabled = false;
                button3.Visible = false;
                button4.Enabled = false;
                button4.Visible = false;
                button5.Enabled = true;
                button5.Visible = true;
                button6.Enabled = false;
                button6.Visible = false;
                button7.Enabled = false;
                button7.Visible = false;
                button9.Visible = false;
                button9.Enabled = false;
                button11.Visible = true;
                button11.Enabled = true;
            }
            
            if(FormDangnhap.empjob.ToString() == "ChV00002")
            {
                button3.Enabled = true;
                button3.Visible = true;
                button4.Enabled = true;
                button4.Visible = true;
                button6.Enabled = true;
                button6.Visible = true;
                button7.Enabled = false;
                button7.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                button5.Enabled = false;
                button5.Visible = false;
                button9.Enabled = true;
                button9.Visible = true;
                button10.Visible = true;
                button10.Enabled = true;
                button11.Visible = true;
                button11.Enabled = true;
            }

            if (FormDangnhap.empjob.ToString() == "ChV00003")
            {
                button11.Visible = true;
                button11.Enabled = true;
                button3.Enabled = false;
                button3.Visible = false;
                button4.Enabled = false;
                button4.Visible = false;
                button6.Enabled = false;
                button6.Visible = false;
                button7.Enabled = false;
                button7.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                button5.Enabled = false;
                button5.Visible = false;
            }

            


        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Bangkhosachform());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new PhieuphatForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new TacgiaForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new HoadonForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new ChucvuForm());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            loadform(new Reportform());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new ReportBookStore());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadform(new ReportCashier());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loadform(new Clientfrm());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loadform(new Info());
        }
    }
}
