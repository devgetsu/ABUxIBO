namespace EntityCoreLesson.Domain.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public long Employee_count {  get; set; }
    }
}
