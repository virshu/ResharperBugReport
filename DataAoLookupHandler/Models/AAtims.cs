using Microsoft.EntityFrameworkCore;

namespace DataAoLookupHandler.Models;

public class AAtims : DbContext
{
    public virtual DbSet<IncarcerationArrestXref> IncarcerationArrestXref { get; set; }
    public virtual DbSet<Lookup> Lookup { get; set; }
    public virtual DbSet<Arrest> Arrest { get; set; }
    public virtual DbSet<Agency> Agency { get; set; }

}