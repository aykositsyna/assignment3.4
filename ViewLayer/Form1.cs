using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            StudentsListView.Columns.Add("index");
            StudentsListView.Columns.Add("Name");
            StudentsListView.Columns.Add("Speciality");
            StudentsListView.Columns.Add("Group");
        }

        public event Action<StudentEventArgs> AddEvent;
        public event Action<int> DeleteEvent;

        void IView.UpdateData(IEnumerable<StudentEventArgs> studentEventArgs)
        {
            StudentsListView.Items.Clear();

            int index = 1;
            foreach (StudentEventArgs e in studentEventArgs)
            {
                ListViewItem studentItem = new ListViewItem(index.ToString());

                studentItem.SubItems.Add(e.name);
                studentItem.SubItems.Add(e.speciality);
                studentItem.SubItems.Add(e.group);
                StudentsListView.Items.Add(studentItem);
                index++;
            }
        
        }

        private void DeleteStudentBttn_Click(object sender, EventArgs e)
        {
            if (StudentsListView.SelectedIndices.Count >= 1)
            {
                DeleteEvent?.Invoke(StudentsListView.SelectedIndices[0]);
            }
            else
            {
                MessageBox.Show("Wrong index :(");
            }

        }

        private void AddStudentBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTB.Text) || String.IsNullOrEmpty(SpecialityTB.Text) || String.IsNullOrEmpty(GroupTB.Text))
            {
                MessageBox.Show("No info entered :(");
            }
            else
            {
                AddEvent?.Invoke(new StudentEventArgs() { name = NameTB.Text, speciality =  SpecialityTB.Text, group = GroupTB.Text });
            }

        }

    }
}
