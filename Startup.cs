using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using TecnicalAssistence.Infrastructure.Repository.Context;

namespace TecnicalAssistence
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Assistencia técnica REST API",
                    Version = "v1",
                    Description =
                        "API de agendamento, consulta e acopanhamento de atendimento de agendamentos de assistencias em unidades com possibilidade de extenção para atender a requisitos de inspeção visando melhoria contínua dos serviços prestados pela Cyrela. " +
                        "<br />" +
                        "<h5>Sequencia de status de um atendimento</h5>" +
                        "<center><img src=\"/images/status-flow.png\" /></center><br />" +
                        "<br />" +
                        "<h5>Database</h5>" +
                        "<center><img src=\"/images/cyrela-db.png\" style=\"width: 50%;\"/></center><br />" +
                        "<br />",
                    Contact = new OpenApiContact {Name = "Time XXXX", Email = "time.xxx@fiap.com"}
                });

                string caminhoAplicacao = PlatformServices.Default.Application.ApplicationBasePath;
                string nomeAplicacao = PlatformServices.Default.Application.ApplicationName;
                string caminhoXmlDoc = Path.Combine(caminhoAplicacao, $"{nomeAplicacao}.xml");
                c.IncludeXmlComments(caminhoXmlDoc);
            });


            services.AddDbContextPool<DataBaseContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(
                        "Server=192.168.68.117;User Id=root;Password=root;Database=cyrela",
                        new MariaDbServerVersion(new Version(8, 0, 21)), // use MariaDbServerVersion for MariaDB
                        mySqlOptions => mySqlOptions
                            .CharSetBehavior(CharSetBehavior.NeverAppend))
                    // Everything from this point on is optional but helps with debugging.
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
                );

    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TecnicalAssistence v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
