using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using WarehouseAPI.Service;

namespace WarehouseAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //===============================================
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        //===============================================
        //builder.Services.AddDbContext<WareHouseContext>(option =>
        // option.UseSqlServer(//TODO)
        //================================================
        builder.Services.AddScoped<IWareHouseServices, WareHouseServices>(); // Registers IWarehouseService with  dependency injection.
        var app = builder.Build(); // Builds the app.

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Provides detailed exception pages in development.
            app.UseSwagger(); // Enables Swagger middleware to serve generated Swagger as JSON endpoint.
            app.UseSwaggerUI(); // Enables Swagger UI.
        }

        app.UseRouting(); // Enables routing.
        app.UseAuthorization(); // Enables authorization.
        app.MapControllers(); // Maps controller endpoints.
        app.Run(); // Runs the app.


    }
}

