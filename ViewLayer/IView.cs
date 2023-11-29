using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    public interface IView
    {
        event Action<StudentEventArgs> AddEvent;
        event Action<int> DeleteEvent;

        void UpdateData(IEnumerable<StudentEventArgs> studentEventArgs);
    }
}
