
namespace ApiSecureStudent.Models
{
    using System.Data.Entity;
    public class DattaContext : DbContext 
    {
        public DattaContext(): base("DefaultConnection") //ctor +tab+tab
        {

        }

        public System.Data.Entity.DbSet<ApiSecureStudent.Models.Student> Students { get; set; }
    }
}