using Week2SimpleProject.Models;

namespace Week2SimpleProject.Data
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
		private readonly List<Employee> employees = new List<Employee>() { new Employee { Id = -1, Name = "Hashem", Email = "hashem@emaildomain.com", Phone = "+1 (123) 456-7890", Age = 25, Salary = 4250.85 } };
		int IncrementalId = 0;
		
		public void CreateNewEmployee(Employee employee)
		{
			employee.Id = IncrementalId++;
			employees.Add(employee);
		}

		public IEnumerable<Employee> GetAllEmployees()
		{
			return employees;
		}

		public Employee? GetEmployeeById(int id)
		{
			Employee? employee = employees.Where(x => x.Id == id).FirstOrDefault();
			return employee;
		}
	}
}
