﻿using ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayer;

namespace Presenter
{
    public class Presenter
    {
        IView view;
        IModel model;

        public Presenter (IModel model, IView view)
        {

            this.model = model;
            this.view = view;
            view.AddEvent += View_OnAdd;
            view.DeleteEvent += View_OnDelete;
            model.DataSourceChanged += Model_DataChanged;
            model.InvokeDataChanged();
        }

        public void View_OnAdd(StudentEventArgs e)
        {
            model.Add(new Student() { Name = e.name, Speciality = e.speciality, Group = e.group});
        }

        public void View_OnDelete(int index)
        {
            model.Delete(index);
        }

        public void Model_DataChanged(object sender, IEnumerable<Student> students)
        {
            List<StudentEventArgs> list = new List<StudentEventArgs>();
            foreach (Student student in students)
            {
                StudentEventArgs e = new StudentEventArgs();
                e.name = student.Name;
                e.speciality = student.Speciality;
                e.group = student.Group;
                list.Add(e);
            }
            view.UpdateData(list);
        }

        


    }
}
