using Filmkolik.Data.Concrete;
using Filmkolik.Data.DAL;
using Filmkolik.Services.Abstract;
using FilmKolik.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmkolik.Services.Concrete
{
    public class EfDatabaseService : IDatabaseService
    {
        private readonly EFProjectContext context;
        public EfDatabaseService(EFProjectContext _context) => context = _context;

        //Field
        private IUser _User;
        private IFilmDetail _FilmDetail;

        //Property
        public IUser User => _User ??= new EFUser(context);
        public IFilmDetail FilmDetail => _FilmDetail ??= new EFFilmDetail(context);

        public void Dispose()
           => context.Dispose();

        public int SaveChanges()
            => context.SaveChanges();
    }
}
