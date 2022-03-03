using static TodosAPI.Infrastructure.Enums.Enums;

namespace TodosAPI.Models.Todos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? DueTo { get; set; }
        public int Status { get; set; }
    }
}
