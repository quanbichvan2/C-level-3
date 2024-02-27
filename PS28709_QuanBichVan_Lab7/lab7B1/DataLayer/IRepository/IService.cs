using System.Collections.Generic;

namespace DataLayer.IRepository
{
    public interface IService<T>
    {
        List<T>? GetList();

        bool Add(T obj);

        bool Update(T obj);
        // T obj là DTO : là dữ liệu truyền từ form xuống
        bool Delete(T obj);

        bool Save();
    }
}
