using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Consious.Identity.DataContext;

public class DataContext : IdentityDbContext
{
    public DataContext(DbContextOptions<DataContext> options):  base(options)
    {
        
    }
}
