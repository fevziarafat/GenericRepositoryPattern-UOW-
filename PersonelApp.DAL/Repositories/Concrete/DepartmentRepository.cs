using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonelApp.DAL.Repositories.Abstract;
using PersonelApp.Domain;

namespace PersonelApp.DAL.Repositories.Concrete
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(PersonelContext context) : base(context)
        {
           // _context.
        }

        public IEnumerable<Department> GetTopDepartmants(int count)
        {
            return PersonelContext.Departments.Take(count);
           
        }

        public IEnumerable<Department> GetDepartmantsWithPersonels()
        {
            return PersonelContext.Departments.Include("Personels").ToList();
        }

        public PersonelContext PersonelContext
        {
            get
            {
                return _context as PersonelContext;
            }
        }
    }
}
