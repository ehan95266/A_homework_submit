using System;
namespace Person
{
    class Student : Person
    {
        public int GPA { get; set; }
        public string Grade { get; set; }

        public Student(string eat, string walk, string gender) : base(eat, walk, gender)
        {
        }

        //override abstract method
        public override void DoYouEat()
        {
            Console.WriteLine("Student eats");
        }

        //encapsulation

        public string DetailInfo()
        {
            return("Amy " + this.eat + " and " + this.walk + " and is " + this.gender);
        }

        //override virtual method
        public override void DoYouWalk(int a,int b)
        {

            Console.WriteLine("student make " + (a * b));
        }
    }

}

