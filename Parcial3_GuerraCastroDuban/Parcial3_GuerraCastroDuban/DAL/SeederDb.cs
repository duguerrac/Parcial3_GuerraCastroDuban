using Parcial3_GuerraCastroDuban.DAL.Entities;

namespace Parcial3_GuerraCastroDuban.DAL
{
    public class SeederDb
    {
        private readonly DataBaseContext _context;

        public SeederDb(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await PopulateServicesAsync();

            await _context.SaveChangesAsync();
        }

        private async Task PopulateServicesAsync()
        {
            if (!_context.Services.Any())
            {
                _context.Services.Add(new Service { Name = "Lavada simple", Price= 25000});
                _context.Services.Add(new Service { Name = "Lavada + Polishada", Price= 50000});
                _context.Services.Add(new Service { Name = "Lavada + Aspirada de Cojinería", Price= 30000});
                _context.Services.Add(new Service { Name = "Lavada Full", Price= 65000});
                _context.Services.Add(new Service { Name = "Lavada en seco del Motor", Price= 80000});
                _context.Services.Add(new Service { Name = "Lavada Chasis", Price= 90000});
            }
        }
    }
}
