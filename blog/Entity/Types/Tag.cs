namespace blog.Entity
{ 
    public class Tag
    {
        public string Tname { get; set; }
        public string? DescriptionLink { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is Tag)
            {
                return this.Tname.Equals(((Tag)obj).Tname);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Tname.GetHashCode();
        }
    }
}
