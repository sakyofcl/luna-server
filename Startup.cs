using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using LunaServer.DiContainer;
using Microsoft.EntityFrameworkCore;
using LunaServer.DAL.DBContext;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;

namespace LunaServer;

public class Startup{
    private IConfiguration _configuration;
    public Startup(IConfiguration configuration){
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services){
        services.AddControllers();
        services.AddDbContext<LunaDBContext>(options => { options.UseSqlServer(_configuration.GetConnectionString("Luna")); });
        DiContainerRegister.RegisterAllContainer(services);
        services.AddSwaggerGen(x => {
            x.SwaggerDoc("v1", APIDocs.getDocsInfo());
        });

    }
    public void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        if (env.IsEnvironment("dev"))
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseEndpoints((endpoint)=>{
            endpoint.MapControllers();
        });

        app.UseSwagger(x => { x.RouteTemplate = "docs/{documentName}/LunaAPI.json"; });
        app.UseSwaggerUI(x =>
        {
            x.SwaggerEndpoint("/docs/v1/LunaAPI.json", "Luna API");
        });
    }
}