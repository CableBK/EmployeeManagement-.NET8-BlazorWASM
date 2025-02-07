namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public String? CivilId { get; set; }
        public String? FileNumber { get; set; }
        public String? Fullname { get; set; }
        public String? JobName { get; set; }
        public String? Address { get; set; }
        public String? TelephoneNumber { get; set; }
        public String? Photo { get; set; }
        public String? Other { get; set; }
    }
}
