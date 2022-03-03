namespace TodosAPI.Infrastructure.Data.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string CreatedDate { get; set; }
        public string? DueTo { get; set; }
        public int Status { get; set; }
    }
}
