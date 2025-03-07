using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Bespoke.Data;
using Bespoke.Data.Interfaces;
using Bespoke.Tests.Stubs;

namespace Bespoke.Tests.DataProject
{
    [TestFixture]
    [TestOf(typeof(UnitOfWork))]
    public class UnitOfWorkTests
    {

        Mock<IServiceProvider> _mockServiceProvider;
        Mock<IDataContextAsync> _mockDataContext;
        private Mock<DatabaseFacade> _databaseFacadeMock;
        private Mock<IDbContextTransaction> _transactionMock;
        private Mock<IDatabaseFacade> _facadeMock;


        [SetUp]
        public void SetUp()
        {
            _databaseFacadeMock = new Mock<DatabaseFacade>();
            _facadeMock = new Mock<IDatabaseFacade>();
            _transactionMock = new Mock<IDbContextTransaction>();
            _mockServiceProvider = new Mock<IServiceProvider>();
            _mockDataContext = new Mock<IDataContextAsync>();

            _mockDataContext.SetupGet(x => x.DatabaseFacade).Returns(_facadeMock.Object);
            
            _databaseFacadeMock
                .Setup(db => db.BeginTransactionAsync(default))
                .ReturnsAsync(_transactionMock.Object);
        }

        protected UnitOfWork GetUnitOfWork()
        {
            return new UnitOfWork(_mockDataContext.Object, _mockServiceProvider.Object);
        }

        [TestFixture]
        public class TheBeginTransactionMethod : UnitOfWorkTests
        {
            [Test]
            public async Task BeginTransactionAsync_ShouldStartTransaction()
            {
                // Act
                var unitOfWork = GetUnitOfWork();
                await unitOfWork.BeginTransactionAsync();

                // Assert
                _mockDataContext.Verify(db => db.DatabaseFacade.BeginTransactionAsync(default), Times.Once);
            }

            [Test]
            public async Task BeginTransactionAsync_ShouldThrowExceptionIfTransactionAlreadyStarted()
            {
                // Arrange
                var unitOfWork = GetUnitOfWork();

                await unitOfWork.BeginTransactionAsync();

                // Act & Assert
                Assert.ThrowsAsync<InvalidOperationException>(() => unitOfWork.BeginTransactionAsync());
            }

        }


        [TestFixture]
        public class TheSaveChangesMethod : UnitOfWorkTests
        {
            [Test]
            public void SaveChanges_ShouldInvokeOnSaveChangesEvent()
            {
                // Arrange
                var unitOfWork = GetUnitOfWork();
                var eventInvoked = false;
                unitOfWork.OnSaveChanges += (_, _) => eventInvoked = true;
                _mockDataContext.Setup(m => m.SaveChanges()).Returns(1);

                // Act
                var result = unitOfWork.SaveChanges();

                // Assert
                Assert.That(eventInvoked, Is.True);
                Assert.That(result, Is.EqualTo(1));
                _mockDataContext.Verify(m => m.SaveChanges(), Times.Once);
            }
        }

        [TestFixture]
        public class TheSaveChangesAsyncMethod : UnitOfWorkTests
        {

            [Test]
            public async Task SaveChangesAsync_ShouldCallDataContextSaveChangesAsync()
            {
                // Arrange
                var unitOfWork = GetUnitOfWork();
                _mockDataContext.Setup(m => m.SaveChangesAsync()).ReturnsAsync(1);

                // Act
                var result = await unitOfWork.SaveChangesAsync();

                // Assert
                Assert.That(result, Is.EqualTo(1));
                _mockDataContext.Verify(m => m.SaveChangesAsync(), Times.Once);
            }

            [Test]
            public async Task SaveChangesAsync_WithCancellationToken_ShouldCallDataContextSaveChangesAsync()
            {
                // Arrange
                var unitOfWork = GetUnitOfWork();

                var cancellationToken = new CancellationToken();
                _mockDataContext.Setup(m => m.SaveChangesAsync(cancellationToken)).ReturnsAsync(1);

                // Act
                var result = await unitOfWork.SaveChangesAsync(cancellationToken);

                // Assert
                Assert.That(result, Is.EqualTo(1));
                _mockDataContext.Verify(m => m.SaveChangesAsync(cancellationToken), Times.Once);
            }
        }


        [TestFixture]
        public class TheRepositoryMethod : UnitOfWorkTests
        {

            [Test]
            public void Repository_ShouldReturnRepositoryInstance()
            {
                var unitOfWork = GetUnitOfWork();
                
                // Arrange
                var mockRepository = Mock.Of<IRepository<TestEntity>>();
                _mockServiceProvider
                    .Setup(m => m.GetService(typeof(IRepository<TestEntity>)))
                    .Returns(mockRepository);

                // Act
                var repository = unitOfWork.Repository<TestEntity>();

                // Assert
                Assert.That(repository, Is.Not.Null);
                Assert.That(repository, Is.SameAs(mockRepository));
                _mockServiceProvider.Verify(m => m.GetService(typeof(IRepository<TestEntity>)), Times.Once);
            }
        }

        [TestFixture]
        public class TheRepositoryAsyncMethod : UnitOfWorkTests
        {

            [Test]
            public void RepositoryAsync_ShouldReturnAsyncRepositoryInstance()
            {
                // Arrange
                var unitOfWork = GetUnitOfWork();
                var mockRepositoryAsync = Mock.Of<IRepositoryAsync<TestEntity>>();
                _mockServiceProvider
                    .Setup(m => m.GetService(typeof(IRepositoryAsync<TestEntity>)))
                    .Returns(mockRepositoryAsync);
                
                // Act
                var repositoryAsync = unitOfWork.RepositoryAsync<TestEntity>();

                // Assert
                Assert.That(repositoryAsync, Is.Not.Null);
                Assert.That(repositoryAsync, Is.SameAs(mockRepositoryAsync));
                _mockServiceProvider.Verify(m => m.GetService(typeof(IRepositoryAsync<TestEntity>)), Times.Once);
            }
        }



        [TestFixture]
        public class TheDisposeMethod : UnitOfWorkTests
        {

            [Test]
            public void Dispose_ShouldDisposeDataContext()
            {
                var unitOfWork = GetUnitOfWork();

                // Act
                unitOfWork.Dispose();

                // Assert
                _mockDataContext.Verify(m => m.Dispose(), Times.Once);
            }

            [Test]
            public void Dispose_ShouldNotDisposeMultipleTimes()
            {
                var unitOfWork = GetUnitOfWork();

                // Act
                unitOfWork.Dispose();
                unitOfWork.Dispose();

                // Assert
                _mockDataContext.Verify(m => m.Dispose(), Times.Once); // Only disposed once
            }
        }

    }

}
