using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Student
    {
        private string name;
        private int age;
        private double finalGrade;
        //Auto-Implemented Property
        public string LastName { get; private set; }

        public Student(string name, string lastname, int age, double finalGrade)
        {
            this.name = name;
            this.LastName = lastname;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        public Student(string name, string lastname, int age) :this(name, lastname, age, 0) //avoid duplicate
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        public string Name
        {
            get
            {
                if (age >= 18)
                {
                    return name;
                }
                else
                {
                    return "This student is under age.";
                }
            }
            set
            {
                if (value != "")
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                if (age >= 18)
                {
                    return age;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value != 0)
                {
                    age = value;
                }
            }
        }

        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                finalGrade = value;
            }
        }
    }
}
