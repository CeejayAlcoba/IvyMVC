using IvyMVC.Context;
using IvyMVC.Models;

namespace IvyMVC.Contracts
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employees>> GetEmployees();
    }
}
 