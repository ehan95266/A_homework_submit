using System;
namespace IPersonService
{
	interface IInstructorService:IPersonService
	{
		public string Department(Person.Department d);
		public bool Head(Person.Department d);
		public decimal Bonus(Person.Instructor I);
	}

    class InstructorService : IInstructorService
    {
        public int Age(Person.Person p)
        {
            return p.year;
        }

        public decimal bonus;
        public decimal Bonus(Person.Instructor I)
        {
            if (I.year > 2)
            {
                bonus = salary + salary;
                return bonus;
            }
            else
            {
                return salary;
            }
        }

        public decimal salary;
        public decimal CalculateSalary(Person.Person p)
        {
            salary = salary * 12;
            return p.salary;
        }

        public List<string> GetMultiAddress(Person.Person p)
        {
            List<string> personadd = new List<string>();
            return personadd;
        }

        public bool Head(Person.Department d)
        {

            if (d.Head)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Department(Person.Department d)
        {
            return d.Name;
        }
    }
}

