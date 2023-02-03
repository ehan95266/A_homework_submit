using System;
namespace IPersonService
{
	public interface IDepartment
	{
		public bool DeptHead(Person.Department d);
		public decimal Budget(Person.Department d);
		public List<string> CourseList(Person.Department d);
	}

	class Deptartment : IDepartment
	{
		public bool DeptHead(Person.Department d)
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
		public decimal Budget(Person.Department d)
		{
			return d.Budget;
		}
		public List<string> CourseList(Person.Department d)
		{
			List<string> list = new List<string>();
			return list;
		}
    }

}

