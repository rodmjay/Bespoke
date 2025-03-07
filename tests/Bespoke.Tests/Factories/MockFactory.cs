using System.Data;
using Microsoft.EntityFrameworkCore.Storage;
using Moq;
using Bespoke.Data.Interfaces;

namespace Bespoke.Tests.Factories
{
    public class MockFactory
    {
        public static Mock<IDataContextAsync> CreateAsyncDataContextMock(
            Action<Mock<IDataContextAsync>> configAction = null)
        {
            var mock = new Mock<IDataContextAsync>();
            configAction?.Invoke(mock);
            SetupFacadeMock(mock);
            return mock;
        }

        public static Mock<IDatabaseFacade> CreateDatabaseFacadeMock(Action<Mock<IDatabaseFacade>> configAction = null)
        {
            var mock = new Mock<IDatabaseFacade>();
            configAction?.Invoke(mock);
            return mock;
        }
        private static void SetupFacadeMock(Mock<IDataContextAsync> mock)
        {
            Mock<IDbContextTransaction> transaction;
            transaction = new Mock<IDbContextTransaction>();

            var mockInnerService = CreateDatabaseFacadeMock(innerMock =>
            {
                innerMock.Setup(i => i.BeginTransactionAsync(CancellationToken.None))
                    .Returns(Task.FromResult(transaction.Object));
            });
            mock.Setup(o => o.DatabaseFacade).Returns(mockInnerService.Object);
        }
    }
}
