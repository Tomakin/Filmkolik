using Filmkolik.ClassModels;
using Filmkolik.Entities.Entity;
using Filmkolik.Library.Functions;
using Filmkolik.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static Filmkolik.Entities.Entity.Enums;
using static Filmkolik.Library.Helpers.ClaimRole;

namespace Filmkolik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ClaimRequirement(ClaimTypes.Role, "Admin_Role", "FilmUser_Role")]
    [Authorize]
    public class FilmsController : ControllerBase
    {
        IDatabaseService _db;
        FilmDetailsFn _filmDetailFn;
        List<FilmModel> films;
        public FilmsController(IDatabaseService db, FilmDetailsFn filmDetailsFn)
        {
            _db = db;
            _filmDetailFn = filmDetailsFn;

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

        [HttpGet("getFilmDetails/{id}")]
        public IActionResult GetFilmDetails(int id)
        {
            FilmDetail detail = _filmDetailFn.getFilmDetail(id);
            return Ok(detail);
        }

        [HttpPost("addFilmDetails")]
        public IActionResult AddFilmDetails(FilmDetail detail)
        {
            _filmDetailFn.addFilmDetail(detail);
            return Ok();
        }
    }
}
