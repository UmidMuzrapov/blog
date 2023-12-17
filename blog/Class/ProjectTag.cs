namespace blog.Class
{
    public class ProjectTag
    {
        public string? Pname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Overview { get; set; }
        public string? GitHubLink { get; set; }
        public string? photoLink { get; set; }
        public Dictionary<string, string>? TagLink { get; set; }
    }
}
