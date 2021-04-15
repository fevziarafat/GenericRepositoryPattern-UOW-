using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelApp.Domain;

namespace PersonelApp.DAL.Repositories.Abstract
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartmants(int count);
        IEnumerable<Department> GetDepartmantsWithPersonels();
    }
}
