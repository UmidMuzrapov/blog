using blog.Entity;

namespace blog.Class
{
    public class ProjectTag
    {
        public string? Pname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Overview { get; set; }
        public string? GitHubLink { get; set; }
        public string? PhotoLink { get; set; }
        public List<Tag> Tags{ get; set; }
    }
}
