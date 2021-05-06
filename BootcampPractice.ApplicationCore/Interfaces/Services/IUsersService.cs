using BootcampPractice.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//Crea una interfaz de servicio en caso de que quiera cambiar entre servicios
namespace BootcampPractice.ApplicationCore.Interfaces.Repositories.Services
{
    public interface IUsersService
    {
        //definir métodos que tendrá el servicio
        //El servicio recibe un DTO
        Task<User> CreateUser(User user);
        Task<IEnumerable<User>> GetAll();

        //.........................................
        Task Delete(string id);
        Task<User> GetById(string id);

    }
}
