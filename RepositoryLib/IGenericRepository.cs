using System.Linq.Expressions;

namespace RepositoryLib
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //CRUD

        //create(insert)
        void Add(TEntity entity);
        //Read(select) select * from .... where id=1
        TEntity FindById(params object[] id);
        //select * from ...
        IEnumerable<TEntity> GetAll();

        //select * from ... where name='?' and price =? 
        //x=>x.name=='&' && x.price==10
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        //Delete
        void Remove(TEntity entity);
        //Update
        void Update(TEntity entity);


    }
}