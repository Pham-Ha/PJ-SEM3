using Microsoft.EntityFrameworkCore;

namespace Project_SEM3.Models
{
    public class ClinicDBContext :DbContext
    {
        public ClinicDBContext(DbContextOptions options) : base(options)
        {

        }
        
    }
}
