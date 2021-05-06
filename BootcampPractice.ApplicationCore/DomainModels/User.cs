using System;
using System.Collections.Generic;
using System.Text;
//En el application core se pone todo lo que no se va a mostrar al publico. Todo lo privado
//El domain model solo va a accederse por medio del core y la infraestructura, es decir, los datos o algún servicio externo
namespace BootcampPractice.ApplicationCore.DomainModels
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }
    }
}
