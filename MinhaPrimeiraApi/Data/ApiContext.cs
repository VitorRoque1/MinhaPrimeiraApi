namespace MinhaPrimeiraApi.Data;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.Models;
public class ApiContext : DbContext
{
    public ApiContext (DbContextOptions<ApiContext> options) : base(options)
    {

    }

    public DbSet <Api> Apis { get; set; }

}
