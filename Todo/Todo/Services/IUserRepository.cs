using Todo.Entitys;

namespace Todo.Services
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User list);
        void Delete(User list);
        User GetById(int id);
        List<User> GetAll();
    }
}
