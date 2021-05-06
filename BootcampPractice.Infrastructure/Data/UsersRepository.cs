using BootcampPractice.ApplicationCore.DomainModels;
using BootcampPractice.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//Implementa IUsersRepository, implementa una interfaz. Es nuestro acceso a datos
namespace BootcampPractice.Infrastructure.Data
{
    public class UsersRepository : IUsersRepository
    {
        //crear lista de users en memoria local, no acceso a base de datos:
        List<User> Users = new List<User>();

        public Task<User> Create(User user)
        {
            //La lista de memoria, cuando mande a llamar del repositorio el create(), asigna un id y lo agrega a la lista. Mientras no reinicie la aplicación, seguirá en la memoria
            user.Id = Guid.NewGuid().ToString(); //generar user id
            Users.Add(user);

            return Task.FromResult(user);
        }

        public Task Delete(string id)
        {
            Users.RemoveAll(p => p.Id == id);
            return Task.FromResult("completado");
            
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return Task.FromResult((IEnumerable<User>)Users); //se hace un cast, es decir, asegurarse que sea del tipo IEnumerable
        }

        public Task<User> GetById(string id)
        {
            //task from result se utiliza cuando no requerimos un método asíncrono, pero nuestro metodo requiere un task
            return Task.FromResult(Users.Find(u => u.Id == id));
        }
    }
}
