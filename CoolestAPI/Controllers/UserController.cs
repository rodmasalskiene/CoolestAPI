using CoolestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CoolestAPI.Controllers

        public class UserController : Controller
        {
            [HttpGet]
            public ActionResult<IEnumerable<User>> Get()
            {
                // Retorna uma lista de usuários
                return new List<User>()
            {
                new User() { Id = 1, Name = "João Silva", Email = "joaosilva@email.com" },
            };
            }
        }
  

    //// Código do gemini 
    ///
    //    using System;
    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Threading.Tasks;
    //using Microsoft.AspNetCore.Mvc;

    //namespace App.Controllers
    //    {
    //        [Route("api/[controller]")]
    //        [ApiController]
    //        public class UserController : ControllerBase
    //        {
    //            // GET: api/User
    //            [HttpGet]
    //            public ActionResult<IEnumerable<User>> Get()
    //            {
    //                // Retorna uma lista de usuários
    //                return new List<User>()
    //            {
    //                new User() { Id = 1, Name = "João Silva", Email = "joaosilva@email.com" },
    //                new User() { Id = 2, Name = "Maria Oliveira", Email = "mariaoliveira@email.com" },
    //                new User() { Id = 3, Name = "Pedro Souza", Email = "pedrosouza@email.com" }
    //            };
    //            }

    //            // GET: api/User/5
    //            [HttpGet("{id}")]
    //            public ActionResult<User> Get(int id)
    //            {
    //                // Retorna um usuário específico pelo ID
    //                var user = new User() { Id = id, Name = "Nome do Usuário", Email = "email@email.com" };

    //                if (user == null)
    //                {
    //                    return NotFound();
    //                }

    //                return user;
    //            }

    //            // POST: api/User
    //            [HttpPost]
    //            public ActionResult<User> Post([FromBody] User user)
    //            {
    //                // Cria um novo usuário
    //                // ...

    //                return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    //            }

    //            // PUT: api/User/5
    //            [HttpPut("{id}")]
    //            public IActionResult Put(int id, [FromBody] User user)
    //            {
    //                // Atualiza um usuário existente
    //                // ...

    //                return NoContent();
    //            }

    //            // DELETE: api/User/5
    //            [HttpDelete("{id}")]
    //            public IActionResult Delete(int id)
    //            {
    //                // Deleta um usuário
    //                // ...

    //                return NoContent();
    //            }
    //        }

    //        public class User
    //        {
    //            public int Id { get; set; }
    //            public string Name { get; set; }
    //            public string Email { get; set; }
    //        }
    //    }
    //}

}
}
