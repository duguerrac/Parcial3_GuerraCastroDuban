using Parcial3_GuerraCastroDuban.DAL.Entities;
using Parcial3_GuerraCastroDuban.Enums;
using Parcial3_GuerraCastroDuban.Helpers;
using System.Net;

namespace Parcial3_GuerraCastroDuban.DAL
{
    public class SeederDb
    {
        private readonly DataBaseContext _context;
        private readonly IUserHelper _userHelper;

        public SeederDb(DataBaseContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeederAsync()
        {
            var email = "CorreoPruebaDeLaApp@yopmail.com";
            await _context.Database.EnsureCreatedAsync();
            await PopulateServicesAsync();
            await PopulateRoleAsync();
            //await PopulateUserAsync();
            await PopulateUserAsync("Admin", "Role", "admin_role@yopmail.com", "3002323232", "Street Fighter 1", "102030","Medellin", UserType.Admin);
            await PopulateUserAsync("Jose", "Gonzalez", "user_role@yopmail.com", "40056566756", "Street Fighter 2", "405060","Bogota", UserType.User);
            await _context.SaveChangesAsync();
        }
        private async Task PopulateServicesAsync()
        {
            if (!_context.Services.Any())
            {
                _context.Services.Add(new Service { Name = "Lavada simple", Price = 25000 });
                _context.Services.Add(new Service { Name = "Lavada + Polishada", Price = 50000 });
                _context.Services.Add(new Service { Name = "Lavada + Aspirada de Cojinería", Price = 30000 });
                _context.Services.Add(new Service { Name = "Lavada Full", Price = 65000 });
                _context.Services.Add(new Service { Name = "Lavada en seco del Motor", Price = 80000 });
                _context.Services.Add(new Service { Name = "Lavada Chasis", Price = 90000 });
            }
        }

        private async Task PopulateUserAsync(
               string firstName,
               string lastName,
               string email,
               string phone,
               string address,
               string document,
               string city,
               UserType userType)
        {
            User user = await _userHelper.GetUserAsync(email);

            if (user == null)
            {
                user = new User
                {
                    CreatedDate = DateTime.Now,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document,
                    City = city,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, user.UserType.ToString());

            }
        }
        private async Task PopulateRoleAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }
    }
}
