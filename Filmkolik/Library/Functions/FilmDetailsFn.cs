using Filmkolik.Entities.Entity;
using Filmkolik.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmkolik.Library.Functions
{
    public class FilmDetailsFn
    {
        IDatabaseService _db;
        public FilmDetailsFn(IDatabaseService db)
        {
            _db = db;
        }

        public FilmDetail getFilmDetail(int id)
        {
            FilmDetail detail = _db.FilmDetail.Get(film => film.FilmID == id);
            if (detail == null)
            {
                _db.FilmDetail.Add(new FilmDetail
                {
                    FilmID = id
                });
                _db.SaveChanges();
            }
            return detail;
        }
    }
}
