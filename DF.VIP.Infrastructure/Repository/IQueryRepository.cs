using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Repository
{
   public interface IQueryRepository<T> where T : BaseEntity
    {
        IQueryable<T> Entities { get; }
    }

}
