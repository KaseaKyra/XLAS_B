namespace CoSoXuLyAnhSo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.pbxLeft = new System.Windows.Forms.PictureBox();
            this.pbxRight = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbxLeft);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 465);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbxRight);
            this.panel2.Location = new System.Drawing.Point(514, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 465);
            this.panel2.TabIndex = 1;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(350, 10);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(135, 36);
            this.btnChonAnh.TabIndex = 0;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChuyenDoi);
            this.panel3.Controls.Add(this.btnChonAnh);
            this.panel3.Location = new System.Drawing.Point(0, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 52);
            this.panel3.TabIndex = 2;
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChuyenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDoi.ForeColor = System.Drawing.Color.White;
            this.btnChuyenDoi.Location = new System.Drawing.Point(533, 10);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(146, 36);
            this.btnChuyenDoi.TabIndex = 1;
            this.btnChuyenDoi.Text = "Hiển thị ảnh";
            this.btnChuyenDoi.UseVisualStyleBackColor = false;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // pbxLeft
            // 
            this.pbxLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbxLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLeft.Location = new System.Drawing.Point(3, 36);
            this.pbxLeft.Name = "pbxLeft";
            this.pbxLeft.Size = new System.Drawing.Size(502, 426);
            this.pbxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLeft.TabIndex = 0;
            this.pbxLeft.TabStop = false;
            // 
            // pbxRight
            // 
            this.pbxRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbxRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRight.Location = new System.Drawing.Point(3, 36);
            this.pbxRight.Name = "pbxRight";
            this.pbxRight.Size = new System.Drawing.Size(489, 426);
            this.pbxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRight.TabIndex = 0;
            this.pbxRight.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ẢNH ĐƯỢC CHỌN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ẢNH HIỂN THỊ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 526);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cơ Sở Xỷ Lý Ảnh Số";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxRight;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChuyenDoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

