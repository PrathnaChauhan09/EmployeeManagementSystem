﻿using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            var departments = new Department[]
            {
                new Department{DepartmentID=1,Name="Admin"},
                new Department{DepartmentID=2,Name="Accounts"},
                new Department{DepartmentID=3,Name="IT"}
            };

            foreach(var d in departments)
            {
                context.Departments.Add(d);
            }

            context.SaveChanges();

            var employees = new Employee[]
            {
                new Employee{FirstName="Prathna",LastName="Chauhan",
                    Address="Ahmedabad",ContactNo="7539514682",DepartmentID=3},
                new Employee{FirstName="Vandan",LastName="Chauhan",
                    Address="Ahmedabad",ContactNo="9876543210",DepartmentID=2},
                new Employee{FirstName="Sai",LastName="Anusha",
                    Address="Gandhinagar",ContactNo="7894561230",DepartmentID=1},
                new Employee{FirstName="Nikesh",LastName="Solanki",
                    Address="Vadodara",ContactNo="1234567890",DepartmentID=1}
            };

            foreach(var e in employees)
            {
                context.Employees.Add(e);
            }

            context.SaveChanges();
        }
    }
}
