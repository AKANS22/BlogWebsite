namespace BlogWebsite.Models.DomainModel
{
    public class Tags
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public ICollection<BlogPost> BlogPost { get; set; }
    }
}
