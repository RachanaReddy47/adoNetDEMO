namespace adoNetDEMO
{
    partial class Extract
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
            this.txtDeptno = new System.Windows.Forms.TextBox();
            this.btngetdata2 = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btngetdata1 = new System.Windows.Forms.Button();
            this.Getdata2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Deptno";
            // 
            // txtDeptno
            // 
            this.txtDeptno.Location = new System.Drawing.Point(347, 101);
            this.txtDeptno.Name = "txtDeptno";
            this.txtDeptno.Size = new System.Drawing.Size(100, 20);
            this.txtDeptno.TabIndex = 1;
            // 
            // btngetdata2
            // 
            this.btngetdata2.Location = new System.Drawing.Point(549, 98);
            this.btngetdata2.Name = "btngetdata2";
            this.btngetdata2.Size = new System.Drawing.Size(75, 23);
            this.btngetdata2.TabIndex = 2;
            this.btngetdata2.Text = "GetData";
            this.btngetdata2.UseVisualStyleBackColor = true;
            this.btngetdata2.Click += new System.EventHandler(this.btngetdata1_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(88, 288);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(616, 150);
            this.dgvData.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(363, 172);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // btngetdata1
            // 
            this.btngetdata1.Location = new System.Drawing.Point(548, 169);
            this.btngetdata1.Name = "btngetdata1";
            this.btngetdata1.Size = new System.Drawing.Size(75, 23);
            this.btngetdata1.TabIndex = 6;
            this.btngetdata1.Text = "GetData1";
            this.btngetdata1.UseVisualStyleBackColor = true;
            this.btngetdata1.Click += new System.EventHandler(this.btngetdata1_Click_1);
            // 
            // Getdata2
            // 
            this.Getdata2.Location = new System.Drawing.Point(549, 249);
            this.Getdata2.Name = "Getdata2";
            this.Getdata2.Size = new System.Drawing.Size(75, 23);
            this.Getdata2.TabIndex = 7;
            this.Getdata2.Text = "GetData2";
            this.Getdata2.UseVisualStyleBackColor = true;
            this.Getdata2.Click += new System.EventHandler(this.Getdata2_Click);
            // 
            // Extract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Getdata2);
            this.Controls.Add(this.btngetdata1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btngetdata2);
            this.Controls.Add(this.txtDeptno);
            this.Controls.Add(this.label1);
            this.Name = "Extract";
            this.Text = "Extract";
            this.Load += new System.EventHandler(this.Extract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptno;
        private System.Windows.Forms.Button btngetdata2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btngetdata1;
        private System.Windows.Forms.Button Getdata2;
    }
}