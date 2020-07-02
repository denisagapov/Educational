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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            Form formgroups = new FormGroups();
            formgroups.Show();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            Form formstudents = new FormStudents();
            formstudents.Show();
        }

        private void buttonLesson_Click(object sender, EventArgs e)
        {
            Form formlessons = new FormLessons();
            formlessons.Show();
        }

        private void buttonPoints_Click(object sender, EventArgs e)
        {
            Form formpoints = new FormPoints();
            formpoints.Show();
        }
    }
}
