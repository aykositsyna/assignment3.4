using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public interface IModel
    {
        void AddStudent(Student student);

        event EventHandler<StudentArgs> EventStudentAddModel;
    }
}
