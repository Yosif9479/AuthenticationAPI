using Microsoft.EntityFrameworkCore;

namespace AuthenticationAPI.Controllers
{
    public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext
    {
           
    }
}
