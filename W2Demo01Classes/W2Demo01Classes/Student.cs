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

        double _studentGrade;

        // Static Data member
        public static int StudentCount = 0;

        /* Properties 
         Let you control access to data members without forcing
         users of the class to call methods
        
         public datatype PropertyName
        {
            
        }
        */
        public int StudentId
        {
            get
            {
                return _studentId;
            }
            set 
            {
                // validate and sanitize your incoming data
                _studentId = value;  // So value will represent the value provided by user 
            }
        }

        // Automatic version of property  auto- implemented
        //public int StudentId
        //{
        //    get; set;  // But no flexibility to add validations here
        //}

        public double StudentGrade { get; set; }

        public string StudentFName
        {  // Read Only Property 
            get
            {
                return _studentFName;
            }
            // because there is no set added
        }


        // Data members- actually store the data
        // Property - provides controlled access - Lock to your storage
        // Methods- represent actions or behaviour


        // So you need to write one setter and one getter method for 
        // each and every data member
        // To Avoid this - Properties were there
        public string GetStudentFirstName()
        {
            return _studentFName;
        }

        public void SetStudentFirstName(string fname)
        {
            // Validation 
            // Name should not be empty
            _studentFName = fname;
        }
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
        //public Student()
        //{
        //    _studentId = 0;
        //    _studentFName = "";
        //    _studentLName = "";
        //}

        public Student(int sid, string firstName, string lastName)
        {
            _studentId = sid;
            _studentFName = firstName;
            _studentLName = lastName;
            StudentGrade = 65;

            StudentCount++;  // Why class name is not there because you are accessing inside the class

        }

        // Constructor Chaining - one constructor will call another constructor, so you can reuse initialization logic instead
        // repeating it.
        /*
         *  : this (...)
         *  
         *  
         */

        public Student()
            : this(0, "", "")
        {

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




        // Static member and methods
        /* Static members and methods belong to class rather than an individual object.
         * It should be public because otherwise you won't able to access it outside the class
         * Static method cannot access object information WHY??  because we provide the reference like which object
         * CTOR or others can access static member 
         * STATIC method can only static data members
         * 
         */

        public static void DisplayStudentCount()
        {
            // UNCOMMENT THE FOLLOWING LINE TO CHECK ERROR   
            //Console.WriteLine($"Total students {_studentFName}"); // Not possible / Not allowed
            // you cannot access regular data members/methods inside static method
            // You can only access static data members/ methods

            Console.WriteLine($"Total students {StudentCount}");
        }

        public static bool IsPassingGrade(double grade)
        {
            if (grade >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }

            // Short cut version
            return grade >= 50;

            // Both versions are doing the same thing
        }
        
    }
}
