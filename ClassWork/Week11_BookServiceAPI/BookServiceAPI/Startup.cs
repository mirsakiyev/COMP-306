using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookServiceAPI.Models;
using BookServiceAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace BookServiceAPI
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
            //add framework services
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //add application services

            //Singleton lifetime services are created the first time they're requested 
            services.AddSingleton<SampleChapters>();
            services.AddSingleton<IBookChaptersService, BookChaptersService>();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Title = "Books Service API",
                    Version = "v1",
                    Description = "Sample service using Async "
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IHostingEnvironment env, SampleChapters sampleChapters)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            await sampleChapters.CreateSampleChaptersAsync(); // create sample data

            app.UseSwagger();

            app.UseSwaggerUI(options =>
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Book Chapter Async Services"));
        }
    }
}
