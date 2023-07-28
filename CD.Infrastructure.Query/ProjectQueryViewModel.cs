namespace CD.Infrastructure.Query
{
    public class ProjectQueryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string File { get; set; }
        public string CreationDate { get; set; }
        public bool IsRemoved { get; set; }
        public string Category { get; set; }
    }
}