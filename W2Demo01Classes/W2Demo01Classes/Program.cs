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

            
        }
    }

    
}
