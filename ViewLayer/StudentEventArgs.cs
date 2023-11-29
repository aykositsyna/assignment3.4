using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer
{
    public class StudentEventArgs : EventArgs
    {
        public string name {  get; set; }

        public string speciality { get; set; }

        public string group { get; set; }
    }
}
