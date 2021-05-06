using BootcampPractice.ApplicationCore.Interfaces.Repositories.Services;
using BootcampPractice.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Entrada del Api
namespace BootcampPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        //inyectar servicio al controlador
        public UsersController(IUsersService usersService)
        {
            this._usersService = usersService;
        }

        [HttpPost]
        //regresa un objeto user para ver que ID trajo
        public Task<User> Create(User user)
        {
            return this._usersService.CreateUser(user);
        }

        [HttpGet]
        //traer una lista de usuarios (IEnumerable). No recibe nada
        public Task<IEnumerable<User>> GetAll()
        {
            return this._usersService.GetAll();
        }

        //Get que lea el Id --> ruta get/id
        [HttpGet, Route("{id}")]
        public Task<User> GeById([FromRoute] string id)
        {
            return this._usersService.GetById(id);
        }

        //Borrar según el id. No va a regresar nada, por eso solo se pone Task
        [HttpDelete, Route("{id}")]
        public Task  Delete([FromRoute] string id)
        {
            return this._usersService.Delete(id);
        }
    }
}
