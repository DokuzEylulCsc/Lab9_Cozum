using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab08
{
    [Serializable]
    class University
    {
        private string name;
        private List<Student> students;

     
        public University(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public Student SearchStudent(string name)
        {
            Student t = null;
            foreach(Student a in students)
            {
                if(String.Equals(a.Name,name))
                {
                    t = a;
                    break;
                }
            }
            if (t == null) throw new StudentNotFound(name);
            return t;
        }
     
        
        public Student SearchStudent(int no)
        {
            Student t = null;
            foreach (Student a in students)
            {
                if (a.No == no)
                {
                    t = a;
                    break;
                }
            }
            if (t == null) throw new StudentNotFound(no);
            return t;
        }

        public List<Student> Students { get { return students; }  }
    }
}
