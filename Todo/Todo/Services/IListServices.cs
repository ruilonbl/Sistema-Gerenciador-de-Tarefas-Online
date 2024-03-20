using Todo.Entitys;

namespace Todo.Services
{
    public interface IListServices
    {
        void Add(ListToDo list);
        void Update(ListToDo list);
        void Delete(ListToDo list);
        ListToDo GetById(int id);
        List<ListToDo> GetAll();
    }
}
