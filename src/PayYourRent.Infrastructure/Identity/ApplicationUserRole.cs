using Microsoft.AspNetCore.Identity;

namespace PayYourRent.Infrastructure.Identity;

public class ApplicationUserRole : IdentityUserRole<Guid>
{
    public virtual ApplicationUser User { get; set; }
    public virtual ApplicationRole Role { get; set; }
}
