using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tntk1
{
    class Program
    {

        public class Student
        {
            public int _age;

        }
        static void Main(String[] args)

        {
            Int32 myVar = new Int32();
            myVar = 256;

            Student student = new Student();
            student._age = 5;

            Calculate(student);
            Console.WriteLine(student._age);
            Console.Read();
        }
        static void Calculate(Student student)
        {
            student._age += 1;

        }
    }
}
