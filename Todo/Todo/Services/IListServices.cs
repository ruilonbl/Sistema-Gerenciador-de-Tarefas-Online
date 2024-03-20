using Todo.Entitys;

namespace Todo.Services
{
    public interface IListServices
    {
        void Add(List list);
        void Update(List list);
        void Delete(List list);
        List GetById(int id);
        List<List> GetAll();
    }
}
