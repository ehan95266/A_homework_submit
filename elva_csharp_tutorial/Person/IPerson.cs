using System;
using Person;

namespace IPersonService
{
	interface IPersonService
	{
		//void method
		public int Age(Person.Person p);
		public decimal CalculateSalary(Person.Person p);
		public List<string> GetMultiAddress(Person.Person p);
	}

    class PersonService : IPersonService
    {
   
        public decimal salary;


        public int Age(Person.Person p)
        {
            return p.year;
        }

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
    }
}

