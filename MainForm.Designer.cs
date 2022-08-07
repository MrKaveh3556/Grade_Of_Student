namespace Grade_Of_Student
{
    partial class MainForm
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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.Student_Name_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Math_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physic_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shimi_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Farsi_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lesson2 = new System.Windows.Forms.ComboBox();
            this.Student_Name2 = new System.Windows.Forms.TextBox();
            this.Lesson_Grade2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lesson_Grade1 = new System.Windows.Forms.TextBox();
            this.Lesson1 = new System.Windows.Forms.ComboBox();
            this.Student_Name1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Student_Name = new System.Windows.Forms.TextBox();
            this.Math = new System.Windows.Forms.TextBox();
            this.Physic = new System.Windows.Forms.TextBox();
            this.Shimi = new System.Windows.Forms.TextBox();
            this.Adabiat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Name_Table,
            this.Math_Table,
            this.Physic_Table,
            this.Shimi_Table,
            this.Farsi_Table,
            this.Average_Grade,
            this.Add,
            this.Delete});
            this.datagridview.Location = new System.Drawing.Point(242, 102);
            this.datagridview.Margin = new System.Windows.Forms.Padding(4);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridview.Size = new System.Drawing.Size(845, 340);
            this.datagridview.TabIndex = 0;
            this.datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grade_Table_CellClick);
            // 
            // Student_Name_Table
            // 
            this.Student_Name_Table.HeaderText = "نام دانشجو";
            this.Student_Name_Table.Name = "Student_Name_Table";
            this.Student_Name_Table.ReadOnly = true;
            this.Student_Name_Table.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Math_Table
            // 
            this.Math_Table.HeaderText = "ریاضی";
            this.Math_Table.Name = "Math_Table";
            this.Math_Table.ReadOnly = true;
            // 
            // Physic_Table
            // 
            this.Physic_Table.HeaderText = "فیزیک";
            this.Physic_Table.Name = "Physic_Table";
            this.Physic_Table.ReadOnly = true;
            // 
            // Shimi_Table
            // 
            this.Shimi_Table.HeaderText = "شیمی";
            this.Shimi_Table.Name = "Shimi_Table";
            this.Shimi_Table.ReadOnly = true;
            // 
            // Farsi_Table
            // 
            this.Farsi_Table.HeaderText = "ادبیات";
            this.Farsi_Table.Name = "Farsi_Table";
            this.Farsi_Table.ReadOnly = true;
            // 
            // Average_Grade
            // 
            this.Average_Grade.HeaderText = "معدل دانشجو";
            this.Average_Grade.Name = "Average_Grade";
            this.Average_Grade.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.HeaderText = "افزودن";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Add.Text = "افزودن";
            this.Add.ToolTipText = "افزودن";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "حذف";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "حذف";
            this.Delete.ToolTipText = "حذف";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(766, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 99);
            this.label1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lesson2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Student_Name2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Lesson_Grade2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(456, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 98);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // Lesson2
            // 
            this.Lesson2.FormattingEnabled = true;
            this.Lesson2.Items.AddRange(new object[] {
            "ریاضی",
            "فیزیک",
            "شیمی",
            "ادبیات"});
            this.Lesson2.Location = new System.Drawing.Point(108, 41);
            this.Lesson2.Margin = new System.Windows.Forms.Padding(4);
            this.Lesson2.Name = "Lesson2";
            this.Lesson2.Size = new System.Drawing.Size(160, 24);
            this.Lesson2.TabIndex = 1;
            // 
            // Student_Name2
            // 
            this.Student_Name2.Location = new System.Drawing.Point(137, 13);
            this.Student_Name2.Name = "Student_Name2";
            this.Student_Name2.Size = new System.Drawing.Size(100, 22);
            this.Student_Name2.TabIndex = 0;
            // 
            // Lesson_Grade2
            // 
            this.Lesson_Grade2.Location = new System.Drawing.Point(137, 72);
            this.Lesson_Grade2.Name = "Lesson_Grade2";
            this.Lesson_Grade2.Size = new System.Drawing.Size(100, 22);
            this.Lesson_Grade2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(244, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "نمره درس";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(276, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "درس";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(244, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = ": نام دانشجو";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(6, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "ویرایش اطلاعات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Lesson_Grade1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Lesson1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Student_Name1);
            this.groupBox2.Location = new System.Drawing.Point(789, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 99);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(3, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "ثبت اطلاعات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Lesson_Grade1
            // 
            this.Lesson_Grade1.Location = new System.Drawing.Point(123, 71);
            this.Lesson_Grade1.Name = "Lesson_Grade1";
            this.Lesson_Grade1.Size = new System.Drawing.Size(100, 22);
            this.Lesson_Grade1.TabIndex = 2;
            // 
            // Lesson1
            // 
            this.Lesson1.FormattingEnabled = true;
            this.Lesson1.Items.AddRange(new object[] {
            "ریاضی",
            "فیزیک",
            "شیمی",
            "ادبیات"});
            this.Lesson1.Location = new System.Drawing.Point(94, 40);
            this.Lesson1.Margin = new System.Windows.Forms.Padding(4);
            this.Lesson1.Name = "Lesson1";
            this.Lesson1.Size = new System.Drawing.Size(160, 24);
            this.Lesson1.TabIndex = 1;
            // 
            // Student_Name1
            // 
            this.Student_Name1.Location = new System.Drawing.Point(123, 12);
            this.Student_Name1.Name = "Student_Name1";
            this.Student_Name1.Size = new System.Drawing.Size(100, 22);
            this.Student_Name1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(230, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "نمره درس";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(262, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "درس";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = ": نام دانشجو";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Student_Name);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Math);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Physic);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.Shimi);
            this.groupBox3.Controls.Add(this.Adabiat);
            this.groupBox3.Location = new System.Drawing.Point(-1, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 340);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(7, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(97, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Student_Name
            // 
            this.Student_Name.Location = new System.Drawing.Point(38, 10);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(100, 22);
            this.Student_Name.TabIndex = 0;
            // 
            // Math
            // 
            this.Math.Location = new System.Drawing.Point(38, 38);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(100, 22);
            this.Math.TabIndex = 1;
            // 
            // Physic
            // 
            this.Physic.Location = new System.Drawing.Point(38, 66);
            this.Physic.Name = "Physic";
            this.Physic.Size = new System.Drawing.Size(100, 22);
            this.Physic.TabIndex = 2;
            // 
            // Shimi
            // 
            this.Shimi.Location = new System.Drawing.Point(38, 94);
            this.Shimi.Name = "Shimi";
            this.Shimi.Size = new System.Drawing.Size(100, 22);
            this.Shimi.TabIndex = 3;
            // 
            // Adabiat
            // 
            this.Adabiat.Location = new System.Drawing.Point(38, 122);
            this.Adabiat.Name = "Adabiat";
            this.Adabiat.Size = new System.Drawing.Size(100, 22);
            this.Adabiat.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(145, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(84, 28);
            this.label12.TabIndex = 37;
            this.label12.Text = "نمره ادبیات :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(145, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(84, 28);
            this.label11.TabIndex = 36;
            this.label11.Text = "نام دانشجو :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(145, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(84, 28);
            this.label10.TabIndex = 35;
            this.label10.Text = "نمره ریاضی :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(145, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(84, 28);
            this.label9.TabIndex = 34;
            this.label9.Text = "نمره فیزیک :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(145, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 33;
            this.label8.Text = "نمره شیمی :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 483);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView datagridview;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Math_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physic_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shimi_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Farsi_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average_Grade;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ComboBox Lesson2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox Student_Name2;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox Lesson_Grade2;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox Lesson_Grade1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox Lesson1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox Student_Name1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox Student_Name;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox Math;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox Physic;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox Shimi;
        internal System.Windows.Forms.TextBox Adabiat;
    }
}

