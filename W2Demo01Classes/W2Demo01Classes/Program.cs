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

            student2.DisplayStudent();

        }
    }

    
}
