using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Interfaces;

namespace RepositoryLayer.Sevices
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public object GetUserDetails()
        {
            var data = _context.EmployeeDemo.ToList();

            if (data == null)
            {
                return null;
            }

            return data;
        }
    }
}
