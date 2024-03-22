﻿using System.Collections.Generic;
using Todo.DataContex;
using Todo.Entitys;
using Todo.Services;

namespace Todo.Repositorys
{
    public class ListRepository : IListServices
    {
        private readonly ApplicationDbContext _context;
        public ListRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(ListToDo list)
        {
            _context.Add(list);
        }

        public void Delete(ListToDo list)
        {
            _context.Remove(list);
        }

        public List<ListToDo> GetAll()
        {
           return _context.listToDos.ToList();
        }

        public ListToDo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ListToDo list)
        {
            throw new NotImplementedException();
        }
    }
}
