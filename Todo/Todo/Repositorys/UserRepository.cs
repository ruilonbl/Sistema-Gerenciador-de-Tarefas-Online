using System.Collections.Generic;
using Todo.DataContex;
using Todo.Entitys;
using Todo.Services;

namespace Todo.Repositorys
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(User user)
        {
            _context.Add(user);
        }

        public void Delete(User user)
        {
            _context.Remove(user);
        }

        public List<User> GetAll()
        {
            return _context.users.ToList();
        }

        public User GetById(int id)
        {
            return _context.users.FirstOrDefault(x => x.id == id);
        }

        public void Update(User user)
        {
            _context.Update(user);
        }
    }
}
