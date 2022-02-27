using Microsoft.AspNetCore.Identity;

namespace PayYourRent.Infrastructure.Identity;

public class ApplicationUserClaim : IdentityUserClaim<Guid>
{
    public virtual ApplicationUser User { get; set; }
}
