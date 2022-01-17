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
    public partial class ReportCashier : Form
    {
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        public SqlCommand sqlcmd;
        DataSet ds = new DataSet();
        public ReportCashier()
        {
            InitializeComponent();
            this.filldatafromdatabase();
        }

        public void filldatafromdatabase()
        {
            conn.Open();
            sqlcmd = new SqlCommand("select count(Mahoadon) as [Số lượng hóa đơn], datepart(month, getdate()) as [Tháng báo cáo], datepart(day, getdate()) as [Ngày báo cáo], datepart(year, getdate()) as [Năm báo cáo] from dbo.Hoadon", conn);
            SqlCommand sqlcmd1 = new SqlCommand("select count(Mathe) as [Số lượng thẻ] from dbo.Themuonsach", conn);
            SqlCommand sqlcmd2 = new SqlCommand("select count(Maphieu) as [Số lượng phiếu] from dbo.Phieuphat", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlcmd;
            DataTable dt = new DataTable();
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            sqlDataAdapter1.SelectCommand = sqlcmd1;
            DataTable dt1 = new DataTable();
            dt1.Clear();
            sqlDataAdapter1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            sqlDataAdapter2.SelectCommand = sqlcmd2;
            DataTable dt2 = new DataTable();
            dt2.Clear();
            sqlDataAdapter2.Fill(dt2);
            dataGridView3.DataSource = dt2;

            
            conn.Close();
        }

        private void ReportCashier_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() + "/" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "/" + dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            label3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
