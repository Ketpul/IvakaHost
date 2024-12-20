using Microsoft.AspNetCore.Identity;

namespace CaloriesCalculator.Data
{
    public class SeedData
    {
        public IdentityUser AdminUser { get; set; }

        public SeedData()
        {
            SeedUsers();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();


            AdminUser = new IdentityUser()
            {
                Id = "df7c92db-9dec-4483-9b0c-39836de8f44a",
                UserName = "admin@domain.com",
                NormalizedUserName = "ADMIN@DOMAIN.COM",
                Email = "admin@domain.com",
                NormalizedEmail = "ADMIN@DOMAIN.COM",
                PhoneNumber = "1234567890",
            };


            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "AdminPassword123!");
        }
    }
}
