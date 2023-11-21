﻿using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class StudentArgs : EventArgs
    {
        public Student Student { get; set; }
        public StudentArgs(Student student)
        {
            Student = student;
        }
    }
}
