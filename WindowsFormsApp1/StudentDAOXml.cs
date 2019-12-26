using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public class StudentDAOXml : StudentDAO
    {

        List<Student> mStudenti = new List<Student>();
        const string filePath = @"F:\PASS\Studenti.xml";

        public void loadStudents()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Student>));


            if (File.Exists(filePath))
            {
                Stream stream2 = File.OpenRead(filePath);
                mStudenti = (List<Student>)xmlSer.Deserialize(stream2);

                stream2.Close();
            }
        }

        public void saveStudents()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Student>));
            Stream stream = File.OpenWrite(filePath);
            xmlSer.Serialize(stream, mStudenti);
            stream.Close();
        }
        public void addStudent(Student s)
        {
            mStudenti.Add(s);
            saveStudents();
        }

        public void deleteStudent(string nrMatricol)
        {
            mStudenti.Remove(mStudenti.Find(_=>_.mNrMatricol.Equals(nrMatricol)));
            File.Delete(filePath);
            saveStudents();
        }

        public List<Student> getAllStudents()
        {
            return mStudenti;
        }

        public Student getStudent(string nrMatricol)
        {
            return mStudenti.Find(_ => _.mNrMatricol.Equals(nrMatricol));
        }

    }
}
