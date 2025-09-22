using Microsoft.AspNetCore.Mvc;
using Week2SimpleProject.Data;
using Week2SimpleProject.Models;

namespace Week2SimpleProject.ApiControllers
{
	[Route("api/employees")]
	[ApiController]
	public class EmployeesApiController(IEmployeeRepository repository) : ControllerBase
	{
		private readonly IEmployeeRepository _repository = repository;

		[HttpGet]
		public ActionResult<IEnumerable<Employee>> GetAllEmployees()
		{
			return Ok(_repository.GetAllEmployees());
		}

		[HttpGet("{id}")]
		public ActionResult<Employee> GetEmployeeById(int id)
		{
			return Ok(_repository.GetEmployeeById(id));
		}

		[HttpPost]
		public void CreateNewEmployee([FromBody] Employee employee)
		{
			_repository.CreateNewEmployee(employee);
		}
	}
}
