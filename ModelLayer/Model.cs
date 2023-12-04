using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Model : IModel
    {
        private List<Student> Students = new List<Student>()
        {
            new Student() {Name = "Ivan", Speciality = "History", Group = "AB22-02"},
            new Student() {Name = "Egor", Speciality = "SKD", Group = "AB10-01"}
        };

        public event EventHandler<IEnumerable<Student>> DataSourceChanged ;

        public void Add(Student student)
        {
            Students.Add(student);
            DataSourceChanged?.Invoke(this, );
        }

        public void Delete(int index)
        {
            Students.RemoveAt(index);
            DataSourceChanged?.Invoke(this, Students);
        }
    }
}
