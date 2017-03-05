using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Repository
{
    public class CommandRepository<T> : ICommandRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;

        public CommandRepository(IDbContext context)
        {
            this._context = context;
        }
        public int SaveChanges()
        {
           return  _context.SaveChanges();
        }
    }
}
