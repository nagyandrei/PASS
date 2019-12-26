using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class StudentHoroscop
    {

        public static bool PreziceMedie(Student student)
        {
            if((student.mNrMatricol.Count() + student.mNume.Count())%2==1)
            {
                return true;
            }
            return false;
        }

        public static bool PreziceZiBuna(string Nume)
        {
            int d = (int)System.DateTime.Now.DayOfWeek;
            if ((d + Convert.ToInt32(Nume[0])) % 2 == 1)
            {
                return true;
            }
            return false;
        }

        public static int PreziceMediePeste8(List<Student> Studenti)
        {
            int count = 0;
            foreach (var student in Studenti)
            {
                if (student.mMedie >= 8.0)
                    if (!PreziceMedie(student))
                        count++;
            }
           return count;
        }
    }
}
