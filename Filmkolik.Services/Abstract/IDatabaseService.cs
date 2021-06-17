using FilmKolik.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmkolik.Services.Abstract
{
    public interface IDatabaseService : IDisposable
    {
        IUser User { get; }
        IFilmDetail FilmDetail { get; }
        int SaveChanges();
    }
}
