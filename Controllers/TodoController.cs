using MeuTodo.Data;
using MeuTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Controllers
{
    // atributos
    [ApiController]
    [Route("v1")]   
    public class TodoController : ControllerBase
    {
        // atributos
        [HttpGet]
        [Route("todos")] // URL
        public async Task<IActionResult> Get(
            [FromServices] AppDataContext context)
        { 
            var todos = await context
            .Todos
            .AsNoTracking()
            .ToListAsync();
            return Ok(todos);
        }
    }
}