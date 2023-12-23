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
                return this.Tname.Equals(((Tag)obj).Tname, StringComparison.OrdinalIgnoreCase);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return FirstCharToUpper(Tname.ToLower()).GetHashCode();
        }

        public string FirstCharToUpper(string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };
    }
}
