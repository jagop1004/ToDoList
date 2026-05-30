using Microsoft.AspNetCore.Mvc;
using ToDoListBackend.Services;
using ToDoListBackend.Models;

namespace ToDoListBackend.Data
{
    public abstract class Repository
    {
        DatabaseManagment? db;
        public abstract IEnumerable<IDataStructure> GetAll(DatabaseManagment db);
        public abstract IDataStructure GetById(DatabaseManagment db, int id);
        public abstract bool WriteById(DatabaseManagment db, int id);
        public abstract bool Create(DatabaseManagment db, IDataStructure data);
        public abstract bool DeleteById(DatabaseManagment db, int id);
    }
}
