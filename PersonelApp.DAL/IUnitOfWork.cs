using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelApp.DAL.Repositories.Abstract;

namespace PersonelApp.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository DepartmentRepository { get; }
        IPersonelRepository PersonelRepository { get; }
        int Complete();
    }
}
