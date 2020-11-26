using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KomunikatorTekstowy.Database;
using KomunikatorTekstowy.Mapper;
using KomunikatorTekstowy.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KomunikatorTekstowy
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
            services.AddAutoMapper(c => c.AddProfile<AutoMap>(), typeof(Startup));
            services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAllOrgins",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                    );
            });

            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IChatsRepository, ChatsRepository>();
            services.AddControllers();
            services.AddDbContext<IntroductionDbContext>(options => 
            options.UseMySQL( 
                    Configuration.GetConnectionString("DefaultConnection")
                    )
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
<<<<<<< HEAD
            app.UseDeveloperExceptionPage();
=======
>>>>>>> Adrian
            app.UseCors("AllowAllOrgins");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
