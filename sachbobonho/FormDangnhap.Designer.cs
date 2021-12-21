namespace sachbobonho
{
    partial class FormDangnhap
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
            this.emailtxtbx = new System.Windows.Forms.TextBox();
            this.passwordtxtbx = new System.Windows.Forms.TextBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.signinbtn = new System.Windows.Forms.Button();
            this.registerlink = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailtxtbx
            // 
            this.emailtxtbx.BackColor = System.Drawing.Color.Firebrick;
            this.emailtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.emailtxtbx.ForeColor = System.Drawing.SystemColors.Info;
            this.emailtxtbx.Location = new System.Drawing.Point(331, 182);
            this.emailtxtbx.Name = "emailtxtbx";
            this.emailtxtbx.Size = new System.Drawing.Size(698, 45);
            this.emailtxtbx.TabIndex = 0;
            // 
            // passwordtxtbx
            // 
            this.passwordtxtbx.BackColor = System.Drawing.Color.Firebrick;
            this.passwordtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passwordtxtbx.ForeColor = System.Drawing.SystemColors.Info;
            this.passwordtxtbx.Location = new System.Drawing.Point(331, 252);
            this.passwordtxtbx.Name = "passwordtxtbx";
            this.passwordtxtbx.Size = new System.Drawing.Size(698, 45);
            this.passwordtxtbx.TabIndex = 1;
            this.passwordtxtbx.UseSystemPasswordChar = true;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userlbl.Location = new System.Drawing.Point(206, 182);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(96, 36);
            this.userlbl.TabIndex = 2;
            this.userlbl.Text = "Email:";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passlbl.Location = new System.Drawing.Point(155, 256);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(153, 36);
            this.passlbl.TabIndex = 3;
            this.passlbl.Text = "Mật khẩu: ";
            // 
            // signinbtn
            // 
            this.signinbtn.BackColor = System.Drawing.Color.Firebrick;
            this.signinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signinbtn.Location = new System.Drawing.Point(649, 378);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(256, 64);
            this.signinbtn.TabIndex = 4;
            this.signinbtn.Text = "Đăng nhập ";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // registerlink
            // 
            this.registerlink.AutoSize = true;
            this.registerlink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerlink.ForeColor = System.Drawing.Color.AliceBlue;
            this.registerlink.Location = new System.Drawing.Point(360, 315);
            this.registerlink.Name = "registerlink";
            this.registerlink.Size = new System.Drawing.Size(471, 32);
            this.registerlink.TabIndex = 5;
            this.registerlink.Text = "Nhấn vào đường link này để đăng ký";
            this.registerlink.Click += new System.EventHandler(this.registerlink_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Firebrick;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitbtn.Location = new System.Drawing.Point(161, 378);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(256, 64);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.Text = "Quay lại";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sachbobonho.Properties.Resources.user_128;
            this.pictureBox1.Location = new System.Drawing.Point(487, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 158);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1084, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.registerlink);
            this.Controls.Add(this.signinbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.passwordtxtbx);
            this.Controls.Add(this.emailtxtbx);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangnhap";
            this.Text = "FormDangnhap";
            this.Load += new System.EventHandler(this.FormDangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailtxtbx;
        private System.Windows.Forms.TextBox passwordtxtbx;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.Label registerlink;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}