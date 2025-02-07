namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? CivilId { get; set; }
        public String? FileNumber { get; set; }
        public String? Fullname { get; set; }
        public String? JobName { get; set; }
        public String? Address { get; set; }
        public String? TelephoneNumber { get; set; }
        public String? Photo { get; set; }
        public String? Other { get; set; }

        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }
        public Branch? Branch { get; set; }
        public int BranchId { get; set; }
        public Town? Town { get; set; }
        public int TownId { get; set; }

    }
}
