using Filmkolik.ClassModels;
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
    public class FilmsController : ControllerBase
    {
        IDatabaseService _db;
        List<FilmModel> films;
        public FilmsController(IDatabaseService db)
        {
            _db = db;
            films = new List<FilmModel>()
            {
                new FilmModel
                {
                    ID = 550,
                    FilmName = "Fight Club",
                    FilmImageUrl = "/pB8BM7pdSp6B6Ih7QZ4DrQ3PmJK.jpg"
                },
                new FilmModel
                {
                    ID = 551,
                    FilmName = "The Poseidon Adventure",
                    FilmImageUrl = "/6RGiA5BfhelU9zoD0b1GAG4GWWf.jpg"
                }
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(films);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(films.FirstOrDefault(fod => fod.ID == id));
        }

        [HttpPost("getFilmDetail")]
        public IActionResult GetFilmDetail(int filmDetailID)
        {
            return Ok(_db.FilmDetail.GetByID(filmDetailID));
        }
    }
}
