using System;
namespace IPersonService
{

	interface ICourseService
	{
		public List<string> NumStudent(Person.Student n);
	}

	class Course : ICourseService
	{
		public List<string> NumStudent(Person.Student n)
		{
			List<string> multistudent = new List<string>();
			return multistudent;

        }
	}
}

