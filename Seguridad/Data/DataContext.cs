using Microsoft.EntityFrameworkCore;
using Seguridad.Models;

namespace Seguridad.Data
{
    public class DataContext : DbContext

        //contructor acceso a datos
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {



        }
        //declaracion de la tabla
        public DbSet<Users>? Users { get; set; }
       

        
    }
}
