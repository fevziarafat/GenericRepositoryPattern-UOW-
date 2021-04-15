using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace PersonelApp.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity>where TEntity:class,new()
    {
        TEntity GetById(int Id);
        IEnumerable<TEntity>GetAll();
        void Add(TEntity entity);
        void AddRange (IEnumerable<TEntity> entities);
        void Remove(int Id);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}
