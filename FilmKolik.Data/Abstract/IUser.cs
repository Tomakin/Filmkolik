using Filmkolik.Core.Data;
using Filmkolik.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKolik.Data.Abstract
{
    public interface IUser : IEntityRepository<User>
    {
    }
}
