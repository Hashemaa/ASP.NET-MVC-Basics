using System.ComponentModel.DataAnnotations;

namespace Week2SimpleProject.Models
{
	public class Employee
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]
		public string Email { get; set; } = string.Empty;
		[Required]
		public string Phone { get; set; } = string.Empty;
		[Required]
		public uint Age { get; set; }
		[Required]
		[Range(0.00, double.MaxValue)]
		public double Salary { get; set; }
		[Required]
		public bool IsCurrentlyHired { get; set; } = false;
		public DateOnly HireDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime? LastUpdatedAt { get; set; } = null;
	}
}
