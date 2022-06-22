using Cadastro.Domain.Interfaces;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Infra.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infra.Data.Repositories.Abstract
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        protected readonly CadastroContext _context;
        public BaseRepository(CadastroContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }
    }
}
