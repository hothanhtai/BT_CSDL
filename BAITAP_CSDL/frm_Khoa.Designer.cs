
namespace BAITAP_CSDL
{
    partial class frm_Khoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_makhoa = new System.Windows.Forms.TextBox();
            this.txt_tenkhoa = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(149, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(149, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(619, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi Chú";
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_makhoa.Location = new System.Drawing.Point(274, 124);
            this.txt_makhoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_makhoa.Multiline = true;
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(261, 38);
            this.txt_makhoa.TabIndex = 3;
            // 
            // txt_tenkhoa
            // 
            this.txt_tenkhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenkhoa.Location = new System.Drawing.Point(274, 206);
            this.txt_tenkhoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tenkhoa.Multiline = true;
            this.txt_tenkhoa.Name = "txt_tenkhoa";
            this.txt_tenkhoa.Size = new System.Drawing.Size(261, 39);
            this.txt_tenkhoa.TabIndex = 4;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ghichu.Location = new System.Drawing.Point(718, 124);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(253, 186);
            this.txt_ghichu.TabIndex = 5;
            this.txt_ghichu.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.DeepPink;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_them.Location = new System.Drawing.Point(152, 397);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 37);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DeepPink;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Location = new System.Drawing.Point(508, 397);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 37);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DeepPink;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Location = new System.Drawing.Point(318, 397);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 37);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.Red;
            this.btn_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dong.Location = new System.Drawing.Point(819, 397);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(94, 37);
            this.btn_dong.TabIndex = 9;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(386, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "THÔNG TIN KHOA";
            // 
            // frm_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.txt_tenkhoa);
            this.Controls.Add(this.txt_makhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_Khoa";
            this.Text = "frm_Khoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_makhoa;
        private System.Windows.Forms.TextBox txt_tenkhoa;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Label label4;
    }
}