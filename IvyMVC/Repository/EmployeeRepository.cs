using Dapper;
using IvyMVC.Context;
using IvyMVC.Contracts;
using IvyMVC.Models;

namespace IvyMVC.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DapperContext _context;
        public EmployeeRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employees>> GetEmployees()
        {
            var query = "SELECT * FROM Employees";
            using (var connection = _context.CreateConnection())
            {
                var employees = await connection.QueryAsync<Employees>(query);
                return employees.ToList();
            }
        }
    }
}
