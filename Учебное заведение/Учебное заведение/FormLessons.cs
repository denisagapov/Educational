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
    public partial class FormLessons : Form
    {
        public FormLessons()
        {
            InitializeComponent();
            ShowLessons();
        }
        void ShowLessons()
        {
            listViewLesson.Items.Clear();
            foreach (LessonsSet lessonset in Program.EduDb.LessonsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    lessonset.Id.ToString(),lessonset.Lesson,
                    lessonset.Teacher, lessonset.Semester.ToString(),
                    lessonset.Year.ToString(),
                });
                item.Tag = lessonset;
                listViewLesson.Items.Add(item);
            }
            listViewLesson.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLesson.SelectedItems.Count == 1)
            {
                LessonsSet lessonset = listViewLesson.SelectedItems[0].Tag as LessonsSet;
                textBoxName.Text = lessonset.Lesson;
                textBoxTeacher.Text = lessonset.Teacher;
                textBoxSemester.Text = lessonset.Semester.ToString();
                textBoxYear.Text = lessonset.Year.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxTeacher.Text = "";
                textBoxSemester.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LessonsSet lessonset = new LessonsSet();
                if (textBoxName.Text != "") lessonset.Lesson = textBoxName.Text;
                if (textBoxTeacher.Text != "") lessonset.Teacher = textBoxTeacher.Text;
                if (textBoxSemester.Text != "") lessonset.Semester = Convert.ToInt32(textBoxSemester.Text);
                if (textBoxYear.Text != "") lessonset.Year = Convert.ToInt32(textBoxYear.Text);
                Program.EduDb.LessonsSet.Add(lessonset);
                Program.EduDb.SaveChanges();
            }
            catch
            {
                { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            ShowLessons();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != "")
            && (textBoxTeacher.Text != "")
            && (textBoxSemester.Text != "")
            && (textBoxYear.Text != ""))
            {
                if (listViewLesson.SelectedItems.Count == 1)
                {
                    LessonsSet lessonset = listViewLesson.SelectedItems[0].Tag as LessonsSet;
                    if (textBoxName.Text != "") lessonset.Lesson = textBoxName.Text;
                    if (textBoxTeacher.Text != "") lessonset.Teacher = textBoxTeacher.Text;
                    if (textBoxSemester.Text != "") lessonset.Semester = Convert.ToInt32(textBoxSemester.Text);
                    if (textBoxYear.Text != "") lessonset.Year = Convert.ToInt32(textBoxYear.Text);
                    Program.EduDb.SaveChanges();
                    ShowLessons();
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
                if (listViewLesson.SelectedItems.Count == 1)
                {
                    LessonsSet lessonset = listViewLesson.SelectedItems[0].Tag as LessonsSet;
                    Program.EduDb.LessonsSet.Remove(lessonset);
                    Program.EduDb.SaveChanges();
                    ShowLessons();
                }
                textBoxName.Text = "";
                textBoxTeacher.Text = "";
                textBoxSemester.Text = "";
                textBoxYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

        }
    }
}

