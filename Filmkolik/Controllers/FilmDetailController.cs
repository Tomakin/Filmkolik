using Filmkolik.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmkolik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmDetailController : ControllerBase
    {
        IDatabaseService _db;
        public FilmDetailController(IDatabaseService db)
        {
            _db = db;
        }

        [HttpPost("getFilmDetail")]
        public IActionResult GetFilmDetail(int filmDetailID)
        {
            return Ok(_db.FilmDetail.GetByID(filmDetailID));
        }
    }
}
