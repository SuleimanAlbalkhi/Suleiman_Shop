using System;
using System.Collections.Generic;
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
using Microsoft.Extensions.Logging;
using shop.API.Data;


namespace shop.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<ProductContext>();

            services.AddDbContext<SqliteContext>();

            services.AddCors();

            services.AddControllers();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IProductRepo, SqlProductRepo>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options =>
            {
                options
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // using (var lite = new SqliteContext())
            // {
            //     using (var server = new ProductContext())
            //     {
            //         var products = server.Products.ToList();
            //         foreach (var item in products)
            //         {
            //             lite.Products.Add(new Models.Product{
            //                 Name = item.Name,
            //                 Description = item.Description,
            //                 PictureUrl = item.PictureUrl,
            //                 Price = item.Price,
            //                 ProductBrand = item.ProductBrand,
            //                 ProductType = item.ProductType
            //             });
                        
            //         }
            //     }
            //     lite.SaveChanges();
            // }
        }
    }


}
