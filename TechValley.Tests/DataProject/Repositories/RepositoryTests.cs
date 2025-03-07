using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TechValley.Data;
using TechValley.Data.Enums;
using TechValley.Data.Interfaces;
using TechValley.Data.Repositories;
using TechValley.Tests.Stubs;

namespace TechValley.Tests.DataProject.Repositories
{
    [TestFixture]
    public class RepositoryTests
    {
        protected readonly DbContextOptions<TestDbContext> _dbContextOptions =
            new DbContextOptionsBuilder<TestDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

        protected IDataContextAsync _context;
        protected IUnitOfWorkAsync _unitOfWork;
        protected Repository<TestEntity> _repository;
        protected Mock<IServiceProvider> _mockServiceProvider;

        [SetUp]
        public void SetUp()
        {
            _mockServiceProvider = new Mock<IServiceProvider>();
        }

        [TestFixture]
        public class TheTotalCountAsyncMethod : RepositoryTests
        {
            [SetUp]
            public void SetUp2()
            {
                var settings = Options.Create(new DbSettings());

                _context = new TestDbContext(_dbContextOptions, settings);
                _unitOfWork = new UnitOfWork(_context, _mockServiceProvider.Object);
                _repository = new Repository<TestEntity>(_context, _unitOfWork);
            }


            [Test]
            public async Task TotalCountAsync_ReturnsCorrectCount()
            {
                var testData = TestEntityHelpers.ValidEntities.AsQueryable();

                _repository.InsertRange(testData, true);

                // ActTestEntity
                var result = await _repository.TotalCountAsync();

                // Assert
                ClassicAssert.AreEqual(testData.Count(), result);
            }
        }
        
        [TestFixture]
        public class TheTotalCountMethod : RepositoryTests
        {
            [SetUp]
            public void SetUp2()
            {
                var settings = Options.Create(new DbSettings());

                _context = new TestDbContext(_dbContextOptions, settings);
                _unitOfWork = new UnitOfWork(_context, _mockServiceProvider.Object);
                _repository = new Repository<TestEntity>(_context, _unitOfWork);
            }

            [Test]
            public void TotalCount_ReturnsCorrectCount()
            {
                var testData = TestEntityHelpers.ValidEntities.AsQueryable();

                _repository.InsertRange(testData, true);

                // ActTestEntity
                var result = _repository.TotalCount();

                // Assert
                ClassicAssert.AreEqual(testData.Count(), result);
            }

        }



        [TestFixture]
        public class TheInsertMethod : RepositoryTests
        {
            [SetUp]
            public void SetUp2()
            {
                var settings = Options.Create(new DbSettings());

                _context = new TestDbContext(_dbContextOptions, settings);
                _unitOfWork = new UnitOfWork(_context, _mockServiceProvider.Object);
                _repository = new Repository<TestEntity>(_context, _unitOfWork);
            }
            [Test]
            public void Insert_AddsEntityToDbSet()
            {
                // Arrange
                var key = new object[] {1};
                var entity = new TestEntity {Id = 1, Name = "test1"};

                _repository.Insert(entity, true);

                // Act
                var result = _repository.Find(key);

                // Assert
                ClassicAssert.AreEqual(entity, result);
            }
        }

        [TestFixture]
        public class TheDeleteMethod : RepositoryTests
        {
            [SetUp]
            public void SetUp2()
            {
                var settings = Options.Create(new DbSettings());

                _context = new TestDbContext(_dbContextOptions, settings);
                _unitOfWork = new UnitOfWork(_context, _mockServiceProvider.Object);
                _repository = new Repository<TestEntity>(_context, _unitOfWork);
            }
            [TestCaseSource(typeof(TestEntityHelpers), nameof(TestEntityHelpers.ValidEntities))]
            public void Delete_RemovesEntityFromDbSet(TestEntity entity)
            {
                _repository.Insert(entity, true);
                // Act
                _repository.Delete(entity);

                // Assert
                ClassicAssert.AreEqual(ObjectState.Deleted, entity.ObjectState);
            }
        }

        [TestFixture]
        public class TheUpdateMethod : RepositoryTests
        {
            [SetUp]
            public void SetUp2()
            {
                var settings = Options.Create(new DbSettings());

                _context = new TestDbContext(_dbContextOptions, settings);
                _unitOfWork = new UnitOfWork(_context, _mockServiceProvider.Object);
                _repository = new Repository<TestEntity>(_context, _unitOfWork);
            }
            [TestCaseSource(typeof(TestEntityHelpers), nameof(TestEntityHelpers.ValidEntities))]
            public void Update_MarksEntityAsModified(TestEntity entity)
            {
                // Act
                _repository.Update(entity);

                // Assert
                ClassicAssert.AreEqual(ObjectState.Modified, entity.ObjectState);
            }
        }

        [TestFixture]
        public class TheQueryableMethod : RepositoryTests
        {
            [SetUp]
            public void SetUp2()
            {
                var settings = Options.Create(new DbSettings());

                _context = new TestDbContext(_dbContextOptions, settings);
                _unitOfWork = new UnitOfWork(_context, _mockServiceProvider.Object);
                _repository = new Repository<TestEntity>(_context, _unitOfWork);
            }

            [Test]
            public void Queryable_ReturnsDbSetQueryable()
            {
                // Arrange
                var testData = TestEntityHelpers.ValidEntities.AsQueryable();

                _repository.InsertRange(testData, true);

                // Act
                var result = _repository.Queryable().ToList();

                // Assert
                ClassicAssert.AreEqual(testData.Count(), result.Count);
            }
        }



        [TestFixture]
        public class TheFindMethod : RepositoryTests
        {
            [SetUp]
            public void SetUp2()
            {
                var settings = Options.Create(new DbSettings());

                _context = new TestDbContext(_dbContextOptions, settings);
                _unitOfWork = new UnitOfWork(_context, _mockServiceProvider.Object);
                _repository = new Repository<TestEntity>(_context, _unitOfWork);
            }
            [Test]
            public void Find_CallsDbSetFindWithCorrectParameters()
            {
                // Arrange
                var key = new object[] { 1 };
                var entity = new TestEntity { Id = 1, ObjectState = ObjectState.Added, Name = "test1" };

                _repository.Insert(entity, true);

                // Act
                var result = _repository.Find(key);

                // Assert
                ClassicAssert.AreEqual(entity, result);
            }
        }
    }

}
