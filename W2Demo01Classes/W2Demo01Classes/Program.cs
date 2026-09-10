using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2Demo01Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and use the object

            // Syntax 
            // Class Name  objectName =  new ClassName();

            Student student1 = new Student();

            // How to access public Data Members
            // object.DataMember

            //student1._studentId;  // NO NO NO - Private  ONLY Public 

            // It requires 3 arguments  
            // Order does matter 
            student1.CreateStudent(1,"Aulakh", "Simran");

            student1.DisplayStudent();
            
            

        }
    }

    public class Student
    {
        // Data Members
        private int _studentId;  // By default data members are private
        string _studentFName;
        string _studentLName;

        // Methods
        public void DisplayStudent()
        {
            Console.WriteLine($"Student Id : {_studentId}");
            Console.WriteLine($"Student Name : {_studentLName}, {_studentFName}");
        }

        public void CreateStudent(int studentId, string studentFirstName, string studentLastName)
        {
            // validations to check for 
            _studentId = studentId;
            _studentFName = studentFirstName;
            _studentLName = studentLastName; 
        }
    }
}
