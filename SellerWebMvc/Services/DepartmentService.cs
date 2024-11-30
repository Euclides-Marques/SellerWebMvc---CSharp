﻿using SellerWebMvc.Data;
using SellerWebMvc.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SellerWebMvc.Services
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
    }
}