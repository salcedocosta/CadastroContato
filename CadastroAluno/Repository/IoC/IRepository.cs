using System;
using System.Collections;
using System.Collections.Generic;

namespace Repository.IoC
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}
