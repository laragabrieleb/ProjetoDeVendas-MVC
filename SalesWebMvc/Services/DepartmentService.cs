using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        internal void Update(Seller seller)
        {
            throw new NotFoundException("Id not found");
        }
    }
}
