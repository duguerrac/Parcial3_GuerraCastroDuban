using Microsoft.EntityFrameworkCore;
using Parcial3_GuerraCastroDuban.DAL.Entities;

namespace Parcial3_GuerraCastroDuban.DAL
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options): base(options) 
        {

        }
        public DbSet<Parcial3_GuerraCastroDuban.DAL.Entities.Services>? Services { get; set; }
        
    }
}
