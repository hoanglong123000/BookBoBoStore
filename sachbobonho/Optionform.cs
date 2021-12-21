using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sachbobonho
{
    public partial class Optionform : Form
    {
        public Optionform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhapkhachangform logcliefrm = new Dangnhapkhachangform();
            logcliefrm.ShowDialog();
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangnhap formDangnhap = new FormDangnhap();
            formDangnhap.ShowDialog();
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
