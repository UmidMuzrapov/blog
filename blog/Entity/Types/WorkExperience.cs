namespace blog.Entity
{
    public class WorkExperience
    {
        public string? Title { get; set; }

        public string? Company {  get; set; }
        
        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public DateTime? startDate { get; set; }

        public DateTime? endDate { get; set; }

        public List<string> Responsibilities { get; set; } = new List<string>();
    }
}
