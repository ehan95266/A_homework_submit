namespace IPersonService
{
    interface IStudentService : IPersonService
	{
		public List<string> MultiCourse(params string[] arr);
		public decimal CalcGPA(Person.Student s);
		public string GradeLetter(Person.Student s);
	}

    class StudentService : IStudentService
    {
        public int Age(Person.Person p)
        {
            return p.year;
        }

        
        public decimal CalcGPA(Person.Student s)
        {
            return s.GPA;
        }

        public int salary;
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

        public string GradeLetter(Person.Student s)
        {
            return s.Grade;
        }

        public List<string> MultiCourse(params string[] arr)
        {
            List<string> course = new List<string>();
            return course;
        }
    }
}

