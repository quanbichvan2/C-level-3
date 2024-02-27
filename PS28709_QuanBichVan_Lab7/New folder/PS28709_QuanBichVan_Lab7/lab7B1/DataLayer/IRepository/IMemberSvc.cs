using DataLayer.Models;
namespace DataLayer.IRepository
{
    public interface IMemberSvc 
    {
        List<Member>? GetList();
        bool Add(Member member);
        bool Update(Member member);
        bool Delete(Member member);
        bool Save();
    }
}
