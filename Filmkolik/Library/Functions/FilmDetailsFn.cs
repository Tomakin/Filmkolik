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
            detail = _db.FilmDetail.Get(film => film.FilmID == id);
            return detail;
        }

        public void addFilmDetail(FilmDetail detail)
        {
            FilmDetail filmDetail = _db.FilmDetail.Get(film => film.FilmID == detail.FilmID);
            if (filmDetail != null)
            {
                filmDetail.Not = detail.Not;
                filmDetail.Score = detail.Score;
                _db.FilmDetail.Update(filmDetail);
                _db.SaveChanges();
            }

        }
    }
}
