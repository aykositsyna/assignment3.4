using ModelLayer;
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

        public Presenter ()
        {
            view.AddEvent += View_OnAdd;
            view.DeleteEvent += View_OnDelete;
        }

        public void View_OnAdd(StudentEventArgs e)
        {
            model.Add(new Student());
        }

        public void View_OnDelete(int index)
        {
            model.Delete(index);
        }

        public void Model_DataChanged(IEnumerable<StudentEventArgs> studentEventArgs)
        {
            view.UpdateData(studentEventArgs);
        }


    }
}
