namespace Entities.Concrete
{
    public class UserEducation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EducationId { get; set; }
        public bool ParticipationStatus { get; set; }
        public bool SuccessStatus { get; set; }
        public bool TimeSpent { get; set; }
        public bool Favorite { get; set; }
        public bool WatchLater { get; set; }
        public bool Notes { get; set; }
    }

}
