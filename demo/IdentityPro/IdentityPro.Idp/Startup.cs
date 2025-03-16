using Bespoke.Azure.AppInsights.Extensions;
using Bespoke.Azure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Bespoke.Core.Extensions;
using Bespoke.Data.Extensions;
using Bespoke.Data.SqlServer;
using Bespoke.Rest.Extensions;
using Bespoke.Rest.Swagger.Extensions;
using IdentityPro.Data.Contexts;
using IdentityPro.Services.Extensions;
using IdentityPro.Services.Implementation;
using Bespoke.Core.Settings;
using Microsoft.Extensions.Options;
using Bespoke.Rest.Middleware;

namespace IdentityPro.Idp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
    
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBespoke(Configuration, builder =>
            {
                builder
                    .AddEventAggregator()
                    .AddAutomapper()
                    .AddStorage(
                        dbSettings =>
                        {
                            dbSettings.MigrationsAssembly = "IdentityPro.Infrastructure.SqlServer";
                            dbSettings.MaxRetryCount = 5;
                        },
                        dataBuilder =>
                        {
                            dataBuilder.UseSqlServer<ApplicationContext>(sqlSettings =>
                            {
                                sqlSettings.ConnectionStringName = "DefaultConnection";
                            });
                        }
                    )
                    .AddAzure(
                        azureSettings =>
                        {
                            azureSettings.UseAzureManagedIdentity = true;
                            azureSettings.AccountName = "MyAzureStorageAccount";
                            azureSettings.AccountKey = "SuperSecretKey";
                        },
                        azureBuilder =>
                        {
                            azureBuilder.AddAppInsights(
                                appInsightsSettings =>
                                {
                                    appInsightsSettings.CloudRoleName = "IDPRO";
                                    appInsightsSettings.EnableAdaptiveSampling = true;
                                    appInsightsSettings.EnableDependencyTrackingTelemetryModule = false;
                                });
                        })
                    .AddRest(restSettings => { restSettings.Cors.AllowAnyOrigin = true; },
                        restBuilder => { restBuilder.AddSwagger(options =>
                        {
                            options.SwaggerGenDemoMode();
                        }); 
                        });

                builder.AddIdentity();
                builder.AddUserDependencies();
                //builder.Services.AddServices(Configuration);
            });


            //// Configure Identity
            //services.AddIdentity<User, Role>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = true;
            //    options.Password.RequireDigit = true;
            //    options.Password.RequireLowercase = true;
            //    options.Password.RequireNonAlphanumeric = true;
            //    options.Password.RequireUppercase = true;
            //    options.Password.RequiredLength = 8;
            //})
            //.AddEntityFrameworkStores<ApplicationContext>()
            //.AddDefaultTokenProviders();

            // Configure authentication using Microsoft Identity Web
            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ApplicationScheme;
                })
                .AddCookie(IdentityConstants.ApplicationScheme, options =>
                {
                    options.Cookie.Name = "Identity.Application";
                })
                .AddCookie(IdentityConstants.ExternalScheme, options =>
                {
                    options.Cookie.Name = "Identity.External";
                });
            //.AddMicrosoftIdentityWebApp(Configuration.GetSection("AzureSettings/AzureAd"));

            // Add Email Sender
            services.AddTransient<IEmailSender, EmailSender>();

            // Add Razor Pages with Microsoft Identity UI support
            services.AddRazorPages()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeFolder("/Account/Manage");
                    options.Conventions.AllowAnonymousToPage("/Account/Login");
                    options.Conventions.AllowAnonymousToPage("/Account/Register");
                    options.Conventions.AllowAnonymousToPage("/Account/ForgotPassword");
                });
        }
    
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            IOptions<AppSettings> settings)
        {
            app.UseMiddleware<ExceptionMiddleware>();

            var appSettings = settings.Value;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{settings.Value.Version}/swagger.json", appSettings.Name);
                c.RoutePrefix = "swagger"; // Changed from string.Empty to "swagger"
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
    
            app.UseRouting();
    
            app.UseAuthentication();
            app.UseAuthorization();
    
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
