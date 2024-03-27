using Todo.Entitys;

namespace Todo.Services
{
    public class ListaServices : IListServices
    {
        private readonly IListRepository _listRepository;

        public ListaServices(IListRepository listRepository) 
        {
            _listRepository = listRepository;
        }

        public void Add(ListToDo list)
        {
            _listRepository.Add(list);
        }

        public void Delete(ListToDo list)
        {
            _listRepository.Delete(list);
        }

        public List<ListToDo> GetAll()
        {
            return _listRepository.GetAll();
        }

        public ListToDo GetById(int id)
        {
            return _listRepository.GetById(id);
        }

        public void Update(ListToDo list)
        {
            _listRepository.Update(list);
        }
    }
}
