namespace sachbobonho
{
    partial class PhieuphatForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empcombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertinfobtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.finefeetxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reasonrtbx = new System.Windows.Forms.RichTextBox();
            this.orderidlbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Snow;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Firebrick;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Firebrick;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Snow;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Snow;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 513);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 28);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ngày lập phiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Họ và tên khách:";
            // 
            // empcombobox
            // 
            this.empcombobox.BackColor = System.Drawing.Color.Firebrick;
            this.empcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcombobox.ForeColor = System.Drawing.SystemColors.Menu;
            this.empcombobox.FormattingEnabled = true;
            this.empcombobox.Location = new System.Drawing.Point(267, 456);
            this.empcombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empcombobox.Name = "empcombobox";
            this.empcombobox.Size = new System.Drawing.Size(321, 33);
            this.empcombobox.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tên nhân viên lập phiếu:";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletebtn.Location = new System.Drawing.Point(975, 310);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(147, 61);
            this.deletebtn.TabIndex = 50;
            this.deletebtn.Text = "Xóa";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Firebrick;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updatebtn.Location = new System.Drawing.Point(478, 310);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(166, 61);
            this.updatebtn.TabIndex = 49;
            this.updatebtn.Text = "Cập nhật";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 283);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // insertinfobtn
            // 
            this.insertinfobtn.BackColor = System.Drawing.Color.Firebrick;
            this.insertinfobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertinfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertinfobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.insertinfobtn.Location = new System.Drawing.Point(41, 316);
            this.insertinfobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertinfobtn.Name = "insertinfobtn";
            this.insertinfobtn.Size = new System.Drawing.Size(138, 55);
            this.insertinfobtn.TabIndex = 47;
            this.insertinfobtn.Text = "Thêm";
            this.insertinfobtn.UseVisualStyleBackColor = false;
            this.insertinfobtn.Click += new System.EventHandler(this.insertinfobtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Phí đền bù:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // finefeetxtbx
            // 
            this.finefeetxtbx.BackColor = System.Drawing.Color.Firebrick;
            this.finefeetxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finefeetxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finefeetxtbx.ForeColor = System.Drawing.SystemColors.Menu;
            this.finefeetxtbx.Location = new System.Drawing.Point(160, 564);
            this.finefeetxtbx.Name = "finefeetxtbx";
            this.finefeetxtbx.Size = new System.Drawing.Size(459, 30);
            this.finefeetxtbx.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 623);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Lí do:";
            // 
            // reasonrtbx
            // 
            this.reasonrtbx.BackColor = System.Drawing.Color.Firebrick;
            this.reasonrtbx.ForeColor = System.Drawing.SystemColors.Menu;
            this.reasonrtbx.Location = new System.Drawing.Point(79, 610);
            this.reasonrtbx.Name = "reasonrtbx";
            this.reasonrtbx.Size = new System.Drawing.Size(1056, 173);
            this.reasonrtbx.TabIndex = 60;
            this.reasonrtbx.Text = "";
            // 
            // orderidlbl
            // 
            this.orderidlbl.AutoSize = true;
            this.orderidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidlbl.Location = new System.Drawing.Point(316, 328);
            this.orderidlbl.Name = "orderidlbl";
            this.orderidlbl.Size = new System.Drawing.Size(44, 32);
            this.orderidlbl.TabIndex = 71;
            this.orderidlbl.Text = "stt";
            this.orderidlbl.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Firebrick;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 393);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 33);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(891, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 44);
            this.button2.TabIndex = 94;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.BackColor = System.Drawing.Color.Firebrick;
            this.Searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.Searchbox.Location = new System.Drawing.Point(794, 393);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(232, 45);
            this.Searchbox.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(670, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 95;
            this.label8.Text = "Tìm kiếm:";
            // 
            // PhieuphatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1156, 807);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.orderidlbl);
            this.Controls.Add(this.reasonrtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finefeetxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empcombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertinfobtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuphatForm";
            this.Text = "PhieuphatForm";
            this.Load += new System.EventHandler(this.PhieuphatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox empcombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertinfobtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finefeetxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox reasonrtbx;
        private System.Windows.Forms.Label orderidlbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Label label8;
    }
}