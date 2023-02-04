using System;
namespace hwk7Generic
{
	public interface IRepository<T> where T:class
	{
        public int Id { get; set; }
        

        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        T GetById(int Id);
    }
}

