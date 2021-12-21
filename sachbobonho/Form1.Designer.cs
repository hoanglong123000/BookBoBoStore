namespace sachbobonho
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sachboboDataSet = new sachbobonho.sachboboDataSet();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new sachbobonho.sachboboDataSetTableAdapters.BangSachTableAdapter();
            this.tableAdapterManager = new sachbobonho.sachboboDataSetTableAdapters.TableAdapterManager();
            this.uploadinfobtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.nameofbooktxtbx = new System.Windows.Forms.TextBox();
            this.insertinfobtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empcombobox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Searchbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sachboboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sachboboDataSet
            // 
            this.sachboboDataSet.DataSetName = "sachboboDataSet";
            this.sachboboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "BangSach";
            this.sachBindingSource.DataSource = this.sachboboDataSet;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangchucvuTableAdapter = null;
            this.tableAdapterManager.BangkhachhangTableAdapter = null;
            this.tableAdapterManager.BangkhosachTableAdapter = null;
            this.tableAdapterManager.BangnhanvienTableAdapter = null;
            this.tableAdapterManager.BangSachTableAdapter = this.sachTableAdapter;
            this.tableAdapterManager.BangtacgiaTableAdapter = null;
            this.tableAdapterManager.HoadonTableAdapter = null;
            this.tableAdapterManager.PhieuphatTableAdapter = null;
            this.tableAdapterManager.ThemuonsachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sachbobonho.sachboboDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uploadinfobtn
            // 
            this.uploadinfobtn.BackColor = System.Drawing.Color.Firebrick;
            this.uploadinfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadinfobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.uploadinfobtn.Location = new System.Drawing.Point(214, 715);
            this.uploadinfobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uploadinfobtn.Name = "uploadinfobtn";
            this.uploadinfobtn.Size = new System.Drawing.Size(307, 78);
            this.uploadinfobtn.TabIndex = 2;
            this.uploadinfobtn.Text = "Tải hình ảnh từ máy lên";
            this.uploadinfobtn.UseVisualStyleBackColor = false;
            this.uploadinfobtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-2, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên sách:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameofbooktxtbx
            // 
            this.nameofbooktxtbx.BackColor = System.Drawing.Color.Firebrick;
            this.nameofbooktxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameofbooktxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofbooktxtbx.ForeColor = System.Drawing.SystemColors.Control;
            this.nameofbooktxtbx.Location = new System.Drawing.Point(142, 389);
            this.nameofbooktxtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameofbooktxtbx.Name = "nameofbooktxtbx";
            this.nameofbooktxtbx.Size = new System.Drawing.Size(780, 30);
            this.nameofbooktxtbx.TabIndex = 5;
            this.nameofbooktxtbx.TextChanged += new System.EventHandler(this.imagetitletxtbx_TextChanged);
            // 
            // insertinfobtn
            // 
            this.insertinfobtn.BackColor = System.Drawing.Color.Firebrick;
            this.insertinfobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertinfobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.insertinfobtn.Location = new System.Drawing.Point(25, 294);
            this.insertinfobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertinfobtn.Name = "insertinfobtn";
            this.insertinfobtn.Size = new System.Drawing.Size(221, 55);
            this.insertinfobtn.TabIndex = 6;
            this.insertinfobtn.Text = "Thêm sách";
            this.insertinfobtn.UseVisualStyleBackColor = false;
            this.insertinfobtn.Click += new System.EventHandler(this.insertinfobtn_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
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
            this.dataGridView1.Size = new System.Drawing.Size(1141, 283);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "stt";
            this.label2.Visible = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Firebrick;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updatebtn.Location = new System.Drawing.Point(463, 294);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(258, 55);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Cập nhật sách";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Firebrick;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletebtn.Location = new System.Drawing.Point(917, 294);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(227, 55);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "Xóa sách";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-2, 766);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ảnh của cuốn sách: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(-2, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sơ lược nội dung:";
            // 
            // pricetxtbx
            // 
            this.pricetxtbx.BackColor = System.Drawing.Color.Firebrick;
            this.pricetxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricetxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxtbx.ForeColor = System.Drawing.SystemColors.Control;
            this.pricetxtbx.Location = new System.Drawing.Point(214, 658);
            this.pricetxtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pricetxtbx.Name = "pricetxtbx";
            this.pricetxtbx.Size = new System.Drawing.Size(250, 30);
            this.pricetxtbx.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(-2, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá của cuốn sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên nhân viên:";
            // 
            // empcombobox
            // 
            this.empcombobox.BackColor = System.Drawing.Color.Firebrick;
            this.empcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcombobox.ForeColor = System.Drawing.SystemColors.Menu;
            this.empcombobox.FormattingEnabled = true;
            this.empcombobox.Location = new System.Drawing.Point(157, 607);
            this.empcombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empcombobox.Name = "empcombobox";
            this.empcombobox.Size = new System.Drawing.Size(307, 33);
            this.empcombobox.TabIndex = 17;
            this.empcombobox.SelectedIndexChanged += new System.EventHandler(this.empcombobox_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Firebrick;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(185, 430);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(959, 132);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(527, 569);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 236);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(738, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 87;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 86;
            this.label7.Text = "Tìm kiếm:";
            // 
            // Searchbox
            // 
            this.Searchbox.BackColor = System.Drawing.Color.Firebrick;
            this.Searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.Searchbox.Location = new System.Drawing.Point(124, 356);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(486, 30);
            this.Searchbox.TabIndex = 85;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1156, 807);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.empcombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pricetxtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertinfobtn);
            this.Controls.Add(this.nameofbooktxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uploadinfobtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sachboboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sachboboDataSet sachboboDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private sachboboDataSetTableAdapters.BangSachTableAdapter sachTableAdapter;
        private sachboboDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button uploadinfobtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameofbooktxtbx;
        private System.Windows.Forms.Button insertinfobtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox empcombobox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Searchbox;
    }
}

