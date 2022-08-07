using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Of_Student
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public struct Student
        {
            public string Student_Name { get; set; }
            public int Student_Lesson { get; set; }
            public double Grade { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Student_Name1.Text.Trim() == string.Empty
                && Lesson1.SelectedItem == null
                && Lesson_Grade1.Text.Trim() == string.Empty)
                MessageBox.Show($"Fill all informations");
            else
            {
                Student student = new Student();
                student.Student_Lesson = Lesson1.SelectedIndex + 1;
                student.Student_Name = Student_Name1.Text.Trim();
                student.Grade = Convert.ToDouble(Lesson_Grade1.Text.Trim());
                datagridview.Rows.Add();
                int index = datagridview.RowCount - 1;
                datagridview.Rows[index].Cells[0].Value = student.Student_Name;
                datagridview.Rows[index].Cells[student.Student_Lesson].Value = student.Grade;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (Student_Name2.Text.Trim() == string.Empty
    && Lesson2.SelectedItem == null
    && Lesson_Grade2.Text.Trim() == string.Empty)
                MessageBox.Show($"Fill all informations");
            else
            {
                bool flag = false;
                student.Student_Lesson = Lesson2.SelectedIndex + 1;
                student.Student_Name = Student_Name2.Text.Trim();
                student.Grade = Convert.ToDouble(Lesson_Grade2.Text.Trim());
                int length = datagridview.RowCount;
                for (int i = 0; i < length; i++)
                {
                    string name = Convert.ToString(datagridview.Rows[i].Cells[0].Value);
                    if (name.Equals(student.Student_Name))
                    {
                        flag = true;
                        datagridview.Rows[i].Cells[student.Student_Lesson].Value = student.Grade;
                    }
                }
                if (!flag)
                    MessageBox.Show($"{Student_Name2.Text.Trim()} Not Found");
            }
        }
        private void Grade_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
                datagridview.Rows.Add(1);
            if (e.ColumnIndex == 7)
                datagridview.Rows.RemoveAt(e.RowIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Student_Name.Text.Trim() == string.Empty
                && Math.Text.Trim() == string.Empty
                && Physic.Text.Trim() == string.Empty
                && Shimi.Text.Trim() == string.Empty
                && Adabiat.Text.Trim() == string.Empty)
                MessageBox.Show("Fill all information");
            else
            {
                datagridview.Rows.Add();
                int index = datagridview.RowCount - 1;
                string name = Student_Name.Text.Trim();
                double math = Convert.ToDouble(Math.Text.Trim()),
                    physic = Convert.ToDouble(Physic.Text.Trim()),
                    shimi = Convert.ToDouble(Shimi.Text.Trim()),
                    adabiat = Convert.ToDouble(Adabiat.Text.Trim()),
                    average = (math + physic + shimi + adabiat) / 4;
                datagridview.Rows[index].Cells[0].Value = name;
                datagridview.Rows[index].Cells[1].Value = math;
                datagridview.Rows[index].Cells[2].Value = physic;
                datagridview.Rows[index].Cells[3].Value = shimi;
                datagridview.Rows[index].Cells[4].Value = adabiat;
                datagridview.Rows[index].Cells[5].Value = average;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Student_Name.Text.Trim() == string.Empty)
                MessageBox.Show("Fill all information");
            else
            {
                int length = datagridview.RowCount;
                string name = Student_Name.Text.Trim();
                double math = Convert.ToDouble(Math.Text.Trim()),
                    physic = Convert.ToDouble(Physic.Text.Trim()),
                    shimi = Convert.ToDouble(Shimi.Text.Trim()),
                    adabiat = Convert.ToDouble(Adabiat.Text.Trim()),
                    average = (math + physic + shimi + adabiat) / 4;
                for (int i = 0; i < length; i++)
                {
                    string Name = Convert.ToString(datagridview.Rows[i].Cells[0].Value);
                    if (name.Equals(Name))
                    {
                        datagridview.Rows[i].Cells[0].Value = name;
                        datagridview.Rows[i].Cells[1].Value = math;
                        datagridview.Rows[i].Cells[2].Value = physic;
                        datagridview.Rows[i].Cells[3].Value = shimi;
                        datagridview.Rows[i].Cells[4].Value = adabiat;
                        datagridview.Rows[i].Cells[5].Value = average;
                    }
                }

            }
        }
    }
}
