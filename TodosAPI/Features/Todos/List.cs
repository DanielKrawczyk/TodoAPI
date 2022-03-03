using MediatR;
using TodosAPI.Infrastructure.Data.Repositories.Interfaces;
using TodosAPI.Models.Todos;

namespace TodosAPI.Features.Todos
{
    public class List
    {
        public record Request() : IRequest<List<TodoDto>>;

        public class Handler : IRequestHandler<Request, List<TodoDto>>
        {
            private readonly IReadTodosRepository _readTodosRepository;

            public Handler(IReadTodosRepository readTodosRepository)
            {
                _readTodosRepository = readTodosRepository ?? throw new ArgumentException(nameof(readTodosRepository));
            }

            public async Task<List<TodoDto>> Handle(Request request, CancellationToken cancellationToken)
                => await _readTodosRepository.GetTodoList();
        }
    }
}
