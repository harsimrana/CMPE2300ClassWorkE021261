using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2Demo01Classes
{
    public class Student
    {
        // Data Members
        private int _studentId;  // By default data members are private
        string _studentFName;
        string _studentLName;

        // Methods

        // Constructor: a special method that runs automatically 
        // when you create an object
        // Purpose: Main purpose is to initialze the object so it starts with a valid, useful state
        // You will never call constructor yourself

        // Three Important Characteristics 
        /* 1. Its name is the same as the class name
         * 2. It has no return data type, not even void
         * 3. It usually inializes fields or properties 
         * 
         */

        // NO RETURN DATA Type, No Parameters - Default Constructor
        public Student()
        {
            _studentId = 0;
            _studentFName = "";
            _studentLName = "";
        }

        public Student(int sid, string firstName, string lastName)
        {
            _studentId = sid;
            _studentFName = firstName;
            _studentLName = lastName;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Student Id : {_studentId}");
            Console.WriteLine($"Student Name : {_studentLName}, {_studentFName}");
        }

        // NOT required now because your CTOR will handle that
        public void CreateStudent(int studentId, string studentFirstName, string studentLastName)
        {
            // validations to check for 
            _studentId = studentId;
            _studentFName = studentFirstName;
            _studentLName = studentLastName;
        }

        
    }
}
