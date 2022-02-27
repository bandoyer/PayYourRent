using Ardalis.Specification.EntityFrameworkCore;
using PayYourRent.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayYourRent.Infrastructure.Data;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(PayYourRentContext dbContext) : base(dbContext)
    {
    }
}