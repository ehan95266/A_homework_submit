using System;
namespace hwk7Generic
{
	public class MyList<T>
	{
		public List<T> data = new List<T>();
        public T? elementlist;
		public int index;

		public void Add(int index,T elementlist) { }
        public void Remove(int index) { }
        public bool Contains(T elementlist)
		{
			if (true)
			{
				return true;
			}
			else
			{	
			}
			
		}
        public void Clear() { }
        public void InsertAt(T element, int index) { }
        public void DeleteAt(int index) { }
		public T? Find(int index)
		{
			if (index < 6)
			{

				return elementlist;
			}
			else
			{
				return default;
			}
		}
    }
}

