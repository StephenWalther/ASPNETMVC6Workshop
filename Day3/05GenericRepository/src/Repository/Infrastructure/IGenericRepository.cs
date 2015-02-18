
using System;
/// <summary>
/// Program against abstractions (IGenericRepository) and not concrete classes (GenericRepository)
/// </summary>
public interface IGenericRepository : IDisposable
{
    System.Linq.IQueryable<T> Query<T>() where T : class;
    void Add<T>(T entityToCreate) where T : class;
    T Find<T>(params object[] keyValues) where T : class;
    void Delete<T>(T entityToDelete) where T : class;
    void SaveChanges();
    System.Collections.Generic.IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters);
}
