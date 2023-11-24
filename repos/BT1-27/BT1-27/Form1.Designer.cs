namespace BT1_27
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioLgbt = new System.Windows.Forms.RadioButton();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.checkJava = new System.Windows.Forms.CheckBox();
            this.checkPython = new System.Windows.Forms.CheckBox();
            this.btnSublmit = new System.Windows.Forms.Button();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.groupCourse = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupGender.SuspendLayout();
            this.groupCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput2);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(143, 112);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(221, 26);
            this.txtInput2.TabIndex = 3;
            this.txtInput2.TextChanged += new System.EventHandler(this.txtInput2_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(143, 58);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(221, 26);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hà Nội",
            "Hồ Chí Minh",
            "Cần Thơ",
            "Bình Dương",
            "Long An"});
            this.comboBox1.Location = new System.Drawing.Point(12, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(463, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioMale
            // 
            this.radioMale.AccessibleName = "Male";
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(27, 24);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(68, 24);
            this.radioMale.TabIndex = 5;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(27, 66);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(87, 24);
            this.radioFemale.TabIndex = 6;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioLgbt
            // 
            this.radioLgbt.AutoSize = true;
            this.radioLgbt.Location = new System.Drawing.Point(27, 109);
            this.radioLgbt.Name = "radioLgbt";
            this.radioLgbt.Size = new System.Drawing.Size(76, 24);
            this.radioLgbt.TabIndex = 7;
            this.radioLgbt.TabStop = true;
            this.radioLgbt.Text = "LGBT";
            this.radioLgbt.UseVisualStyleBackColor = true;
            this.radioLgbt.CheckedChanged += new System.EventHandler(this.radioLgbt_CheckedChanged);
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(31, 25);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(55, 24);
            this.checkC.TabIndex = 8;
            this.checkC.Text = "C#";
            this.checkC.UseVisualStyleBackColor = true;
            this.checkC.CheckedChanged += new System.EventHandler(this.checkC_CheckedChanged);
            // 
            // checkJava
            // 
            this.checkJava.AutoSize = true;
            this.checkJava.Location = new System.Drawing.Point(31, 71);
            this.checkJava.Name = "checkJava";
            this.checkJava.Size = new System.Drawing.Size(68, 24);
            this.checkJava.TabIndex = 9;
            this.checkJava.Text = "Java";
            this.checkJava.UseVisualStyleBackColor = true;
            this.checkJava.CheckedChanged += new System.EventHandler(this.checkJava_CheckedChanged);
            // 
            // checkPython
            // 
            this.checkPython.AutoSize = true;
            this.checkPython.Location = new System.Drawing.Point(31, 116);
            this.checkPython.Name = "checkPython";
            this.checkPython.Size = new System.Drawing.Size(84, 24);
            this.checkPython.TabIndex = 10;
            this.checkPython.Text = "Python";
            this.checkPython.UseVisualStyleBackColor = true;
            this.checkPython.CheckedChanged += new System.EventHandler(this.checkPython_CheckedChanged);
            // 
            // btnSublmit
            // 
            this.btnSublmit.Location = new System.Drawing.Point(567, 369);
            this.btnSublmit.Name = "btnSublmit";
            this.btnSublmit.Size = new System.Drawing.Size(113, 50);
            this.btnSublmit.TabIndex = 11;
            this.btnSublmit.Text = "Submit";
            this.btnSublmit.UseVisualStyleBackColor = true;
            this.btnSublmit.Click += new System.EventHandler(this.btnSublmit_Click);
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.radioMale);
            this.groupGender.Controls.Add(this.radioFemale);
            this.groupGender.Controls.Add(this.radioLgbt);
            this.groupGender.Location = new System.Drawing.Point(530, 12);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(170, 138);
            this.groupGender.TabIndex = 12;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            this.groupGender.Enter += new System.EventHandler(this.groupGender_Enter);
            // 
            // groupCourse
            // 
            this.groupCourse.Controls.Add(this.checkC);
            this.groupCourse.Controls.Add(this.checkJava);
            this.groupCourse.Controls.Add(this.checkPython);
            this.groupCourse.Location = new System.Drawing.Point(530, 173);
            this.groupCourse.Name = "groupCourse";
            this.groupCourse.Size = new System.Drawing.Size(170, 149);
            this.groupCourse.TabIndex = 13;
            this.groupCourse.TabStop = false;
            this.groupCourse.Text = "Course";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupCourse);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.btnSublmit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupCourse.ResumeLayout(false);
            this.groupCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioLgbt;
        private System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.CheckBox checkJava;
        private System.Windows.Forms.CheckBox checkPython;
        private System.Windows.Forms.Button btnSublmit;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.GroupBox groupCourse;
    }
}

