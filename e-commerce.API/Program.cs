
using System.Threading.Tasks;
using e_commerce.API.Extensions;
using e_commerce.Repository.DbContexts;
using e_commerce.Repository.Seeding;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region DatabasesConnection
            builder.Services.AddDbContext<StoreContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("StoreConnection"));
            });
            #endregion

            builder.Services.AddApplicationServices();

            var app = builder.Build();

            #region Seeding
            var scop = app.Services.CreateScope();
            var services = scop.ServiceProvider;
            var dbcontext = services.GetRequiredService<StoreContext>();
            await dbcontext.Database.MigrateAsync();
            await StoreContextSeeding.SeedDataAsync(dbcontext);
            #endregion

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
