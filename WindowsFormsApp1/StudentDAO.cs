using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface StudentDAO
    {
        void addStudent(Student student);
        List<Student> getAllStudents();
        void deleteStudent(string nrMatricol);
        Student getStudent(string nrMatricol);
        void saveStudents();
        void loadStudents();
    }
}
