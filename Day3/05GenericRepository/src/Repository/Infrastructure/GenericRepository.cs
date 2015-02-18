using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Models
{

    // Use the Generic Repository for database access (don't use the DbContext directly)
    // Using the Generic Repository enhances the testability and maintainability of your app.
    public class GenericRepository : IGenericRepository
    {

        // This should be the one and only place in your app that you refer
        // to the DbContext
        private MoviesDB _dataContext = new MoviesDB();

        /// <summary>
        /// Generic query method.
        /// </summary>
        public IQueryable<T> Query<T>() where T : class
        {
            return _dataContext.Set<T>().AsQueryable();
        }




        /// <summary>
        /// Find row by id
        /// https://github.com/aspnet/EntityFramework/issues/797
        /// </summary>
        public T Find<T>(params object[] keyValues) where T : class
        {
            throw new NotImplementedException();
            //return _dataContext.Set<T>().Find(keyValues);
        }


        /// <summary>
        /// Add new entity
        /// </summary>
        public void Add<T>(T entityToCreate) where T : class
        {
            _dataContext.Set<T>().Add(entityToCreate);
        }

        /// <summary>
        /// Delete existing entity
        /// </summary>
        public void Delete<T>(T entityToDelete) where T : class
        {
            _dataContext.Set<T>().Remove(entityToDelete);
        }


        /// <summary>
        /// Save changes and throw validation exceptions
        /// </summary>
        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }


        /// <summary>
        /// Execute stored procedures and dynamic sql
        /// https://github.com/aspnet/EntityFramework/issues/624
        /// </summary>
        public IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
            //return this._dataContext.Database.SqlQuery<T>(sql, parameters);
        }

        public void Dispose()
        {
            _dataContext.Dispose();
            _dataContext.Movies.Include(m => m.Director);
        }

    }


    /// <summary>
    /// This class promotes the Include() method from the entity framework so it
    /// can be used at a higher layer. You might not want to reference the Entity Framework
    /// in your presentation layer.
    /// </summary>
    public static class GenericRepositoryExtensions
    {
        public static IQueryable<T> Include<T, TProperty>(this IQueryable<T> queryable, Expression<Func<T, TProperty>> relatedEntity) where T : class
        {
            return QueryableExtensions.Include<T, TProperty>(queryable, relatedEntity);
        }
    }

}