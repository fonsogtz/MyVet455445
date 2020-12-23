using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data
{
    public class DataContext: IdentityDbContext<User> // hereando con la clase personalizada USER
    {
        //nuestra bd va a contener el modelo owner
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        //actualizando la base, diciendole que son 6 tablas
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<History> Histories { get; set; }

        public DbSet<Owner> Owners { get; set; }

        //administradores del sistema
        public DbSet<Manager> Managers { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<PetType> PetTypes { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }

    }
}
