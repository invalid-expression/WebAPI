using Infrastructure.Data.Model;
using Infrastructure.Data.Model.Common;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _department;
        public DepartmentController(IDepartment department)
        {
            _department = department;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartment()
        {
            var data = await _department.GetDepartment();
            return Ok(data);
        }

        [HttpGet("{ID}")]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartmentByID(int DeptID)
        {
            var DataByID = await _department.GetDepartmentByID(DeptID);
            return Ok(DataByID);    
        }

        [HttpPost]
        public async Task<ActionResult<Response>> PostDepartment(Department department)
        {
            var DataPost = await _department.PostDepartment(department);
            return Ok(DataPost);
        }
    }
}
