using Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace Service
{
    public interface IServiceBase<T> where T : class
    {        
        T Get(int id);
        IEnumerable<T> GetAll();
        Validate Add(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}
