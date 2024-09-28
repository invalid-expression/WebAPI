using Infrastructure.Data.Model;
using Infrastructure.Data.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IDepartment 
    {
        Task<IEnumerable<Department>> GetDepartment();

        Task<IEnumerable<Department>> GetDepartmentByID(int DeptID);

        Task<Response> PostDepartment(Department department);

        Task<Response> PutDepartment(Department department);

        Task<Response> DeleteDepartment(int ID);
    }
}
