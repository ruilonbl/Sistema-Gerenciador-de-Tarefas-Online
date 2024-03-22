using Todo.Entitys;

namespace Todo.Services
{
    public interface IListRepository
    {
        void Add(ListToDo list);
        void Update(ListToDo list);
        void Delete(ListToDo list);
        ListToDo GetById(int id);
        List<ListToDo> GetAll();
    }
}
