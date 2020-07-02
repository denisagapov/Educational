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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
            ShowStudents();
            ShowGroups();
        }

        void ShowStudents()
        {
            listViewStudent.Items.Clear();
            foreach (StudentsSet studentset in Program.EduDb.StudentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    studentset.Id.ToString(),studentset.SecondName,
                    studentset.FirstName, studentset.LastName,
                    studentset.GroupsSet.Name, studentset.YearReceipt.ToString(),
                });
                item.Tag = studentset;
                listViewStudent.Items.Add(item);         
            }
            listViewStudent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowGroups()
        {
            comboBoxGroup.Items.Clear();
            foreach (GroupsSet groupset in Program.EduDb.GroupsSet)
            {
                string[] item = { groupset.Id.ToString() + ".", groupset.Name};
                comboBoxGroup.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count == 1)
            {
                StudentsSet studentset = listViewStudent.SelectedItems[0].Tag as StudentsSet;
                textBoxSecondName.Text = studentset.SecondName;
                textBoxFirstName.Text = studentset.FirstName;
                textBoxLastName.Text = studentset.LastName;
                comboBoxGroup.SelectedIndex = comboBoxGroup.FindString(studentset.IdGroup.ToString());
                textBoxYear.Text = studentset.YearReceipt.ToString();
            }
            else
            {
                textBoxSecondName.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                comboBoxGroup.SelectedItem = null;
                textBoxYear.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StudentsSet studentset = new StudentsSet();
                if (textBoxSecondName.Text!="") studentset.SecondName=textBoxSecondName.Text;
                if (textBoxFirstName.Text!="" )studentset.FirstName=textBoxFirstName.Text;
                if (textBoxLastName.Text != "") studentset.LastName=textBoxLastName.Text;
                if (comboBoxGroup.SelectedItem != null) studentset.IdGroup = Convert.ToInt32(comboBoxGroup.SelectedItem.ToString().Split('.')[0]);
                if (textBoxYear.Text!="") studentset.YearReceipt=Convert.ToInt32(textBoxYear.Text);
                Program.EduDb.StudentsSet.Add(studentset);
                Program.EduDb.SaveChanges();
            }
            catch
            {
                { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            ShowStudents();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((textBoxSecondName.Text != "")
            && (textBoxFirstName.Text != "")
            && (textBoxLastName.Text != "") 
            && (comboBoxGroup.SelectedItem != null)
            && (textBoxYear.Text != ""))
            {
                if (listViewStudent.SelectedItems.Count == 1)
                {
                    StudentsSet studentset = listViewStudent.SelectedItems[0].Tag as StudentsSet;
                    if (textBoxSecondName.Text != "") studentset.SecondName = textBoxSecondName.Text;
                    if (textBoxFirstName.Text != "") studentset.FirstName = textBoxFirstName.Text;
                    if (textBoxLastName.Text != "") studentset.LastName = textBoxLastName.Text;
                    if (comboBoxGroup.SelectedItem != null) studentset.IdGroup = Convert.ToInt32(comboBoxGroup.SelectedItem.ToString().Split('.')[0]);
                    if (textBoxYear.Text != "") studentset.YearReceipt=Convert.ToInt32(textBoxYear.Text);
                    Program.EduDb.SaveChanges();
                    ShowStudents();
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
                if (listViewStudent.SelectedItems.Count == 1)
                {
                    StudentsSet studentset = listViewStudent.SelectedItems[0].Tag as StudentsSet;
                    Program.EduDb.StudentsSet.Remove(studentset);
                    Program.EduDb.SaveChanges();
                    ShowStudents();
                }
                textBoxSecondName.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                comboBoxGroup.SelectedItem = null;
                textBoxYear.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

