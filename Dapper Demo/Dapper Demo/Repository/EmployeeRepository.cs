using Dapper;
using DapperDemo.Data;
using DapperDemo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IDbConnection db;

        public EmployeeRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Employee Add(Employee employee)
        {
/*            var sql = "INSERT INTO Companies (Name, Address, City, State, PostalCode) " +
                      "Values(@Name, @Address, @City, @State, @PostalCode);"
                    + "SELECT CAST(SCOPE_IDENTITY() as int);";
            var id = db.Query<int>(sql, new
            {
                @Name = company.Name,
                @Address = company.Address,
                @City = company.City,
                @State = company.State,
                @PostalCode = company.PostalCode
*//*
                 // same here because properties name match parameters name we can remove parameters name
                company.Name,
                company.Address,
                company.City,
                company.State,
                company.PostalCode*//*

            }).Single();
            company.CompanyId = id;
            return company;*/

            // or

            var sql = "INSERT INTO Employees (Name, Title, Email, Phone, CompanyId)" +
                      "Values(@Name, @Title, @Email, @Phone, @CompanyId);"
                    + "SELECT CAST(SCOPE_IDENTITY() as int);";
            var id = db.Query<int>(sql, employee).Single();
            employee.EmployeeId = id;
            return employee;
        }

        public Employee Find(int id)
        {
            var sql = "SELECT * FROM Employees WHERE EmployeeId = @Id";
            return db.Query<Employee>(sql, new { id }).Single(); // or { @Id = id } or { id }
        }

        public List<Employee> GetAll()
        {
            var sql = "SELECT * FROM Employees";
            return db.Query<Employee>(sql).ToList();
        }

        public void Remove(int id)
        {
            var sql = "DELETE FROM Employees WHERE EmployeeId = @Id";
            db.Execute(sql, new { id });
        }

        public Employee Update(Employee employee)
        {
            var sql = "UPDATE Employees SET  Name = @Name, Title = @Title, Email = @Email, " +
                      "Phone = @Phone, CompanyId = @CompanyId WHERE EmployeeId = @EmployeeId";
            db.Execute(sql, employee);
            return employee;
        }
    }
}
