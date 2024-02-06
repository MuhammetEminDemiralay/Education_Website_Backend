namespace Entities.Concrete
{
    public class FrequentlyAskedQuestion
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}
