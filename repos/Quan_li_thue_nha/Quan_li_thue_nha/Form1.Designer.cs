namespace Quan_li_thue_nha
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboThoihan = new System.Windows.Forms.ComboBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtInputCanho = new System.Windows.Forms.TextBox();
            this.txtInputTen = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachithuongtru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydonden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoihanhopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU THUÊ NHÀ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboThoihan);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtInputCanho);
            this.groupBox1.Controls.Add(this.txtInputTen);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người thuê";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(736, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // comboThoihan
            // 
            this.comboThoihan.FormattingEnabled = true;
            this.comboThoihan.Items.AddRange(new object[] {
            "3 tháng",
            "5 tháng",
            "1 năm",
            "2 năm",
            "3 năm"});
            this.comboThoihan.Location = new System.Drawing.Point(795, 128);
            this.comboThoihan.Name = "comboThoihan";
            this.comboThoihan.Size = new System.Drawing.Size(197, 40);
            this.comboThoihan.TabIndex = 13;
            this.comboThoihan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(720, 35);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(272, 39);
            this.txtgia.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(223, 175);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 39);
            this.txtAddress.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(223, 128);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(233, 39);
            this.txtSDT.TabIndex = 10;
            // 
            // txtInputCanho
            // 
            this.txtInputCanho.Location = new System.Drawing.Point(223, 80);
            this.txtInputCanho.Name = "txtInputCanho";
            this.txtInputCanho.Size = new System.Drawing.Size(233, 39);
            this.txtInputCanho.TabIndex = 9;
            this.txtInputCanho.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtInputTen
            // 
            this.txtInputTen.Location = new System.Drawing.Point(126, 30);
            this.txtInputTen.Name = "txtInputTen";
            this.txtInputTen.Size = new System.Drawing.Size(330, 39);
            this.txtInputTen.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(595, 184);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(189, 51);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(590, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thời hạn hợp đồng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(590, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gía thuê: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(590, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày dọn đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(52, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ thường trú: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(52, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(53, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số hiệu căn hộ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(53, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.ten,
            this.Socanho,
            this.sodienthoai,
            this.diachithuongtru,
            this.giathue,
            this.ngaydonden,
            this.thoihanhopdong});
            this.dataGridView1.Location = new System.Drawing.Point(12, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 307);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Stt
            // 
            this.Stt.HeaderText = "Stt";
            this.Stt.MinimumWidth = 3;
            this.Stt.Name = "Stt";
            this.Stt.Width = 50;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên:";
            this.ten.MinimumWidth = 8;
            this.ten.Name = "ten";
            this.ten.Width = 150;
            // 
            // Socanho
            // 
            this.Socanho.HeaderText = "Số Căn Hộ";
            this.Socanho.MinimumWidth = 8;
            this.Socanho.Name = "Socanho";
            this.Socanho.Width = 150;
            // 
            // sodienthoai
            // 
            this.sodienthoai.HeaderText = "Số Điện Thoại";
            this.sodienthoai.MinimumWidth = 8;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Width = 150;
            // 
            // diachithuongtru
            // 
            this.diachithuongtru.HeaderText = "Địa chỉ thường trú";
            this.diachithuongtru.MinimumWidth = 8;
            this.diachithuongtru.Name = "diachithuongtru";
            this.diachithuongtru.Width = 150;
            // 
            // giathue
            // 
            this.giathue.HeaderText = "Gía thuê";
            this.giathue.MinimumWidth = 8;
            this.giathue.Name = "giathue";
            this.giathue.Width = 150;
            // 
            // ngaydonden
            // 
            this.ngaydonden.HeaderText = "Ngày dọn đến";
            this.ngaydonden.MinimumWidth = 8;
            this.ngaydonden.Name = "ngaydonden";
            this.ngaydonden.Width = 150;
            // 
            // thoihanhopdong
            // 
            this.thoihanhopdong.HeaderText = "Thời hạn hợp đồng";
            this.thoihanhopdong.MinimumWidth = 8;
            this.thoihanhopdong.Name = "thoihanhopdong";
            this.thoihanhopdong.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboThoihan;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtInputCanho;
        private System.Windows.Forms.TextBox txtInputTen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachithuongtru;
        private System.Windows.Forms.DataGridViewTextBoxColumn giathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydonden;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoihanhopdong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

