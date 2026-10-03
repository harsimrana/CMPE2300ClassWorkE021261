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

            //Student student1 = new Student();  // this is default constructor 

            Student student1 = new Student(1, "Simran", "Aulakh");  // This will call your parameterized CTOR

            // How to access public Data Members
            // object.DataMember

            //student1._studentId;  // NO NO NO - Private  ONLY Public 

            // It requires 3 arguments  
            // Order does matter 

            // NOT REQUIRED NOW - Constructor is doing that job
            //student1.CreateStudent(1,"Aulakh", "Simran");

            student1.DisplayStudent();

            Student student2 = new Student(); // using default CTOR

            // Flow -> Student() calls - Student( with parameters)

            student2.DisplayStudent();


            // Another object of Student Class

            Student student3 = null;  // null reference for student3

            // Following line will cause error because student3 is null
            //student3.DisplayStudent();

            // One way to handle this nicely is Elvis Operator
            student3?.DisplayStudent();
            // ?.   null-conditional operator 
            // Elvis Operator looks like Elvis Presley' hair and face sideways

            // without your Elvis operator - it will cause NullReferenceException because student is null.

            //  student3?.DisplayStudent(); 
            // student3 == null ? null : student3.DisplayStudent()

            // check if student3 is null, if so - do nothing otherwise call DisplayStudent() method 

            /* if(student3== null)
             * {
             *      
             * }
             * else{
             *      student3.DisplayStudent();
             * }
             * 
             */


            // Using Properties to work with data members
            Student student4 = new Student();

            // object.PropertyName 
            student4.StudentId = 5;  // Setting the value
            
            // It will complaint about the following because we are trying to access a read only property

            //student4.StudentFName = "Simran";

            Console.WriteLine(student4.StudentId); // Accessing the value
            
            Console.WriteLine(student4.StudentFName);

            Student student5= new Student();

            Console.WriteLine($" Total Number of students so far {Student.StudentCount}");

            // Calling Static method 
            // No need to create an object to access static members
            Student.DisplayStudentCount();


            student5.StudentGrade = 53; 
            // Let's test passing grades for any student

            bool returnedValue = Student.IsPassingGrade(student5.StudentGrade);

            string reponse = returnedValue ? "Passing" : "failing";

            Console.WriteLine(" You are " + reponse);



            // Week 04 Day 01: Demo Continue to Grow : 22.09.2026

            // Equals()

            Student s1 = new Student(300, "Simran1", "Aulakh");
            Student s2 = new Student(300, "Simran", "Aulakh");
            
            // Reference Equality
            // True or False ?? -- Run the program
            Console.WriteLine(s1 == s2);

            // Assigning reference to another variable 
            Student s3 = s1;

            // True or False ??
            Console.WriteLine(s1 == s3);

            // True or False ?? True - Value/ content Equality 
            Console.WriteLine(s1.StudentFName == s2.StudentFName);


            // Test it with Equals TRUE or False 
            Console.WriteLine(s1.Equals(s2));


            // Week 05 Day 01: Demo Continue to Grow : 29.09.2026
            // Compare objects with each other

            List<Student> myStudents = new List<Student>
            {
                new Student(101, "Simran", "Aulakh", 63),
                new Student(102,"Alex", "ABC", 85),
                new Student (103, "John", "Xyz", 90)
            };

            //myStudents.Sort();


            /* What happens internally
             * 
             * myStudents.Sort() ->  List needs to compare studnets Objects
             * 
             * -> CompareTo()  -> Student Says which one comes first 
             * 
             * -> List rearrange objects 
             * 
             * Sort() function does not know it magically 
             * 
             * YOur class has defined the comparison rule
             * 
             */
            //foreach (Student student in myStudents)
            //{
            //    Console.WriteLine(student);
            //}
            // not required because we have method for it
            DisplayStudents(myStudents);



            /*  Week 05 Day 03: Demo Continue to Grow : 02.10.2026
                Compare objects with each other

                Comparison<T>  in C# is a delegate used to define how two objects should be compared for sorting

                - rule that takes two objects and tells C# which one should come first

                
             * 
             */

            Console.WriteLine("Sort By Student Id");

            Comparison<Student> compareBy = CompareByID;  // Assigning method CompareById to my delegate : NO ()

            myStudents.Sort(compareBy);  // Magic - passing sorting rule here

            // Printing students
            DisplayStudents(myStudents);


            Console.WriteLine("Sort By Student First name");

            compareBy = CompareByFName;
            myStudents.Sort(compareBy);

            // Printing students
            DisplayStudents(myStudents);


            Console.WriteLine("Sort By Student Last name");
              //     Notice the class name here WHY ??  
            compareBy = Student.CompareByLName;

            myStudents.Sort(compareBy);

            DisplayStudents(myStudents);


            // Part 02: Predicate<T> 

            Console.WriteLine("Students with Grade 80 or above");

            Predicate<Student> gradeCheck = HasHighGrade;

            // Find all students who are scoring 80 or above
            List<Student> gradeResult = myStudents.FindAll(gradeCheck);

            DisplayStudents(gradeResult);
        }

        // Method to show my students

        static void DisplayStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Comparison Methods for comparison rules

        // Define a rule to sort students according to Student ID
        static int CompareByID(Student s1, Student s2)
        { 
            return s1.StudentId.CompareTo(s2.StudentId);
        }

        // Rule #02 to sort students according to Student FirstName
        static int CompareByFName(Student s1, Student s2)
        { 
            return s1.StudentFName.CompareTo(s2.StudentFName);
        }

        // Rule #03 to sort students according to Student LastName
        // Go check the class def for Rule #03- you can place rules in your class as well



        // Predicate
        /*
         *  Predicate<T> is another delegate type
         *    but unlike Comparison<T> . It does not compare two objects.
         *    
         *    It always asks YES/NO or TRUE/FALSE about one object
         *    
         */


        static bool HasHighGrade(Student student)
        {
            return student.StudentGrade >= 80; // taking decision based on student Grade
        }



    }

    
}
