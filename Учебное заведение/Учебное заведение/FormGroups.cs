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
    public partial class FormGroups : Form
    {
        public FormGroups()
        {
            InitializeComponent();
            ShowGroups();
        }
        void ShowGroups()
        {
            listViewGroup.Items.Clear();
            foreach (GroupsSet groupset in Program.EduDb.GroupsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    groupset.Id.ToString(),groupset.Name
                });
                item.Tag = groupset;
                listViewGroup.Items.Add(item);
            }
            listViewGroup.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGroup.SelectedItems.Count == 1)
            {
                GroupsSet groupset = listViewGroup.SelectedItems[0].Tag as GroupsSet;
                textBoxGroup.Text = groupset.Name;
            }
            else
            {
                textBoxGroup.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GroupsSet groupset = new GroupsSet();
                if (textBoxGroup.Text != "") groupset.Name = textBoxGroup.Text;
                Program.EduDb.GroupsSet.Add(groupset);
                Program.EduDb.SaveChanges();
            }
            catch
            {
                { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            ShowGroups();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxGroup.Text !="")
            {
                if (listViewGroup.SelectedItems.Count == 1)
                {
                    GroupsSet groupset = listViewGroup.SelectedItems[0].Tag as GroupsSet;
                    if (textBoxGroup.Text != "")
                        groupset.Name = textBoxGroup.Text;
                    Program.EduDb.SaveChanges();
                    ShowGroups();
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
                if (listViewGroup.SelectedItems.Count == 1)
                {
                    GroupsSet groupset = listViewGroup.SelectedItems[0].Tag as GroupsSet;
                    Program.EduDb.GroupsSet.Remove(groupset);
                    Program.EduDb.SaveChanges();
                    ShowGroups();
                }
                textBoxGroup.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {

        }
    }
}
