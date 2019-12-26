using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> student = new List<Student>();
        Random rnd = new Random();
        StudentFactory createStudent;
        StudentDAO studentDao;
        const string configFilePath = @"F:\PASS\Config.txt";

        public Form1()
        {
            InitializeComponent();
            txtMatricol.Text = rnd.Next(999999).ToString();
            txtMedie.Text = rnd.Next(5, 9).ToString() + "." + rnd.Next(0, 99).ToString();

            createStudent = new StudentFactory(bool.Parse(readFromConfig(configFilePath)));
            studentDao = createStudent.Build();
            studentDao.loadStudents();

            foreach (var student in studentDao.getAllStudents())
            {
                listBox1.Items.Add(student.ToString());
            }
        }

        private string readFromConfig(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            Student s = new Student(txtMatricol.Text, txtNume.Text, float.Parse(txtMedie.Text));
            studentDao.addStudent(s);
            listBox1.Items.Add(s.ToString());

            txtMatricol.Text = rnd.Next(999999).ToString();
            txtMedie.Text = rnd.Next(5, 9).ToString() + "." + rnd.Next(0, 99).ToString();

        }

        private void validare(TextBox textBox)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPreziceMedie_Click(object sender, EventArgs e)
        {
            string []listBoxArray = listBox1.SelectedItem.ToString().Split(' ');
            if (StudentHoroscop.PreziceMedie(studentDao.getStudent(listBoxArray[0])))
                lblMedie.Text = "Media va creste";
            else
                lblMedie.Text = "Media va scadea";

        }

        private void btnMediePeste8_Click(object sender, EventArgs e)
        {
            lblMedie8.Text = "Nr studenti care vor avea media scazuta: "+StudentHoroscop.PreziceMediePeste8(studentDao.getAllStudents()).ToString();
        }

        private void btnZiBuna_Click(object sender, EventArgs e)
        {
            string[] listBoxArray = listBox1.SelectedItem.ToString().Split(' ');
            if (StudentHoroscop.PreziceZiBuna(studentDao.getStudent(listBoxArray[0]).mNume))
                lblZiBuna.Text = "Studentul va avea o zi buna";
            else
                lblZiBuna.Text = "Studentul nu va avea o zi buna";
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            string[] listBoxArray = listBox1.SelectedItem.ToString().Split(' ');
            studentDao.deleteStudent(listBoxArray[0]);

            listBox1.Items.Clear();

            foreach (var student in studentDao.getAllStudents())
            {
                listBox1.Items.Add(student.ToString());
            }
        }
    }
}
