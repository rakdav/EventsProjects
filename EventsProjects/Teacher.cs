using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProjects
{
    public delegate void ExamDelegate(string t);
    internal class Teacher
    {
        public event ExamDelegate examEvent;
        public void Exam(string task)
        {
            if (examEvent != null) examEvent(task);
        }
    }
}
