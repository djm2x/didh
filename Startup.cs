using Admin5.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Extensions;
using Newtonsoft.Json;
using Helpers;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;

namespace Admin5
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
            services.AddCors(options =>
           {
               options.AddPolicy("CorsPolicy", builder =>
               {
                   builder
                   // .WithOrigins ("http://localhost:4200")
                   .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
               });
           });
            //
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            //auth
            
            //Provide a secret key to Encrypt and Decrypt the Token
            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            // var key = Encoding.ASCII.GetBytes("this_is_the_secret_phrase");

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(x =>
           {
               x.RequireHttpsMetadata = false;
               x.SaveToken = true;
               x.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = new SymmetricSecurityKey(key),
                   ValidateIssuer = false,
                   ValidateAudience = false
               };
           });
            //auth



            services.AddDbContext<AdminContext>(options =>
            {
                // options.UseSqlServer(Configuration.GetConnectionString("didh"));
                // options.UseSqlServer(Configuration.GetConnectionString("db"));
                options.UseSqlite(Configuration.GetConnectionString("sqlite"));
                // options.EnableSensitiveDataLogging();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //auth
            //Addd User session - JRozario

            // app.UseSession();
            //Add JWToken to all incoming HTTP Request Header
            // app.Use(async (context, next) =>
            // {
            //     var JWToken = context.Session.GetString("JWToken");
            //     if (!string.IsNullOrEmpty(JWToken))
            //     {
            //         context.Request.Headers.Add("Authorization", "Bearer " + JWToken);
            //     }
            //     await next();
            // });

            //Add JWToken Authentication service - JRozario
            // app.UseAuthentication();
            //auth


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.Use(async (context, next) =>
                {
                    await next();

                    if (context.Response.StatusCode == 404
                        && !Path.HasExtension(context.Request.Path.Value))
                    {
                        context.Request.Path = "/index.html";
                        await next();
                    }
                });
            }

            


            app.UseRouting();

            app.UseCors("CorsPolicy");

            // app.UseHttpsRedirection();


            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMiddleware<ErrorHandler>();

            var provider = new FileExtensionContentTypeProvider();
            // provider.Mappings.Add(".exe", "application/octect-stream");
            app.UseStaticFiles(new StaticFileOptions
            {
                ServeUnknownFileTypes = true, //allow unkown file types also to be served
                // DefaultContentType = "Whatver you want eg: plain/text" //content type to returned if fileType is not known.
                ContentTypeProvider = provider
            });

            // app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
