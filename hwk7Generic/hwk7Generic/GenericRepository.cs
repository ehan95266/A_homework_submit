using System;

namespace hwk7Generic
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        
        public List<T> list;

        public int Id { get; set ; }
       

        public void Add(T item)
        {
            list.Add(item);
        }


        public IEnumerable<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    return item;
                }

            }
            return null;
        }


        public void Update(T item) { }
        


        public void Remove(T item)
        {
            list.Remove(item);
        }
        
    }
}

