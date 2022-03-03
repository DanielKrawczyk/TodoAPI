using TodosAPI.Infrastructure.Data.Repositories.Interfaces;
using TodosAPI.Models.Todos;

namespace TodosAPI.Infrastructure.Data.Repositories.Read
{
    public class ReadTodosRepository : IReadTodosRepository
    {
        private readonly DataContext _context;

        public ReadTodosRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task<List<TodoDto>> GetTodoList()
        {
            var result = (
                from todo in _context.Todos
                select new TodoDto()
                {
                   Id = todo.Id,
                   Title = todo.Title,
                   Description = todo.Description,
                   CreationDate = DateTime.Parse(todo.CreationDate),
                   DueTo = todo.DueTo != null ? DateTime.Parse(todo.DueTo) : null,
                   Status = todo.Status
                }).ToList();

            return Task.FromResult(result);
        }

        public Task<TodoDto?> GetTodo(int id)
        {
            var result = (
                from todo in _context.Todos
                where todo.Id == id
                select new TodoDto()
                {
                    Id = todo.Id,
                    Title = todo.Title,
                    Description = todo.Description,
                    CreationDate = DateTime.Parse(todo.CreationDate),
                    DueTo = todo.DueTo != null ? DateTime.Parse(todo.DueTo) : null,
                    Status = todo.Status
                }).FirstOrDefault();

            return Task.FromResult(result);
        }
    }
}
