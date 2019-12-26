using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   // [Serializable()]
    public class Student
    {
        public string mNume;
        public float mMedie;
        public string mNrMatricol;

        public Student(string NrMatricol, string Nume, float Medie)
        {
            mNrMatricol = NrMatricol;
            mNume = Nume;
            mMedie = Medie;
        }

        public Student()
        { }


        public override string ToString()
        {
            return mNrMatricol+" "+mNume+" "+mMedie;
        }
    }
}
