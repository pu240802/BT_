namespace lab5_bt1
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
            this.btnKTChien = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnlipton = new System.Windows.Forms.Button();
            this.btncoca = new System.Windows.Forms.Button();
            this.btncafe = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnpepsi = new System.Windows.Forms.Button();
            this.btnCGTender = new System.Windows.Forms.Button();
            this.btnGR = new System.Windows.Forms.Button();
            this.btnGVC = new System.Windows.Forms.Button();
            this.btnTVC = new System.Windows.Forms.Button();
            this.btnBurgerPMC = new System.Windows.Forms.Button();
            this.btnBurgerPMT = new System.Windows.Forms.Button();
            this.btnBurgerPMG = new System.Windows.Forms.Button();
            this.btnBurgerPMB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTenban = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.clMonan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(369, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fastfood Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKTChien);
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnlipton);
            this.groupBox1.Controls.Add(this.btncoca);
            this.groupBox1.Controls.Add(this.btncafe);
            this.groupBox1.Controls.Add(this.btn7up);
            this.groupBox1.Controls.Add(this.btnpepsi);
            this.groupBox1.Controls.Add(this.btnCGTender);
            this.groupBox1.Controls.Add(this.btnGR);
            this.groupBox1.Controls.Add(this.btnGVC);
            this.groupBox1.Controls.Add(this.btnTVC);
            this.groupBox1.Controls.Add(this.btnBurgerPMC);
            this.groupBox1.Controls.Add(this.btnBurgerPMT);
            this.groupBox1.Controls.Add(this.btnBurgerPMG);
            this.groupBox1.Controls.Add(this.btnBurgerPMB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(34, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // btnKTChien
            // 
            this.btnKTChien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKTChien.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnKTChien.Location = new System.Drawing.Point(616, 186);
            this.btnKTChien.Name = "btnKTChien";
            this.btnKTChien.Size = new System.Drawing.Size(196, 37);
            this.btnKTChien.TabIndex = 14;
            this.btnKTChien.Text = "Khoai tây chiên";
            this.btnKTChien.UseVisualStyleBackColor = true;
            this.btnKTChien.Click += new System.EventHandler(this.btnKTChien_Click);
            // 
            // btnCam
            // 
            this.btnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCam.ForeColor = System.Drawing.Color.Red;
            this.btnCam.Location = new System.Drawing.Point(772, 136);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(94, 41);
            this.btnCam.TabIndex = 13;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // btnlipton
            // 
            this.btnlipton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlipton.ForeColor = System.Drawing.Color.Red;
            this.btnlipton.Location = new System.Drawing.Point(772, 84);
            this.btnlipton.Name = "btnlipton";
            this.btnlipton.Size = new System.Drawing.Size(94, 41);
            this.btnlipton.TabIndex = 12;
            this.btnlipton.Text = "Lipton";
            this.btnlipton.UseVisualStyleBackColor = true;
            this.btnlipton.Click += new System.EventHandler(this.btnlipton_Click);
            // 
            // btncoca
            // 
            this.btncoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncoca.ForeColor = System.Drawing.Color.Red;
            this.btncoca.Location = new System.Drawing.Point(772, 37);
            this.btncoca.Name = "btncoca";
            this.btncoca.Size = new System.Drawing.Size(94, 41);
            this.btncoca.TabIndex = 11;
            this.btncoca.Text = "CoCa";
            this.btncoca.UseVisualStyleBackColor = true;
            this.btncoca.Click += new System.EventHandler(this.btncoca_Click);
            // 
            // btncafe
            // 
            this.btncafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncafe.ForeColor = System.Drawing.Color.Red;
            this.btncafe.Location = new System.Drawing.Point(532, 136);
            this.btncafe.Name = "btncafe";
            this.btncafe.Size = new System.Drawing.Size(99, 41);
            this.btncafe.TabIndex = 10;
            this.btncafe.Text = "Cafe";
            this.btncafe.UseVisualStyleBackColor = true;
            this.btncafe.Click += new System.EventHandler(this.btncafe_Click);
            // 
            // btn7up
            // 
            this.btn7up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn7up.ForeColor = System.Drawing.Color.Red;
            this.btn7up.Location = new System.Drawing.Point(532, 84);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(99, 41);
            this.btn7up.TabIndex = 9;
            this.btn7up.Text = "7 up";
            this.btn7up.UseVisualStyleBackColor = true;
            this.btn7up.Click += new System.EventHandler(this.btn7up_Click);
            // 
            // btnpepsi
            // 
            this.btnpepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnpepsi.ForeColor = System.Drawing.Color.Red;
            this.btnpepsi.Location = new System.Drawing.Point(532, 37);
            this.btnpepsi.Name = "btnpepsi";
            this.btnpepsi.Size = new System.Drawing.Size(99, 41);
            this.btnpepsi.TabIndex = 8;
            this.btnpepsi.Text = "Pepsi";
            this.btnpepsi.UseVisualStyleBackColor = true;
            this.btnpepsi.Click += new System.EventHandler(this.btnpepsi_Click);
            // 
            // btnCGTender
            // 
            this.btnCGTender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCGTender.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCGTender.Location = new System.Drawing.Point(274, 186);
            this.btnCGTender.Name = "btnCGTender";
            this.btnCGTender.Size = new System.Drawing.Size(218, 37);
            this.btnCGTender.TabIndex = 7;
            this.btnCGTender.Text = "Cơm Gà Tender";
            this.btnCGTender.UseVisualStyleBackColor = true;
            this.btnCGTender.Click += new System.EventHandler(this.btnCGTender_Click);
            // 
            // btnGR
            // 
            this.btnGR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGR.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGR.Location = new System.Drawing.Point(274, 136);
            this.btnGR.Name = "btnGR";
            this.btnGR.Size = new System.Drawing.Size(218, 41);
            this.btnGR.TabIndex = 6;
            this.btnGR.Text = "Gà rán phần";
            this.btnGR.UseVisualStyleBackColor = true;
            this.btnGR.Click += new System.EventHandler(this.btnGR_Click);
            // 
            // btnGVC
            // 
            this.btnGVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGVC.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGVC.Location = new System.Drawing.Point(274, 84);
            this.btnGVC.Name = "btnGVC";
            this.btnGVC.Size = new System.Drawing.Size(218, 41);
            this.btnGVC.TabIndex = 5;
            this.btnGVC.Text = "Gà viên Cola";
            this.btnGVC.UseVisualStyleBackColor = true;
            this.btnGVC.Click += new System.EventHandler(this.btnGVC_Click);
            // 
            // btnTVC
            // 
            this.btnTVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTVC.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTVC.Location = new System.Drawing.Point(274, 37);
            this.btnTVC.Name = "btnTVC";
            this.btnTVC.Size = new System.Drawing.Size(218, 41);
            this.btnTVC.TabIndex = 4;
            this.btnTVC.Text = "Tôm viên Cola";
            this.btnTVC.UseVisualStyleBackColor = true;
            this.btnTVC.Click += new System.EventHandler(this.btnTVC_Click);
            // 
            // btnBurgerPMC
            // 
            this.btnBurgerPMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBurgerPMC.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerPMC.Location = new System.Drawing.Point(25, 186);
            this.btnBurgerPMC.Name = "btnBurgerPMC";
            this.btnBurgerPMC.Size = new System.Drawing.Size(222, 37);
            this.btnBurgerPMC.TabIndex = 3;
            this.btnBurgerPMC.Text = "Burger Phô mai Cá";
            this.btnBurgerPMC.UseVisualStyleBackColor = true;
            this.btnBurgerPMC.Click += new System.EventHandler(this.btnBurgerPMC_Click);
            // 
            // btnBurgerPMT
            // 
            this.btnBurgerPMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBurgerPMT.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerPMT.Location = new System.Drawing.Point(25, 131);
            this.btnBurgerPMT.Name = "btnBurgerPMT";
            this.btnBurgerPMT.Size = new System.Drawing.Size(222, 41);
            this.btnBurgerPMT.TabIndex = 2;
            this.btnBurgerPMT.Text = "Burger Phô mai Tôm";
            this.btnBurgerPMT.UseVisualStyleBackColor = true;
            this.btnBurgerPMT.Click += new System.EventHandler(this.btnBurgerPMT_Click);
            // 
            // btnBurgerPMG
            // 
            this.btnBurgerPMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBurgerPMG.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerPMG.Location = new System.Drawing.Point(25, 84);
            this.btnBurgerPMG.Name = "btnBurgerPMG";
            this.btnBurgerPMG.Size = new System.Drawing.Size(222, 41);
            this.btnBurgerPMG.TabIndex = 1;
            this.btnBurgerPMG.Text = "Burger Phô mai Gà";
            this.btnBurgerPMG.UseVisualStyleBackColor = true;
            this.btnBurgerPMG.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBurgerPMB
            // 
            this.btnBurgerPMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBurgerPMB.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerPMB.Location = new System.Drawing.Point(25, 37);
            this.btnBurgerPMB.Name = "btnBurgerPMB";
            this.btnBurgerPMB.Size = new System.Drawing.Size(222, 41);
            this.btnBurgerPMB.TabIndex = 0;
            this.btnBurgerPMB.Text = "Burger Phô mai Bò";
            this.btnBurgerPMB.UseVisualStyleBackColor = true;
            this.btnBurgerPMB.Click += new System.EventHandler(this.btnBurgerPMB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(303, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bàn: ";
            // 
            // comboTenban
            // 
            this.comboTenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboTenban.FormattingEnabled = true;
            this.comboTenban.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "A10"});
            this.comboTenban.Location = new System.Drawing.Point(405, 371);
            this.comboTenban.Name = "comboTenban";
            this.comboTenban.Size = new System.Drawing.Size(241, 33);
            this.comboTenban.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab5_bt1.Properties.Resources.notes_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(234, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 98);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrder.Image = global::lab5_bt1.Properties.Resources.Order_history_icon;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(793, 371);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(107, 38);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "    Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::lab5_bt1.Properties.Resources.Recycle_Empty_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(72, 367);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataOrder
            // 
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMonan,
            this.clSoluong});
            this.dataOrder.Location = new System.Drawing.Point(44, 415);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.RowHeadersWidth = 62;
            this.dataOrder.RowTemplate.Height = 28;
            this.dataOrder.Size = new System.Drawing.Size(881, 255);
            this.dataOrder.TabIndex = 6;
            this.dataOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrder_CellContentClick);
            // 
            // clMonan
            // 
            this.clMonan.HeaderText = "Món ăn";
            this.clMonan.MinimumWidth = 8;
            this.clMonan.Name = "clMonan";
            this.clMonan.Width = 407;
            // 
            // clSoluong
            // 
            this.clSoluong.HeaderText = "Số lượng";
            this.clSoluong.MinimumWidth = 8;
            this.clSoluong.Name = "clSoluong";
            this.clSoluong.Width = 407;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 724);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.comboTenban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKTChien;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnlipton;
        private System.Windows.Forms.Button btncoca;
        private System.Windows.Forms.Button btncafe;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnpepsi;
        private System.Windows.Forms.Button btnCGTender;
        private System.Windows.Forms.Button btnGR;
        private System.Windows.Forms.Button btnGVC;
        private System.Windows.Forms.Button btnTVC;
        private System.Windows.Forms.Button btnBurgerPMC;
        private System.Windows.Forms.Button btnBurgerPMT;
        private System.Windows.Forms.Button btnBurgerPMG;
        private System.Windows.Forms.Button btnBurgerPMB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTenban;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoluong;
    }
}

