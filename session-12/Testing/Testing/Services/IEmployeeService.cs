using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeebyId(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}