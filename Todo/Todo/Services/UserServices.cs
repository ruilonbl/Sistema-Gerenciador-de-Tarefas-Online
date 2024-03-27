using Todo.DataContex;
using Todo.Entitys;
using Todo.Repositorys;

namespace Todo.Services
{
    public class UserServices : IUserServices
    {
        private IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }
        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }
        
    }
}
