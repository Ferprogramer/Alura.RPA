using Alura.RPA.Domain.Entities;
using Alura.RPA.Domain.Repositories;
using Alura.RPA.Repository.Contexts;

namespace Alura.RPA.Repository.Repositories
{
    public class CursosRepository : ICursosRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CursosRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void Create(Cursos cursos)
        {
            applicationDbContext.Cursos.Add(cursos);
            applicationDbContext.SaveChanges();
        }
    }
}
