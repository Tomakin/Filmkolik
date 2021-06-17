using Filmkolik.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmkolik.Entities.Entity
{
    public class FilmDetail : BaseEntity, IEntity 
    {
        public string Not { get; set; }
        public decimal Score { get; set; }
        public int FilmID { get; set; }
    }
}
