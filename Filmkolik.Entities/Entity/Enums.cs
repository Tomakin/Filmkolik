using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmkolik.Entities.Entity
{
    public class Enums
    {
        public static Dictionary<Roller, string> roleString = new Dictionary<Roller, string>()
        {
            { Roller.Admin, "Admin_Role"},
            { Roller.StarUser, "StarUser_Role"},
            { Roller.FilmUser, "FilmUser_Role"},
        };

        public enum Roller
        {
            Admin = 1,
            StarUser = 2,
            FilmUser = 3,
        }
    }
}
