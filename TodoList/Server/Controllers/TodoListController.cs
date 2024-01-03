using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Server.Database;
using TodoList.Shared;

namespace TodoList.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        readonly private TodoListDbContext _db;

        public TodoListController(TodoListDbContext db)
        {
            _db = db;
        }

        [HttpPost("AddTodoList")]

        public IActionResult AddTodoList([FromBody] TodoListDto todoListDto)
        {
            Database.TodoList todoList = new Database.TodoList();
            try {
                todoList.Title = todoListDto.Title;
                todoList.Desc = todoListDto.Desc;
                todoList.UserId = todoListDto.UserId;
                todoList.CreatedOn = DateTime.Now;
                todoList.ModifyOn = DateTime.Now;
                todoList.IsDeleted= false;
                _db.TodoLists.Add(todoList);
                _db.SaveChanges();
                return Ok(todoList);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("getList/{userId}")]
        public IActionResult getList(int userId)
        {
            try
            {
                var listsExist=_db.TodoLists.Where(x=>x.UserId == userId).OrderByDescending(x=>x).ToList();
                if(listsExist.Count > 0)
                {
                    return Ok(listsExist);
                }
                else
                {
                    return NotFound();
                }
            }catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
