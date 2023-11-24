namespace LMT22_12
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.Tenhang,
            this.chatlieu,
            this.gianhap,
            this.giaban,
            this.soluong});
            this.dataGridView1.Location = new System.Drawing.Point(60, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(974, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MAHANG
            // 
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.MinimumWidth = 8;
            this.MAHANG.Name = "MAHANG";
            this.MAHANG.Width = 150;
            // 
            // Tenhang
            // 
            this.Tenhang.HeaderText = "Tên Hàng";
            this.Tenhang.MinimumWidth = 8;
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.Width = 150;
            // 
            // chatlieu
            // 
            this.chatlieu.HeaderText = "Chất Liệu";
            this.chatlieu.MinimumWidth = 8;
            this.chatlieu.Name = "chatlieu";
            this.chatlieu.Width = 150;
            // 
            // gianhap
            // 
            this.gianhap.HeaderText = "Gía Nhập";
            this.gianhap.MinimumWidth = 8;
            this.gianhap.Name = "gianhap";
            this.gianhap.Width = 150;
            // 
            // giaban
            // 
            this.giaban.HeaderText = "Gía Bán";
            this.giaban.MinimumWidth = 8;
            this.giaban.Name = "giaban";
            this.giaban.Width = 150;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            this.soluong.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 655);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}

