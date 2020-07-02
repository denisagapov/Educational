using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебное_заведение
{
    public partial class FormPoints : Form
    {
        public FormPoints()
        {
            InitializeComponent();
            ShowPoints();
            ShowStudents();
            ShowLessons();
        }
        void ShowPoints()
        {
            listViewPoint.Items.Clear();
            foreach (PointsSet pointset in Program.EduDb.PointsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pointset.Id.ToString(),pointset.StudentsSet.SecondName+ " "+
                    pointset.StudentsSet.FirstName+ " " + pointset.StudentsSet.LastName,
                    pointset.LessonsSet.Lesson, pointset.Point.ToString()
                });
                item.Tag = pointset;
                listViewPoint.Items.Add(item);
            }
            listViewPoint.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowStudents()
        {
            comboBoxStudent.Items.Clear();
            foreach (StudentsSet studentset in Program.EduDb.StudentsSet)
            {
                string[] item = { studentset.Id.ToString() + ".", studentset.SecondName + " " +
                        studentset.FirstName + " " + studentset.LastName};
                comboBoxStudent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowLessons()
        {
            comboBoxLesson.Items.Clear();
            foreach (LessonsSet lessonset in Program.EduDb.LessonsSet)
            {
                string[] item = { lessonset.Id.ToString() + ".", lessonset.Lesson };
                comboBoxLesson.Items.Add(string.Join(" ", item));
            }
        }


        private void listViewPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPoint.SelectedItems.Count == 1)
            {
                PointsSet pointset = listViewPoint.SelectedItems[0].Tag as PointsSet;
                comboBoxStudent.SelectedIndex = comboBoxStudent.FindString(pointset.IdStudent.ToString());
                comboBoxLesson.SelectedIndex = comboBoxLesson.FindString(pointset.IdLesson.ToString());
                textBoxPoint.Text = pointset.Point.ToString();
            }
            else
            {
                textBoxPoint.Text = "";
                comboBoxStudent.SelectedItem = null;
                comboBoxLesson.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PointsSet pointset = new PointsSet();
                if (comboBoxStudent.SelectedItem != null) pointset.IdStudent = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                if (comboBoxLesson.SelectedItem != null) pointset.IdLesson = Convert.ToInt32(comboBoxLesson.SelectedItem.ToString().Split('.')[0]);
                if (textBoxPoint.Text != "") pointset.Point=Convert.ToDouble(textBoxPoint.Text);
                Program.EduDb.PointsSet.Add(pointset);
                Program.EduDb.SaveChanges();
            }
            catch
            {
                { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            ShowPoints();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((comboBoxStudent.SelectedItem != null) && (comboBoxLesson.SelectedItem != null)
            && (textBoxPoint.Text != ""))
            {
                if (listViewPoint.SelectedItems.Count == 1)
                {
                    PointsSet pointset = listViewPoint.SelectedItems[0].Tag as PointsSet;
                    if (comboBoxStudent.SelectedItem != null) pointset.IdStudent = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                    if (comboBoxLesson.SelectedItem != null) pointset.IdLesson = Convert.ToInt32(comboBoxLesson.SelectedItem.ToString().Split('.')[0]);
                    if (textBoxPoint.Text != "") pointset.Point=Convert.ToDouble(textBoxPoint.Text);
                    Program.EduDb.SaveChanges();
                    ShowPoints();
                }
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPoint.SelectedItems.Count == 1)
                {
                    PointsSet pointset = listViewPoint.SelectedItems[0].Tag as PointsSet;
                    Program.EduDb.PointsSet.Remove(pointset);
                    Program.EduDb.SaveChanges();
                    ShowPoints();
                }
                textBoxPoint.Text = "";
                comboBoxStudent.SelectedItem = null;
                comboBoxLesson.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }

        }
    }
}


