namespace EventRegistrationSystem.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> Roles { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
