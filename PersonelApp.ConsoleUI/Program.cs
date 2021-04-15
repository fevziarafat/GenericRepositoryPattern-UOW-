using System;
using PersonelApp.DAL;
using PersonelApp.Domain;

namespace PersonelApp.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "Pazarlama",CreatedTime = DateTime.Now,IsActive = true
            });
            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "Muhasebe",
                CreatedTime = DateTime.Now,
                IsActive = true
            });
            unitOfWork.Complete();
        }
    }
}
