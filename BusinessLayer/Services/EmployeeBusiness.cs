using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using RepositoryLayer.Interfaces;

namespace BusinessLayer.Services
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeBusiness(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public object GetUserDetails()
        {
            return _repository.GetUserDetails();
        }

    }
}
