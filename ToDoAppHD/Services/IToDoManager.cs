using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppHD.Models;

namespace ToDoAppHD.Services
{
    public interface IToDoManager
    {
        Task<int> Create(ToDo toDo);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(ToDo toDo);
        Task<ToDo> GetById(int Id);
        Task<List<ToDo>> ListAll();
    }
}
