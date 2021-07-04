using Filmkolik.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Filmkolik.Entities.Entity.Enums;

namespace Filmkolik.Entities.Entity
{
    public class User : BaseEntity, IEntity
    {
        private string rol;
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Roller Rol { get; set; }
        [NotMapped]
        public string RolString
        {
            get
            {
                return Enums.roleString[this.Rol];
            }
            set
            {
                rol = value;
            }
        }
    }
}
