using Microsoft.AspNetCore.Identity;

namespace PayYourRent.Infrastructure.Identity;

public class ApplicationUserLogin : IdentityUserLogin<Guid>
{
    public virtual ApplicationUser User { get; set; }
}
