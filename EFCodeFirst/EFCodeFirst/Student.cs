using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Student
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public int tuition { get; set; }
        public string Major { get; set; }

        public static List<String> displayStudents()
        {
            var list = new List<string>();
            using (var db = new CodeFirstContext())
            {
                var stu = db.Students.ToList();
                foreach (var students in stu)
                {
                    list.Add("ID: " + students.Id + " | " + students.Name + " | $" + students.tuition + " | " + students.Major);
                }
            }
            return list;
        }

        public static List<Student> getAll()
        {
            var students = new List<Student>();
            using (var db = new CodeFirstContext())
            {
                var s = db.Students.ToList();
                foreach (Student st in s)
                {
                    students.Add(st);
                }
            }
            return students; 
        }

        public static string total()
        {
            return Student.displayStudents().Count.ToString();
        }
        public static string totalTuition()
        {
            var list = Student.getAll();
            int total = 0;
            foreach (Student student in list)
            {
                total += student.tuition;
            }
            return total.ToString();
        }
        
}

   
    
}
