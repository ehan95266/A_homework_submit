using System;
namespace Person
{
	abstract class Person
	{
		//properties
		public string eat { get; set; }
        public string walk { get; set; }
        public string gender { get; set; }
		public int year { get; set; }
		public decimal salary { get; set; }
		public string name { get; set; }
	
        //constructor
        public Person(string eat,string walk,string gender)
		{
			this.eat = eat;
			this.walk = walk;
			this.gender = gender;
		}

		//abstract method
		public abstract void DoYouEat();

		//virtual method
		public virtual void DoYouWalk(int a,int b)
		{
			
			Console.WriteLine( a+b);
		}
	
	}

}

