
using example_empty.Models;
using example_empty.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_empty
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration _config;
        public Startup(IConfiguration config)
            
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(
    options => options.UseSqlServer(_config.GetConnectionString("EmployeeDBConnection")));
            services.AddMvc();
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true;
                options.Tokens.EmailConfirmationTokenProvider = "CustomEmailConfirmation";

            })
          .AddEntityFrameworkStores<AppDbContext>()
          .AddDefaultTokenProviders()
          .AddTokenProvider<CustomEmailConfirmationTokenProvider
            <ApplicationUser>>("CustomEmailConfirmation");
            //services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            //services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();
            //services.Configure<IdentityOptions>(options =>
            //{
            //    options.Password.RequiredLength = 3;
            //    options.Password.RequiredUniqueChars = 3;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = false;
            //    options.Password.RequireLowercase = false;
            //});
            services.AddAuthorization(options =>
            {
                options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireClaim("Delete Role")


                    );
            });
            services.AddAuthentication()
                    .AddGoogle(
                            options =>
                             {
                                options.ClientId = "662259527050-6qjcd6ukkv0hjr45c5ni3pbvaahai23c.apps.googleusercontent.com";
                               options.ClientSecret = "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";
                            })
                     .AddFacebook(options =>
                      {
                          options.AppId = "850275526544121";
                          options.AppSecret = "6c20022667763d65759ae8e9045a6f30";
                      });
            //creating rolebased policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("admin"));
            });
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("EditRolePolicy", policy => policy.RequireClaim("Edit Role"));
            //});
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("EditRolePolicy",
            //        policy => policy.RequireClaim("Edit Role", "true"));
            //});
            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Administration/AccessDenied");
            });

            //custom authorization 
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("EditRolePolicy", policy =>
            //        policy.RequireAssertion(context => AuthorizeAccess(context)));
            //});

            services.AddAuthorization(options =>
            {
                options.AddPolicy("EditRolePolicy", policy =>
                    policy.AddRequirements(new ManageAdminRolesAndClaimsRequirement()));
            });
            // Register the first handler
            services.AddSingleton<IAuthorizationHandler,
                CanEditOnlyOtherAdminRolesAndClaimsHandler>();

            // Register the second handler
            services.AddSingleton<IAuthorizationHandler, SuperAdminHandler>();
            // Changes token lifespan of all token types
            services.Configure<DataProtectionTokenProviderOptions>(o =>
                    o.TokenLifespan = TimeSpan.FromHours(5));

            // Changes token lifespan of just the Email Confirmation Token type
            services.Configure<CustomEmailConfirmationTokenProviderOptions>(o =>
                    o.TokenLifespan = TimeSpan.FromDays(3));
            services.AddSingleton<DataProtectionPurposeStrings>();
        }

        //private bool AuthorizeAccess(AuthorizationHandlerContext context)
        //{
        //    return context.User.IsInRole("admin") &&
        //            context.User.HasClaim(claim => claim.Type == "Edit Role" && claim.Value == "true") ||
        //            context.User.IsInRole("Super Admin");
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("external-login-callback", "signin-facebook", new { controller = "Account", action = "ExternalLoginCallback" });
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
