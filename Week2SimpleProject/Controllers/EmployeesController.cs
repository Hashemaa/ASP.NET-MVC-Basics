using Microsoft.AspNetCore.Mvc;
using Week2SimpleProject.Data;
using Week2SimpleProject.Models;

namespace Week2SimpleProject.Controllers
{
	public class EmployeesController(IEmployeeRepository repository) : Controller
	{
		private readonly IEmployeeRepository _repository = repository;

		public IActionResult Index()
		{
			return View(_repository.GetAllEmployees());
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Employee employee)
		{
			if (ModelState.IsValid)
			{
				_repository.CreateNewEmployee(employee);
				TempData["success"] = $"{employee.Name} created successfully";
				return RedirectToAction("Index");
			}

			TempData["error"] = "Something went wrong, please try again";
			return View(employee);
		}

		public IActionResult RetrieveEmployee()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult RetrieveEmployee(int id)
		{
			return View(_repository.GetEmployeeById(id));
		}
	}
}
