using TodosAPI.Models.Todos;

namespace TodosAPI.Infrastructure.Data.Repositories.Interfaces
{
    public interface IReadTodosRepository
    {
        Task<List<TodoDto>> GetTodoList();
        Task<TodoDto> GetTodo(int id);
    }
}
