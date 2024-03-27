using Todo.Entitys;

namespace Todo.Services
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User GetById(int id);
        List<User> GetAll();
    }
}
