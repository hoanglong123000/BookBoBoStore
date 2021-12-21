namespace sachbobonho
{
    partial class Bangkhosachform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empcombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ammountofbookbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.orderidlbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertinfobtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bookcombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorcombobox = new System.Windows.Forms.ComboBox();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empcombobox
            // 
            this.empcombobox.BackColor = System.Drawing.Color.Firebrick;
            this.empcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcombobox.ForeColor = System.Drawing.SystemColors.Menu;
            this.empcombobox.FormattingEnabled = true;
            this.empcombobox.Location = new System.Drawing.Point(168, 535);
            this.empcombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empcombobox.Name = "empcombobox";
            this.empcombobox.Size = new System.Drawing.Size(307, 33);
            this.empcombobox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tên nhân viên:";
            // 
            // ammountofbookbox
            // 
            this.ammountofbookbox.BackColor = System.Drawing.Color.Firebrick;
            this.ammountofbookbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammountofbookbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammountofbookbox.ForeColor = System.Drawing.SystemColors.Control;
            this.ammountofbookbox.Location = new System.Drawing.Point(743, 594);
            this.ammountofbookbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ammountofbookbox.Name = "ammountofbookbox";
            this.ammountofbookbox.Size = new System.Drawing.Size(250, 30);
            this.ammountofbookbox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(580, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số lượng sách:";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletebtn.Location = new System.Drawing.Point(997, 380);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(147, 61);
            this.deletebtn.TabIndex = 25;
            this.deletebtn.Text = "Xóa";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Firebrick;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updatebtn.Location = new System.Drawing.Point(493, 380);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(166, 61);
            this.updatebtn.TabIndex = 24;
            this.updatebtn.Text = "Cập nhật";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // orderidlbl
            // 
            this.orderidlbl.AutoSize = true;
            this.orderidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidlbl.Location = new System.Drawing.Point(292, 395);
            this.orderidlbl.Name = "orderidlbl";
            this.orderidlbl.Size = new System.Drawing.Size(44, 32);
            this.orderidlbl.TabIndex = 23;
            this.orderidlbl.Text = "stt";
            this.orderidlbl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(10, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 364);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // insertinfobtn
            // 
            this.insertinfobtn.BackColor = System.Drawing.Color.Firebrick;
            this.insertinfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertinfobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.insertinfobtn.Location = new System.Drawing.Point(36, 386);
            this.insertinfobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertinfobtn.Name = "insertinfobtn";
            this.insertinfobtn.Size = new System.Drawing.Size(138, 55);
            this.insertinfobtn.TabIndex = 21;
            this.insertinfobtn.Text = "Thêm";
            this.insertinfobtn.UseVisualStyleBackColor = false;
            this.insertinfobtn.Click += new System.EventHandler(this.insertinfobtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên tác giả:";
            // 
            // bookcombobox
            // 
            this.bookcombobox.BackColor = System.Drawing.Color.Firebrick;
            this.bookcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookcombobox.ForeColor = System.Drawing.SystemColors.Menu;
            this.bookcombobox.FormattingEnabled = true;
            this.bookcombobox.Location = new System.Drawing.Point(130, 596);
            this.bookcombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookcombobox.Name = "bookcombobox";
            this.bookcombobox.Size = new System.Drawing.Size(307, 33);
            this.bookcombobox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên sách:";
            // 
            // authorcombobox
            // 
            this.authorcombobox.BackColor = System.Drawing.Color.Firebrick;
            this.authorcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorcombobox.ForeColor = System.Drawing.SystemColors.Menu;
            this.authorcombobox.FormattingEnabled = true;
            this.authorcombobox.Location = new System.Drawing.Point(743, 527);
            this.authorcombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.authorcombobox.Name = "authorcombobox";
            this.authorcombobox.Size = new System.Drawing.Size(307, 33);
            this.authorcombobox.TabIndex = 32;
            this.authorcombobox.SelectedIndexChanged += new System.EventHandler(this.authorcombobox_SelectedIndexChanged);
            // 
            // Searchbox
            // 
            this.Searchbox.BackColor = System.Drawing.Color.Firebrick;
            this.Searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.Searchbox.Location = new System.Drawing.Point(168, 461);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(639, 45);
            this.Searchbox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "Tìm kiếm:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(828, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 44);
            this.button2.TabIndex = 86;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bangkhosachform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1156, 659);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.bookcombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorcombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empcombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ammountofbookbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.orderidlbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertinfobtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bangkhosachform";
            this.Text = "Bangkhosachform";
            this.Load += new System.EventHandler(this.Bangkhosachform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox empcombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ammountofbookbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label orderidlbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertinfobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bookcombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox authorcombobox;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}