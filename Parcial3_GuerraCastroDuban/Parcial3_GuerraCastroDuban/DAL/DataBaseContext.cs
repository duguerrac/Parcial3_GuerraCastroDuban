using Microsoft.EntityFrameworkCore;
using Parcial3_GuerraCastroDuban.DAL.Entities;

namespace Parcial3_GuerraCastroDuban.DAL
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options): base(options) 
        {

        }
        public DbSet<Services> Services { get; set; }
    }
}
