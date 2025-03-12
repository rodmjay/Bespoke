using System.Data;

namespace Bespoke.Data.Interfaces;

public interface IDbConnectionFactory
{
    IDbConnection DbConnection { get; }
}