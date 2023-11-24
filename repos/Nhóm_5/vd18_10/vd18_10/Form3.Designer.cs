namespace vd18_10
{
    partial class Form3
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
            this.vD18DataSet = new vd18_10.VD18DataSet();
            this.vD18DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TutorailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutorailname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vD18DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vD18DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // vD18DataSet
            // 
            this.vD18DataSet.DataSetName = "VD18DataSet";
            this.vD18DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vD18DataSetBindingSource
            // 
            this.vD18DataSetBindingSource.DataSource = this.vD18DataSet;
            this.vD18DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TutorailID,
            this.Tutorailname});
            this.dataGridView1.DataSource = this.vD18DataSetBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(48, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(537, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // TutorailID
            // 
            this.TutorailID.HeaderText = "TutorailID";
            this.TutorailID.MinimumWidth = 8;
            this.TutorailID.Name = "TutorailID";
            this.TutorailID.Width = 150;
            // 
            // Tutorailname
            // 
            this.Tutorailname.HeaderText = "TutorailName";
            this.Tutorailname.MinimumWidth = 8;
            this.Tutorailname.Name = "Tutorailname";
            this.Tutorailname.Width = 150;
            // 
            // vD18DataSetBindingSource1
            // 
            this.vD18DataSetBindingSource1.DataSource = this.vD18DataSet;
            this.vD18DataSetBindingSource1.Position = 0;
            // 
            // vD18DataSetBindingSource2
            // 
            this.vD18DataSetBindingSource2.DataSource = this.vD18DataSet;
            this.vD18DataSetBindingSource2.Position = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vD18DataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vD18DataSetBindingSource;
        private VD18DataSet vD18DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutorailname;
        private System.Windows.Forms.BindingSource vD18DataSetBindingSource1;
        private System.Windows.Forms.BindingSource vD18DataSetBindingSource2;
    }
}