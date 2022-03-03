using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodosAPI.Models.Users;

namespace TodosAPI.Features.Users
{
    [Route(Paths.Users.Url)]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetList()
            => throw new NotImplementedException();

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> Get()
            => throw new NotImplementedException();

        [HttpPost]
        public async Task<ActionResult<UserDto>> Post()
            => throw new NotImplementedException();

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Put()
            => throw new NotImplementedException();

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserDto>> Delete()
            => throw new NotImplementedException();
    }
}
