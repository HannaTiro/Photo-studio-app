using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Data.Requests.Grad;
using PhotoStudio.Data.Requests.Komentar;
using PhotoStudio.Data.Requests.Novost;
using PhotoStudio.Data.Requests.PosebnaPonuda;
using PhotoStudio.Data.Requests.Rejting;
using PhotoStudio.Data.Requests.Rezervacija;
using PhotoStudio.Data.Requests.Studio;
using PhotoStudio.Data.Requests.TipFotografa;
using PhotoStudio.Data.Requests.TipKorisnika;
using PhotoStudio.Database;
using PhotoStudio.Filters;
using PhotoStudio.Interface;
using PhotoStudio.Security;
using PhotoStudio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio
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
            services.AddMvc(x =>
            x.Filters.Add<ErrorFilter>()
            );
            services.AddControllers();
            //services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PhotoStudio API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                   // Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic" //,
                    //In = ParameterLocation.Header,
                    //Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });
            services.AddDbContext<PhotoStudioContext>(c => c.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
             .EnableSensitiveDataLogging());
            services.AddAutoMapper(typeof(Startup));

            //Dependency injection
            services.AddScoped<IService<Data.Model.Grad, GradSearchRequest>, GradService>();
            services.AddScoped<IService<Data.Model.TipFotografa, TipFotografaRequest>, TipFotografaService>();
           
            services.AddScoped<IService<Data.Model.TipKorisnika, TipKorisnikaRequest>, TipKorisnikaService>();

            services.AddScoped<IKorisnikService, KorisnikService>();


            services.AddScoped<ICRUDService<Data.Model.Fotograf, FotografSearchRequest, FotografUpsert, FotografUpsert>, FotografService>();
            services.AddScoped<ICRUDService<Data.Model.Komentar, KomentarSearchRequest, KomentarUpsert, KomentarUpsert>, KomentarService>();
            services.AddScoped<ICRUDService<Data.Model.Rejting, RejtingSearchRequest, RejtingUpsert, RejtingUpsert>, RejtingService>();
            services.AddScoped<ICRUDService<Data.Model.Studio, StudioSearchRequest, StudioUpsert, StudioUpsert>, StudioService>();
            services.AddScoped<ICRUDService<Data.Model.Rezervacija, RezervacijaSearchRequest, RezervacijaUpsert, RezervacijaUpsert>, RezervacijaService>();
            services.AddScoped<ICRUDService<Data.Model.Novost, NovostSearchRequest,NovostUpsert, NovostUpsert>, NovostService>();
            services.AddScoped<ICRUDService<Data.Model.PosebnaPonuda, PosebnaPonudaSearchRequest, PosebnaPonudaUpsert, PosebnaPonudaUpsert>, PosebnaPonudaService>();


            services.AddScoped<IPreporukaService, PreporukaService>();
            services.AddScoped<ISlikaService, SlikaService>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication",null);





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI();

          //  app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
