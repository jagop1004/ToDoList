using Microsoft.AspNetCore.Mvc;
using ToDoListBackend.Functionality;
using ToDoListBackend.Models;

namespace ToDoListBackend.Repositories
{
    public abstract class Repository
    {
        DatabaseManagment? db;
        public abstract IEnumerable<IDataStructure> GetAll();
        public abstract IDataStructure GetById(int id);
        public abstract bool WriteById(int id);
        public abstract bool Create(IDataStructure data);
        public abstract bool DeleteById(int id);
    }
}
