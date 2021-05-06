using BootcampPractice.ApplicationCore.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//Define que metodos va a implementar
//Recibe usuario de domain model, no DTO, pues el DTO solo llega hasta el web y del web al core, de ahí no pasa
namespace BootcampPractice.ApplicationCore.Interfaces.Repositories
{
    public interface IUsersRepository //es nuestro contacto a llenar
    {
        Task<User> Create(User user);
        Task Delete(string id);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(string id);

    }
}
