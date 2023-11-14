using Microsoft.EntityFrameworkCore;

namespace ShamsheerClone.Data.DbContexts;

public class ShamsheerCloneDbContext : DbContext
{
    public ShamsheerCloneDbContext(DbContextOptions<ShamsheerCloneDbContext> options) : base(options)
    { }

}
