namespace OOPII_PROJECT
{
    partial class Form2
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
            this.semester = new System.Windows.Forms.Label();
            this.semsterDropDown = new System.Windows.Forms.ComboBox();
            this.letterGrade = new System.Windows.Forms.Label();
            this.ectsCriedts = new System.Windows.Forms.Label();
            this.courseCode = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.Label();
            this.criedtsTxt = new System.Windows.Forms.TextBox();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.gradesDropDown = new System.Windows.Forms.ComboBox();
            this.goBack = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.Notify = new System.Windows.Forms.Label();
            this.clearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add your course name , course code , etcs credits , \r\nletter grade , and semester" +
    ".\r\n(for exemption courses, select semester 0)\r\n";
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Location = new System.Drawing.Point(26, 242);
            this.semester.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(51, 13);
            this.semester.TabIndex = 24;
            this.semester.Text = "Semester";
            // 
            // semsterDropDown
            // 
            this.semsterDropDown.FormattingEnabled = true;
            this.semsterDropDown.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.semsterDropDown.Location = new System.Drawing.Point(116, 239);
            this.semsterDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.semsterDropDown.Name = "semsterDropDown";
            this.semsterDropDown.Size = new System.Drawing.Size(44, 21);
            this.semsterDropDown.TabIndex = 23;
            // 
            // letterGrade
            // 
            this.letterGrade.AutoSize = true;
            this.letterGrade.Location = new System.Drawing.Point(26, 210);
            this.letterGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.letterGrade.Name = "letterGrade";
            this.letterGrade.Size = new System.Drawing.Size(66, 13);
            this.letterGrade.TabIndex = 22;
            this.letterGrade.Text = "Letter Grade";
            // 
            // ectsCriedts
            // 
            this.ectsCriedts.AutoSize = true;
            this.ectsCriedts.Location = new System.Drawing.Point(26, 179);
            this.ectsCriedts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ectsCriedts.Name = "ectsCriedts";
            this.ectsCriedts.Size = new System.Drawing.Size(70, 13);
            this.ectsCriedts.TabIndex = 21;
            this.ectsCriedts.Text = "ECTS Criedts";
            // 
            // courseCode
            // 
            this.courseCode.AutoSize = true;
            this.courseCode.Location = new System.Drawing.Point(26, 145);
            this.courseCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseCode.Name = "courseCode";
            this.courseCode.Size = new System.Drawing.Size(68, 13);
            this.courseCode.TabIndex = 20;
            this.courseCode.Text = "Course Code";
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Location = new System.Drawing.Point(26, 114);
            this.courseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(71, 13);
            this.courseName.TabIndex = 19;
            this.courseName.Text = "Course Name";
            // 
            // criedtsTxt
            // 
            this.criedtsTxt.Location = new System.Drawing.Point(116, 173);
            this.criedtsTxt.Margin = new System.Windows.Forms.Padding(2);
            this.criedtsTxt.Name = "criedtsTxt";
            this.criedtsTxt.Size = new System.Drawing.Size(112, 20);
            this.criedtsTxt.TabIndex = 18;
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(116, 143);
            this.codeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(112, 20);
            this.codeTxt.TabIndex = 17;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(116, 110);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(112, 20);
            this.nameTxt.TabIndex = 16;
            // 
            // gradesDropDown
            // 
            this.gradesDropDown.FormattingEnabled = true;
            this.gradesDropDown.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.gradesDropDown.Location = new System.Drawing.Point(116, 207);
            this.gradesDropDown.Name = "gradesDropDown";
            this.gradesDropDown.Size = new System.Drawing.Size(44, 21);
            this.gradesDropDown.TabIndex = 25;
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.SystemColors.Info;
            this.goBack.Location = new System.Drawing.Point(296, 325);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(91, 49);
            this.goBack.TabIndex = 26;
            this.goBack.Text = "Transcript";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.Info;
            this.insert.Location = new System.Drawing.Point(259, 101);
            this.insert.Margin = new System.Windows.Forms.Padding(2);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(64, 39);
            this.insert.TabIndex = 27;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Notify
            // 
            this.Notify.AutoSize = true;
            this.Notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify.Location = new System.Drawing.Point(49, 291);
            this.Notify.Name = "Notify";
            this.Notify.Size = new System.Drawing.Size(0, 20);
            this.Notify.TabIndex = 28;
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.SystemColors.Info;
            this.clearAll.Location = new System.Drawing.Point(259, 154);
            this.clearAll.Margin = new System.Windows.Forms.Padding(2);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(64, 39);
            this.clearAll.TabIndex = 29;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 377);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.Notify);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.gradesDropDown);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.semsterDropDown);
            this.Controls.Add(this.letterGrade);
            this.Controls.Add(this.ectsCriedts);
            this.Controls.Add(this.courseCode);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.criedtsTxt);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Add Courses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.ComboBox semsterDropDown;
        private System.Windows.Forms.Label letterGrade;
        private System.Windows.Forms.Label ectsCriedts;
        private System.Windows.Forms.Label courseCode;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.TextBox criedtsTxt;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ComboBox gradesDropDown;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label Notify;
        private System.Windows.Forms.Button clearAll;
    }
}