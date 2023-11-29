using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public interface IModel
    {
        void Add(Student student);

        void Delete(int index);

        event EventHandler<IEnumerable<Student>> DataSourceChanged;
    }
}
