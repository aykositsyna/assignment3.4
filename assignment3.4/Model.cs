using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Model : IModel
    {
        public IList<Student> Students { get; set; } = new List<Student>();

        public event EventHandler<StudentArgs> EventStudentAddModel
            = delegate { };

        public void AddStudent(Student student)
        {
            Students.Add(student);

            EventStudentAddModel(this, new StudentArgs(student));
        }

    }
}
