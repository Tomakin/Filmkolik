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
            { Roller.Admin, "Role_Admin"},
            { Roller.User, "Role_User"},
            { Roller.SuperUser, "Role_SuperUser"},
        };

        public enum Roller
        {
            Admin = 1,
            User = 2,
            SuperUser = 3,
        }
    }
}
