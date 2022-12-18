using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CA3_X00180961.ShopRepository;
using ShopRepository.Repository;
using ShopRepository;

namespace CA3_X00180961
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CA3_X00180961Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CA3_X00180961Context") ?? throw new InvalidOperationException("Connection string 'CA3_X00180961Context' not found.")));

            // Add services to the container.
            builder.Services.AddScoped<IShopRepo, RealDb>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = "api";
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}