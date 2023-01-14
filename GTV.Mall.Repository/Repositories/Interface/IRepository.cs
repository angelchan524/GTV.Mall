//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

namespace GTV.Mall.Repository.Repositories.Interface
{

    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        /// <summary>
        /// 取得某一筆資料
        /// </summary>
        /// <param name="id">primary key value</param>
        /// <returns></returns>
        TEntity Get(TKey id);

        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// 以查詢條件取得資料
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// 建立物件
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        void Create(TEntity instance);

        /// <summary>
        /// 依MODEL的值更新
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="keyValues"></param>
        void Update(TEntity instance, params object[] keyValues);


        /// <summary>
        /// Deletes the specified instance by it's key
        /// </summary>
        /// <param name="id">primary key value</param>
        /// <returns></returns>
        void Delete(TKey id);

        /// <summary>
        /// Deletes the specified instance.
        /// </summary>
        /// <param name="item"></param>
        void Delete(TEntity item);

        /// <summary>
        /// Check entity exists or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Exists(TKey id);

        void Detached(TEntity instance);

        /// <summary>
        /// Get first 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Check exists
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        bool Any(Expression<Func<TEntity, bool>> filter);
    }
}
