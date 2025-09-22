using Week2SimpleProject.Models;

namespace Week2SimpleProject.Data
{
	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetAllEmployees();
		Employee? GetEmployeeById(int id);
		void CreateNewEmployee(Employee employee);

	}
}
