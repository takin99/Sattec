using Microsoft.EntityFrameworkCore;
using sattec.Identity.Domain.Entities;

namespace sattec.Identity.Application.Common.Interfaces;

public interface IApplicationDbContext
{
 //   DbSet<User> User { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
