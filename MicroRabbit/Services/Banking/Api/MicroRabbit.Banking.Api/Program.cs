using MediatR;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Infrastructure.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace MicroRabbit.Banking.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            DependencyContainer.RegisterServices(builder.Services);
            builder.Services.AddDbContext<BankingDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDbConnection"));
            });
            builder.Services.AddMediatR(typeof(Program));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
