using Microsoft.EntityFrameworkCore;

namespace My_Portfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(
                (options)=>
                            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnestion"))
                );

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints
            (
                (endpoints) =>
                {
                    endpoints.MapControllerRoute
                    (
                        name: "default",
                        pattern: "{Controller=Home}/{Action=HOME}/{id:int?}"
                    );
                }
            );

            app.Run();
        }
    }
}
