namespace Weathers
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
            this.lbl_textCity = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Dece = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_textCity
            // 
            this.lbl_textCity.AutoSize = true;
            this.lbl_textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_textCity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_textCity.Location = new System.Drawing.Point(12, 20);
            this.lbl_textCity.Name = "lbl_textCity";
            this.lbl_textCity.Size = new System.Drawing.Size(377, 79);
            this.lbl_textCity.TabIndex = 0;
            this.lbl_textCity.Text = "Thanh Pho";
            this.lbl_textCity.Click += new System.EventHandler(this.lbl_textCity_Click);
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Country.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Country.Location = new System.Drawing.Point(12, 99);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(367, 79);
            this.lbl_Country.TabIndex = 1;
            this.lbl_Country.Text = "Quốc Gia: ";
            // 
            // lbl_Dece
            // 
            this.lbl_Dece.AutoSize = true;
            this.lbl_Dece.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dece.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Dece.Location = new System.Drawing.Point(12, 189);
            this.lbl_Dece.Name = "lbl_Dece";
            this.lbl_Dece.Size = new System.Drawing.Size(110, 104);
            this.lbl_Dece.TabIndex = 2;
            this.lbl_Dece.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(485, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 79);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forcast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(485, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 79);
            this.label2.TabIndex = 4;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(485, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conditions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(485, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 79);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(854, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 79);
            this.label5.TabIndex = 7;
            this.label5.Text = "12 Km/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(854, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 79);
            this.label6.TabIndex = 8;
            this.label6.Text = "26";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Dece);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_textCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_textCity;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Dece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

