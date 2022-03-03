using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodosAPI.Models.Todos;

namespace TodosAPI.Features.Todos
{
    [Route(Paths.Todos.Url)]
    public class TodosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodosController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<ActionResult<List<TodoDto>>> GetList()
            => throw new NotImplementedException();

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoDto>> Get()
            => throw new NotImplementedException();

        [HttpPost]
        public async Task<ActionResult<TodoDto>> Post()
            => throw new NotImplementedException();

        [HttpPut("{id}")]
        public async Task<ActionResult<TodoDto>> Put()
            => throw new NotImplementedException();

        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoDto>> Delete()
            => throw new NotImplementedException();
    }
}
