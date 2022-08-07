using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Of_Student
{
    internal class MainClass
    {
        #region Add student
        public void Add_Student(int lesson, string student_name, double grade)
        {

        }
        #endregion
        #region Update student
        public void Update_Student(int select, string student_name, string student_grade)
        {
            MainForm main = new MainForm();
            bool condition = false;
            for (int i = 0; i < main.datagridview.RowCount; i++)
            {
                if (student_name == Convert.ToString(main.datagridview.Rows[i].Cells[0].Value))
                {
                    condition = true;
                    main.datagridview.Rows[i].Cells[0].Value = student_name;
                    main.datagridview.Rows[i].Cells[select].Value = student_grade;
                    double math = Convert.ToDouble(main.datagridview.Rows[i].Cells[1].Value),
                    physic = Convert.ToDouble(main.datagridview.Rows[i].Cells[2].Value),
                    shimi = Convert.ToDouble(main.datagridview.Rows[i].Cells[3].Value),
                    adabiat = Convert.ToDouble(main.datagridview.Rows[i].Cells[4].Value);
                    main.datagridview.Rows[i].Cells[5].Value = (math + physic + shimi + adabiat) / 4;
                }
            }
            if (!condition)
                MessageBox.Show($"{student_name} Not Found");
        }
        #endregion
    }
}
