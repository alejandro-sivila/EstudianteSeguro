namespace admStudentSecurity.Models
{
    using System.Data.Entity;
    public class DattaContext : DbContext
    {
        public DattaContext() : base("DefaultConnection") //ctor +tab+tab
        {
        }

        public System.Data.Entity.DbSet<admStudentSecurity.Models.Student> Students { get; set; }
    }
}