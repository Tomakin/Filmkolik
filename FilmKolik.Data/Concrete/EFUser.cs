using Filmkolik.Core.Data;
using Filmkolik.Data.DAL;
using Filmkolik.Entities.Entity;
using FilmKolik.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmkolik.Data.Concrete
{
    public class EFUser : EfEntityRepository<User>, IUser
    {
        public EFUser(EFProjectContext context) : base(context) { }
    }
}
