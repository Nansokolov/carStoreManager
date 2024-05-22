using Microsoft.AspNetCore.Identity;

namespace carStoreManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Car> Cars { get; set; }
    }
}
