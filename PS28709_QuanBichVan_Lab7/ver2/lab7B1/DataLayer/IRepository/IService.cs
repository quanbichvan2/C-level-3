using System.Collections.Generic;

namespace DataLayer.IRepository
{
    public interface IService<T>
    {
        List<T>? GetList();

        bool Add(T obj);

        bool Update(T obj);

        bool Delete(T obj);

        bool Save();
    }
}
