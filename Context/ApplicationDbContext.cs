using Empleados23AM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados23AM.Context
{
    //Hereda una libreria de entity framework core
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Aqui va la cadena de la conexion
            optionsBuilder.UseMySQL("Server=localhost;port=3306;User ID=root; Database=Empleados23AM");

        }
        //Mapeo de la base de datos
        public DbSet<Empleado> Empleados { get; set; }
    }
}
