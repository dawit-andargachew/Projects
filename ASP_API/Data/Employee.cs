namespace ASP_API.Data
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        //public DateTime DateofBirth { set; get; }
        public string Department { get; set; }

    }
}
