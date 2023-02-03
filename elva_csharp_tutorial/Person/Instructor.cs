using System;
namespace Person
{
	class Instructor:Person
	{
		
		public Instructor(string eat,string walk,string gender):base(eat,walk,gender)
		{
		}

		//override abstract method
		public override void DoYouEat()
		{
			Console.WriteLine("no, instructor walks");
		}

		//encapsulation
        public string DetailInfo()
        {
            return ("John " + this.eat + " and " + this.walk + " and is " + this.gender);
        }

        //override virtual method
        public override void DoYouWalk(int a, int b)
        {

            Console.WriteLine("instructor go to school in days: " + (a / b));
        }
    }
}

