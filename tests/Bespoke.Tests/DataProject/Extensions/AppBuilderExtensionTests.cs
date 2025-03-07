using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Serilog;
using Bespoke.Core.Builders;
using Bespoke.Data.Extensions;
using Bespoke.Data.Interfaces;
using Bespoke.Tests.Stubs;
using Bespoke.Core.Extensions;
using Bespoke.Data.SqlServer;
using Bespoke.Tests.Factories;

namespace Bespoke.Tests.DataProject.Extensions
{
    [TestFixture]
    public class AppBuilderExtensionsTests
    {
        private ServiceCollection _services = new ServiceCollection();
        private IConfigurationBuilder GetValidConfiguration()
        {
            return ConfigurationFactory.CreateConfigurationBuilder(x =>
            {
                x.Add("DbSettings:UseContextPooling", "false");
            });
            
            //return new ConfigurationBuilder()
            //    .AddInMemoryCollection(new Dictionary<string, string>
            //    {
            //        {"DbSettings:UseContextPooling", "false"},
            //        {"DbSettings:SplitQueries", "true"},
            //        {"DbSettings:MaxBatchSize", "100"},
            //        {"DbSettings:MaxRetryCount", "5"},
            //        {"DbSettings:MaxRetryDelaySeconds", "30"},
            //        {"DbSettings:Timeout", "60"},
            //        {
            //            "ConnectionStrings:SqlServer",
            //            "Server=(localdb)\\mssqllocaldb;Database=TestDb;Trusted_Connection=True;"
            //        }
            //    }!);
        }

        private IConfigurationBuilder GetInvalidConfiguration()
        {
            return ConfigurationFactory.CreateConfigurationBuilder(dictionary =>
            {
                dictionary["ConnectionStrings:XXX"] = "false";
            });
        }

        protected AppBuilder GetAppBuilder(IConfigurationBuilder builder)
        {
            IServiceCollection services = new ServiceCollection();
            var appBuilder = services.AddCompositeRoot(builder.Build(), appBuilder =>
            {
                appBuilder.AddAutomapperProfilesFromAssemblies("Bespoke");
                appBuilder.AddStorage(builder =>
                {
                    builder.UseSqlServer<TestDbContext>();
                });
            });


            return services.CreateAppBuilder(builder.Build());
        }


        [TestFixture]
        public class TheUseSqlServerMethod : AppBuilderExtensionsTests
        {

            [Test]
            public void RegistersServicesCorrectly_WithValidConfiguration()
            {

                IServiceCollection services = new ServiceCollection();
                IConfiguration config = GetValidConfiguration().Build();

                var appBuilder = services.AddCompositeRoot(config, appBuilder =>
                {
                    appBuilder.AddAutomapperProfilesFromAssemblies("Bespoke");
                    appBuilder.AddStorage(builder =>
                    {
                        builder.UseSqlServer<TestDbContext>();
                    });
                });

                // Assert
                var provider = appBuilder.Build();

                Assert.That(provider.GetRequiredService<IUnitOfWork>(), Is.Not.Null);
                Assert.That(provider.GetRequiredService<IUnitOfWorkAsync>(), Is.Not.Null);
                Assert.That(provider.GetRequiredService<IRepository<TestEntity>>(), Is.Not.Null);
                Assert.That(provider.GetRequiredService<IRepositoryAsync<TestEntity>>(), Is.Not.Null);
                Assert.That(provider.GetRequiredService<TestDbContext>(), Is.Not.Null);
            }

            [Test]
            public void ThrowsException_WhenConfigurationIsInvalid()
            {
                var appBuilder = GetAppBuilder(GetInvalidConfiguration());

                // Act & Assert
                var exception = Assert.Throws<InvalidOperationException>(() => GetAppBuilder(GetInvalidConfiguration()));
                
                Assert.That(exception.Message, Is.EqualTo("Database configuration is invalid."));
            }

            [Test]
            public void LogsDebugMessages()
            {
                //Arrange
                var loggerMock = new Mock<ILogger>();
                Log.Logger = loggerMock.Object; 
                
                GetAppBuilder(GetValidConfiguration());

                // Assert
                loggerMock.Verify(log => log.Debug(It.Is<string>(msg => msg.Contains("Adding SQL Connection"))), Times.Once);
                loggerMock.Verify(log => log.Fatal(It.IsAny<string>()), Times.Never);
            }



            [Test]
            public void RegistersDbContext_WithoutPooling_WhenConfigured()
            {
                IConfigurationBuilder config = new ConfigurationBuilder()
                    .AddInMemoryCollection(new Dictionary<string, string>
                    {
                        {"DbSettings:UseContextPooling", "false"},
                        {"ConnectionStrings:SqlServer", "TestConnectionString"}
                    });

                var appBuilder = GetAppBuilder(config);
                // Assert
                var dbContextRegistration = appBuilder.Services.SingleOrDefault(sd => sd.ServiceType == typeof(DbContextOptions<TestDbContext>));
                Assert.That(dbContextRegistration);
                Assert.That(dbContextRegistration.Lifetime, Is.EqualTo(ServiceLifetime.Scoped));
            }



            [Test]
            public void RegistersDbContext_WithPooling_WhenConfigured()
            {
                // Arrange
                var config = new ConfigurationBuilder()
                    .AddInMemoryCollection(new Dictionary<string, string>
                    {
                        {"DbSettings:UseContextPooling", "true"},
                        {"ConnectionStrings:SqlServer", "TestConnectionString"}
                    });

                var appBuilder = GetAppBuilder(config);

                // Assert
                var dbContextRegistration = appBuilder.Services.SingleOrDefault(sd => sd.ServiceType == typeof(DbContextOptions<TestDbContext>));
                Assert.That(dbContextRegistration);
                // Note: DbContext pooling is implemented as Singleton under the hood.
            }
        }



    }

}
