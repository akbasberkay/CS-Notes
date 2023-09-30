using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_App_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student UncleJeff = new Student(id: "765421", name: "Elon", surname: "Musk", visa1: 70, visa2: 56, finalexam: 90, school: "MIT");
            UncleJeff.getStudentInfo();
            UncleJeff.getSchoolInfo();
            UncleJeff.getStudentGrade();
            Console.ReadLine();
        }
    }
}
