using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App_Example
{
    public class Student
    {
        private string _id;
        private string _name;
        private string _surname;
        private int _visa1;
        private int _visa2;
        private int _finalexam;
        private string _school;

        public Student(string id, string name, string surname, int visa1, int visa2, int finalexam, string school)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _visa1 = visa1;
            _visa2 = visa2;
            _finalexam = finalexam;
            _school = school;
        }
        public void getStudentInfo()
        {
            Console.WriteLine("ID: " + _id);
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
        }
        public void getStudentGrade()
        {
            Console.WriteLine("Visa1: " + _visa1);
            Console.WriteLine("Visa2: " + _visa2);
            Console.WriteLine("Final Exam: " + _finalexam);
            //took it as 25% from 2 visas and 50% from final
            string grade = getLetterGrade();
            Console.WriteLine("Final Grade: " + grade);
        }
        public void getSchoolInfo() {
            Console.WriteLine(_school);
        }
        private string getLetterGrade()
        {
            double grade = (_visa1 / 4) + (_visa2 / 4) + (_finalexam / 2);
            string lettergrade = "";
            switch (grade)
            {
                case var _ when grade >= 85:
                    lettergrade = "A";
                    break;
                case var _ when grade < 85 && grade >= 70:
                    lettergrade = "B";
                    break;
                case var _ when grade < 70 && grade >= 55:
                    lettergrade = "C";
                    break;
                default:
                    lettergrade = "F";
                    break;
            }
            return lettergrade; 
        }
    }
}
