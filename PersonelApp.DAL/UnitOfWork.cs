using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelApp.DAL.Repositories.Abstract;
using PersonelApp.DAL.Repositories.Concrete;

namespace PersonelApp.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonelContext _personelContext;

        public UnitOfWork(PersonelContext personelContext)
        {
            _personelContext = personelContext;
            DepartmentRepository = new DepartmentRepository(_personelContext);
            PersonelRepository = new PersonelRepository(_personelContext);
        }

        public void Dispose()
        {
            _personelContext.Dispose();
        }

        public IDepartmentRepository DepartmentRepository { get; }
        public IPersonelRepository PersonelRepository { get; }
        public int Complete()
        {
            return _personelContext.SaveChanges();
        }
    }
}
