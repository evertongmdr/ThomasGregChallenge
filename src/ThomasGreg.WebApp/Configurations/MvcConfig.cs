namespace ThomasGreg.WebApp.Configurations
{
    public static class MvcConfig
    {
        public static IServiceCollection AddMvcConfiguration(this IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession();
            services.AddRazorPages();

            return services;
        }
    }
}
