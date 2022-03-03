using MediatR;
using TodosAPI.Infrastructure.Data.Repositories.Interfaces;
using TodosAPI.Models.Todos;

namespace TodosAPI.Features.Todos
{
    public class Todo
    {
        public record Request(int Id) : IRequest<TodoDto?>;

        public class Handler : IRequestHandler<Request, TodoDto?>
        {
            private readonly IReadTodosRepository _readTodosRepository;

            public Handler(IReadTodosRepository readTodosRepository)
            {
                _readTodosRepository = readTodosRepository ?? throw new ArgumentNullException(nameof(readTodosRepository));
            }

            public async Task<TodoDto?> Handle(Request request, CancellationToken cancellationToken)
                => await _readTodosRepository.GetTodo(request.Id);
        }
    }
}
