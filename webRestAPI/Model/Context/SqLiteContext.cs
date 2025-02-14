using Microsoft.EntityFrameworkCore;

namespace webRestAPI.Model.Context
{
  public class SqLiteContext : DbContext
  {
    public SqLiteContext(DbContextOptions<SqLiteContext> options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }
  }
}
