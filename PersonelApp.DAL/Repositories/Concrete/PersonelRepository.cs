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
    public class PersonelRepository:Repository<Personel>,IPersonelRepository
    {
        public PersonelRepository(PersonelContext context) : base(context)
        {
        }

        public IEnumerable<Personel> GetPersonelsWithDepartments()
        {
            return PersonelContext.Personels.Include("Department").ToList();
        }

        public PersonelContext PersonelContext { get
        {
                 return _context as PersonelContext;
        }
        }
    }
}
