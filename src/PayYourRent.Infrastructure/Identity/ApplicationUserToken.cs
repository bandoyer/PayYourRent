using Microsoft.AspNetCore.Identity;

namespace PayYourRent.Infrastructure.Identity;

public class ApplicationUserToken : IdentityUserToken<Guid>
{
    public virtual ApplicationUser User { get; set; }
}
