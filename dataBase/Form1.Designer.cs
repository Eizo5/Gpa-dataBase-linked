namespace OOPII_PROJECT
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
            this.load = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btn_search = new System.Windows.Forms.Button();
            this.displayDropDown = new System.Windows.Forms.ComboBox();
            this.GpaLabel = new System.Windows.Forms.Label();
            this.cgpaLabel = new System.Windows.Forms.Label();
            this.btn_addCourses = new System.Windows.Forms.Button();
            this.courseSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.Info;
            this.load.Location = new System.Drawing.Point(522, 29);
            this.load.Margin = new System.Windows.Forms.Padding(2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(68, 34);
            this.load.TabIndex = 0;
            this.load.Text = "Refresh";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Info;
            this.close.Location = new System.Drawing.Point(594, 29);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(68, 34);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.SystemColors.Info;
            this.clearAll.Location = new System.Drawing.Point(522, 80);
            this.clearAll.Margin = new System.Windows.Forms.Padding(2);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(68, 34);
            this.clearAll.TabIndex = 3;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Info;
            this.delete.Location = new System.Drawing.Point(594, 80);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(68, 34);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 322);
            this.dataGridView1.TabIndex = 13;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Info;
            this.btn_search.Location = new System.Drawing.Point(311, 122);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(60, 20);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // displayDropDown
            // 
            this.displayDropDown.BackColor = System.Drawing.SystemColors.Info;
            this.displayDropDown.FormattingEnabled = true;
            this.displayDropDown.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.displayDropDown.Location = new System.Drawing.Point(26, 181);
            this.displayDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.displayDropDown.Name = "displayDropDown";
            this.displayDropDown.Size = new System.Drawing.Size(35, 21);
            this.displayDropDown.TabIndex = 19;
            // 
            // GpaLabel
            // 
            this.GpaLabel.AutoSize = true;
            this.GpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaLabel.Location = new System.Drawing.Point(101, 498);
            this.GpaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GpaLabel.Name = "GpaLabel";
            this.GpaLabel.Size = new System.Drawing.Size(14, 20);
            this.GpaLabel.TabIndex = 21;
            this.GpaLabel.Text = "-";
            // 
            // cgpaLabel
            // 
            this.cgpaLabel.AutoSize = true;
            this.cgpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpaLabel.Location = new System.Drawing.Point(101, 530);
            this.cgpaLabel.Name = "cgpaLabel";
            this.cgpaLabel.Size = new System.Drawing.Size(14, 20);
            this.cgpaLabel.TabIndex = 22;
            this.cgpaLabel.Text = "-";
            // 
            // btn_addCourses
            // 
            this.btn_addCourses.BackColor = System.Drawing.SystemColors.Info;
            this.btn_addCourses.Location = new System.Drawing.Point(516, 498);
            this.btn_addCourses.Name = "btn_addCourses";
            this.btn_addCourses.Size = new System.Drawing.Size(90, 45);
            this.btn_addCourses.TabIndex = 23;
            this.btn_addCourses.Text = "Add Courses";
            this.btn_addCourses.UseVisualStyleBackColor = false;
            this.btn_addCourses.Click += new System.EventHandler(this.btn_addCourses_Click);
            // 
            // courseSearch
            // 
            this.courseSearch.Location = new System.Drawing.Point(248, 98);
            this.courseSearch.Name = "courseSearch";
            this.courseSearch.Size = new System.Drawing.Size(181, 20);
            this.courseSearch.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Choose a semester";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(5, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "CGPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseSearch);
            this.Controls.Add(this.btn_addCourses);
            this.Controls.Add(this.cgpaLabel);
            this.Controls.Add(this.GpaLabel);
            this.Controls.Add(this.displayDropDown);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.close);
            this.Controls.Add(this.load);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Transcript";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox displayDropDown;
        private System.Windows.Forms.Label GpaLabel;
        private System.Windows.Forms.Label cgpaLabel;
        private System.Windows.Forms.Button btn_addCourses;
        private System.Windows.Forms.TextBox courseSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

