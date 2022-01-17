using LiveCharts;
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
    public partial class Reportform : Form
    {
        
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        public SqlCommand sqlcmd;
        DataSet ds = new DataSet();

        public Reportform()
        {
            InitializeComponent();
        }

        private void Reportform_Load(object sender, EventArgs e)
        {
            filldatagridview();
        }

        public void filldatagridview()
        {
            conn.Open();
            sqlcmd = new SqlCommand("select sum(Tongtien + Phiphat) as [Tổng doanh thu], datepart(MONTH, Ngaylaphoadon) as [Tháng báo cáo] from Hoadon, Phieuphat where Phieuphat.Manhanvien = Hoadon.Manhanvien group by datepart(month, Ngaylaphoadon)", conn);
            SqlCommand sqlcmd1 = new SqlCommand("select count(Makhachhang) from Bangkhachhang", conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            adapter1.SelectCommand = sqlcmd1;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt.Clear();
            dt1.Clear();
            adapter.Fill(dt);
            adapter1.Fill(dt1);
            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView2.DataSource = dt1;
            
            double x = 0;
            double y = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                x = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                y = double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                chart1.Series[0].Points.AddXY(x, y);
            }

            this.chart1.BackColor = Color.Firebrick;

            this.chart1.ChartAreas[0].AxisX.LineColor = Color.Firebrick;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            this.chart1.ChartAreas[0].AxisY.LineColor = Color.Firebrick;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            this.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            
            conn.Close();
        }
        

        

        

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label4.Text = " Tháng " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + ": ";
            label5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " VND";
            label6.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
