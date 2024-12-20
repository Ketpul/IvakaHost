using Microsoft.AspNetCore.Identity;

namespace CaloriesCalculator.Extension
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task CreateRoleAsync(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync("Admin") == false)
            {
                var role = new IdentityRole("Admin");
                await roleManager.CreateAsync(role);
            }

            var admin = await userManager.FindByEmailAsync("admin@domain.com");

            if (admin != null)
            {
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }
    }
}
