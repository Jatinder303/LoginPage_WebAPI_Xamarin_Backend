using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginPage_WebAPI_Xamarin_Backend.Models;

namespace LoginPage_WebAPI_Xamarin_Backend.Data
{
    public class LoginPage_Database : DbContext
    {
        public LoginPage_Database (DbContextOptions<LoginPage_Database> options)
            : base(options)
        {
        }

        public DbSet<LoginPage_WebAPI_Xamarin_Backend.Models.Login> Login { get; set; }
    }
}
