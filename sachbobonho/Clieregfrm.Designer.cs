namespace sachbobonho
{
    partial class Clieregfrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.phnumbx = new System.Windows.Forms.Label();
            this.cliepasbx = new System.Windows.Forms.TextBox();
            this.cliephnumbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleradiobutton = new System.Windows.Forms.RadioButton();
            this.maleradiobutton = new System.Windows.Forms.RadioButton();
            this.returnbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clientname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu đăng ký:";
            // 
            // phnumbx
            // 
            this.phnumbx.AutoSize = true;
            this.phnumbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnumbx.Location = new System.Drawing.Point(-2, 33);
            this.phnumbx.Name = "phnumbx";
            this.phnumbx.Size = new System.Drawing.Size(361, 38);
            this.phnumbx.TabIndex = 6;
            this.phnumbx.Text = "Số điện thoại đăng ký:";
            // 
            // cliepasbx
            // 
            this.cliepasbx.BackColor = System.Drawing.Color.Firebrick;
            this.cliepasbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliepasbx.ForeColor = System.Drawing.SystemColors.Menu;
            this.cliepasbx.Location = new System.Drawing.Point(389, 151);
            this.cliepasbx.Name = "cliepasbx";
            this.cliepasbx.Size = new System.Drawing.Size(458, 49);
            this.cliepasbx.TabIndex = 5;
            // 
            // cliephnumbx
            // 
            this.cliephnumbx.BackColor = System.Drawing.Color.Firebrick;
            this.cliephnumbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliephnumbx.ForeColor = System.Drawing.SystemColors.Menu;
            this.cliephnumbx.Location = new System.Drawing.Point(389, 23);
            this.cliephnumbx.Name = "cliephnumbx";
            this.cliephnumbx.Size = new System.Drawing.Size(458, 49);
            this.cliephnumbx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giới tính:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleradiobutton);
            this.groupBox1.Controls.Add(this.maleradiobutton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(389, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 94);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // femaleradiobutton
            // 
            this.femaleradiobutton.AutoSize = true;
            this.femaleradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradiobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.femaleradiobutton.Location = new System.Drawing.Point(118, 38);
            this.femaleradiobutton.Name = "femaleradiobutton";
            this.femaleradiobutton.Size = new System.Drawing.Size(75, 40);
            this.femaleradiobutton.TabIndex = 17;
            this.femaleradiobutton.Text = "Nữ";
            this.femaleradiobutton.UseVisualStyleBackColor = true;
            // 
            // maleradiobutton
            // 
            this.maleradiobutton.AutoSize = true;
            this.maleradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.maleradiobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.maleradiobutton.Location = new System.Drawing.Point(15, 38);
            this.maleradiobutton.Name = "maleradiobutton";
            this.maleradiobutton.Size = new System.Drawing.Size(97, 40);
            this.maleradiobutton.TabIndex = 16;
            this.maleradiobutton.Text = "Nam";
            this.maleradiobutton.UseVisualStyleBackColor = true;
            // 
            // returnbtn
            // 
            this.returnbtn.BackColor = System.Drawing.Color.Firebrick;
            this.returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.returnbtn.Location = new System.Drawing.Point(119, 320);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(363, 47);
            this.returnbtn.TabIndex = 25;
            this.returnbtn.Text = "Quay lại trang đăng nhập";
            this.returnbtn.UseVisualStyleBackColor = false;
            this.returnbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.Firebrick;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.registerbtn.Location = new System.Drawing.Point(655, 320);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(271, 46);
            this.registerbtn.TabIndex = 24;
            this.registerbtn.Text = "Đăng ký ";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 38);
            this.label3.TabIndex = 26;
            this.label3.Text = "Họ tên khách hàng:";
            // 
            // clientname
            // 
            this.clientname.BackColor = System.Drawing.Color.Firebrick;
            this.clientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientname.ForeColor = System.Drawing.SystemColors.Menu;
            this.clientname.Location = new System.Drawing.Point(389, 90);
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(458, 49);
            this.clientname.TabIndex = 27;
            // 
            // Clieregfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(999, 439);
            this.Controls.Add(this.clientname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phnumbx);
            this.Controls.Add(this.cliepasbx);
            this.Controls.Add(this.cliephnumbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Clieregfrm";
            this.Text = "Clieregfrm";
            this.Load += new System.EventHandler(this.Clieregfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phnumbx;
        private System.Windows.Forms.TextBox cliepasbx;
        private System.Windows.Forms.TextBox cliephnumbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleradiobutton;
        private System.Windows.Forms.RadioButton maleradiobutton;
        private System.Windows.Forms.Button returnbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientname;
    }
}