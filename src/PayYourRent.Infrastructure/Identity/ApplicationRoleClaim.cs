using Microsoft.AspNetCore.Identity;

namespace PayYourRent.Infrastructure.Identity;

public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
{
    public virtual ApplicationRole Role { get; set; }
}
