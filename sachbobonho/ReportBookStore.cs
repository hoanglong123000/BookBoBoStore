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
    public partial class ReportBookStore : Form
    {
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7JD8AP0\SQLEXPRESS;Initial Catalog=sachbobo;Integrated Security = true");
        public SqlCommand sqlcmd;
        DataSet ds = new DataSet();
        public ReportBookStore()
        {
            InitializeComponent();
        }

        private void ReportBookStore_Load(object sender, EventArgs e)
        {
            this.chart1.BackColor = Color.Firebrick;

            this.chart1.ChartAreas[0].AxisX.LineColor = Color.Firebrick;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            this.chart1.ChartAreas[0].AxisY.LineColor = Color.Firebrick;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            this.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            filldatafromdatabase();
        }

        public void filldatafromdatabase()
        {
            conn.Open();
            sqlcmd = new SqlCommand("select datepart(month, getdate()) as [Tháng báo cáo], datepart(day, getdate()), datepart(year, getdate()), sum(Soluongsach) as [Tổng số lượng sách] from Bangkhosach", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlcmd;
            DataTable dt = new DataTable();
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            double x = 0;
            double y = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                x = double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                y = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                chart1.Series[0].Points.AddXY(x, y);
            }
            label4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString() + " sách";
            label5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + "/" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "/" + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            conn.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
