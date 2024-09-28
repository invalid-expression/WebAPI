using Infrastructure.Data;
using Infrastructure.Data.Model;
using Infrastructure.Data.Model.Common;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class DepartmentServices : IDepartment
    {
        private readonly CompanyContext _context;

        public DepartmentServices(CompanyContext context)
        {
            _context = context;
        }
        public Task<Response> DeleteDepartment(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Department>> GetDepartment()
        {
            var DepartmentList = await _context.Departments.ToListAsync();
            return DepartmentList;
        }

        public async Task<IEnumerable<Department>> GetDepartmentByID(int DeptID)
        {
            var DepartmentList = await _context.Departments.Where(x => x.DeptID == DeptID).ToListAsync();
            return DepartmentList;
        }

        public async Task<Response> PostDepartment(Department department)
        {
            var DepartmentPost = _context.Departments.Add(department);
                                 await _context.SaveChangesAsync();
            return new Response
            {
                StatusCode = 200,
                Message = "New Department Successfully Generated",
                Result = true
            };
        }

        public Task<Response> PutDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
