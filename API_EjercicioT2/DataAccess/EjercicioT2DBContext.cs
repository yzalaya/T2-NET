using Microsoft.EntityFrameworkCore;
using API_EjercicioT2.Models.DataModels;

namespace API_EjercicioT2.DataAccess
{
    public class EjercicioT2DBContext: DbContext
    {
        public EjercicioT2DBContext(DbContextOptions<EjercicioT2DBContext> options): base(options)
        {

        }

        // TODO: Add DbSets (Tables of our Data Base)
        public DbSet<Curso>? Cursos { get; set; }
    }
}